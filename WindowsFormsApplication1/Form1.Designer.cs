namespace WindowsFormsApplication1
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
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.btnSegitiga = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(49, 46);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(184, 22);
            this.txtAngka.TabIndex = 0;
            this.txtAngka.Text = " INPUT ANGKA";
            // 
            // btnSegitiga
            // 
            this.btnSegitiga.Location = new System.Drawing.Point(49, 91);
            this.btnSegitiga.Name = "btnSegitiga";
            this.btnSegitiga.Size = new System.Drawing.Size(161, 26);
            this.btnSegitiga.TabIndex = 1;
            this.btnSegitiga.Text = "Generate Segitiga";
            this.btnSegitiga.UseVisualStyleBackColor = true;
            this.btnSegitiga.Click += new System.EventHandler(this.btnSegitiga_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate Bilangan Ganjil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate Bilangan Prima";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(88, 172);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(46, 17);
            this.lblHasil.TabIndex = 4;
            this.lblHasil.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 586);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSegitiga);
            this.Controls.Add(this.txtAngka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.Button btnSegitiga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblHasil;
    }
}

