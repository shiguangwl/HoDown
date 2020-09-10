using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoDown.domain
{
    class ShareFile
    {
         private string app_id;
         private string category;
         private string delete_fs_id;
         private string extent_int3;
         private string file_key;
         private string fs_id;
         private string isdelete;
         private string isdir;
         private string local_ctime;
         private string local_mtime;
         private string md5;
         private string oper_id;
         private string parent_path;
         private string path;
         private string path_md5;
         private string privacy;
         private string root_ns;
         private string server_ctime;
         private string server_filename;
         private string server_mtime;
         private string share;
         private string size;
         private string status;


        public ShareFile(string app_id, string category, string delete_fs_id, string extent_int3, string file_key, string fs_id, string isdelete, string isdir, string local_ctime, string local_mtime, string md5, string oper_id, string parent_path, string path, string path_md5, string privacy, string root_ns, string server_ctime, string server_filename, string server_mtime, string share, string size, string status)
        {
            this.App_id = app_id;
            this.Category = category;
            this.Delete_fs_id = delete_fs_id;
            this.Extent_int3 = extent_int3;
            this.File_key = file_key;
            this.Fs_id = fs_id;
            this.Isdelete = isdelete;
            this.Isdir = isdir;
            this.Local_ctime = local_ctime;
            this.Local_mtime = local_mtime;
            this.Md5 = md5;
            this.Oper_id = oper_id;
            this.Parent_path = parent_path;
            this.Path = path;
            this.Path_md5 = path_md5;
            this.Privacy = privacy;
            this.Root_ns = root_ns;
            this.Server_ctime = server_ctime;
            this.Server_filename = server_filename;
            this.Server_mtime = server_mtime;
            this.Share = share;
            this.Size = size;
            this.Status = status;
        }

        public string App_id { get => app_id; set => app_id = value; }
        public string Category { get => category; set => category = value; }
        public string Delete_fs_id { get => delete_fs_id; set => delete_fs_id = value; }
        public string Extent_int3 { get => extent_int3; set => extent_int3 = value; }
        public string File_key { get => file_key; set => file_key = value; }
        public string Fs_id { get => fs_id; set => fs_id = value; }
        public string Isdelete { get => isdelete; set => isdelete = value; }
        public string Isdir { get => isdir; set => isdir = value; }
        public string Local_ctime { get => local_ctime; set => local_ctime = value; }
        public string Local_mtime { get => local_mtime; set => local_mtime = value; }
        public string Md5 { get => md5; set => md5 = value; }
        public string Oper_id { get => oper_id; set => oper_id = value; }
        public string Parent_path { get => parent_path; set => parent_path = value; }
        public string Path { get => path; set => path = value; }
        public string Path_md5 { get => path_md5; set => path_md5 = value; }
        public string Privacy { get => privacy; set => privacy = value; }
        public string Root_ns { get => root_ns; set => root_ns = value; }
        public string Server_ctime { get => server_ctime; set => server_ctime = value; }
        public string Server_filename { get => server_filename; set => server_filename = value; }
        public string Server_mtime { get => server_mtime; set => server_mtime = value; }
        public string Share { get => share; set => share = value; }
        public string Size { get => size; set => size = value; }
        public string Status { get => status; set => status = value; }
    }
}
