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
        
        string[] hexArrayUnencrypted;
        BigInteger[] decryptedArray;
        

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

        public static string ConvertHexToString(string HexValue)
        {
            string StrValue = "";
            while (HexValue.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
                HexValue = HexValue.Substring(2, HexValue.Length - 2);
            }
            return StrValue;
        }

        //converts message to hex
        private void buttonToHex_Click(object sender, EventArgs e)
        {
            try
            {
                //general string from message box
                initialMessage = encryptionInput.Text;

                //variables, string to char array
                char[] charArrayInitialMessage = initialMessage.ToCharArray();
                string[] hexStringArrayOfChar = new string[charArrayInitialMessage.Length];
                string[] a1 = new string[charArrayInitialMessage.Length];
                string g = "";

                //char array to string array
                for (int i = 0; i < charArrayInitialMessage.Length; i++)
                {
                    a1[i] = charArrayInitialMessage[i].ToString();
                }

                //convert each element of string array to hex array
                for (int i = 0; i < charArrayInitialMessage.Length; i++)
                {
                    hexStringArrayOfChar[i] = fToHexString(a1[i]);
                }

                //combine hex array for display
                for (int i = 0; i < hexStringArrayOfChar.Length; i++)
                {
                    g = g + hexStringArrayOfChar[i];
                }

                //set variables and text box
                hexArrayUnencrypted = hexStringArrayOfChar;
                hexValueS = g;
                hexValue.Text = g;
            }
            catch (Exception)
            {
                MessageBox.Show("You found an odd error. Please don't do that again.");
            }
        }

        //encrypts hex message
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                valueE = BigInteger.Parse(tbValueE.Text);
                valueN = BigInteger.Parse(tbValueN.Text);

                BigInteger[] n = new BigInteger[hexArrayUnencrypted.Length];
                BigInteger[] q = new BigInteger[hexArrayUnencrypted.Length];
                string myHex = "";

                //parse hex array into BigInteger Array
                for (int i = 0; i < hexArrayUnencrypted.Length; i++)
                {
                    n[i] = BigInteger.Parse(hexArrayUnencrypted[i].ToString(), NumberStyles.HexNumber);
                }

                //encrypt BigInteger Array by element
                for (int i = 0; i < hexArrayUnencrypted.Length; i++)
                {
                    q[i] = encryptData(n[i], valueE, valueN);
                }

                //convert BigInteger array to a hex string and prep for display
                for (int i = 0; i < hexArrayUnencrypted.Length; i++)
                {
                    myHex = myHex + q[i].ToString("x");
                }

                //variables and text box set
                encryptedHex = myHex;
                encryptionHex.Text = myHex;
                repeatEncryptedHex.Text = myHex;
                encryptedArray = q;
            }
            catch (Exception)
            {
                if (string.IsNullOrWhiteSpace(tbValueE.Text) || string.IsNullOrWhiteSpace(tbValueN.Text))
                {
                    MessageBox.Show("Value E or Value N have not been inputted.");
                }
                else if (string.IsNullOrWhiteSpace(hexValue.Text))
                {
                    MessageBox.Show("You need to convert a string to a hex value");
                }
                else
                {
                    MessageBox.Show("I don't know what error is here");
                }            
            }
        }

        //decrypts hex message
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                valueD = BigInteger.Parse(tbValueD.Text);
                valueN = BigInteger.Parse(tbValueN.Text);

                BigInteger[] n = encryptedArray;
                BigInteger[] finalArray = new BigInteger[encryptedArray.Length]; ;
                string myHex = "";

                //decrypt BigInteger Array
                for (int i = 0; i < encryptedArray.Length; i++)
                {
                    finalArray[i] = decryptValue(n[i], valueD, valueN);
                }

                //convert to hex
                for (int i = 0; i < encryptedArray.Length; i++)
                {
                    myHex = myHex + finalArray[i].ToString("x");
                }

                //variables and text box
                decryptedHex = myHex;
                decryptedHexBox.Text = myHex;
                decryptedArray = finalArray;
            }
            catch (Exception)
            {
                if (string.IsNullOrWhiteSpace(tbValueD.Text) || string.IsNullOrWhiteSpace(tbValueN.Text))
                {
                    MessageBox.Show("Value D or Value N have not been inputted.");
                }
                else if (string.IsNullOrWhiteSpace(repeatEncryptedHex.Text))
                {
                    MessageBox.Show("Please encrypt a value first");
                }
                else
                {
                    MessageBox.Show("I don't know what error is here");
                } 
            }
        }

        //converts decrypted hex message to string
        private void buttonToString_Click(object sender, EventArgs e)
        {
            try
            {
                string[] hexStringArray = new string[decryptedArray.Length];
                string finalString = "";
                for (int i = 0; i < hexStringArray.Length; i++)
                {
                    hexStringArray[i] = decryptedArray[i].ToString("x");
                }

                //convert to hex
                for (int i = 0; i < encryptedArray.Length; i++)
                {
                    finalString = finalString + ConvertHexToString(hexStringArray[i]);
                }

                finalMessage = finalString;
                decryptionMessage.Text = finalMessage;
            }
            catch (Exception)
            {
                if (string.IsNullOrWhiteSpace(decryptedHexBox.Text))
                {
                    MessageBox.Show("Decrypt a value first.");
                }
                else
                {
                    MessageBox.Show("This error probably comes from incorrect RSA values or some other error");
                }
            }
        }


        //encryption funciton
        private BigInteger encryptData(BigInteger a, BigInteger e, BigInteger n)
        {
            BigInteger encryptedValue = a;
            encryptedValue = BigInteger.ModPow(encryptedValue, e, n);

            return encryptedValue;
        }

        //decryption function
        private BigInteger decryptValue(BigInteger a, BigInteger d, BigInteger n)
        {
            BigInteger decryptedValue = a;
            decryptedValue = BigInteger.ModPow(decryptedValue, d, n);

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
