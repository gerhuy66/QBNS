namespace QBNS
{
    partial class ShopFr
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAddAGR = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTenShop = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTenChuCH = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenShop = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTenChuShop = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa Hàng Nông Sản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(373, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(977, 547);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnAddAGR);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 729);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(109, 304);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(157, 30);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "In Bảng Thống Kê";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAddAGR
            // 
            this.btnAddAGR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAGR.Location = new System.Drawing.Point(109, 250);
            this.btnAddAGR.Name = "btnAddAGR";
            this.btnAddAGR.Size = new System.Drawing.Size(157, 30);
            this.btnAddAGR.TabIndex = 6;
            this.btnAddAGR.Text = "Thêm Nông Sản Mới";
            this.btnAddAGR.UseVisualStyleBackColor = false;
            this.btnAddAGR.Click += new System.EventHandler(this.btnAddAGR_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefresh.Location = new System.Drawing.Point(261, 526);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Cập Nhật";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(55, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông Tin Cửa Hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.avatar);
            this.panel3.Controls.Add(this.tbDiaChi);
            this.panel3.Controls.Add(this.tbTenShop);
            this.panel3.Controls.Add(this.tbSDT);
            this.panel3.Controls.Add(this.tbTenChuCH);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.lbDiaChi);
            this.panel3.Controls.Add(this.lbTenShop);
            this.panel3.Controls.Add(this.lbSDT);
            this.panel3.Controls.Add(this.lbTenChuShop);
            this.panel3.Location = new System.Drawing.Point(19, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 187);
            this.panel3.TabIndex = 0;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(9, 20);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 122);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(212, 126);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(100, 20);
            this.tbDiaChi.TabIndex = 9;
            // 
            // tbTenShop
            // 
            this.tbTenShop.Location = new System.Drawing.Point(212, 85);
            this.tbTenShop.Name = "tbTenShop";
            this.tbTenShop.Size = new System.Drawing.Size(100, 20);
            this.tbTenShop.TabIndex = 8;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(212, 54);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(100, 20);
            this.tbSDT.TabIndex = 7;
            // 
            // tbTenChuCH
            // 
            this.tbTenChuCH.Location = new System.Drawing.Point(212, 20);
            this.tbTenChuCH.Name = "tbTenChuCH";
            this.tbTenChuCH.Size = new System.Drawing.Size(100, 20);
            this.tbTenChuCH.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCapNhat.Location = new System.Drawing.Point(90, 157);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 27);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập Nhật Thông Tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(122, 126);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(53, 16);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbTenShop
            // 
            this.lbTenShop.AutoSize = true;
            this.lbTenShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenShop.Location = new System.Drawing.Point(122, 90);
            this.lbTenShop.Name = "lbTenShop";
            this.lbTenShop.Size = new System.Drawing.Size(70, 16);
            this.lbTenShop.TabIndex = 3;
            this.lbTenShop.Text = "Tên Shop:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(122, 55);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(96, 16);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbTenChuShop
            // 
            this.lbTenChuShop.AutoSize = true;
            this.lbTenChuShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenChuShop.Location = new System.Drawing.Point(122, 20);
            this.lbTenChuShop.Name = "lbTenChuShop";
            this.lbTenChuShop.Size = new System.Drawing.Size(83, 16);
            this.lbTenChuShop.TabIndex = 1;
            this.lbTenChuShop.Text = "Tên Chủ CH:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(373, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 86);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(38, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nông Sản";
            // 
            // ShopFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "ShopFr";
            this.Text = "ShopFr";
            this.Load += new System.EventHandler(this.ShopFr_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenShop;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTenChuShop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTenShop;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbTenChuCH;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnAddAGR;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}