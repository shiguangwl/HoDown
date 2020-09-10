using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoDown.domain
{
    class ShareFile_2
    {


        private string category;
        private string fs_id;
        private string isdir;
        private string local_ctime;
        private string local_mtime;
        private string md5;
        private string path;
        private string server_ctime;
        private string server_filename;
        private string server_mtime;
        private string size;

        public ShareFile_2(string category, string fs_id, string isdir, string local_ctime, string local_mtime, string md5, string path, string server_ctime, string server_filename, string server_mtime, string size)
        {
            this.Category = category;
            this.Fs_id = fs_id;
            this.Isdir = isdir;
            this.Local_ctime = local_ctime;
            this.Local_mtime = local_mtime;
            this.Md5 = md5;
            this.Path = path;
            this.Server_ctime = server_ctime;
            this.Server_filename = server_filename;
            this.Server_mtime = server_mtime;
            this.Size = size;
        }

        public string Category { get => category; set => category = value; }
        public string Fs_id { get => fs_id; set => fs_id = value; }
        public string Isdir { get => isdir; set => isdir = value; }
        public string Local_ctime { get => local_ctime; set => local_ctime = value; }
        public string Local_mtime { get => local_mtime; set => local_mtime = value; }
        public string Md5 { get => md5; set => md5 = value; }
        public string Path { get => path; set => path = value; }
        public string Server_ctime { get => server_ctime; set => server_ctime = value; }
        public string Server_filename { get => server_filename; set => server_filename = value; }
        public string Server_mtime { get => server_mtime; set => server_mtime = value; }
        public string Size { get => size; set => size = value; }
    }
}
