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
    public partial class mian : Form
    {
        public HashSet<string> static_tags_set_ = new HashSet<string>();
        //public HashSet<string> static_tags_set_pre = new HashSet<string>();
        List<string> RPC_list = new List<string>();
        Dictionary<string, Service> main_dic2 = new Dictionary<string, Service>();
        HashSet<string> id_set = new HashSet<string>();
        string static_cur_edit_service_name = null;
        string static_cur_edit_RPC_Type = null;
        string cur_edit_id = null;
        Form cur_Form_;
        Form cur_tag_form_;
        Form cur_tag_search_form_;
        int static_cur_row;
        Service static_cur_service;
        Dictionary<string, string> static_cur_interface = null;
        string cut_tag;
        bool ok_to_save = true;
        public mian()
        {
            InitializeComponent();
            initializeRPC_list();
        }
        private void initializeRPC_list()
        {
            RPC_list.Add("R/R  Method");
            RPC_list.Add("F&F Method");
            RPC_list.Add("Event");
            RPC_list.Add("Notifier");
            RPC_list.Add("Setter");
            RPC_list.Add("Getter");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
            // row_lock.Add(0);
        }

        //按键编辑
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                static_cur_row = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.Rows[static_cur_row].Cells[0].Value == null || dataGridView1.Rows[static_cur_row].Cells[3].Value == null)
                {
                    return;
                }
                if (static_cur_edit_service_name != null)
                {
                    MessageBox.Show("正在编辑其他项目，请关闭其他窗口后重试", "注意");
                    return;
                }

                string cur_edit_RPC_Type = dataGridView1.Rows[static_cur_row].Cells[3].Value.ToString();
                static_cur_edit_service_name = dataGridView1.Rows[static_cur_row].Cells[0].Value.ToString();
                static_cur_service = main_dic2[static_cur_edit_service_name];
                static_cur_interface = static_cur_service.Interface_[static_cur_row - static_cur_service.begin_row_index];
                if (cur_Form_ != null)
                {
                    return;
                }

                if (cur_edit_RPC_Type == RPC_list[0]) //RR
                {
                    cur_Form_ = new RR_METHOD();
                }
                else if (cur_edit_RPC_Type == RPC_list[1])//FF
                {
                    cur_Form_ = new FF_METHOD();
                }
                else if (cur_edit_RPC_Type == RPC_list[2])//Event
                {
                    cur_Form_ = new Event();
                }
                else //Field
                {
                    if(cur_edit_RPC_Type == RPC_list[3])
                        cur_Form_ = new Notifier();
                    else if(cur_edit_RPC_Type == RPC_list[4])
                        cur_Form_ = new Setter();
                    else
                        cur_Form_ = new Getter();
                }

                foreach (var ctr in cur_Form_.Controls)
                {
                    if (ctr is System.Windows.Forms.TextBox)
                    {
                        string name = (ctr as System.Windows.Forms.TextBox).Name.ToString();
                        if (static_cur_interface.ContainsKey(name))
                        {
                            (ctr as System.Windows.Forms.TextBox).Text = static_cur_interface[name].ToString();
                        }
                    }
                    if (ctr is System.Windows.Forms.ComboBox)
                    {
                        string name = (ctr as System.Windows.Forms.ComboBox).Name.ToString();
                        if (static_cur_interface.ContainsKey(name))
                        {
                            (ctr as System.Windows.Forms.ComboBox).Text = static_cur_interface[name].ToString();
                        }
                    }
                }

                cur_Form_.Show();
                cur_Form_.FormClosing += FormClosing;
            }
        }
        //弹出窗口保存编辑
        private void FormClosing(object sender, FormClosingEventArgs e)
        {

            foreach (var ctr in cur_Form_.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox)
                {
                    string name = (ctr as System.Windows.Forms.TextBox).Name.ToString();

                    static_cur_interface[name] = (ctr as System.Windows.Forms.TextBox).Text.ToString();
                }
                if (ctr is System.Windows.Forms.ComboBox)
                {
                    string name = (ctr as System.Windows.Forms.ComboBox).Name.ToString();
                    static_cur_interface[name] = (ctr as System.Windows.Forms.ComboBox).Text.ToString();
                }
            }
            dataGridView1.Rows[static_cur_row].Cells[4].Value = static_cur_interface["Interface_Name"];
            static_cur_edit_service_name = null;
            cur_Form_ = null;
            static_cur_interface = null;
            static_cur_service = null;
            //throw new NotImplementedException();
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int cur_row = dataGridView1.CurrentCell.RowIndex;
            //第一列
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {

            }
            //第二列
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                if (dataGridView1.Rows[cur_row].Cells[0].Value == null)
                {
                    MessageBox.Show("请先完成第一项填写", "提醒");
                    e.Cancel = true;
                    return;
                }
                string cur_service_name = dataGridView1.Rows[cur_row].Cells[0].Value.ToString();
                if (main_dic2.ContainsKey(cur_service_name) && !main_dic2[cur_service_name].is_only_one_line())
                {
                    MessageBox.Show("请删除其他接口后再进行修改", "注意");
                    e.Cancel = true;
                    return;
                }
                cur_edit_id = dataGridView1.CurrentCell.Value == null ? null : dataGridView1.CurrentCell.Value.ToString();
            }
            //第三列
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                if (dataGridView1.Rows[cur_row].Cells[0].Value == null)
                {
                    MessageBox.Show("请先完成第一项填写", "提醒");
                    e.Cancel = true;
                    return;
                }
                string cur_service_name = dataGridView1.Rows[cur_row].Cells[0].Value.ToString();
                if (main_dic2.ContainsKey(cur_service_name) && !main_dic2[cur_service_name].is_only_one_line())
                {
                    MessageBox.Show("请删除其他接口后再进行修改", "注意");
                    e.Cancel = true;
                    return;
                }
            }
            //第四列
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                if (dataGridView1.Rows[cur_row].Cells[1].Value == null || dataGridView1.Rows[cur_row].Cells[2].Value == null || dataGridView1.Rows[cur_row].Cells[0].Value == null)
                {
                    MessageBox.Show("请先完成前三项填写", "提醒");
                    e.Cancel = true;
                    return;
                }
                static_cur_edit_RPC_Type = dataGridView1.Rows[cur_row].Cells[3].Value == null ? null : dataGridView1.Rows[cur_row].Cells[3].Value.ToString();
            }


        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cur_row = dataGridView1.CurrentCell.RowIndex;
            string name = dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString();
            string val = dataGridView1.CurrentCell.Value == null ? null : dataGridView1.CurrentCell.Value.ToString();

            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (val != null)
                {
                    if (main_dic2.ContainsKey(val))
                    {
                        MessageBox.Show("已存在相同的服务名", "注意");
                        for (int i = 0; i < 3; i++)
                        {
                            dataGridView1.Rows[cur_row].Cells[i].Value = null;
                        }
                        return;
                    }
                }

            }
            string cur_service_name = dataGridView1.Rows[cur_row].Cells[0].Value == null ? null : dataGridView1.Rows[cur_row].Cells[0].Value.ToString();

            if (cur_service_name == null)
            {
                for (int i = 0; i < 3; i++)
                {
                    dataGridView1.Rows[cur_row].Cells[i].Value = null;
                }
                return;
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                if (cur_Form_ != null ) 
                {
                    MessageBox.Show("请关闭其他窗口", "注意");
                    return;
                }

                //如果RPC改了
                if (static_cur_edit_RPC_Type != val)
                {
                    //如果现在变为空（操作失误）
                    if (val == null)
                    {
                        dataGridView1.CurrentCell.Value = static_cur_edit_RPC_Type;
                        return;
                    }
                    else
                    {
                        //如果原来是空的
                        if (static_cur_edit_RPC_Type == null)
                        {
                            dataGridView1.Rows[cur_row].Cells[0].ReadOnly = true;
                            
                            //检查是非是新的服务
                            if (!main_dic2.ContainsKey(cur_service_name))
                            {
                                static_cur_service = new Service(cur_service_name, cur_row);
                                static_cur_service.service_name_ = dataGridView1.Rows[cur_row].Cells[0].Value.ToString();
                                static_cur_service.service_id_ = dataGridView1.Rows[cur_row].Cells[1].Value.ToString();
                                static_cur_service.server_description_ = dataGridView1.Rows[cur_row].Cells[2].Value.ToString();
                                static_cur_service.add_one_interface();
                            }
                            else
                            {
                                static_cur_service = main_dic2[cur_service_name];
                            }

                            int index_in_list = cur_row - static_cur_service.begin_row_index;
                            static_cur_service.Interface_[index_in_list][name] = val;
                            main_dic2[cur_service_name] = static_cur_service;
                        }
                        //原来不是空，说明RPC被改了
                        else
                        {
                            static_cur_service = main_dic2[cur_service_name];
                            Dictionary<string, string> new_interface = new Dictionary<string, string>();
                            new_interface[name] = val;


                            if (val == RPC_list[0]) //RR
                            {
                                cur_Form_ = new RR_METHOD();
                            }
                            else if (val == RPC_list[1])//FF
                            {
                                cur_Form_ = new FF_METHOD();
                            }
                            else if (val == RPC_list[2])//Event
                            {
                                cur_Form_ = new Event();
                            }
                            else //Field
                            {
                                if (val == RPC_list[3])
                                    cur_Form_ = new Notifier();
                                else if (val == RPC_list[4])
                                    cur_Form_ = new Setter();
                                else
                                    cur_Form_ = new Getter();
                            }

                            
                            foreach (var ctr in cur_Form_.Controls)
                            {
                                if (ctr is System.Windows.Forms.TextBox)
                                {
                                    string name_ = (ctr as System.Windows.Forms.TextBox).Name.ToString();

                                    new_interface[name_] = (ctr as System.Windows.Forms.TextBox).Text.ToString();
                                }
                                if (ctr is System.Windows.Forms.ComboBox)
                                {
                                    string name_ = (ctr as System.Windows.Forms.ComboBox).Name.ToString();
                                    new_interface[name_] = (ctr as System.Windows.Forms.ComboBox).Text.ToString();
                                }
                            }

                            new_interface["Interface_Name"] = dataGridView1.Rows[cur_row].Cells[4].Value == null ? "" : dataGridView1.Rows[cur_row].Cells[4].Value.ToString();
                            static_cur_service.change_one_interface(cur_row, new_interface);
                            cur_Form_.Close();
                        }
                    }
                }
                cur_Form_ = null;
                static_cur_service = null;
                static_cur_edit_RPC_Type = null;
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                //main_dic2[cur_service_name].server_description_ = val == null ? "" : val;
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                if (cur_edit_id != val)
                {
                    if (cur_edit_id != null)
                    {
                        id_set.Remove(cur_edit_id);
                        cur_edit_id = null;
                    }

                    if (val != null)
                    {
                        if (id_set.Contains(val))
                        {
                            dataGridView1.CurrentCell.Value = null;
                            MessageBox.Show("已存在相同的服务id", "注意");
                            
                        }
                        else
                        {
                            id_set.Add(val);
                            //main_dic2[cur_service_name].service_id_ = val;
                            
                        }
                    }
                    if (main_dic2.ContainsKey(cur_service_name))
                    {
                        main_dic2[cur_service_name].service_id_ = val == null ? "" : val;
                    }
                }
                cur_edit_id = null;
            }

            //System.Drawing.Rectangle rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.Rows[cur_row].Cells[4].ColumnIndex, dataGridView1.Rows[cur_row].Cells[4].RowIndex, false);

            //tmp.Left = rect.Left;
            //tmp.Top = rect.Top;
            //tmp.Width = rect.Width;
            //tmp.Height = rect.Height;
            //tmp.Visible = true;
            //}
        }
        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int cur_row = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[cur_row].Cells[0].Value != null)
                {
                    string cur_RPC_Type = dataGridView1.Rows[cur_row].Cells[3].Value == null ? null : dataGridView1.Rows[cur_row].Cells[3].Value.ToString();
                    string cur_service_name = dataGridView1.Rows[cur_row].Cells[0].Value.ToString();

                    string cur_service_id = dataGridView1.Rows[cur_row].Cells[1].Value == null ? null : dataGridView1.Rows[cur_row].Cells[1].Value.ToString();

                    if (main_dic2.ContainsKey(cur_service_name))
                    {
                        static_cur_service = main_dic2[cur_service_name];
                        static_cur_service.delete_one_interface(cur_row);
                        if (static_cur_service.interface_number() == 0)
                        {
                            id_set.Remove(static_cur_service.service_id_);
                            main_dic2.Remove(static_cur_service.service_name_);
                        }
                        static_cur_service = null;
                    }
                }
                re_load();
            }
        }



        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string[] key = main_dic.Keys.ToArray<string>();
            //for (int i = 0; i < main_dic.Count; i++) {
            //    int count = 0;
            //    int count_min =
            //    foreach (string var in main_dic[key[i]].Values) {
            //        count++;
            //        switch (var) {
            //            case "R/R  Method":

            //                break;
            //            case "F&F Method":
            //                break;
            //            case "Event":
            //                break;
            //            case "Field":
            //                break;
            //            default:
            //                count++;
            //                break;
            //        }                  
            //    }
            //}
            // RWXxml xml = new RWXxml();
            //xml.WriteXml(main_dic2);

            re_load();
            int len = dataGridView1.Rows.Count;
            for(int i = 0; i < len; ++i)
            {
                if(dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[4].Value.ToString() == "")
                {
                    string tmp = string.Format("第{0}行接口名未填写", i + 1);
                    MessageBox.Show(tmp, "注意");
                    return;
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            //设置默认保存格式为.xml
            sfd.Filter = "xml files (*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();
                RWXxml xml = new RWXxml();


                string fileName = sfd.FileName;
                xml.WriteXml(main_dic2, fileName);
            }


            //textBox1.ReadOnly = true;
            //string file_path = "C:\\Users\\bills\\Desktop\\c#win\\WindowsFormsApp1\\save1111.xlsx";
            //Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //Workbook w;
            //try
            //{
            //    w= app.Workbooks.Open(file_path);
            //}
            //catch
            //{
            //     w = app.Workbooks.Add(true);
            //}

            //Worksheet ws = w.Worksheets[1];
            //ws.Cells[2, 2] = "新建的";

            //w.SaveAs(file_path);
            //app.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }




        private void 添加接口_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                MessageBox.Show("请选中Service Name", "注意");
                return;
            }


            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (dataGridView1.CurrentCell.Value != null)
                {
                    int cur_row = dataGridView1.CurrentCell.RowIndex;
                    string cur_service_name = dataGridView1.CurrentCell.Value.ToString();
                    if (!main_dic2.ContainsKey(cur_service_name))
                    {
                        MessageBox.Show("请先把本行填写完整", "注意");
                        return;
                    }
                    static_cur_service = main_dic2[cur_service_name];
                    static_cur_service.add_one_interface();
                    static_cur_service = null;
                    re_load();
                }

            }
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.re_load();
            //RWXxml xml = new RWXxml();
            //main_dic2 = xml.ReadXml();
        }


        private void re_load()
        {
            //System.Data.DataTable dt = (System.Data.DataTable)dataGridView1.DataSource;
            //dt.Rows.Clear();
            //dataGridView1.DataSource = dt;

            dataGridView1.Rows.Clear();
            static_tags_set_.Clear();
            id_set.Clear();
            foreach (var service_name in main_dic2.Keys)
            {
                bool already_begin = false;
                Service cur_service = main_dic2[service_name];
                foreach (var tag in cur_service.tag_)
                {
                    static_tags_set_.Add(tag);
                }
                id_set.Add(cur_service.service_id_);
                for (int i = 0; i < cur_service.interface_number(); i++)
                {
                    dataGridView1.Rows.Add();
                    int cur_row = dataGridView1.Rows.Count - 1;
                    Dictionary<string, string> cur_interface_ = cur_service.Interface_[i];
                    if (already_begin == false)
                    {
                        cur_service.begin_row_index = cur_row;
                        already_begin = true;
                    }
                    if (i == cur_service.interface_number() - 1)
                    {
                        cur_service.end_row_index = cur_row;
                    }
                    dataGridView1.Rows[cur_row].Cells[0].Value = cur_service.service_name_;
                    dataGridView1.Rows[cur_row].Cells[0].ReadOnly = true;
                    dataGridView1.Rows[cur_row].Cells[1].Value = cur_service.service_id_;
                    dataGridView1.Rows[cur_row].Cells[2].Value = cur_service.server_description_;
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[cur_row].Cells[j].Style.BackColor = cur_service.back_color();
                        dataGridView1.Rows[cur_row].Cells[j].Style.ForeColor = cur_service.fore_color();
                        if (j != 0)
                        {
                            dataGridView1.Rows[cur_row].Cells[j].ReadOnly = !cur_service.is_only_one_interface();
                        }
                    }
                    if (cur_interface_.ContainsKey(dataGridView1.Rows[cur_row].Cells[3].OwningColumn.HeaderText.ToString()))
                        dataGridView1.Rows[cur_row].Cells[3].Value = cur_interface_[dataGridView1.Rows[cur_row].Cells[3].OwningColumn.HeaderText.ToString()];
                    if (cur_interface_.ContainsKey(dataGridView1.Rows[cur_row].Cells[4].OwningColumn.HeaderText.ToString()))
                        dataGridView1.Rows[cur_row].Cells[4].Value = cur_interface_[dataGridView1.Rows[cur_row].Cells[4].OwningColumn.HeaderText.ToString()];
                }
                if (!cur_service.is_only_one_interface())
                {
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[cur_service.begin_row_index].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cur_tag_search_form_ != null)
            {
                MessageBox.Show("重复打开搜索窗口", "注意");
                return;
            }
            re_load();
            cur_tag_search_form_ = new tag_from_search();
            cur_tag_search_form_.Show();
            //System.Windows.Forms.ComboBox cur_cb_tags_sel = (cur_tag_form_ as tag_form).cb_tags_sel;

            foreach (var tag in static_tags_set_)
            {
                (cur_tag_search_form_ as tag_from_search).lsb_lib.Items.Add(tag);
            }
            cur_tag_search_form_.FormClosing += save_and_search;

        }
        private void save_and_search(object sender, EventArgs e)
        {
            HashSet<string> tmp_keys = new HashSet<string>();
            foreach (var label in (cur_tag_search_form_ as tag_from_search).lsb_lb.Items)
            {
                tmp_keys.Add(label.ToString());
            }

            dataGridView1.Rows.Clear();
            foreach (var service_name in main_dic2.Keys)
            {
                if (tmp_keys.Count != 0 && !tmp_keys.IsSubsetOf(main_dic2[service_name].tag_))
                {
                    continue;
                }
                bool already_begin = false;
                Service cur_service = main_dic2[service_name];
                for (int i = 0; i < cur_service.interface_number(); i++)
                {
                    dataGridView1.Rows.Add();
                    int cur_row = dataGridView1.Rows.Count - 1;
                    Dictionary<string, string> cur_interface_ = cur_service.Interface_[i];
                    if (already_begin == false)
                    {
                        cur_service.begin_row_index = cur_row;
                        already_begin = true;
                    }
                    if (i == cur_service.interface_number() - 1)
                    {
                        cur_service.end_row_index = cur_row;
                    }
                    dataGridView1.Rows[cur_row].Cells[0].Value = cur_service.service_name_;
                    dataGridView1.Rows[cur_row].Cells[0].ReadOnly = true;
                    dataGridView1.Rows[cur_row].Cells[1].Value = cur_service.service_id_;
                    dataGridView1.Rows[cur_row].Cells[2].Value = cur_service.server_description_;
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[cur_row].Cells[j].Style.BackColor = cur_service.back_color();
                        dataGridView1.Rows[cur_row].Cells[j].Style.ForeColor = cur_service.fore_color();
                        if (j != 0)
                        {
                            dataGridView1.Rows[cur_row].Cells[j].ReadOnly = !cur_service.is_only_one_interface();
                        }
                    }
                    if (cur_interface_.ContainsKey(dataGridView1.Rows[cur_row].Cells[3].OwningColumn.HeaderText.ToString()))
                        dataGridView1.Rows[cur_row].Cells[3].Value = cur_interface_[dataGridView1.Rows[cur_row].Cells[3].OwningColumn.HeaderText.ToString()];
                    if (cur_interface_.ContainsKey(dataGridView1.Rows[cur_row].Cells[4].OwningColumn.HeaderText.ToString()))
                        dataGridView1.Rows[cur_row].Cells[4].Value = cur_interface_[dataGridView1.Rows[cur_row].Cells[4].OwningColumn.HeaderText.ToString()];
                }
                if (!cur_service.is_only_one_interface())
                {
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[cur_service.begin_row_index].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }
            cur_tag_search_form_ = null;
        }
        private void 选择标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int cur_row = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[cur_row].Cells[0].Value != null)
                {
                    if (static_cur_edit_service_name != null)
                    {
                        MessageBox.Show("正在编辑其他项目，请关闭其他窗口后重试", "注意");
                        return;
                    }

                    static_cur_edit_service_name = dataGridView1.Rows[cur_row].Cells[0].Value.ToString();
                    if (!main_dic2.ContainsKey(static_cur_edit_service_name))
                    {
                        MessageBox.Show("请把服务信息填写完整", "注意");
                        static_cur_edit_service_name = null;
                        return;
                    }
                    cur_tag_form_ = new tag_form();
                    cur_tag_form_.Show();
                    //System.Windows.Forms.ComboBox cur_cb_tags_sel = (cur_tag_form_ as tag_form).cb_tags_sel;

                    foreach (var tag in static_tags_set_)
                    {
                        (cur_tag_form_ as tag_form).lsb_lib.Items.Add(tag);
                    }
                    foreach (var tag in main_dic2[static_cur_edit_service_name].tag_)
                    {
                        (cur_tag_form_ as tag_form).lsb_lb.Items.Add(tag);
                    }
                    cur_tag_form_.FormClosing += save_and_exit;
                }
            }

        }
        private void save_and_exit(object sender, EventArgs e)
        {
            //if((cur_tag_form_ as tag_form).cb_tags_sel.Text != null)
            //{
            //    string val = (cur_tag_form_ as tag_form).cb_tags_sel.Text.ToString();
            //    main_dic2[static_cur_edit_service_name].tag_ = val;
            //}
            //else
            //{
            //    main_dic2[static_cur_edit_service_name].tag_ = "NON_TAGS";
            //}
            // HashSet<string> old = main_dic2[static_cur_edit_service_name].tag_;
            main_dic2[static_cur_edit_service_name].tag_ = new HashSet<string>();

            foreach (var label in (cur_tag_form_ as tag_form).lsb_lb.Items)
            {
                main_dic2[static_cur_edit_service_name].tag_.Add(label.ToString());
                static_tags_set_.Add(label.ToString());
            }
            static_cur_edit_service_name = null;
            cur_tag_form_ = null;
        }

        private void 加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            //if (fog.ShowDialog() == DialogResult.OK) { 
            //    filepath1
            //}
            //判断是否点选文件
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RWXxml xml = new RWXxml();
                string path = ofd.FileName;
                main_dic2 = xml.ReadXml(path);

                re_load();
            }
            else
            {
                MessageBox.Show("未选中文件", "提示");
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || dataGridView1.CurrentCell.ColumnIndex != 1) return;
            string tmp = dataGridView1.CurrentCell.Value.ToString();
            foreach (var c in tmp)
            {
                if(c <'0' || c > '9')
                {
                    MessageBox.Show("Id只能填写数字", "注意");
                    dataGridView1.CurrentCell.Value = null;
                    break;
                }
            }
            dataGridView1.CancelEdit();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var help_Form = new 版本信息();
            help_Form.Show();
        }
    }
}
