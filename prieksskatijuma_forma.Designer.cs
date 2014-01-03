namespace puzlicis
{
    partial class prieksskatijuma_forma
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
            this.SuspendLayout();
            // 
            // prieksskatijuma_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 428);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "prieksskatijuma_forma";
            this.ShowInTaskbar = false;
            this.Text = "Attēla priekšskatījums";
            this.Click += new System.EventHandler(this.prieksskatijuma_forma_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.prieksskatijuma_forma_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prieksskatijuma_forma_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}