namespace CheckBoxControl
{
    partial class SeasonForm
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblSeason = new System.Windows.Forms.Label();
            this.CheckBoxFeb = new System.Windows.Forms.CheckBox();
            this.CheckBoxMar = new System.Windows.Forms.CheckBox();
            this.CheckBoxNov = new System.Windows.Forms.CheckBox();
            this.CheckBoxDec = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnExit.Location = new System.Drawing.Point(210, 239);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(177, 49);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Kilépés";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // LblSeason
            // 
            this.LblSeason.AutoSize = true;
            this.LblSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSeason.Location = new System.Drawing.Point(248, 321);
            this.LblSeason.Name = "LblSeason";
            this.LblSeason.Size = new System.Drawing.Size(31, 33);
            this.LblSeason.TabIndex = 1;
            this.LblSeason.Text = "_";
            this.LblSeason.Visible = false;
            // 
            // CheckBoxFeb
            // 
            this.CheckBoxFeb.AutoSize = true;
            this.CheckBoxFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxFeb.Location = new System.Drawing.Point(27, 41);
            this.CheckBoxFeb.Name = "CheckBoxFeb";
            this.CheckBoxFeb.Size = new System.Drawing.Size(136, 37);
            this.CheckBoxFeb.TabIndex = 2;
            this.CheckBoxFeb.Text = "Február";
            this.CheckBoxFeb.UseVisualStyleBackColor = true;
            this.CheckBoxFeb.CheckedChanged += new System.EventHandler(this.CheckBoxFeb_CheckedChanged);
            // 
            // CheckBoxMar
            // 
            this.CheckBoxMar.AutoSize = true;
            this.CheckBoxMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxMar.Location = new System.Drawing.Point(27, 126);
            this.CheckBoxMar.Name = "CheckBoxMar";
            this.CheckBoxMar.Size = new System.Drawing.Size(137, 37);
            this.CheckBoxMar.TabIndex = 3;
            this.CheckBoxMar.Text = "Március";
            this.CheckBoxMar.UseVisualStyleBackColor = true;
            this.CheckBoxMar.CheckedChanged += new System.EventHandler(this.CheckBoxMar_CheckedChanged);
            // 
            // CheckBoxNov
            // 
            this.CheckBoxNov.AutoSize = true;
            this.CheckBoxNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxNov.Location = new System.Drawing.Point(210, 41);
            this.CheckBoxNov.Name = "CheckBoxNov";
            this.CheckBoxNov.Size = new System.Drawing.Size(169, 37);
            this.CheckBoxNov.TabIndex = 4;
            this.CheckBoxNov.Text = "November";
            this.CheckBoxNov.UseVisualStyleBackColor = true;
            this.CheckBoxNov.CheckedChanged += new System.EventHandler(this.CheckBoxNov_CheckedChanged);
            // 
            // CheckBoxDec
            // 
            this.CheckBoxDec.AutoSize = true;
            this.CheckBoxDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxDec.Location = new System.Drawing.Point(210, 126);
            this.CheckBoxDec.Name = "CheckBoxDec";
            this.CheckBoxDec.Size = new System.Drawing.Size(169, 37);
            this.CheckBoxDec.TabIndex = 5;
            this.CheckBoxDec.Text = "December";
            this.CheckBoxDec.UseVisualStyleBackColor = true;
            this.CheckBoxDec.CheckedChanged += new System.EventHandler(this.CheckBoxDec_CheckedChanged);
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBoxDec);
            this.Controls.Add(this.CheckBoxNov);
            this.Controls.Add(this.CheckBoxMar);
            this.Controls.Add(this.CheckBoxFeb);
            this.Controls.Add(this.LblSeason);
            this.Controls.Add(this.BtnExit);
            this.Name = "SeasonForm";
            this.Text = "CheckBoxControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblSeason;
        private System.Windows.Forms.CheckBox CheckBoxFeb;
        private System.Windows.Forms.CheckBox CheckBoxMar;
        private System.Windows.Forms.CheckBox CheckBoxNov;
        private System.Windows.Forms.CheckBox CheckBoxDec;
    }
}

