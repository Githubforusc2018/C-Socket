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
        string clientIP;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            //ip地址
            IPAddress ip = IPAddress.Parse(ipText.Text);
            //端口号
            IPEndPoint point = new IPEndPoint(ip, int.Parse(portText.Text));
            //创建监听用的Socket
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Bind(point); //绑定监听的端口.
                socket.Listen(10);  //监听队列
                Thread thread = new Thread(AcceptInfo);
                thread.Start(socket);   //不加socket参数，无法连接.
            }catch(Exception ex)
            {
                //显示.
                showMsg(ex.Message);
            }
            
        }
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        void AcceptInfo(object o)
        {
            Socket socket = o as Socket;
            while (true)
            {
                //通信用socket
                try
                {
                    //创建通信的Socket
                    Socket tSocket = socket.Accept();   //等待连接.
                    string point = tSocket.RemoteEndPoint.ToString();   //端口号
                    clientIP = point;   //包含ip+端口
                    //显示连接成功.
                    showMsg(point + " : 连接成功!");
                    //此时将clientIP发送给客户端,
                    byte[] buffer = Encoding.UTF8.GetBytes(clientIP); //发给客户端,一个当前时间和服务器ip和文本
                    tSocket.Send(buffer);   //对应不到ip    
                    //用了listview?
                    dic.Add(point, tSocket);
                    //接收消息.
                    Thread th = new Thread(receiveMsg);
                    th.Start(tSocket);
                }catch(Exception ex)
                {
                    showMsg(ex.Message);
                    break;
                }
            }
        }
        //接收消息
        void receiveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                //接收客户端发送过来的数据
                try
                {
                    //定义byte数组存放客户端接收过来的数据
                    byte[] buffer = new byte[1024 * 1024];
                    int len = client.Receive(buffer);
                    //字节转字符串.
                    string words = Encoding.UTF8.GetString(buffer, 0, len);
                    //client.RemoteEndPoint.ToString() == clientIP  true
                    showMsg(client.RemoteEndPoint.ToString() + ":" + words);
                }catch(Exception ex)
                {
                    showMsg(ex.Message);
                    break;
                }
            }
        }
        void showMsg(string msg)
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            textlog.AppendText(currentTime.ToString() + "\r\n"); //发送时间
            textlog.AppendText(msg + "\r\n");
            textlog.AppendText("\r\n"); //换行,注目.
        }

        private void Btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                showMsg(ipText.Text+":"+txtMsg.Text);
                byte[] buffer = Encoding.UTF8.GetBytes(ipText.Text+" : " + txtMsg.Text); //发给客户端,和服务器ip和文本
                dic[clientIP].Send(buffer);   //对应不到ip
                //client.Send(buffer);
            }catch(Exception ex)
            {
                showMsg(ex.Message);
            }
        }

        private void Btn_Closeconnect_Click(object sender, EventArgs e)
        {
            dic[clientIP].Close();  //关闭连接.

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
