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
            this.tsNongSan = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // tsNongSan
            // 
            this.tsNongSan.Location = new System.Drawing.Point(0, 0);
            this.tsNongSan.Name = "tsNongSan";
            this.tsNongSan.Size = new System.Drawing.Size(936, 25);
            this.tsNongSan.TabIndex = 0;
            this.tsNongSan.Text = "toolStrip1";
            // 
            // frNongSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.tsNongSan);
            this.Name = "frNongSan";
            this.Text = "frNongSan";
            this.Load += new System.EventHandler(this.frNongSan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNongSan;
    }
}