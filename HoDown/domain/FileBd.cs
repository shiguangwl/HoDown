using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoDown.domain
{
    public class FileBd
    {
        private string isdir;
        private string server_filename;
        private string path;
        private string size;
        private string local_mtime;
        private int dir_empty;

        public FileBd() { }
        public FileBd(string isdir, string server_filename, string path, string size, string local_mtime)
        {
            this.Isdir = isdir;
            this.Server_filename = server_filename;
            this.Path = path;
            this.Size = size;
            this.Local_mtime = local_mtime;
        }
        public override string ToString()
        {
            return "isdir:"+this.isdir+"\n"+ "server_filename:" + this.server_filename + "\n" + "path:"
                + this.path + "\n" + "size:" + this.size + "\n" + "local_mtime:" + this.local_mtime + "\n\n\n";
        }
        //public FileBd DeepCopy()
        //{
        //    FileBd other = (FileBd)this.MemberwiseClone();
        //    other.Isdir = new String(this.Isdir.ToCharArray());
        //    other.Server_filename = new String(this.server_filename.ToCharArray());
        //    other.Path = new String(this.path.ToCharArray());
        //    other.Size = new String(this.size.ToCharArray());
        //    other.Local_mtime = new String(this.local_mtime.ToCharArray());
        //    return other;
        //}
        public string Isdir { get => isdir; set => isdir = value; }
        public string Server_filename { get => server_filename; set => server_filename = value; }
        public string Path { get => path; set => path = value; }
        public string Size { get => size; set => size = value; }
        public string Local_mtime { get => local_mtime; set => local_mtime = value; }
        public int Dir_empty { get => dir_empty; set => dir_empty = value; }
        //"isdir": 1,
        //"server_filename": "Temp",
        //"path": "/Temp",


    }


    public class FileRequeststate
    {
        private string errno;
        private string guid_info;
        private List<FileBd> list;

        public FileRequeststate(){}
        public FileRequeststate(string errno, string guid_info, List<FileBd> path)
        {
            this.Errno = errno;
            this.Guid_info = guid_info;
            this.List = path;
        }
        public string Errno { get => errno; set => errno = value; }
        public string Guid_info { get => guid_info; set => guid_info = value; }
        public List<FileBd> List { get => list; set => list = value; }
    }


    public class FilePares
    {
        private string host;
        private string client_ip;
        private string[] server;
        private string path;
        private string fsl;
        private string request_id;

        //"host": "d6.baidupcs.com",
        //"client_ip": "42.49.224.216",
        //"server": [
        //    "qdall01.baidupcs.com",
        //    "qdall01.baidupcs.com"
        //],
        //"path": "/file/452a7f3a11655bf7ddf755b0698fda0a?bkt=en-82d2bca2fdceac3fd539f7534c4920fa346635c2f5782a4f8722c1f6127d7076b05a6ff59d6eea51&fid=3428279438-778750-127277336183672&time=1587819903&sign=FDTAXUGERQlBHSKf-DCb740ccc5511e5e8fedcff06b081203-pPayxT9OFWZE%2Bvr6Fj0e7iAhBM4%3D&to=&size=13441564&sta_dx=13441564&sta_cs=1&sta_ft=zip&sta_ct=7&sta_mt=7&fm2=MH%2CQingdao%2CAnywhere%2C%2Chunan%2Ccnc&ctime=1549786600&mtime=1549848261&resv0=-1&resv1=0&resv2=rlim&resv3=2&resv4=13441564&vuk=3428279438&iv=-2&htype=&randtype=em&newver=1&newfm=1&secfm=1&flow_ver=3&pkey=en-36bc7fcc6d9329bc7a317d52c318e169033304e5bf4042759565741ca0ed9b8911d1a016fd8ea665&expires=8h&rt=pr&r=259051967&exp_id_list=%5B%2249250-6%22%5D&vbdid=2321969319&fin=zhizhu.zip&rtype=1&dp-logid=2687549478891268305&dp-callid=0.1&tsl=0&csl=0&fsl=-1&csign=zHam1qm9KgDckm0cvV0xTDrDDlk%3D&so=1&ut=8&uter=0&serv=0&uc=1458616558&ti=16c8192e22ea32f52492d047e841eb3d93be079aceeba4eb&adg=c_954eb4c2c0bb811c14d0aa0199767551&reqlabel=778750_l_90cb2c61f2cb54874086578bef3c0f56_-1_ec8beaebb7bc154d36c23325565cb2c7&by=themis",
        //"fsl": -1,
        //"request_id": "2687549478891268305"
        public FilePares(string host, string client_ip, string[] server, string path, string fsl, string request_id)
        {
            this.host = host;
            this.client_ip = client_ip;
            this.server = server;
            this.path = path;
            this.fsl = fsl;
            this.request_id = request_id;
        }

        public string Host { get => host; set => host = value; }
        public string Client_ip { get => client_ip; set => client_ip = value; }
        public string[] Server { get => server; set => server = value; }
        public string Path { get => path; set => path = value; }
        public string Fsl { get => fsl; set => fsl = value; }
        public string Request_id { get => request_id; set => request_id = value; }
        
    }



    public class FileDown 
    {

        private string fileName;
        private string fileLink;
        private string fileSave;
        public FileDown() { }
        public FileDown(string fileName, string fileLink, string fileSave)
        {
            this.fileName = fileName;
            this.fileLink = fileLink;
            this.fileSave = fileSave;
        }

        public override string ToString()
        {
            return 
                "文件名:"+this.fileName+
                "链接:"+this.fileLink+
                "保存位置:"+this.fileSave
                ;
        }
        public string FileName { get => fileName; set => fileName = value; }
        public string FileLink { get => fileLink; set => fileLink = value; }
        public string FileSave { get => fileSave; set => fileSave = value; }
    }
}
