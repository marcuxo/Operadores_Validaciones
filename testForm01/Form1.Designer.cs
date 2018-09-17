namespace testForm01
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
            this.saludar = new System.Windows.Forms.Button();
            this.tx01 = new System.Windows.Forms.Label();
            this.text01 = new System.Windows.Forms.TextBox();
            this.txOP01 = new System.Windows.Forms.TextBox();
            this.txOP2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RESPTA = new System.Windows.Forms.Label();
            this.OPERADR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saludar
            // 
            this.saludar.Location = new System.Drawing.Point(87, 85);
            this.saludar.Name = "saludar";
            this.saludar.Size = new System.Drawing.Size(100, 23);
            this.saludar.TabIndex = 0;
            this.saludar.Text = "Saludo";
            this.saludar.UseVisualStyleBackColor = true;
            this.saludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx01
            // 
            this.tx01.AutoSize = true;
            this.tx01.Location = new System.Drawing.Point(26, 37);
            this.tx01.Name = "tx01";
            this.tx01.Size = new System.Drawing.Size(69, 13);
            this.tx01.TabIndex = 1;
            this.tx01.Text = "Loading. .. . .";
            // 
            // text01
            // 
            this.text01.Location = new System.Drawing.Point(87, 59);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(100, 20);
            this.text01.TabIndex = 2;
            this.text01.Tag = "";
            this.text01.Text = "\r\n";
            this.text01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text01_KeyPress);
            // 
            // txOP01
            // 
            this.txOP01.Location = new System.Drawing.Point(29, 164);
            this.txOP01.Name = "txOP01";
            this.txOP01.Size = new System.Drawing.Size(61, 20);
            this.txOP01.TabIndex = 3;
            this.txOP01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txOP01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txOP01_KeyPress);
            // 
            // txOP2
            // 
            this.txOP2.Location = new System.Drawing.Point(189, 164);
            this.txOP2.Name = "txOP2";
            this.txOP2.Size = new System.Drawing.Size(61, 20);
            this.txOP2.TabIndex = 4;
            this.txOP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txOP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txOP01_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RESPTA
            // 
            this.RESPTA.AutoSize = true;
            this.RESPTA.Location = new System.Drawing.Point(176, 214);
            this.RESPTA.Name = "RESPTA";
            this.RESPTA.Size = new System.Drawing.Size(0, 13);
            this.RESPTA.TabIndex = 6;
            // 
            // OPERADR
            // 
            this.OPERADR.Location = new System.Drawing.Point(127, 164);
            this.OPERADR.Name = "OPERADR";
            this.OPERADR.Size = new System.Drawing.Size(23, 20);
            this.OPERADR.TabIndex = 7;
            this.OPERADR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Validaciones de letras y numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Operador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "................................................................................." +
    ".....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OPERADR);
            this.Controls.Add(this.RESPTA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txOP2);
            this.Controls.Add(this.txOP01);
            this.Controls.Add(this.text01);
            this.Controls.Add(this.tx01);
            this.Controls.Add(this.saludar);
            this.Name = "Form1";
            this.Text = "Validaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saludar;
        private System.Windows.Forms.Label tx01;
        private System.Windows.Forms.TextBox text01;
        private System.Windows.Forms.TextBox txOP01;
        private System.Windows.Forms.TextBox txOP2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RESPTA;
        private System.Windows.Forms.TextBox OPERADR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

