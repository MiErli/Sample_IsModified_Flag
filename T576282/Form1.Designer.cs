namespace T576282 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnShowDialog = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlResult = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowDialog.Location = new System.Drawing.Point(37, 12);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 0;
            this.btnShowDialog.Text = "Show a dialog";
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "DialogResult:";
            // 
            // labelControlResult
            // 
            this.labelControlResult.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlResult.Appearance.Options.UseFont = true;
            this.labelControlResult.Location = new System.Drawing.Point(106, 52);
            this.labelControlResult.Name = "labelControlResult";
            this.labelControlResult.Size = new System.Drawing.Size(5, 13);
            this.labelControlResult.TabIndex = 2;
            this.labelControlResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 150);
            this.Controls.Add(this.labelControlResult);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnShowDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShowDialog;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlResult;
    }
}

