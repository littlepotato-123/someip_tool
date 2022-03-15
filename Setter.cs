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
    public partial class Setter : Form
    {
        public Setter()
        {
            InitializeComponent();
        }

        private void Send_Strategy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Event_Group_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signal_Id_TextChanged(object sender, EventArgs e)
        {
            string s = Signal_Id.Text.ToString();
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                {

                }
                else
                {
                    MessageBox.Show("只能输入整数", "注意");
                    Signal_Id.Text = null;
                    break;
                }
            }
            return;
        }
    }
}
