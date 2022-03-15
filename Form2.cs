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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    if(MessageBox.Show("是否保存","正在退出",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //    {
            //       //e.Cancel = true;
            //        //this.Hide();
            //        //保存逻辑
            //    }
            //    else
            //    {

            //    }
                
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
