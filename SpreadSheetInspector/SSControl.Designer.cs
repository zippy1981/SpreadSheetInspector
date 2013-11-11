namespace SpreadSheetInspector
{
    partial class SSControl
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
            this.cmbWorkSheets = new System.Windows.Forms.ComboBox();
            this.gridWorkSheet = new SourceGrid.DataGrid();
            this.SuspendLayout();
            // 
            // cmbWorkSheets
            // 
            this.cmbWorkSheets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWorkSheets.FormattingEnabled = true;
            this.cmbWorkSheets.Location = new System.Drawing.Point(3, 3);
            this.cmbWorkSheets.Name = "cmbWorkSheets";
            this.cmbWorkSheets.Size = new System.Drawing.Size(394, 24);
            this.cmbWorkSheets.TabIndex = 1;
            this.cmbWorkSheets.SelectedIndexChanged += new System.EventHandler(this.cmbWorkSheets_SelectedIndexChanged);
            // 
            // gridWorkSheet
            // 
            this.gridWorkSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWorkSheet.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.gridWorkSheet.EnableSort = false;
            this.gridWorkSheet.FixedRows = 1;
            this.gridWorkSheet.Location = new System.Drawing.Point(3, 33);
            this.gridWorkSheet.Name = "gridWorkSheet";
            this.gridWorkSheet.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridWorkSheet.Size = new System.Drawing.Size(394, 214);
            this.gridWorkSheet.TabIndex = 2;
            this.gridWorkSheet.TabStop = true;
            this.gridWorkSheet.ToolTipText = "";
            // 
            // SSControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridWorkSheet);
            this.Controls.Add(this.cmbWorkSheets);
            this.Name = "SSControl";
            this.Size = new System.Drawing.Size(400, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorkSheets;
        private SourceGrid.DataGrid gridWorkSheet;
    }
}
