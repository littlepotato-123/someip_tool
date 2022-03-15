
namespace WindowsFormsApp1
{
    partial class tag_from_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tag_from_search));
            this.lb_tags_sel = new System.Windows.Forms.Label();
            this.lsb_lb = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lsb_lib = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tags_sel
            // 
            this.lb_tags_sel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_tags_sel.Location = new System.Drawing.Point(12, 9);
            this.lb_tags_sel.Name = "lb_tags_sel";
            this.lb_tags_sel.Size = new System.Drawing.Size(149, 37);
            this.lb_tags_sel.TabIndex = 2;
            this.lb_tags_sel.Text = "搜索标签：";
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
            this.btn_add.Location = new System.Drawing.Point(151, 67);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 35);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "<<添加标签";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(151, 123);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(115, 35);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "<<删除标签";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lsb_lib
            // 
            this.lsb_lib.FormattingEnabled = true;
            this.lsb_lib.ItemHeight = 15;
            this.lsb_lib.Location = new System.Drawing.Point(283, 49);
            this.lsb_lib.Name = "lsb_lib";
            this.lsb_lib.Size = new System.Drawing.Size(119, 244);
            this.lsb_lib.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "标签库：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tag_from_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 359);
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
            this.Name = "tag_from_search";
            this.Text = "标签";
            this.Load += new System.EventHandler(this.tag_form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lb_tags_sel;
        public System.Windows.Forms.ListBox lsb_lb;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.ListBox lsb_lib;
        public System.Windows.Forms.Label label1;
    }
}