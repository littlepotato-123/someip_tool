
namespace WindowsFormsApp1
{
    partial class FF_METHOD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FF_METHOD));
            this.lb_Method_Name = new System.Windows.Forms.Label();
            this.lb_Method_Id = new System.Windows.Forms.Label();
            this.lb_Method_Description = new System.Windows.Forms.Label();
            this.lb_Udp_Tcp = new System.Windows.Forms.Label();
            this.lb_Input_Parameter = new System.Windows.Forms.Label();
            this.label8_Remark = new System.Windows.Forms.Label();
            this.Interface_Name = new System.Windows.Forms.TextBox();
            this.Method_Description = new System.Windows.Forms.TextBox();
            this.Method_Id = new System.Windows.Forms.TextBox();
            this.Remark = new System.Windows.Forms.TextBox();
            this.Input_Parameter = new System.Windows.Forms.TextBox();
            this.Udp_Tcp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_Method_Name
            // 
            this.lb_Method_Name.AutoSize = true;
            this.lb_Method_Name.Location = new System.Drawing.Point(48, 46);
            this.lb_Method_Name.Name = "lb_Method_Name";
            this.lb_Method_Name.Size = new System.Drawing.Size(95, 15);
            this.lb_Method_Name.TabIndex = 0;
            this.lb_Method_Name.Text = "Method_Name";
            // 
            // lb_Method_Id
            // 
            this.lb_Method_Id.AutoSize = true;
            this.lb_Method_Id.Location = new System.Drawing.Point(263, 46);
            this.lb_Method_Id.Name = "lb_Method_Id";
            this.lb_Method_Id.Size = new System.Drawing.Size(79, 15);
            this.lb_Method_Id.TabIndex = 1;
            this.lb_Method_Id.Text = "Method_Id";
            // 
            // lb_Method_Description
            // 
            this.lb_Method_Description.AutoSize = true;
            this.lb_Method_Description.Location = new System.Drawing.Point(485, 46);
            this.lb_Method_Description.Name = "lb_Method_Description";
            this.lb_Method_Description.Size = new System.Drawing.Size(151, 15);
            this.lb_Method_Description.TabIndex = 2;
            this.lb_Method_Description.Text = "Method_Description";
            // 
            // lb_Udp_Tcp
            // 
            this.lb_Udp_Tcp.AutoSize = true;
            this.lb_Udp_Tcp.Location = new System.Drawing.Point(48, 239);
            this.lb_Udp_Tcp.Name = "lb_Udp_Tcp";
            this.lb_Udp_Tcp.Size = new System.Drawing.Size(63, 15);
            this.lb_Udp_Tcp.TabIndex = 3;
            this.lb_Udp_Tcp.Text = "Udp_Tcp";
            // 
            // lb_Input_Parameter
            // 
            this.lb_Input_Parameter.AutoSize = true;
            this.lb_Input_Parameter.Location = new System.Drawing.Point(281, 239);
            this.lb_Input_Parameter.Name = "lb_Input_Parameter";
            this.lb_Input_Parameter.Size = new System.Drawing.Size(127, 15);
            this.lb_Input_Parameter.TabIndex = 4;
            this.lb_Input_Parameter.Text = "Input_Parameter";
            // 
            // label8_Remark
            // 
            this.label8_Remark.AutoSize = true;
            this.label8_Remark.Location = new System.Drawing.Point(592, 239);
            this.label8_Remark.Name = "label8_Remark";
            this.label8_Remark.Size = new System.Drawing.Size(55, 15);
            this.label8_Remark.TabIndex = 7;
            this.label8_Remark.Text = "Remark";
            // 
            // Interface_Name
            // 
            this.Interface_Name.Location = new System.Drawing.Point(43, 77);
            this.Interface_Name.Name = "Interface_Name";
            this.Interface_Name.Size = new System.Drawing.Size(100, 25);
            this.Interface_Name.TabIndex = 8;
            // 
            // Method_Description
            // 
            this.Method_Description.Location = new System.Drawing.Point(454, 77);
            this.Method_Description.Name = "Method_Description";
            this.Method_Description.Size = new System.Drawing.Size(233, 25);
            this.Method_Description.TabIndex = 10;
            // 
            // Method_Id
            // 
            this.Method_Id.Location = new System.Drawing.Point(273, 77);
            this.Method_Id.Name = "Method_Id";
            this.Method_Id.Size = new System.Drawing.Size(69, 25);
            this.Method_Id.TabIndex = 11;
            this.Method_Id.TextChanged += new System.EventHandler(this.Method_Id_TextChanged);
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(587, 273);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(100, 25);
            this.Remark.TabIndex = 13;
            // 
            // Input_Parameter
            // 
            this.Input_Parameter.Location = new System.Drawing.Point(222, 273);
            this.Input_Parameter.Name = "Input_Parameter";
            this.Input_Parameter.Size = new System.Drawing.Size(235, 25);
            this.Input_Parameter.TabIndex = 15;
            // 
            // Udp_Tcp
            // 
            this.Udp_Tcp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Udp_Tcp.FormattingEnabled = true;
            this.Udp_Tcp.Items.AddRange(new object[] {
            "Udp",
            "Tcp"});
            this.Udp_Tcp.Location = new System.Drawing.Point(51, 275);
            this.Udp_Tcp.Name = "Udp_Tcp";
            this.Udp_Tcp.Size = new System.Drawing.Size(67, 23);
            this.Udp_Tcp.TabIndex = 16;
            // 
            // FF_METHOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.Udp_Tcp);
            this.Controls.Add(this.Input_Parameter);
            this.Controls.Add(this.Remark);
            this.Controls.Add(this.Method_Id);
            this.Controls.Add(this.Method_Description);
            this.Controls.Add(this.Interface_Name);
            this.Controls.Add(this.label8_Remark);
            this.Controls.Add(this.lb_Input_Parameter);
            this.Controls.Add(this.lb_Udp_Tcp);
            this.Controls.Add(this.lb_Method_Description);
            this.Controls.Add(this.lb_Method_Id);
            this.Controls.Add(this.lb_Method_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FF_METHOD";
            this.Text = "FF_METHOD";
            this.Load += new System.EventHandler(this.FF_METHOD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Method_Name;
        private System.Windows.Forms.Label lb_Method_Id;
        private System.Windows.Forms.Label lb_Method_Description;
        private System.Windows.Forms.Label lb_Udp_Tcp;
        private System.Windows.Forms.Label lb_Input_Parameter;
        //private System.Windows.Forms.Label lb_Send_Strategy;
       // private System.Windows.Forms.Label label7_Epsilon_Value;
        private System.Windows.Forms.Label label8_Remark;
        private System.Windows.Forms.TextBox Interface_Name;
        //private System.Windows.Forms.TextBox
        //

        private System.Windows.Forms.TextBox Method_Description;
        private System.Windows.Forms.TextBox Method_Id;
        //private System.Windows.Forms.ComboBox Send_Strategy;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.TextBox Input_Parameter;
        private System.Windows.Forms.ComboBox Udp_Tcp;
    }
}