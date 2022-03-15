
namespace WindowsFormsApp1
{
    partial class tag_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tag_form));
            this.lb_tags_sel = new System.Windows.Forms.Label();
            this.lsb_lb = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lsb_lib = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_to_lib = new System.Windows.Forms.Button();
            this.tb_add_to_lib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_tags_sel
            // 
            this.lb_tags_sel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_tags_sel.Location = new System.Drawing.Point(12, 9);
            this.lb_tags_sel.Name = "lb_tags_sel";
            this.lb_tags_sel.Size = new System.Drawing.Size(149, 37);
            this.lb_tags_sel.TabIndex = 2;
            this.lb_tags_sel.Text = "已选标签：";
            this.lb_tags_sel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tags_sel.Click += new System.EventHandler(this.lb_tags_sel_Click);
            // 
            // lsb_lb
            // 
            this.lsb_lb.FormattingEnabled = true;
            this.lsb_lb.ItemHeight = 15;
            this.lsb_lb.Location = new System.Drawing.Point(26, 49);
            this.lsb_lb.Name = "lsb_lb";
            this.lsb_lb.Size = new System.Drawing.Size(119, 244);
            this.lsb_lb.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(151, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 29);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "<<添加标签";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(151, 137);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(128, 29);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "<<删除标签";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lsb_lib
            // 
            this.lsb_lib.FormattingEnabled = true;
            this.lsb_lib.ItemHeight = 15;
            this.lsb_lib.Location = new System.Drawing.Point(306, 49);
            this.lsb_lib.Name = "lsb_lib";
            this.lsb_lib.Size = new System.Drawing.Size(119, 244);
            this.lsb_lib.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "标签库：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_add_to_lib
            // 
            this.btn_add_to_lib.Location = new System.Drawing.Point(151, 310);
            this.btn_add_to_lib.Name = "btn_add_to_lib";
            this.btn_add_to_lib.Size = new System.Drawing.Size(128, 29);
            this.btn_add_to_lib.TabIndex = 8;
            this.btn_add_to_lib.Text = "添加标签";
            this.btn_add_to_lib.UseVisualStyleBackColor = true;
            this.btn_add_to_lib.Click += new System.EventHandler(this.btn_add_to_lib_Click);
            // 
            // tb_add_to_lib
            // 
            this.tb_add_to_lib.Location = new System.Drawing.Point(26, 314);
            this.tb_add_to_lib.Name = "tb_add_to_lib";
            this.tb_add_to_lib.Size = new System.Drawing.Size(119, 25);
            this.tb_add_to_lib.TabIndex = 9;
            // 
            // tag_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 359);
            this.Controls.Add(this.tb_add_to_lib);
            this.Controls.Add(this.btn_add_to_lib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsb_lib);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lsb_lb);
            this.Controls.Add(this.lb_tags_sel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tag_form";
            this.Text = "标签";
            this.Load += new System.EventHandler(this.tag_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_tags_sel;
        public System.Windows.Forms.ListBox lsb_lb;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.ListBox lsb_lib;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_add_to_lib;
        public System.Windows.Forms.TextBox tb_add_to_lib;
    }
}