using HoDown.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HoDown.utool
{
    class HttpRequest
    {
        #region 同步通过GET方式发送数据
        /// 通过GET方式发送数据
        public static string SendDataByGET(string Url, string postDataStr, ref CookieContainer cookie,string referer=null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            if (cookie.Count == 0)
            {
                request.CookieContainer = new CookieContainer();
                cookie = request.CookieContainer;
            }
            else
            {
                request.CookieContainer = cookie;
            }
            //设置为无代理模式，不走系统代理,防止抓包
            request.Proxy = null;
            request.Referer = referer;
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = "netdisk;P2SP;2.2.60.26";
            Console.WriteLine(request.RequestUri);
            try
            {

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;

            }
            catch (Exception e1)
            {
                return null;
                //Catch 块

            }
           
        }
        #endregion


        #region 同步通过POST方式发送数据
        /// 通过POST方式发送数据
        public static string SendDataByPost(string Url, string postDataStr, ref CookieContainer cookie, string referer = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            if (cookie.Count == 0)
            {
                request.CookieContainer = new CookieContainer();
                cookie = request.CookieContainer;
            }
            else
            {
                request.CookieContainer = cookie;
            }

            request.Proxy = null;
            request.Method = "POST";
            request.Referer = referer;
            request.UserAgent = "netdisk;P2SP;2.2.60.26";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postDataStr.Length;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
        #endregion


        #region 同步通过GET方式发送数据
        /// 通过GET方式发送数据 返回cookie
        public static CookieCollection SendDataByPostRcookies(string Url, string postDataStr, ref CookieContainer cookie, string referer = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            if (cookie.Count == 0)
            {
                request.CookieContainer = new CookieContainer();
                cookie = request.CookieContainer;
            }
            else
            {
                request.CookieContainer = cookie;
            }

            request.Proxy = null;
            request.Method = "POST";
            request.Referer = referer;
            request.UserAgent = "netdisk;P2SP;2.2.60.26";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postDataStr.Length;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Stream myResponseStream = response.GetResponseStream();
            //StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            //string retString = myStreamReader.ReadToEnd();
            //myStreamReader.Close();
            //myResponseStream.Close();
            return response.Cookies;
        }
        #endregion

        //url编码
        public static string tourl(string filePath)
        {
            return HttpUtility.UrlEncode(filePath, System.Text.Encoding.UTF8);
        }


        //添加cookie
        public void AddCookie(string ccDomain,string ccName,string ccValue)
        {
            Cookie cookie = new Cookie();
            //Cookie处理
            cookie.Domain = ccDomain;
            cookie.Name = ccName;
            cookie.Value = ccValue;
            Common.cookies.Add(cookie);
        }

    }
}
