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
    public partial class RR_METHOD : Form
    {
        public RR_METHOD()
        {
            InitializeComponent();
        }

        private void RR_METHOD_Load(object sender, EventArgs e)
        {

        }

        private void RR_METHOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
               

            }
        }

        private void Method_Id_TextChanged(object sender, EventArgs e)
        {
            string s = Method_Id.Text.ToString();
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                {

                }
                else
                {
                    MessageBox.Show("只能输入整数", "注意");
                    Method_Id.Text = null;
                    break;
                }
            }
            return;
        }
    }
}
