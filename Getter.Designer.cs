
namespace WindowsFormsApp1
{
    partial class Getter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Getter));
            this.lb_Udp_Tcp = new System.Windows.Forms.Label();
            this.lb_Output_Parameter = new System.Windows.Forms.Label();
            this.label8_Remark = new System.Windows.Forms.Label();
            this.Output_Parameter = new System.Windows.Forms.TextBox();
            this.Remark = new System.Windows.Forms.TextBox();
            this.Udp_Tcp = new System.Windows.Forms.ComboBox();
            this.Field_Property_Data_Type = new System.Windows.Forms.TextBox();
            this.Interface_Name = new System.Windows.Forms.TextBox();
            this.lb_Field_Name_Type = new System.Windows.Forms.Label();
            this.lb_Field_Name = new System.Windows.Forms.Label();
            this.Signal_Name = new System.Windows.Forms.TextBox();
            this.lb_Signal_Name = new System.Windows.Forms.Label();
            this.Signal_Id = new System.Windows.Forms.TextBox();
            this.lb_Signal_Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Udp_Tcp
            // 
            this.lb_Udp_Tcp.AutoSize = true;
            this.lb_Udp_Tcp.Location = new System.Drawing.Point(58, 166);
            this.lb_Udp_Tcp.Name = "lb_Udp_Tcp";
            this.lb_Udp_Tcp.Size = new System.Drawing.Size(63, 15);
            this.lb_Udp_Tcp.TabIndex = 3;
            this.lb_Udp_Tcp.Text = "Udp_Tcp";
            // 
            // lb_Output_Parameter
            // 
            this.lb_Output_Parameter.AutoSize = true;
            this.lb_Output_Parameter.Location = new System.Drawing.Point(442, 166);
            this.lb_Output_Parameter.Name = "lb_Output_Parameter";
            this.lb_Output_Parameter.Size = new System.Drawing.Size(135, 15);
            this.lb_Output_Parameter.TabIndex = 5;
            this.lb_Output_Parameter.Text = "Output_Parameter";
            // 
            // label8_Remark
            // 
            this.label8_Remark.AutoSize = true;
            this.label8_Remark.Location = new System.Drawing.Point(247, 166);
            this.label8_Remark.Name = "label8_Remark";
            this.label8_Remark.Size = new System.Drawing.Size(55, 15);
            this.label8_Remark.TabIndex = 7;
            this.label8_Remark.Text = "Remark";
            // 
            // Output_Parameter
            // 
            this.Output_Parameter.Location = new System.Drawing.Point(419, 199);
            this.Output_Parameter.Name = "Output_Parameter";
            this.Output_Parameter.Size = new System.Drawing.Size(205, 25);
            this.Output_Parameter.TabIndex = 12;
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(220, 197);
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
            this.Udp_Tcp.Location = new System.Drawing.Point(55, 199);
            this.Udp_Tcp.Name = "Udp_Tcp";
            this.Udp_Tcp.Size = new System.Drawing.Size(82, 23);
            this.Udp_Tcp.TabIndex = 16;
            // 
            // Field_Property_Data_Type
            // 
            this.Field_Property_Data_Type.Location = new System.Drawing.Point(220, 76);
            this.Field_Property_Data_Type.Name = "Field_Property_Data_Type";
            this.Field_Property_Data_Type.Size = new System.Drawing.Size(100, 25);
            this.Field_Property_Data_Type.TabIndex = 23;
            // 
            // Interface_Name
            // 
            this.Interface_Name.Location = new System.Drawing.Point(40, 76);
            this.Interface_Name.Name = "Interface_Name";
            this.Interface_Name.Size = new System.Drawing.Size(100, 25);
            this.Interface_Name.TabIndex = 21;
            // 
            // lb_Field_Name_Type
            // 
            this.lb_Field_Name_Type.AutoSize = true;
            this.lb_Field_Name_Type.Location = new System.Drawing.Point(207, 45);
            this.lb_Field_Name_Type.Name = "lb_Field_Name_Type";
            this.lb_Field_Name_Type.Size = new System.Drawing.Size(127, 15);
            this.lb_Field_Name_Type.TabIndex = 18;
            this.lb_Field_Name_Type.Text = "Field_Name_Type";
            // 
            // lb_Field_Name
            // 
            this.lb_Field_Name.AutoSize = true;
            this.lb_Field_Name.Location = new System.Drawing.Point(42, 45);
            this.lb_Field_Name.Name = "lb_Field_Name";
            this.lb_Field_Name.Size = new System.Drawing.Size(95, 15);
            this.lb_Field_Name.TabIndex = 17;
            this.lb_Field_Name.Text = "Field_Name ";
            // 
            // Signal_Name
            // 
            this.Signal_Name.Location = new System.Drawing.Point(387, 76);
            this.Signal_Name.Name = "Signal_Name";
            this.Signal_Name.Size = new System.Drawing.Size(136, 25);
            this.Signal_Name.TabIndex = 31;
            // 
            // lb_Signal_Name
            // 
            this.lb_Signal_Name.AutoSize = true;
            this.lb_Signal_Name.Location = new System.Drawing.Point(408, 45);
            this.lb_Signal_Name.Name = "lb_Signal_Name";
            this.lb_Signal_Name.Size = new System.Drawing.Size(95, 15);
            this.lb_Signal_Name.TabIndex = 30;
            this.lb_Signal_Name.Text = "Signal_Name";
            // 
            // Signal_Id
            // 
            this.Signal_Id.Location = new System.Drawing.Point(570, 76);
            this.Signal_Id.Name = "Signal_Id";
            this.Signal_Id.Size = new System.Drawing.Size(54, 25);
            this.Signal_Id.TabIndex = 29;
            this.Signal_Id.TextChanged += new System.EventHandler(this.Signal_Id_TextChanged);
            // 
            // lb_Signal_Id
            // 
            this.lb_Signal_Id.AutoSize = true;
            this.lb_Signal_Id.Location = new System.Drawing.Point(545, 45);
            this.lb_Signal_Id.Name = "lb_Signal_Id";
            this.lb_Signal_Id.Size = new System.Drawing.Size(79, 15);
            this.lb_Signal_Id.TabIndex = 28;
            this.lb_Signal_Id.Text = "Signal_Id";
            // 
            // Getter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 265);
            this.Controls.Add(this.Signal_Name);
            this.Controls.Add(this.lb_Signal_Name);
            this.Controls.Add(this.Signal_Id);
            this.Controls.Add(this.lb_Signal_Id);
            this.Controls.Add(this.Field_Property_Data_Type);
            this.Controls.Add(this.Interface_Name);
            this.Controls.Add(this.lb_Field_Name_Type);
            this.Controls.Add(this.lb_Field_Name);
            this.Controls.Add(this.Udp_Tcp);
            this.Controls.Add(this.Remark);
            this.Controls.Add(this.Output_Parameter);
            this.Controls.Add(this.label8_Remark);
            this.Controls.Add(this.lb_Output_Parameter);
            this.Controls.Add(this.lb_Udp_Tcp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Getter";
            this.Text = "Getter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Udp_Tcp;
        private System.Windows.Forms.Label lb_Output_Parameter;
        //private System.Windows.Forms.Label label7_Epsilon_Value;
        private System.Windows.Forms.Label label8_Remark;
        private System.Windows.Forms.TextBox Output_Parameter;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.ComboBox Udp_Tcp;
        private System.Windows.Forms.TextBox Field_Property_Data_Type;
        private System.Windows.Forms.TextBox Interface_Name;
        private System.Windows.Forms.Label lb_Field_Name_Type;
        private System.Windows.Forms.Label lb_Field_Name;
        private System.Windows.Forms.TextBox Signal_Name;
        private System.Windows.Forms.Label lb_Signal_Name;
        private System.Windows.Forms.TextBox Signal_Id;
        private System.Windows.Forms.Label lb_Signal_Id;
    }

}