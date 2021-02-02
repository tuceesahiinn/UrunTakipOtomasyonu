namespace _3MOtomotivSatisOtomasyonu.Note
{
    partial class frmNoteDetail
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
            this.rchTxtNoteDeatil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtNoteDeatil
            // 
            this.rchTxtNoteDeatil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rchTxtNoteDeatil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTxtNoteDeatil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxtNoteDeatil.Location = new System.Drawing.Point(0, 0);
            this.rchTxtNoteDeatil.Name = "rchTxtNoteDeatil";
            this.rchTxtNoteDeatil.ReadOnly = true;
            this.rchTxtNoteDeatil.Size = new System.Drawing.Size(982, 453);
            this.rchTxtNoteDeatil.TabIndex = 0;
            this.rchTxtNoteDeatil.Text = "";
            // 
            // frmNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.rchTxtNoteDeatil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNoteDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT DETAYLARI";
            this.Load += new System.EventHandler(this.frmNoteDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtNoteDeatil;
    }
}