using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace WindowsFormsApp1
{
    public class Service
    {
        public HashSet<string> tag_ { get; set; }
        public string service_name_ { get; set; }
        public string service_id_ { get; set; }
        public string server_description_ { get; set; }
        // public Dictionary<string,Dictionary<string,string>> interface_ { get; set; }
        public List<Dictionary<string, string>> Interface_ { get; set; }
        public int begin_row_index { get; set; }
        public int end_row_index { get; set; }
        public bool is_shown { get; set; }
        public Service(string service_name, int cur_row)
        {
            this.service_name_ = service_name;
            //interface_ = new Dictionary<string, Dictionary<string, string>>();
            Interface_ = new List<Dictionary<string, string>>();
            begin_row_index = cur_row;
            end_row_index = cur_row;
            is_shown = true;
            tag_ = new HashSet<string>();
        }

        public void add_one_interface()
        {
            //interface_[RPC_Type] = new Dictionary<string, string>();
            //interface_[RPC_Type]["RPC_Type"] = RPC_Type;
            Interface_.Add(new Dictionary<string, string>());
        }
        public void change_one_interface(int cur_row, Dictionary<string, string> new_interface)
        {
            int index_in_list = cur_row - begin_row_index;
            Interface_[index_in_list] = new_interface;
        }
        public void delete_one_interface(int cur_row)
        {
            int index_in_list = cur_row - begin_row_index;
            Interface_.RemoveAt(index_in_list);
        }
        //public bool is_empty()
        //{
        //    return row_num <= 0;
        //}
        public bool is_only_one_line()
        {
            return begin_row_index == end_row_index;
        }
        public bool is_only_one_interface()
        {
            return Interface_.Count == 1;
        }
        public Color back_color()
        {
            return is_only_one_interface() ? Color.White : Color.Pink;
        }
        public Color fore_color()
        {
            return is_only_one_interface() ? Color.Black : Color.Pink;
        }
        public int interface_number()
        {
            return Interface_.Count;
        }
       

    }
}
