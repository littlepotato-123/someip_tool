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
    public partial class tag_from_search : Form
    {
        public tag_from_search()
        {
            InitializeComponent();
        }

        private void tag_form_Load(object sender, EventArgs e)
        {
        }

        private void lb_tags_sel_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(lsb_lib.SelectedItem !=null)
            {
                lsb_lb.Items.Add(lsb_lib.SelectedItem.ToString());
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        { 
            if (lsb_lb.SelectedItem != null)
            {
                lsb_lb.Items.Remove(lsb_lb.SelectedItem.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
