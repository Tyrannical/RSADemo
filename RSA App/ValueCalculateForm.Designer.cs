namespace RSA_App
{
    partial class ValueCalculateForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPrimeOne = new System.Windows.Forms.TextBox();
            this.textPrimeTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheckPrime = new System.Windows.Forms.Button();
            this.textBoxPrimeRespone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLargePrime = new System.Windows.Forms.Button();
            this.btnMediumPrime = new System.Windows.Forms.Button();
            this.btnSmallPrimes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDValue = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tbCheckE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckE = new System.Windows.Forms.Button();
            this.tbEValue = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbNValue = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSendValues = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSendD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSendE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSendN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(692, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "This form is designed to help you generate the public and private keys for basic " +
    "RSA crypto.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 67);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "The first step is to choose two different and in standard cases large prime numbe" +
    "rs. Enter your two numbers and let the program check if they are prime numbers.";
            // 
            // textPrimeOne
            // 
            this.textPrimeOne.Location = new System.Drawing.Point(292, 19);
            this.textPrimeOne.Name = "textPrimeOne";
            this.textPrimeOne.Size = new System.Drawing.Size(394, 20);
            this.textPrimeOne.TabIndex = 3;
            // 
            // textPrimeTwo
            // 
            this.textPrimeTwo.Location = new System.Drawing.Point(292, 66);
            this.textPrimeTwo.Name = "textPrimeTwo";
            this.textPrimeTwo.Size = new System.Drawing.Size(394, 20);
            this.textPrimeTwo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "#1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "#2";
            // 
            // buttonCheckPrime
            // 
            this.buttonCheckPrime.Location = new System.Drawing.Point(292, 92);
            this.buttonCheckPrime.Name = "buttonCheckPrime";
            this.buttonCheckPrime.Size = new System.Drawing.Size(164, 42);
            this.buttonCheckPrime.TabIndex = 7;
            this.buttonCheckPrime.Text = "Check for Primes";
            this.buttonCheckPrime.UseVisualStyleBackColor = true;
            this.buttonCheckPrime.Click += new System.EventHandler(this.buttonCheckPrime_Click);
            // 
            // textBoxPrimeRespone
            // 
            this.textBoxPrimeRespone.Location = new System.Drawing.Point(462, 92);
            this.textBoxPrimeRespone.Multiline = true;
            this.textBoxPrimeRespone.Name = "textBoxPrimeRespone";
            this.textBoxPrimeRespone.ReadOnly = true;
            this.textBoxPrimeRespone.Size = new System.Drawing.Size(224, 42);
            this.textBoxPrimeRespone.TabIndex = 8;
            this.textBoxPrimeRespone.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLargePrime);
            this.groupBox1.Controls.Add(this.btnMediumPrime);
            this.groupBox1.Controls.Add(this.btnSmallPrimes);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBoxPrimeRespone);
            this.groupBox1.Controls.Add(this.textPrimeOne);
            this.groupBox1.Controls.Add(this.buttonCheckPrime);
            this.groupBox1.Controls.Add(this.textPrimeTwo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prime Values";
            // 
            // btnLargePrime
            // 
            this.btnLargePrime.Location = new System.Drawing.Point(176, 92);
            this.btnLargePrime.Name = "btnLargePrime";
            this.btnLargePrime.Size = new System.Drawing.Size(79, 39);
            this.btnLargePrime.TabIndex = 11;
            this.btnLargePrime.Text = "Large";
            this.btnLargePrime.UseVisualStyleBackColor = true;
            this.btnLargePrime.Click += new System.EventHandler(this.btnLargePrime_Click);
            // 
            // btnMediumPrime
            // 
            this.btnMediumPrime.Location = new System.Drawing.Point(91, 92);
            this.btnMediumPrime.Name = "btnMediumPrime";
            this.btnMediumPrime.Size = new System.Drawing.Size(79, 39);
            this.btnMediumPrime.TabIndex = 10;
            this.btnMediumPrime.Text = "Medium";
            this.btnMediumPrime.UseVisualStyleBackColor = true;
            this.btnMediumPrime.Click += new System.EventHandler(this.btnMediumPrime_Click);
            // 
            // btnSmallPrimes
            // 
            this.btnSmallPrimes.Location = new System.Drawing.Point(6, 92);
            this.btnSmallPrimes.Name = "btnSmallPrimes";
            this.btnSmallPrimes.Size = new System.Drawing.Size(79, 39);
            this.btnSmallPrimes.TabIndex = 9;
            this.btnSmallPrimes.Text = "Small";
            this.btnSmallPrimes.UseVisualStyleBackColor = true;
            this.btnSmallPrimes.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDValue);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.tbCheckE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonCheckE);
            this.groupBox2.Controls.Add(this.tbEValue);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.tbNValue);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 315);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculations";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RSA_App.Properties.Resources._0f177e14a52de7efb3b8a1fc3e9cea35;
            this.pictureBox2.Location = new System.Drawing.Point(428, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 26);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "d = ";
            // 
            // tbDValue
            // 
            this.tbDValue.Location = new System.Drawing.Point(462, 261);
            this.tbDValue.Multiline = true;
            this.tbDValue.Name = "tbDValue";
            this.tbDValue.Size = new System.Drawing.Size(216, 28);
            this.tbDValue.TabIndex = 21;
            this.tbDValue.TabStop = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(428, 170);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(250, 53);
            this.textBox12.TabIndex = 20;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "5: Compute d to satisfy the congruence relation ";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCheckE
            // 
            this.tbCheckE.Location = new System.Drawing.Point(102, 263);
            this.tbCheckE.Multiline = true;
            this.tbCheckE.Name = "tbCheckE";
            this.tbCheckE.ReadOnly = true;
            this.tbCheckE.Size = new System.Drawing.Size(184, 42);
            this.tbCheckE.TabIndex = 10;
            this.tbCheckE.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "e = ";
            // 
            // buttonCheckE
            // 
            this.buttonCheckE.Location = new System.Drawing.Point(6, 263);
            this.buttonCheckE.Name = "buttonCheckE";
            this.buttonCheckE.Size = new System.Drawing.Size(90, 42);
            this.buttonCheckE.TabIndex = 9;
            this.buttonCheckE.Text = "Check e and d";
            this.buttonCheckE.UseVisualStyleBackColor = true;
            this.buttonCheckE.Click += new System.EventHandler(this.buttonCheckE_Click);
            // 
            // tbEValue
            // 
            this.tbEValue.Location = new System.Drawing.Point(50, 229);
            this.tbEValue.Multiline = true;
            this.tbEValue.Name = "tbEValue";
            this.tbEValue.Size = new System.Drawing.Size(236, 28);
            this.tbEValue.TabIndex = 18;
            this.tbEValue.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 170);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(280, 53);
            this.textBox8.TabIndex = 11;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "4: Choose an integer e such that 1 < e < totient, and e is coprime to the totient" +
    ".";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Totient = ";
            // 
            // tbTValue
            // 
            this.tbTValue.Location = new System.Drawing.Point(486, 105);
            this.tbTValue.Multiline = true;
            this.tbTValue.Name = "tbTValue";
            this.tbTValue.ReadOnly = true;
            this.tbTValue.Size = new System.Drawing.Size(192, 28);
            this.tbTValue.TabIndex = 16;
            this.tbTValue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "n = ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSA_App.Properties.Resources._4a9feeb8111c8b7f10cddc3bbb8dc0c9;
            this.pictureBox1.Location = new System.Drawing.Point(428, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 37);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(428, 19);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(250, 37);
            this.textBox5.TabIndex = 12;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "3: Calculate the totient";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNValue
            // 
            this.tbNValue.Location = new System.Drawing.Point(50, 71);
            this.tbNValue.Multiline = true;
            this.tbNValue.Name = "tbNValue";
            this.tbNValue.ReadOnly = true;
            this.tbNValue.Size = new System.Drawing.Size(236, 28);
            this.tbNValue.TabIndex = 14;
            this.tbNValue.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(280, 37);
            this.textBox4.TabIndex = 11;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "2: Calculate n=pq; p and q being the above primes.";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSendValues);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbSendD);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbSendE);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbSendN);
            this.groupBox3.Location = new System.Drawing.Point(12, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 111);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Values";
            // 
            // buttonSendValues
            // 
            this.buttonSendValues.Location = new System.Drawing.Point(14, 65);
            this.buttonSendValues.Name = "buttonSendValues";
            this.buttonSendValues.Size = new System.Drawing.Size(664, 40);
            this.buttonSendValues.TabIndex = 22;
            this.buttonSendValues.Text = "Send Values to Main Form";
            this.buttonSendValues.UseVisualStyleBackColor = true;
            this.buttonSendValues.Click += new System.EventHandler(this.buttonSendValues_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "d = ";
            // 
            // tbSendD
            // 
            this.tbSendD.Location = new System.Drawing.Point(500, 19);
            this.tbSendD.Multiline = true;
            this.tbSendD.Name = "tbSendD";
            this.tbSendD.ReadOnly = true;
            this.tbSendD.Size = new System.Drawing.Size(180, 28);
            this.tbSendD.TabIndex = 20;
            this.tbSendD.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "e = ";
            // 
            // tbSendE
            // 
            this.tbSendE.Location = new System.Drawing.Point(267, 19);
            this.tbSendE.Multiline = true;
            this.tbSendE.Name = "tbSendE";
            this.tbSendE.ReadOnly = true;
            this.tbSendE.Size = new System.Drawing.Size(180, 28);
            this.tbSendE.TabIndex = 18;
            this.tbSendE.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "n = ";
            // 
            // tbSendN
            // 
            this.tbSendN.Location = new System.Drawing.Point(38, 19);
            this.tbSendN.Multiline = true;
            this.tbSendN.Name = "tbSendN";
            this.tbSendN.ReadOnly = true;
            this.tbSendN.Size = new System.Drawing.Size(180, 28);
            this.tbSendN.TabIndex = 16;
            this.tbSendN.TabStop = false;
            // 
            // ValueCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ValueCalculateForm";
            this.Text = "ValueCalculateForm";
            this.Load += new System.EventHandler(this.ValueCalculateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPrimeOne;
        private System.Windows.Forms.TextBox textPrimeTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheckPrime;
        private System.Windows.Forms.TextBox textBoxPrimeRespone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDValue;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox tbCheckE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckE;
        private System.Windows.Forms.TextBox tbEValue;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSendValues;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSendD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSendE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSendN;
        private System.Windows.Forms.Button btnSmallPrimes;
        private System.Windows.Forms.Button btnLargePrime;
        private System.Windows.Forms.Button btnMediumPrime;

    }
}