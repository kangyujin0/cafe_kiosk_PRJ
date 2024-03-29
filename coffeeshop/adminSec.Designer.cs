﻿namespace coffeeshop
{
    partial class adminSec
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bellNameLb = new System.Windows.Forms.Label();
            this.idWelcomeLb = new System.Windows.Forms.Label();
            this.pwResetBtn = new System.Windows.Forms.Button();
            this.portOpenBtn = new System.Windows.Forms.Button();
            this.bell_5 = new System.Windows.Forms.Button();
            this.bell_4 = new System.Windows.Forms.Button();
            this.bell_3 = new System.Windows.Forms.Button();
            this.bell_2 = new System.Windows.Forms.Button();
            this.bell_1 = new System.Windows.Forms.Button();
            this.totalSalesBtn = new System.Windows.Forms.Label();
            this.completedListBtn = new System.Windows.Forms.Button();
            this.waitingListBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.bellNameLb);
            this.splitContainer1.Panel1.Controls.Add(this.idWelcomeLb);
            this.splitContainer1.Panel1.Controls.Add(this.pwResetBtn);
            this.splitContainer1.Panel1.Controls.Add(this.portOpenBtn);
            this.splitContainer1.Panel1.Controls.Add(this.bell_5);
            this.splitContainer1.Panel1.Controls.Add(this.bell_4);
            this.splitContainer1.Panel1.Controls.Add(this.bell_3);
            this.splitContainer1.Panel1.Controls.Add(this.bell_2);
            this.splitContainer1.Panel1.Controls.Add(this.bell_1);
            this.splitContainer1.Panel1.Controls.Add(this.totalSalesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.completedListBtn);
            this.splitContainer1.Panel1.Controls.Add(this.waitingListBtn);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_admin);
            this.splitContainer1.Size = new System.Drawing.Size(2176, 1301);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // bellNameLb
            // 
            this.bellNameLb.AutoSize = true;
            this.bellNameLb.Location = new System.Drawing.Point(54, 216);
            this.bellNameLb.Name = "bellNameLb";
            this.bellNameLb.Size = new System.Drawing.Size(45, 15);
            this.bellNameLb.TabIndex = 1;
            this.bellNameLb.Text = "label1";
            // 
            // idWelcomeLb
            // 
            this.idWelcomeLb.AutoSize = true;
            this.idWelcomeLb.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idWelcomeLb.Location = new System.Drawing.Point(1841, 82);
            this.idWelcomeLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idWelcomeLb.Name = "idWelcomeLb";
            this.idWelcomeLb.Size = new System.Drawing.Size(194, 24);
            this.idWelcomeLb.TabIndex = 1;
            this.idWelcomeLb.Text = "유저 환영 메세지";
            this.idWelcomeLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwResetBtn
            // 
            this.pwResetBtn.AutoSize = true;
            this.pwResetBtn.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwResetBtn.Location = new System.Drawing.Point(1845, 135);
            this.pwResetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pwResetBtn.Name = "pwResetBtn";
            this.pwResetBtn.Size = new System.Drawing.Size(197, 40);
            this.pwResetBtn.TabIndex = 1;
            this.pwResetBtn.Text = "비밀번호 재설정";
            this.pwResetBtn.UseVisualStyleBackColor = true;
            this.pwResetBtn.Click += new System.EventHandler(this.pwResetBtn_Click);
            // 
            // portOpenBtn
            // 
            this.portOpenBtn.AutoSize = true;
            this.portOpenBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portOpenBtn.Location = new System.Drawing.Point(38, 156);
            this.portOpenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portOpenBtn.Name = "portOpenBtn";
            this.portOpenBtn.Size = new System.Drawing.Size(169, 42);
            this.portOpenBtn.TabIndex = 8;
            this.portOpenBtn.Text = "진동벨 연결";
            this.portOpenBtn.UseVisualStyleBackColor = true;
            this.portOpenBtn.Click += new System.EventHandler(this.portOpenBtn_Click);
            // 
            // bell_5
            // 
            this.bell_5.AutoSize = true;
            this.bell_5.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bell_5.Location = new System.Drawing.Point(226, 246);
            this.bell_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bell_5.Name = "bell_5";
            this.bell_5.Size = new System.Drawing.Size(103, 42);
            this.bell_5.TabIndex = 7;
            this.bell_5.Text = "5번 벨";
            this.bell_5.UseVisualStyleBackColor = true;
            this.bell_5.Click += new System.EventHandler(this.bell_5_Click);
            // 
            // bell_4
            // 
            this.bell_4.AutoSize = true;
            this.bell_4.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bell_4.Location = new System.Drawing.Point(335, 201);
            this.bell_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bell_4.Name = "bell_4";
            this.bell_4.Size = new System.Drawing.Size(103, 42);
            this.bell_4.TabIndex = 6;
            this.bell_4.Text = "4번 벨";
            this.bell_4.UseVisualStyleBackColor = true;
            this.bell_4.Click += new System.EventHandler(this.bell_4_Click);
            // 
            // bell_3
            // 
            this.bell_3.AutoSize = true;
            this.bell_3.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bell_3.Location = new System.Drawing.Point(226, 201);
            this.bell_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bell_3.Name = "bell_3";
            this.bell_3.Size = new System.Drawing.Size(103, 42);
            this.bell_3.TabIndex = 5;
            this.bell_3.Text = "3번 벨";
            this.bell_3.UseVisualStyleBackColor = true;
            this.bell_3.Click += new System.EventHandler(this.bell_3_Click);
            // 
            // bell_2
            // 
            this.bell_2.AutoSize = true;
            this.bell_2.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bell_2.Location = new System.Drawing.Point(335, 156);
            this.bell_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bell_2.Name = "bell_2";
            this.bell_2.Size = new System.Drawing.Size(103, 42);
            this.bell_2.TabIndex = 4;
            this.bell_2.Text = "2번 벨";
            this.bell_2.UseVisualStyleBackColor = true;
            this.bell_2.Click += new System.EventHandler(this.bell_2_Click);
            // 
            // bell_1
            // 
            this.bell_1.AutoSize = true;
            this.bell_1.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bell_1.Location = new System.Drawing.Point(226, 156);
            this.bell_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bell_1.Name = "bell_1";
            this.bell_1.Size = new System.Drawing.Size(103, 42);
            this.bell_1.TabIndex = 3;
            this.bell_1.Text = "1번 벨";
            this.bell_1.UseVisualStyleBackColor = true;
            this.bell_1.Click += new System.EventHandler(this.bell_1_Click);
            // 
            // totalSalesBtn
            // 
            this.totalSalesBtn.AutoSize = true;
            this.totalSalesBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalSalesBtn.Location = new System.Drawing.Point(730, 60);
            this.totalSalesBtn.Name = "totalSalesBtn";
            this.totalSalesBtn.Size = new System.Drawing.Size(163, 30);
            this.totalSalesBtn.TabIndex = 2;
            this.totalSalesBtn.Text = "누적 매출: ";
            this.totalSalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedListBtn
            // 
            this.completedListBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.completedListBtn.Location = new System.Drawing.Point(329, 44);
            this.completedListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.completedListBtn.Name = "completedListBtn";
            this.completedListBtn.Size = new System.Drawing.Size(280, 62);
            this.completedListBtn.TabIndex = 1;
            this.completedListBtn.Text = "완료주문 확인하기";
            this.completedListBtn.UseVisualStyleBackColor = true;
            this.completedListBtn.Click += new System.EventHandler(this.completedListBtn_Click);
            // 
            // waitingListBtn
            // 
            this.waitingListBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.waitingListBtn.Location = new System.Drawing.Point(30, 44);
            this.waitingListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitingListBtn.Name = "waitingListBtn";
            this.waitingListBtn.Size = new System.Drawing.Size(280, 62);
            this.waitingListBtn.TabIndex = 0;
            this.waitingListBtn.Text = "대기주문 확인하기";
            this.waitingListBtn.UseVisualStyleBackColor = true;
            this.waitingListBtn.Click += new System.EventHandler(this.waitingListBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 752);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2176, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(12, 20);
            this.sbLabel1.Text = ".";
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowHeadersWidth = 62;
            this.dataGridView_admin.RowTemplate.Height = 40;
            this.dataGridView_admin.Size = new System.Drawing.Size(2176, 778);
            this.dataGridView_admin.TabIndex = 0;
            this.dataGridView_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_admin_CellClick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1845, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "로그아웃";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2176, 1301);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adminSec";
            this.Text = "관리자 모드";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button waitingListBtn;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Label totalSalesBtn;
        private System.Windows.Forms.Button completedListBtn;
        private System.Windows.Forms.Button bell_5;
        private System.Windows.Forms.Button bell_4;
        private System.Windows.Forms.Button bell_3;
        private System.Windows.Forms.Button bell_2;
        private System.Windows.Forms.Button bell_1;
        private System.Windows.Forms.Button portOpenBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button pwResetBtn;
        private System.Windows.Forms.Label idWelcomeLb;
        private System.Windows.Forms.Label bellNameLb;
        private System.Windows.Forms.Button button1;
    }
}