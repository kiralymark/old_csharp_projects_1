namespace SaveFileDialogControl
{
    partial class DialogControlForm
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LblPath = new System.Windows.Forms.Label();
            this.LblOutputFullPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(434, 44);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Mentés";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(43, 46);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(287, 357);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(434, 182);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(53, 13);
            this.LblPath.TabIndex = 2;
            this.LblPath.Text = "Elérési út:";
            // 
            // LblOutputFullPath
            // 
            this.LblOutputFullPath.AutoSize = true;
            this.LblOutputFullPath.Location = new System.Drawing.Point(434, 208);
            this.LblOutputFullPath.Name = "LblOutputFullPath";
            this.LblOutputFullPath.Size = new System.Drawing.Size(13, 13);
            this.LblOutputFullPath.TabIndex = 3;
            this.LblOutputFullPath.Text = "_";
            // 
            // DialogControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOutputFullPath);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.BtnSave);
            this.Name = "DialogControlForm";
            this.Text = "DialogControl";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Label LblOutputFullPath;
    }
}

