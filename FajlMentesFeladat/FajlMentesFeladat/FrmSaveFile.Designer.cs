namespace FajlMentesFeladat
{
    partial class FrmSaveFile
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
            this.BtnMentes = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LblSaveFullPath = new System.Windows.Forms.Label();
            this.LblPath = new System.Windows.Forms.Label();
            this.TxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnMentes
            // 
            this.BtnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMentes.Location = new System.Drawing.Point(350, 70);
            this.BtnMentes.Name = "BtnMentes";
            this.BtnMentes.Size = new System.Drawing.Size(133, 50);
            this.BtnMentes.TabIndex = 1;
            this.BtnMentes.Text = "Save";
            this.BtnMentes.UseVisualStyleBackColor = true;
            this.BtnMentes.Click += new System.EventHandler(this.BtnMentes_Click);
            // 
            // LblSaveFullPath
            // 
            this.LblSaveFullPath.AutoSize = true;
            this.LblSaveFullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSaveFullPath.Location = new System.Drawing.Point(141, 261);
            this.LblSaveFullPath.Name = "LblSaveFullPath";
            this.LblSaveFullPath.Size = new System.Drawing.Size(18, 20);
            this.LblSaveFullPath.TabIndex = 2;
            this.LblSaveFullPath.Text = "_";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPath.Location = new System.Drawing.Point(49, 261);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(86, 20);
            this.LblPath.TabIndex = 3;
            this.LblPath.Text = "Save Path:";
            // 
            // TxtBox
            // 
            this.TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtBox.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtBox.Location = new System.Drawing.Point(53, 70);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(256, 117);
            this.TxtBox.TabIndex = 5;
            this.TxtBox.Text = "RichTextBox Text.";
            // 
            // FrmSaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.LblSaveFullPath);
            this.Controls.Add(this.BtnMentes);
            this.Name = "FrmSaveFile";
            this.Text = "Save File";
            this.Load += new System.EventHandler(this.FrmSaveFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMentes;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label LblSaveFullPath;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.RichTextBox TxtBox;
    }
}

