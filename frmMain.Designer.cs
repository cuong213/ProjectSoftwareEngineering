
namespace CNPM
{
    partial class frmMain
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
            this.btnQuanLyPN = new System.Windows.Forms.Button();
            this.btnQuanLyPX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyPN
            // 
            this.btnQuanLyPN.Location = new System.Drawing.Point(201, 40);
            this.btnQuanLyPN.Name = "btnQuanLyPN";
            this.btnQuanLyPN.Size = new System.Drawing.Size(106, 49);
            this.btnQuanLyPN.TabIndex = 0;
            this.btnQuanLyPN.Text = "Quản Lý Phiếu Nhập";
            this.btnQuanLyPN.UseVisualStyleBackColor = true;
            this.btnQuanLyPN.Click += new System.EventHandler(this.btnQuanLyPN_Click);
            // 
            // btnQuanLyPX
            // 
            this.btnQuanLyPX.Location = new System.Drawing.Point(201, 125);
            this.btnQuanLyPX.Name = "btnQuanLyPX";
            this.btnQuanLyPX.Size = new System.Drawing.Size(106, 42);
            this.btnQuanLyPX.TabIndex = 1;
            this.btnQuanLyPX.Text = "Quản Lý Phiếu Xuất";
            this.btnQuanLyPX.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 248);
            this.Controls.Add(this.btnQuanLyPX);
            this.Controls.Add(this.btnQuanLyPN);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyPN;
        private System.Windows.Forms.Button btnQuanLyPX;
    }
}