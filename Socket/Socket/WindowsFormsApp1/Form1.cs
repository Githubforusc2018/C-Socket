using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //创建连接的Socket
        Socket socketSend;
        Thread threadReceive;
        public Form1()
        {
            InitializeComponent();
            InitListView(this.listView1);   //窗体加载初始化listView.
        }
        private void ListViewForm_Load(object sender, EventArgs e)
        {
            InitListView(this.listView1);   //窗体加载初始化listView.
        }

        public void InitListView(ListView lv)
        {
            //初始化ListView的方法.
            ColumnHeader h1 = new ColumnHeader();
            h1.Text = "姓名";
            h1.Width = 100;
            ColumnHeader h2 = new ColumnHeader();
            h2.Text = "班级";
            h2.Width = 100;
            ColumnHeader h3 = new ColumnHeader();
            h3.Text = "年龄";
            h3.Width = 100;
            lv.GridLines = true;    //显示网格线
            lv.FullRowSelect = true;    //显示全行.
            h1.TextAlign = HorizontalAlignment.Center;  //第一列不能居中.
            h2.TextAlign = HorizontalAlignment.Center;
            h3.TextAlign = HorizontalAlignment.Center;
            lv.Columns.Add("", 0);
            lv.Columns.Add(h1);
            lv.Columns.Add(h2);
            lv.Columns.Add(h3);
            lv.View = System.Windows.Forms.View.Details;    //不添加不能显示列名.
            //View：获取或设置项在控件中的显示方式，包括Details、LargeIcon、List、SmallIcon、Tile（默认为 LargeIcon）
            //Details：可以显示任意的列，但只有第一列可以包含一个小图标和标签，其它的列项只能显示文字信息，有列表头。（效果见下图）
            //不如不添加，加个icon试试
        }
        public ListView insertListView(ListView lv)
        {
            //接受输入
            var usertext = userText.Text;   //账户名
            var classtext = classText.Text; //班级
            var agetext = ageText.Text; //年龄
            //创建行对象.
            ListViewItem listViewItem = new ListViewItem("");
            //添加同一行数据
            listViewItem.SubItems.Add(usertext);
            listViewItem.SubItems.Add(classtext);
            listViewItem.SubItems.Add(agetext);
            //将对象绑定在listview中
            lv.Items.Add(listViewItem);
            MessageBox.Show("添加成功");
            return lv;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            insertListView(listView1);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(this.textIP.Text.Trim());    //获取ip地址.
                socketSend.Connect(ip, Convert.ToInt32(this.textPort.Text.Trim()));
                showMsg("连接成功");
                showMsg("服务器" + socketSend.RemoteEndPoint.ToString());
                showMsg("客户端" + socketSend.LocalEndPoint.ToString());
                //连接成功,就可以接收服务器发送的信息了.
                Thread th = new Thread(ReceiveMsg);
                th.Start();
                //实例化回调
            }catch(Exception ex)
            {
                showMsg(ex.Message);
                MessageBox.Show("连接服务器出错:" + ex.ToString());
            }
        }
        //接收服务器的消息.
        private void ReceiveMsg()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int len = socketSend.Receive(buffer);   //获取长度
                    string s = Encoding.UTF8.GetString(buffer, 0, len);
                    //将信息显示在textArea中.
                    showMsg(socketSend.RemoteEndPoint.ToString() + ":" + s);
                }catch(Exception ex)
                {
                    showMsg(ex.Message);
                    break;
                }
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //客户端发服务器消息.
            if (socketSend != null)
            {
                try
                {
                    //发送消息.
                    showMsg(txtMsg.Text);
                    byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);
                    socketSend.Send(buffer);
                }catch(Exception ex)
                {
                    //显示出错的消息
                    showMsg(ex.Message);
                }
            }
        }
        void showMsg(string msg)
        {
            textInfo.AppendText(msg + "\r\n");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
