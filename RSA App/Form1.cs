using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Globalization;

namespace RSA_App
{
    public partial class PrimaryForm : Form
    {
        //globals
        string initialMessage, finalMessage, encryptedHex, decryptedHex, hexValueS;
        BigInteger[] encryptedArray;
        BigInteger valueE, valueN, valueD;
        

        public PrimaryForm()
        {
            InitializeComponent();
        }

        
        //converts a string to a hex string
        public static string fToHexString(string str)
        {
            byte[] ba = Encoding.Default.GetBytes(str);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");

            return hexString.ToString();
        }

        //converts a hex string to a normal string
        public static string HexStringToString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }
            var sb = new StringBuilder();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        //ignore
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //converts message to hex
        private void buttonToHex_Click(object sender, EventArgs e)
        {
            initialMessage = encryptionInput.Text;

            string hexString = fToHexString(initialMessage);
            hexValueS = hexString;

            hexValue.Text = hexString;
        }

        //encrypts hex message
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            valueE = BigInteger.Parse(tbValueE.Text);
            valueN = BigInteger.Parse(tbValueN.Text);

            char[] initialCArray = hexValueS.ToCharArray();
            BigInteger[] n = new BigInteger[initialCArray.Length];
            BigInteger[] q = new BigInteger[initialCArray.Length];
            string myHex = "";

            for (int i = 0; i < initialCArray.Length; i++)
            {
                n[i] = BigInteger.Parse(initialCArray[i].ToString(), NumberStyles.HexNumber);
            }

            System.Diagnostics.Debug.WriteLine("");
            for (int i = 0; i < initialCArray.Length; i++)
            {
                q[i] = encryptData(n[i], valueE, valueN);
                System.Diagnostics.Debug.Write(n[i]);
            }

            for (int i = 0; i < initialCArray.Length; i++)
            {
                myHex = myHex + q[i].ToString("X");
            }
            encryptedHex = myHex;

            encryptionHex.Text = myHex;
            repeatEncryptedHex.Text = myHex;
            encryptedArray = q;
        }

        //decrypts hex message
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            valueD = BigInteger.Parse(tbValueD.Text);
            valueN = BigInteger.Parse(tbValueN.Text);
            char[] initialCArray = encryptedHex.ToCharArray();
            BigInteger[] n = encryptedArray;
            BigInteger[] finalArray = new BigInteger[encryptedArray.Length]; ;
            string myHex = "";

            System.Diagnostics.Debug.WriteLine("");
            for (int i = 0; i < encryptedArray.Length; i++)
            {
                finalArray[i] = decryptValue(n[i], valueD, valueN);
            }
            
            for (int i = 0; i < encryptedArray.Length; i++)
            {
                myHex = myHex + finalArray[i].ToString("X");
            }
            decryptedHex = myHex;

            decryptedHexBox.Text = myHex;
        }

        //converts decrypted hex message to string
        private void buttonToString_Click(object sender, EventArgs e)
        {
            finalMessage = HexStringToString(decryptedHex);
            decryptionMessage.Text = finalMessage;
        }

        //encryption funciton
        private BigInteger encryptData(BigInteger a, BigInteger e, BigInteger n)
        {
            BigInteger encryptedValue = a;
            encryptedValue = BigInteger.Pow(encryptedValue, (int)e) % n;

            return encryptedValue;
        }

        //decryption function
        private BigInteger decryptValue(BigInteger a, BigInteger d, BigInteger n)
        {
            BigInteger decryptedValue = a;
            decryptedValue = BigInteger.Pow(decryptedValue, (int)d) % n;

            return decryptedValue;
        }

        //sets encryption/decryption values
        private void buttonSimpleValues_Click(object sender, EventArgs e)
        {
            tbValueD.Text = tbSimpleD.Text;
            tbValueE.Text = tbSimpleE.Text;
            tbValueN.Text = tbSimpleN.Text;
        }

        //opens form to explain crypto
        private void buttonExplain_Click(object sender, EventArgs e)
        {
            CryptoExplainForm frmExplain = new CryptoExplainForm();
            frmExplain.Show();
        }

        //opens form to help calculate crypto
        private void buttonCalculateValues_Click(object sender, EventArgs e)
        {
            ValueCalculateForm frmCalculate = new ValueCalculateForm();
            frmCalculate.Show();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            tbValueD.Text = variableValues.variableDValue.ToString();
            tbValueE.Text = variableValues.variableEValue.ToString();
            tbValueN.Text = variableValues.variableNValue.ToString();
        }

        public static class variableValues
        {
            public static BigInteger variableDValue { get; set; }
            public static BigInteger variableEValue { get; set; }
            public static BigInteger variableNValue { get; set; }
        }


    }
}
