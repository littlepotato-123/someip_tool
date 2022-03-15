
namespace WindowsFormsApp1
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.lb_Event_Name = new System.Windows.Forms.Label();
            this.lb_Event_Id = new System.Windows.Forms.Label();
            this.lb_Event_Description = new System.Windows.Forms.Label();
            this.lb_Udp_Tcp = new System.Windows.Forms.Label();
            this.label8_Remark = new System.Windows.Forms.Label();
            this.Interface_Name = new System.Windows.Forms.TextBox();
            this.Method_Description = new System.Windows.Forms.TextBox();
            this.Event_Id = new System.Windows.Forms.TextBox();
            this.Remark = new System.Windows.Forms.TextBox();
            this.Udp_Tcp = new System.Windows.Forms.ComboBox();
            this.lb_Eventgroup_id = new System.Windows.Forms.Label();
            this.Event_Group_id = new System.Windows.Forms.TextBox();
            this.Event_Parameter = new System.Windows.Forms.TextBox();
            this.lb_Event_Group_Name = new System.Windows.Forms.Label();
            this.Send_Type = new System.Windows.Forms.ComboBox();
            this.lb_Send_Type = new System.Windows.Forms.Label();
            this.Cyclic_Time = new System.Windows.Forms.TextBox();
            this.lb_Cyclic_Time = new System.Windows.Forms.Label();
            this.Input_Parameter = new System.Windows.Forms.TextBox();
            this.lb_Input_Parameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Event_Name
            // 
            this.lb_Event_Name.AutoSize = true;
            this.lb_Event_Name.Location = new System.Drawing.Point(32, 45);
            this.lb_Event_Name.Name = "lb_Event_Name";
            this.lb_Event_Name.Size = new System.Drawing.Size(87, 15);
            this.lb_Event_Name.TabIndex = 0;
            this.lb_Event_Name.Text = "Event Name";
            // 
            // lb_Event_Id
            // 
            this.lb_Event_Id.AutoSize = true;
            this.lb_Event_Id.Location = new System.Drawing.Point(237, 45);
            this.lb_Event_Id.Name = "lb_Event_Id";
            this.lb_Event_Id.Size = new System.Drawing.Size(71, 15);
            this.lb_Event_Id.TabIndex = 1;
            this.lb_Event_Id.Text = "Event Id";
            // 
            // lb_Event_Description
            // 
            this.lb_Event_Description.AutoSize = true;
            this.lb_Event_Description.Location = new System.Drawing.Point(408, 45);
            this.lb_Event_Description.Name = "lb_Event_Description";
            this.lb_Event_Description.Size = new System.Drawing.Size(143, 15);
            this.lb_Event_Description.TabIndex = 2;
            this.lb_Event_Description.Text = "Event Description";
            // 
            // lb_Udp_Tcp
            // 
            this.lb_Udp_Tcp.AutoSize = true;
            this.lb_Udp_Tcp.Location = new System.Drawing.Point(642, 45);
            this.lb_Udp_Tcp.Name = "lb_Udp_Tcp";
            this.lb_Udp_Tcp.Size = new System.Drawing.Size(63, 15);
            this.lb_Udp_Tcp.TabIndex = 3;
            this.lb_Udp_Tcp.Text = "Udp_Tcp";
            // 
            // label8_Remark
            // 
            this.label8_Remark.AutoSize = true;
            this.label8_Remark.Location = new System.Drawing.Point(587, 272);
            this.label8_Remark.Name = "label8_Remark";
            this.label8_Remark.Size = new System.Drawing.Size(55, 15);
            this.label8_Remark.TabIndex = 7;
            this.label8_Remark.Text = "Remark";
            // 
            // Interface_Name
            // 
            this.Interface_Name.Location = new System.Drawing.Point(27, 78);
            this.Interface_Name.Name = "Interface_Name";
            this.Interface_Name.Size = new System.Drawing.Size(100, 25);
            this.Interface_Name.TabIndex = 8;
            // 
            // Method_Description
            // 
            this.Method_Description.Location = new System.Drawing.Point(376, 78);
            this.Method_Description.Name = "Method_Description";
            this.Method_Description.Size = new System.Drawing.Size(194, 25);
            this.Method_Description.TabIndex = 10;
            // 
            // Event_Id
            // 
            this.Event_Id.Location = new System.Drawing.Point(230, 78);
            this.Event_Id.Name = "Event_Id";
            this.Event_Id.Size = new System.Drawing.Size(78, 25);
            this.Event_Id.TabIndex = 11;
            this.Event_Id.TextChanged += new System.EventHandler(this.Method_Id_TextChanged);
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(561, 301);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(100, 25);
            this.Remark.TabIndex = 13;
            // 
            // Udp_Tcp
            // 
            this.Udp_Tcp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Udp_Tcp.FormattingEnabled = true;
            this.Udp_Tcp.Items.AddRange(new object[] {
            "Udp",
            "Tcp"});
            this.Udp_Tcp.Location = new System.Drawing.Point(637, 80);
            this.Udp_Tcp.Name = "Udp_Tcp";
            this.Udp_Tcp.Size = new System.Drawing.Size(81, 23);
            this.Udp_Tcp.TabIndex = 16;
            this.Udp_Tcp.SelectedIndexChanged += new System.EventHandler(this.Udp_Tcp_SelectedIndexChanged);
            // 
            // lb_Eventgroup_id
            // 
            this.lb_Eventgroup_id.AutoSize = true;
            this.lb_Eventgroup_id.Location = new System.Drawing.Point(227, 163);
            this.lb_Eventgroup_id.Name = "lb_Eventgroup_id";
            this.lb_Eventgroup_id.Size = new System.Drawing.Size(111, 15);
            this.lb_Eventgroup_id.TabIndex = 24;
            this.lb_Eventgroup_id.Text = "Eventgroup_id";
            // 
            // Event_Group_id
            // 
            this.Event_Group_id.Location = new System.Drawing.Point(258, 198);
            this.Event_Group_id.Name = "Event_Group_id";
            this.Event_Group_id.Size = new System.Drawing.Size(60, 25);
            this.Event_Group_id.TabIndex = 25;
            this.Event_Group_id.TextChanged += new System.EventHandler(this.Eventgroup_Name_id_TextChanged);
            // 
            // Event_Parameter
            // 
            this.Event_Parameter.Location = new System.Drawing.Point(55, 198);
            this.Event_Parameter.Name = "Event_Parameter";
            this.Event_Parameter.Size = new System.Drawing.Size(100, 25);
            this.Event_Parameter.TabIndex = 27;
            // 
            // lb_Event_Group_Name
            // 
            this.lb_Event_Group_Name.AutoSize = true;
            this.lb_Event_Group_Name.Location = new System.Drawing.Point(39, 163);
            this.lb_Event_Group_Name.Name = "lb_Event_Group_Name";
            this.lb_Event_Group_Name.Size = new System.Drawing.Size(135, 15);
            this.lb_Event_Group_Name.TabIndex = 26;
            this.lb_Event_Group_Name.Text = "Event_Group_Name";
            // 
            // Send_Type
            // 
            this.Send_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Send_Type.FormattingEnabled = true;
            this.Send_Type.Items.AddRange(new object[] {
            "Changed",
            "Cyclic"});
            this.Send_Type.Location = new System.Drawing.Point(430, 200);
            this.Send_Type.Name = "Send_Type";
            this.Send_Type.Size = new System.Drawing.Size(100, 23);
            this.Send_Type.TabIndex = 29;
            this.Send_Type.SelectedIndexChanged += new System.EventHandler(this.Send_Strategy_SelectedIndexChanged);
            // 
            // lb_Send_Type
            // 
            this.lb_Send_Type.AutoSize = true;
            this.lb_Send_Type.Location = new System.Drawing.Point(431, 163);
            this.lb_Send_Type.Name = "lb_Send_Type";
            this.lb_Send_Type.Size = new System.Drawing.Size(79, 15);
            this.lb_Send_Type.TabIndex = 28;
            this.lb_Send_Type.Text = "Send_Type";
            // 
            // Cyclic_Time
            // 
            this.Cyclic_Time.Enabled = false;
            this.Cyclic_Time.Location = new System.Drawing.Point(637, 198);
            this.Cyclic_Time.Name = "Cyclic_Time";
            this.Cyclic_Time.Size = new System.Drawing.Size(100, 25);
            this.Cyclic_Time.TabIndex = 31;
            this.Cyclic_Time.TextChanged += new System.EventHandler(this.tb_Cyclic_Time_TextChanged);
            // 
            // lb_Cyclic_Time
            // 
            this.lb_Cyclic_Time.AutoSize = true;
            this.lb_Cyclic_Time.Location = new System.Drawing.Point(619, 163);
            this.lb_Cyclic_Time.Name = "lb_Cyclic_Time";
            this.lb_Cyclic_Time.Size = new System.Drawing.Size(127, 15);
            this.lb_Cyclic_Time.TabIndex = 30;
            this.lb_Cyclic_Time.Text = "Cyclic Time(ms)";
            // 
            // Input_Parameter
            // 
            this.Input_Parameter.Location = new System.Drawing.Point(55, 317);
            this.Input_Parameter.Name = "Input_Parameter";
            this.Input_Parameter.Size = new System.Drawing.Size(194, 25);
            this.Input_Parameter.TabIndex = 33;
            // 
            // lb_Input_Parameter
            // 
            this.lb_Input_Parameter.AutoSize = true;
            this.lb_Input_Parameter.Location = new System.Drawing.Point(66, 285);
            this.lb_Input_Parameter.Name = "lb_Input_Parameter";
            this.lb_Input_Parameter.Size = new System.Drawing.Size(127, 15);
            this.lb_Input_Parameter.TabIndex = 32;
            this.lb_Input_Parameter.Text = "Input_Parameter";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(806, 392);
            this.Controls.Add(this.Input_Parameter);
            this.Controls.Add(this.lb_Input_Parameter);
            this.Controls.Add(this.Cyclic_Time);
            this.Controls.Add(this.lb_Cyclic_Time);
            this.Controls.Add(this.Send_Type);
            this.Controls.Add(this.lb_Send_Type);
            this.Controls.Add(this.Event_Parameter);
            this.Controls.Add(this.lb_Event_Group_Name);
            this.Controls.Add(this.Event_Group_id);
            this.Controls.Add(this.lb_Eventgroup_id);
            this.Controls.Add(this.Udp_Tcp);
            this.Controls.Add(this.Remark);
            this.Controls.Add(this.Event_Id);
            this.Controls.Add(this.Method_Description);
            this.Controls.Add(this.Interface_Name);
            this.Controls.Add(this.label8_Remark);
            this.Controls.Add(this.lb_Udp_Tcp);
            this.Controls.Add(this.lb_Event_Description);
            this.Controls.Add(this.lb_Event_Id);
            this.Controls.Add(this.lb_Event_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Event_Name;
        private System.Windows.Forms.Label lb_Event_Id;
        private System.Windows.Forms.Label lb_Event_Description;
        private System.Windows.Forms.Label lb_Udp_Tcp;
       // private System.Windows.Forms.Label label7_Epsilon_Value;
        private System.Windows.Forms.Label label8_Remark;
        private System.Windows.Forms.TextBox Interface_Name;
        //private System.Windows.Forms.TextBox Epsilon_Value;
        private System.Windows.Forms.TextBox Method_Description;
        private System.Windows.Forms.TextBox Event_Id;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.ComboBox Udp_Tcp;
        private System.Windows.Forms.Label lb_Eventgroup_id;
        private System.Windows.Forms.TextBox Event_Group_id;
        private System.Windows.Forms.TextBox Event_Parameter;
        private System.Windows.Forms.Label lb_Event_Group_Name;
        private System.Windows.Forms.ComboBox Send_Type;
        private System.Windows.Forms.Label lb_Send_Type;
        private System.Windows.Forms.TextBox Cyclic_Time;
        private System.Windows.Forms.Label lb_Cyclic_Time;
        private System.Windows.Forms.TextBox Input_Parameter;
        private System.Windows.Forms.Label lb_Input_Parameter;
    }
}