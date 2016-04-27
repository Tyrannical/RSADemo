namespace RSA_App
{
    partial class PrimaryForm
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
            this.encryptionInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hexValue = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonToHex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionHex = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.decryptedHexBox = new System.Windows.Forms.TextBox();
            this.buttonToString = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptionMessage = new System.Windows.Forms.TextBox();
            this.repeatEncryptedHex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValueD = new System.Windows.Forms.TextBox();
            this.tbValueN = new System.Windows.Forms.TextBox();
            this.tbValueE = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSimpleValues = new System.Windows.Forms.Button();
            this.tbSimpleD = new System.Windows.Forms.TextBox();
            this.tbSimpleN = new System.Windows.Forms.TextBox();
            this.tbSimpleE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExplain = new System.Windows.Forms.Button();
            this.buttonCalculateValues = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptionInput
            // 
            this.encryptionInput.Location = new System.Drawing.Point(15, 35);
            this.encryptionInput.Multiline = true;
            this.encryptionInput.Name = "encryptionInput";
            this.encryptionInput.Size = new System.Drawing.Size(272, 117);
            this.encryptionInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hexValue);
            this.groupBox1.Controls.Add(this.buttonEncrypt);
            this.groupBox1.Controls.Add(this.buttonToHex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.encryptionHex);
            this.groupBox1.Controls.Add(this.encryptionInput);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hex Value";
            // 
            // hexValue
            // 
            this.hexValue.Location = new System.Drawing.Point(15, 175);
            this.hexValue.Multiline = true;
            this.hexValue.Name = "hexValue";
            this.hexValue.Size = new System.Drawing.Size(272, 117);
            this.hexValue.TabIndex = 6;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(316, 371);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(192, 62);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonToHex
            // 
            this.buttonToHex.Location = new System.Drawing.Point(316, 35);
            this.buttonToHex.Name = "buttonToHex";
            this.buttonToHex.Size = new System.Drawing.Size(192, 62);
            this.buttonToHex.TabIndex = 4;
            this.buttonToHex.Text = "Convert To Hex";
            this.buttonToHex.UseVisualStyleBackColor = true;
            this.buttonToHex.Click += new System.EventHandler(this.buttonToHex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted Hex Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // encryptionHex
            // 
            this.encryptionHex.Location = new System.Drawing.Point(15, 316);
            this.encryptionHex.Multiline = true;
            this.encryptionHex.Name = "encryptionHex";
            this.encryptionHex.Size = new System.Drawing.Size(272, 117);
            this.encryptionHex.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.decryptedHexBox);
            this.groupBox2.Controls.Add(this.buttonToString);
            this.groupBox2.Controls.Add(this.buttonDecrypt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.decryptionMessage);
            this.groupBox2.Controls.Add(this.repeatEncryptedHex);
            this.groupBox2.Location = new System.Drawing.Point(576, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 444);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decrypted Hex Value";
            // 
            // decryptedHexBox
            // 
            this.decryptedHexBox.Location = new System.Drawing.Point(15, 175);
            this.decryptedHexBox.Multiline = true;
            this.decryptedHexBox.Name = "decryptedHexBox";
            this.decryptedHexBox.Size = new System.Drawing.Size(272, 117);
            this.decryptedHexBox.TabIndex = 6;
            // 
            // buttonToString
            // 
            this.buttonToString.Location = new System.Drawing.Point(316, 371);
            this.buttonToString.Name = "buttonToString";
            this.buttonToString.Size = new System.Drawing.Size(192, 62);
            this.buttonToString.TabIndex = 5;
            this.buttonToString.Text = "Convert To String";
            this.buttonToString.UseVisualStyleBackColor = true;
            this.buttonToString.Click += new System.EventHandler(this.buttonToString_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(316, 35);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(192, 62);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Decrypted Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Encrypted Hex Value";
            // 
            // decryptionMessage
            // 
            this.decryptionMessage.Location = new System.Drawing.Point(15, 316);
            this.decryptionMessage.Multiline = true;
            this.decryptionMessage.Name = "decryptionMessage";
            this.decryptionMessage.Size = new System.Drawing.Size(272, 117);
            this.decryptionMessage.TabIndex = 1;
            // 
            // repeatEncryptedHex
            // 
            this.repeatEncryptedHex.Location = new System.Drawing.Point(15, 35);
            this.repeatEncryptedHex.Multiline = true;
            this.repeatEncryptedHex.Name = "repeatEncryptedHex";
            this.repeatEncryptedHex.Size = new System.Drawing.Size(272, 117);
            this.repeatEncryptedHex.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbValueD);
            this.groupBox3.Controls.Add(this.tbValueN);
            this.groupBox3.Controls.Add(this.tbValueE);
            this.groupBox3.Location = new System.Drawing.Point(8, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 219);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Values for Calculation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Value: d";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Value: n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Value: e";
            // 
            // tbValueD
            // 
            this.tbValueD.Location = new System.Drawing.Point(82, 152);
            this.tbValueD.Multiline = true;
            this.tbValueD.Name = "tbValueD";
            this.tbValueD.ReadOnly = true;
            this.tbValueD.Size = new System.Drawing.Size(209, 61);
            this.tbValueD.TabIndex = 2;
            // 
            // tbValueN
            // 
            this.tbValueN.Location = new System.Drawing.Point(82, 86);
            this.tbValueN.Multiline = true;
            this.tbValueN.Name = "tbValueN";
            this.tbValueN.ReadOnly = true;
            this.tbValueN.Size = new System.Drawing.Size(209, 61);
            this.tbValueN.TabIndex = 1;
            // 
            // tbValueE
            // 
            this.tbValueE.Location = new System.Drawing.Point(82, 19);
            this.tbValueE.Multiline = true;
            this.tbValueE.Name = "tbValueE";
            this.tbValueE.ReadOnly = true;
            this.tbValueE.Size = new System.Drawing.Size(209, 61);
            this.tbValueE.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSimpleValues);
            this.groupBox4.Controls.Add(this.tbSimpleD);
            this.groupBox4.Controls.Add(this.tbSimpleN);
            this.groupBox4.Controls.Add(this.tbSimpleE);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(313, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 147);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simple Values";
            // 
            // buttonSimpleValues
            // 
            this.buttonSimpleValues.Location = new System.Drawing.Point(19, 102);
            this.buttonSimpleValues.Name = "buttonSimpleValues";
            this.buttonSimpleValues.Size = new System.Drawing.Size(201, 36);
            this.buttonSimpleValues.TabIndex = 10;
            this.buttonSimpleValues.Text = "Set Values";
            this.buttonSimpleValues.UseVisualStyleBackColor = true;
            this.buttonSimpleValues.Click += new System.EventHandler(this.buttonSimpleValues_Click);
            // 
            // tbSimpleD
            // 
            this.tbSimpleD.Location = new System.Drawing.Point(68, 71);
            this.tbSimpleD.Name = "tbSimpleD";
            this.tbSimpleD.Size = new System.Drawing.Size(152, 20);
            this.tbSimpleD.TabIndex = 9;
            // 
            // tbSimpleN
            // 
            this.tbSimpleN.Location = new System.Drawing.Point(68, 45);
            this.tbSimpleN.Name = "tbSimpleN";
            this.tbSimpleN.Size = new System.Drawing.Size(152, 20);
            this.tbSimpleN.TabIndex = 8;
            // 
            // tbSimpleE
            // 
            this.tbSimpleE.Location = new System.Drawing.Point(68, 19);
            this.tbSimpleE.Name = "tbSimpleE";
            this.tbSimpleE.Size = new System.Drawing.Size(152, 20);
            this.tbSimpleE.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Value: d";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Value: n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Value: e";
            // 
            // buttonExplain
            // 
            this.buttonExplain.Location = new System.Drawing.Point(911, 553);
            this.buttonExplain.Name = "buttonExplain";
            this.buttonExplain.Size = new System.Drawing.Size(210, 60);
            this.buttonExplain.TabIndex = 9;
            this.buttonExplain.Text = "Explain RSA Crypto";
            this.buttonExplain.UseVisualStyleBackColor = true;
            this.buttonExplain.Click += new System.EventHandler(this.buttonExplain_Click);
            // 
            // buttonCalculateValues
            // 
            this.buttonCalculateValues.Location = new System.Drawing.Point(911, 622);
            this.buttonCalculateValues.Name = "buttonCalculateValues";
            this.buttonCalculateValues.Size = new System.Drawing.Size(210, 60);
            this.buttonCalculateValues.TabIndex = 10;
            this.buttonCalculateValues.Text = "Calculate Encryption Values";
            this.buttonCalculateValues.UseVisualStyleBackColor = true;
            this.buttonCalculateValues.Click += new System.EventHandler(this.buttonCalculateValues_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(313, 616);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(240, 66);
            this.buttonSync.TabIndex = 11;
            this.buttonSync.Text = "Sync Data";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 694);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.buttonCalculateValues);
            this.Controls.Add(this.buttonExplain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrimaryForm";
            this.Text = "RSA Crypto App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox encryptionInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonToHex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionHex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonToString;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptionMessage;
        private System.Windows.Forms.TextBox repeatEncryptedHex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hexValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox decryptedHexBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSimpleValues;
        private System.Windows.Forms.TextBox tbSimpleD;
        private System.Windows.Forms.TextBox tbSimpleN;
        private System.Windows.Forms.TextBox tbSimpleE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExplain;
        private System.Windows.Forms.Button buttonCalculateValues;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.TextBox tbValueD;
        private System.Windows.Forms.TextBox tbValueN;
        private System.Windows.Forms.TextBox tbValueE;

    }
}

