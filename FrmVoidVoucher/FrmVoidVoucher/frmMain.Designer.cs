namespace FrmVoidVoucher
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lsvWh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.dtpBill = new k.libary.kDateTimePicker(this.components);
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ยกเลกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbbrand = new System.Windows.Forms.ToolStripDropDownButton();
            this.bBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cms.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvWh
            // 
            this.lsvWh.CheckBoxes = true;
            this.lsvWh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvWh.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsvWh.FullRowSelect = true;
            this.lsvWh.GridLines = true;
            this.lsvWh.Location = new System.Drawing.Point(0, 39);
            this.lsvWh.Name = "lsvWh";
            this.lsvWh.Size = new System.Drawing.Size(433, 584);
            this.lsvWh.TabIndex = 0;
            this.lsvWh.UseCompatibleStateImageBehavior = false;
            this.lsvWh.View = System.Windows.Forms.View.Details;
            this.lsvWh.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvWh_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "whcode";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "whname";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "dns";
            this.columnHeader4.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtBill);
            this.groupBox1.Controls.Add(this.dtpBill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(433, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียด";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(385, 114);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ตรวจสอบ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(149, 71);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(200, 23);
            this.txtBill.TabIndex = 4;
            this.txtBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBill_KeyDown);
            // 
            // dtpBill
            // 
            this.dtpBill.DisplayThai = true;
            this.dtpBill.Location = new System.Drawing.Point(149, 29);
            this.dtpBill.Name = "dtpBill";
            this.dtpBill.Size = new System.Drawing.Size(200, 23);
            this.dtpBill.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(439, 212);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(759, 411);
            this.lsvBill.TabIndex = 2;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.Click += new System.EventHandler(this.lsvBill_Click);
            this.lsvBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvBill_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ลำดับ";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "สาขา";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "วันที่ขาย";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "จุดขาย";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "เลขที่บิล";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "เลขที่คูปอง/เว้าเชอร์";
            this.columnHeader10.Width = 243;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "dns";
            this.columnHeader11.Width = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(90, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "เลขที่บิล*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ยกเลกToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(104, 26);
            // 
            // ยกเลกToolStripMenuItem
            // 
            this.ยกเลกToolStripMenuItem.Name = "ยกเลกToolStripMenuItem";
            this.ยกเลกToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ยกเลกToolStripMenuItem.Text = "ยกเลิก";
            this.ยกเลกToolStripMenuItem.Click += new System.EventHandler(this.ยกเลกToolStripMenuItem_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(149, 113);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 23);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(85, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "หมายเหตุ*";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbrand,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(93, 36);
            this.tsbClose.Text = "ปิดหน้าต่าง";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsbbrand
            // 
            this.tsbbrand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBToolStripMenuItem,
            this.bCToolStripMenuItem,
            this.bMToolStripMenuItem});
            this.tsbbrand.Image = ((System.Drawing.Image)(resources.GetObject("tsbbrand.Image")));
            this.tsbbrand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbrand.Name = "tsbbrand";
            this.tsbbrand.Size = new System.Drawing.Size(83, 36);
            this.tsbbrand.Text = "Brand";
            // 
            // bBToolStripMenuItem
            // 
            this.bBToolStripMenuItem.Name = "bBToolStripMenuItem";
            this.bBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bBToolStripMenuItem.Text = "BB";
            this.bBToolStripMenuItem.Click += new System.EventHandler(this.bBToolStripMenuItem_Click);
            // 
            // bCToolStripMenuItem
            // 
            this.bCToolStripMenuItem.Name = "bCToolStripMenuItem";
            this.bCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bCToolStripMenuItem.Text = "BC";
            this.bCToolStripMenuItem.Click += new System.EventHandler(this.bCToolStripMenuItem_Click);
            // 
            // bMToolStripMenuItem
            // 
            this.bMToolStripMenuItem.Name = "bMToolStripMenuItem";
            this.bMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bMToolStripMenuItem.Text = "BM";
            this.bMToolStripMenuItem.Click += new System.EventHandler(this.bMToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 623);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvWh);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "ยกเลิก คูปอง/เว้าเชอร์";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvWh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBill;
        private k.libary.kDateTimePicker dtpBill;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem ยกเลกToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripDropDownButton tsbbrand;
        private System.Windows.Forms.ToolStripMenuItem bBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMToolStripMenuItem;
    }
}

