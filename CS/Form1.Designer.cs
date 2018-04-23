namespace WaitForm_SetDescription {
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.btnShowWaitForm = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnShowWaitForm
            // 
            this.btnShowWaitForm.Location = new System.Drawing.Point(12, 12);
            this.btnShowWaitForm.Name = "btnShowWaitForm";
            this.btnShowWaitForm.Size = new System.Drawing.Size(128, 31);
            this.btnShowWaitForm.TabIndex = 0;
            this.btnShowWaitForm.Text = "Show Wait Form";
            this.btnShowWaitForm.Click += new System.EventHandler(this.btnShowWaitForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 463);
            this.Controls.Add(this.btnShowWaitForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShowWaitForm;
    }
}

