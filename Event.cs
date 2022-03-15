using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void Udp_Tcp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Send_Strategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Send_Type.Text.ToString() == "Changed")
            {
                this.Cyclic_Time.Enabled = false;
                this.Cyclic_Time.Text = "";
            }
            else 
            {
                this.Cyclic_Time.Enabled = true;
            }
        }

        private void tb_Cyclic_Time_TextChanged(object sender, EventArgs e)
        {
            string s = Cyclic_Time.Text.ToString();
            foreach(var c in s)
            {
                if(c >= '0' && c<='9')
                {

                }
                else
                {
                    MessageBox.Show("只能输入整数", "注意");
                    Cyclic_Time.Text = null;
                    break;
                }
            }
            return;
        }

        private void Method_Id_TextChanged(object sender, EventArgs e)
        {
            string s = Event_Id.Text.ToString();
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                {

                }
                else
                {
                    MessageBox.Show("只能输入整数", "注意");
                    Event_Id.Text = null;
                    break;
                }
            }
            return;
        }

        private void Eventgroup_Name_id_TextChanged(object sender, EventArgs e)
        {
            string s = Event_Group_id.Text.ToString();
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                {

                }
                else
                {
                    MessageBox.Show("只能输入整数", "注意");
                    Event_Group_id.Text = null;
                    break;
                }
            }
            return;
        }
    }
}
