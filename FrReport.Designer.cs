namespace QBNS
{
    partial class FrReport
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.agrREPORT2 = new QBNS.agrREPORT();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(951, 450);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // cryReportViewer
            // 
            this.cryReportViewer.ActiveViewIndex = 0;
            this.cryReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryReportViewer.Location = new System.Drawing.Point(0, 0);
            this.cryReportViewer.Name = "cryReportViewer";
            this.cryReportViewer.ReportSource = this.agrREPORT2;
            this.cryReportViewer.Size = new System.Drawing.Size(951, 450);
            this.cryReportViewer.TabIndex = 2;
            // 
            // FrReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.cryReportViewer);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "FrReport";
            this.Text = "FrReport";
            this.Load += new System.EventHandler(this.FrReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryReportViewer;
        private agrREPORT agrREPORT2;
    }
}