namespace QBNS
{
    partial class AgrItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.agrPIC = new System.Windows.Forms.PictureBox();
            this.lbNameAG = new System.Windows.Forms.Label();
            this.pmDES = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbDVT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agrPIC)).BeginInit();
            this.pmDES.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agrPIC
            // 
            this.agrPIC.Location = new System.Drawing.Point(4, 4);
            this.agrPIC.Name = "agrPIC";
            this.agrPIC.Size = new System.Drawing.Size(191, 156);
            this.agrPIC.TabIndex = 0;
            this.agrPIC.TabStop = false;
            // 
            // lbNameAG
            // 
            this.lbNameAG.AutoSize = true;
            this.lbNameAG.BackColor = System.Drawing.Color.White;
            this.lbNameAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAG.Location = new System.Drawing.Point(3, 0);
            this.lbNameAG.Name = "lbNameAG";
            this.lbNameAG.Size = new System.Drawing.Size(134, 24);
            this.lbNameAG.TabIndex = 1;
            this.lbNameAG.Text = "Tên Nông Sản";
            this.lbNameAG.Click += new System.EventHandler(this.lbNameAG_Click);
            // 
            // pmDES
            // 
            this.pmDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pmDES.Controls.Add(this.panel1);
            this.pmDES.Location = new System.Drawing.Point(231, 4);
            this.pmDES.Name = "pmDES";
            this.pmDES.Size = new System.Drawing.Size(448, 178);
            this.pmDES.TabIndex = 2;
            this.pmDES.Paint += new System.Windows.Forms.PaintEventHandler(this.pmDES_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDVT);
            this.panel1.Controls.Add(this.lbDonGia);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.richTB);
            this.panel1.Controls.Add(this.lbNameAG);
            this.panel1.Location = new System.Drawing.Point(20, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 172);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTB
            // 
            this.richTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTB.Location = new System.Drawing.Point(7, 27);
            this.richTB.Name = "richTB";
            this.richTB.Size = new System.Drawing.Size(282, 64);
            this.richTB.TabIndex = 4;
            this.richTB.Text = "";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(15, 106);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(82, 20);
            this.lbSoLuong.TabIndex = 5;
            this.lbSoLuong.Text = "Số Lượng:";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(15, 133);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(72, 20);
            this.lbDonGia.TabIndex = 6;
            this.lbDonGia.Text = "Đơn Giá:";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(151, 106);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(95, 20);
            this.lbDVT.TabIndex = 7;
            this.lbDVT.Text = "Đơn Vị Tính:";
            // 
            // AgrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pmDES);
            this.Controls.Add(this.agrPIC);
            this.Name = "AgrItem";
            this.Size = new System.Drawing.Size(679, 182);
            this.Load += new System.EventHandler(this.AgrItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agrPIC)).EndInit();
            this.pmDES.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox agrPIC;
        private System.Windows.Forms.Label lbNameAG;
        private System.Windows.Forms.Panel pmDES;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTB;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
