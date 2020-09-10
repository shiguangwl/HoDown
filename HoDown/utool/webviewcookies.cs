
//using HoDown.utool;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HoDown.domain
//{
//    public static class Cookiestool 
//    {
//        //获取cookies 方法
//        public static void GetCookies()
//        {
//            //获取cookies
//            var cookieManager = CefSharp.Cef.GetGlobalCookieManager();
//            cookieManager.VisitAllCookies(new webview_cookies()); //CefSharpv3 (CefSharp.Core required)
//        }
//    }

//    public class webview_cookies : ICookieVisitor
//    {
//        //private FileIO fileIO= new FileIO();
//        public void Dispose()
//        {
//            #region   序列化cookies
//            ////序列化cookies
//            //List<System.Net.Cookie> cc = HttpRequest.GetAllCookies(Common.cookies);
//            //string jsonStr = JsonConvert.SerializeObject(cc, Formatting.Indented);
//            //FileIO.SaveFile(@"D:\\111.txt", jsonStr);
//            #endregion
//            Fileclass.LoadFile();
//        }

//        public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
//        {
          
//            //Cookie处理
//            Common.cookie.Domain = cookie.Domain;
//            Common.cookie.Name = cookie.Name;
//            Common.cookie.Value = cookie.Value;
//            Common.cookies.Add(Common.cookie);
//            Console.WriteLine(cookie.Domain + "  " + cookie.Name + " = " + cookie.Value);
//            return true;
//        }
//    }
//}
