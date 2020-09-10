using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HoDown.domain
{
    class Common
    {
        public static CookieContainer cookies = new CookieContainer();

        //public static FileList fileList;   //文件列表

        //文件,文件夹信息对象
        public static List<FileBd> filelist = new List<FileBd>();

        //列表路径
        public static string filePath = "/";

        //文件下载队列 //暂时没用
        public static Queue<FileBd> fileDownList = new Queue<FileBd>();

        //下载保存位置
        public static string SavePathStatic = Directory.GetCurrentDirectory();

        //是否已登录
        public static bool isSign = false;

    }
}
