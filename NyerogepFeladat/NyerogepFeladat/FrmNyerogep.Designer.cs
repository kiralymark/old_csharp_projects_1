namespace NyerogepFeladat
{
    partial class FrmNyerogep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNyerogep));
            this.LblSzam1 = new System.Windows.Forms.Label();
            this.LblSzam2 = new System.Windows.Forms.Label();
            this.LblSzam3 = new System.Windows.Forms.Label();
            this.BtnPress = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblEgyenleg = new System.Windows.Forms.Label();
            this.LblEgyenlegValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSzam1
            // 
            this.LblSzam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSzam1.Location = new System.Drawing.Point(71, 110);
            this.LblSzam1.Name = "LblSzam1";
            this.LblSzam1.Size = new System.Drawing.Size(42, 43);
            this.LblSzam1.TabIndex = 0;
            this.LblSzam1.Text = "X";
            this.LblSzam1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSzam2
            // 
            this.LblSzam2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSzam2.Location = new System.Drawing.Point(167, 110);
            this.LblSzam2.Name = "LblSzam2";
            this.LblSzam2.Size = new System.Drawing.Size(42, 43);
            this.LblSzam2.TabIndex = 1;
            this.LblSzam2.Text = "X";
            this.LblSzam2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSzam3
            // 
            this.LblSzam3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSzam3.Location = new System.Drawing.Point(277, 110);
            this.LblSzam3.Name = "LblSzam3";
            this.LblSzam3.Size = new System.Drawing.Size(42, 43);
            this.LblSzam3.TabIndex = 2;
            this.LblSzam3.Text = "X";
            this.LblSzam3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnPress
            // 
            this.BtnPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPress.Location = new System.Drawing.Point(115, 196);
            this.BtnPress.Name = "BtnPress";
            this.BtnPress.Size = new System.Drawing.Size(162, 39);
            this.BtnPress.TabIndex = 3;
            this.BtnPress.Text = ":PRESS:";
            this.BtnPress.UseVisualStyleBackColor = true;
            this.BtnPress.Click += new System.EventHandler(this.BtnPress_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblStatus.Location = new System.Drawing.Point(163, 30);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(69, 20);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status:_";
            // 
            // LblEgyenleg
            // 
            this.LblEgyenleg.AutoSize = true;
            this.LblEgyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEgyenleg.Location = new System.Drawing.Point(111, 270);
            this.LblEgyenleg.Name = "LblEgyenleg";
            this.LblEgyenleg.Size = new System.Drawing.Size(88, 20);
            this.LblEgyenleg.TabIndex = 5;
            this.LblEgyenleg.Text = "Egyenleg =";
            // 
            // LblEgyenlegValue
            // 
            this.LblEgyenlegValue.AutoSize = true;
            this.LblEgyenlegValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEgyenlegValue.Location = new System.Drawing.Point(223, 270);
            this.LblEgyenlegValue.Name = "LblEgyenlegValue";
            this.LblEgyenlegValue.Size = new System.Drawing.Size(45, 20);
            this.LblEgyenlegValue.TabIndex = 6;
            this.LblEgyenlegValue.Text = "_100";
            // 
            // FrmNyerogep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.LblEgyenlegValue);
            this.Controls.Add(this.LblEgyenleg);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnPress);
            this.Controls.Add(this.LblSzam3);
            this.Controls.Add(this.LblSzam2);
            this.Controls.Add(this.LblSzam1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNyerogep";
            this.Text = "Nyerőgép";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSzam1;
        private System.Windows.Forms.Label LblSzam2;
        private System.Windows.Forms.Label LblSzam3;
        private System.Windows.Forms.Button BtnPress;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblEgyenleg;
        private System.Windows.Forms.Label LblEgyenlegValue;
    }
}