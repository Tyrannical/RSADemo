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

namespace RSA_App
{
    public partial class RSAEncryptionWithoutHex : Form
    {
        BigInteger[] encryptedMessageBIArray;

        public RSAEncryptionWithoutHex()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //variables and converting string to byte array
                byte[] toBytes = Encoding.UTF8.GetBytes(tbMessage.Text);
                BigInteger[] unencryptedMessage = new BigInteger[toBytes.Length];
                BigInteger[] encryptedMessage = new BigInteger[toBytes.Length];
                string outputString = "";

                //converts byte to BigInteger then encryptes the BigInteger value
                for (int i = 0; i < toBytes.Length; i++)
                {
                    unencryptedMessage[i] = toBytes[i];
                    encryptedMessage[i] = encryptBI(unencryptedMessage[i], globalVariables.variableNValue, globalVariables.variableEValue);
                    outputString = outputString + encryptedMessage[i].ToString();
                }

                //sets Primary Variable and set textbox value
                encryptedMessageBIArray = encryptedMessage;
                tbEncrypted.Text = outputString;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a message or correctly use the sync button.");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //variables and presets BigInteger arrays
                byte[] byteArray = new byte[encryptedMessageBIArray.Length];
                BigInteger[] decryptedMessage = encryptedMessageBIArray;
                BigInteger[] encryptedMessage = encryptedMessageBIArray;
                string str = "";

                //decrypts message, then converts each BigInteger index into a byte array which then converts a byte array to a string
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    decryptedMessage[i] = decryptBI(encryptedMessage[i], globalVariables.variableNValue, globalVariables.variableDValue);
                    byteArray = decryptedMessage[i].ToByteArray();
                    str = str + System.Text.Encoding.UTF8.GetString(byteArray);
                }

                //sets textbox value
                tbDecrypted.Text = str;
            }
            catch (Exception)
            {
                MessageBox.Show("Please encrypt a message first or correctly use the sync button.");
            }
        }

        //encryption method
        public BigInteger encryptBI(BigInteger basicMessage, BigInteger n, BigInteger e)
        {
            BigInteger encryptedBI = new BigInteger();
            encryptedBI = BigInteger.ModPow(basicMessage, e, n);
            return encryptedBI;
        }

        //decryption method
        public BigInteger decryptBI(BigInteger encryptedMessage, BigInteger n, BigInteger d)
        {
            BigInteger decryptedBI = new BigInteger();
            decryptedBI = BigInteger.ModPow(encryptedMessage, d, n);
            return decryptedBI;
        }
        
        //pull global variables
        private void btnSync_Click(object sender, EventArgs e)
        {
            tbDValue.Text = globalVariables.variableDValue.ToString();
            tbEValue.Text = globalVariables.variableEValue.ToString();
            tbNValue.Text = globalVariables.variableNValue.ToString();
        }
    }
}
