namespace checkBox2
{
    partial class Form1
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
            this.cbRucak = new System.Windows.Forms.CheckBox();
            this.cbDorucak = new System.Windows.Forms.CheckBox();
            this.cbVecera = new System.Windows.Forms.CheckBox();
            this.cbSakriji = new System.Windows.Forms.CheckBox();
            this.btPosalji = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbRucak
            // 
            this.cbRucak.AutoSize = true;
            this.cbRucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRucak.Location = new System.Drawing.Point(121, 151);
            this.cbRucak.Name = "cbRucak";
            this.cbRucak.Size = new System.Drawing.Size(92, 29);
            this.cbRucak.TabIndex = 0;
            this.cbRucak.Text = "Rucak";
            this.cbRucak.UseVisualStyleBackColor = true;
            // 
            // cbDorucak
            // 
            this.cbDorucak.AutoSize = true;
            this.cbDorucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDorucak.Location = new System.Drawing.Point(121, 104);
            this.cbDorucak.Name = "cbDorucak";
            this.cbDorucak.Size = new System.Drawing.Size(111, 29);
            this.cbDorucak.TabIndex = 1;
            this.cbDorucak.Text = "Dorucak";
            this.cbDorucak.UseVisualStyleBackColor = true;
            this.cbDorucak.CheckedChanged += new System.EventHandler(this.cbDorucak_CheckedChanged);
            // 
            // cbVecera
            // 
            this.cbVecera.AutoSize = true;
            this.cbVecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVecera.Location = new System.Drawing.Point(121, 200);
            this.cbVecera.Name = "cbVecera";
            this.cbVecera.Size = new System.Drawing.Size(99, 29);
            this.cbVecera.TabIndex = 2;
            this.cbVecera.Text = "Vecera";
            this.cbVecera.UseVisualStyleBackColor = true;
            // 
            // cbSakriji
            // 
            this.cbSakriji.AutoSize = true;
            this.cbSakriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSakriji.Location = new System.Drawing.Point(277, 252);
            this.cbSakriji.Name = "cbSakriji";
            this.cbSakriji.Size = new System.Drawing.Size(90, 29);
            this.cbSakriji.TabIndex = 3;
            this.cbSakriji.Text = "Sakriji";
            this.cbSakriji.UseVisualStyleBackColor = true;
            this.cbSakriji.CheckedChanged += new System.EventHandler(this.cbSakriji_CheckedChanged);
            // 
            // btPosalji
            // 
            this.btPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosalji.Location = new System.Drawing.Point(121, 252);
            this.btPosalji.Name = "btPosalji";
            this.btPosalji.Size = new System.Drawing.Size(102, 48);
            this.btPosalji.TabIndex = 4;
            this.btPosalji.Text = "Posalji";
            this.btPosalji.UseVisualStyleBackColor = true;
            this.btPosalji.Click += new System.EventHandler(this.btPosalji_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(251, 92);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(178, 154);
            this.tb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 576);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btPosalji);
            this.Controls.Add(this.cbSakriji);
            this.Controls.Add(this.cbVecera);
            this.Controls.Add(this.cbDorucak);
            this.Controls.Add(this.cbRucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRucak;
        private System.Windows.Forms.CheckBox cbDorucak;
        private System.Windows.Forms.CheckBox cbVecera;
        private System.Windows.Forms.CheckBox cbSakriji;
        private System.Windows.Forms.Button btPosalji;
        private System.Windows.Forms.TextBox tb1;
    }
}

