namespace QBNS
{
    partial class frNongSan
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
            this.tsNongSan = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.btnDelAGR = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsNongSan
            // 
            this.tsNongSan.Location = new System.Drawing.Point(0, 0);
            this.tsNongSan.Name = "tsNongSan";
            this.tsNongSan.Size = new System.Drawing.Size(1370, 25);
            this.tsNongSan.TabIndex = 0;
            this.tsNongSan.Text = "toolStrip1";
            this.tsNongSan.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsNongSan_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtGridView.Location = new System.Drawing.Point(0, 144);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.Size = new System.Drawing.Size(874, 291);
            this.dtGridView.TabIndex = 2;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            this.dtGridView.SelectionChanged += new System.EventHandler(this.dtGridView_SelectionChanged);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkBlue;
            this.pnTitle.Controls.Add(this.label3);
            this.pnTitle.Controls.Add(this.tbMaCH);
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnTitle.Location = new System.Drawing.Point(0, 91);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(874, 53);
            this.pnTitle.TabIndex = 3;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Cửa Hàng:";
            // 
            // tbMaCH
            // 
            this.tbMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaCH.Location = new System.Drawing.Point(768, 11);
            this.tbMaCH.Name = "tbMaCH";
            this.tbMaCH.Size = new System.Drawing.Size(103, 29);
            this.tbMaCH.TabIndex = 7;
            this.tbMaCH.TextChanged += new System.EventHandler(this.tbMaCH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nông Sản ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbDelete);
            this.panel2.Controls.Add(this.btnDelAGR);
            this.panel2.Controls.Add(this.btnUpDate);
            this.panel2.Location = new System.Drawing.Point(974, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 341);
            this.panel2.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(8, 315);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Cập Nhật";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Nông Sản";
            // 
            // tbDelete
            // 
            this.tbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDelete.Location = new System.Drawing.Point(174, 13);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(103, 29);
            this.tbDelete.TabIndex = 3;
            this.tbDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelAGR
            // 
            this.btnDelAGR.BackColor = System.Drawing.Color.Yellow;
            this.btnDelAGR.Location = new System.Drawing.Point(44, 204);
            this.btnDelAGR.Name = "btnDelAGR";
            this.btnDelAGR.Size = new System.Drawing.Size(134, 41);
            this.btnDelAGR.TabIndex = 1;
            this.btnDelAGR.Text = "Xóa";
            this.btnDelAGR.UseVisualStyleBackColor = false;
            this.btnDelAGR.Click += new System.EventHandler(this.btnDelAGR_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(195, 204);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(134, 42);
            this.btnUpDate.TabIndex = 0;
            this.btnUpDate.Text = "Sửa";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // frNongSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.tsNongSan);
            this.Name = "frNongSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frNongSan";
            this.Load += new System.EventHandler(this.frNongSan_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.frNongSan_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNongSan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Button btnDelAGR;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaCH;
    }
}