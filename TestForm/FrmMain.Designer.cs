namespace TestForm
{
    partial class FrmMain
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
            this.ssControl1 = new SpreadSheetInspector.SSControl();
            this.SuspendLayout();
            // 
            // ssControl1
            // 
            this.ssControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssControl1.Location = new System.Drawing.Point(0, 0);
            this.ssControl1.Name = "ssControl1";
            this.ssControl1.Size = new System.Drawing.Size(577, 253);
            this.ssControl1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 253);
            this.Controls.Add(this.ssControl1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadSheetInspector.SSControl ssControl1;
    }
}

