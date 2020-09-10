using System;
using System.IO;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


//Aria2详细信息请看
//https://aria2.github.io/manual/en/html/aria2c.html#rpc-interface

namespace aria2c
{
    public class Aria2
    {
        public static ClientWebSocket webSocket;          //用于连接到Aria2Rpc的客户端
        public static CancellationToken cancellationToken; //传播有关应取消操作的通知



    /// <summary>
    /// 连接Aria2Rpc服务器
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static async Task<bool> ConnectServer(string uri = "ws://127.0.0.1:6800/jsonrpc")
        {
            webSocket = new ClientWebSocket();          //用于连接到Aria2Rpc的客户端
            cancellationToken = new CancellationToken(); //传播有关应取消操作的通知
            bool status = false;  //储存连接状态
            try
            {
                //连接服务器
                await Aria2.webSocket.ConnectAsync(new Uri(uri), Aria2.cancellationToken);
            }
            catch
            {
                status = false;
            }
            //检查连接是否成功
            if (Aria2.webSocket.State == WebSocketState.Open)
            {
                status = true;
            }
            return status;
        }


        /// <summary>
        /// 发送json并返回json消息
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private static async Task<string> SendAndReceive(string json)
        {
            string str = "";
            str = json;
            try
            {
                //发送json数据
                await Aria2.webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(str)), WebSocketMessageType.Text, true, Aria2.cancellationToken);
                var result = new byte[1024];
                //接收数据
                await Aria2.webSocket.ReceiveAsync(new ArraySegment<byte>(result), new CancellationToken());
                str += "\r\n" + Encoding.UTF8.GetString(result, 0, result.Length) + "\r\n";
            }
            catch
            {
                str = "连接错误";
            }
            return str;
        }


        /// <summary>
        /// 添加新的下载
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static async Task<string> AddUri(string Downurl, string Savepath)
        {
            Console.WriteLine(Savepath);
            string str = "";
            //[["https://down.qq.com/qqweb/PCQQ/PCQQ_EXE/PCQQ2020.exe"], {dir: "D:\32位\aria2\666", out: "\666"}]

            String json = "{\"jsonrpc\":\"2.0\",\"method\":\"aria2.addUri\",\"id\":\"" + Guid.NewGuid().ToString() + "\",\"params\":[[\"" + Downurl + "\"],{\"dir\":\"" + Savepath + "\"}]}";

            str = await Aria2.SendAndReceive(json);
            return str;
        }
    }
}