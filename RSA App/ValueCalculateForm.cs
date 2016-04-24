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
    public partial class ValueCalculateForm : Form
    {
        //globals
        BigInteger nValue = 1;
        int tValue = 1;
        BigInteger dValue = 1;
        BigInteger eValue;

        int nCheck = 0;
        int tCheck = 0;
        int dCheck = 0;

        BigInteger fNValue;
        BigInteger fDValue;
        BigInteger fTValue;
        BigInteger fEValue;

        public ValueCalculateForm()
        {
            InitializeComponent();

        }

        private void ValueCalculateForm_Load(object sender, EventArgs e)
        {

        }

        //overrides on close to ask for verification
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
            case DialogResult.No:
                e.Cancel = true;
                break;
            default:
                break;
            }        
        }

        //checks if number is prime
        private Boolean isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public static int GetGCDByModulus(int value1, int value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                    value1 %= value2;
                else
                    value2 %= value1;
            }
            return Math.Max(value1, value2);
        }

        public static bool Coprime(int value1, int value2)
        {
            return GetGCDByModulus(value1, value2) == 1;
        }

        //ignore
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCheckPrime_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(textPrimeOne.Text);
                int n2 = int.Parse(textPrimeTwo.Text);
                string responseS = "";

                Boolean n1b = false;
                Boolean n2b = false;

                n1b = isPrime(n1);
                n2b = isPrime(n2);

                if (n1b && n2b)
                {
                    responseS = "Both numbers are prime numbers";
                    textBoxPrimeRespone.Text = responseS;

                    nValue = n1 * n2;
                    tValue = (n1 - 1) * (n2 - 1);

                    tbNValue.Text = nValue.ToString();
                    tbTValue.Text = tValue.ToString();

                    nCheck = 1;
                    tCheck = 1;
                }
                else if (n1b)
                {
                    responseS = "The second number is NOT a prime";
                    textBoxPrimeRespone.Text = responseS;
                    nCheck = 0;
                    tCheck = 0;
                }
                else if (n2b)
                {
                    responseS = "The first number is NOT a prime";
                    textBoxPrimeRespone.Text = responseS;
                    nCheck = 0;
                    tCheck = 0;
                }
                else
                {
                    responseS = "Both numbers are NOT prime numbers";
                    textBoxPrimeRespone.Text = responseS;
                    nCheck = 0;
                    tCheck = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Improper input (not integers) or empty input boxes for the prime numbers");
            }
        }

        private void buttonCheckE_Click(object sender, EventArgs e)
        {

            try
            {
                int eCheckVal = 0;
                eCheckVal = int.Parse(tbEValue.Text);
                Boolean coPrimeChecker = Coprime(tValue, eCheckVal);
                Boolean totientChecker = false;

                if (1 < eCheckVal && eCheckVal < tValue)
                {
                    totientChecker = true;
                }
                else
                {
                    totientChecker = false;
                }

                if (coPrimeChecker && totientChecker)
                {
                    tbCheckE.Text = "The value is coprime and is between 1 and the totient";

                    eValue = int.Parse(tbEValue.Text);

                    BigInteger qq = BigInteger.Multiply(tValue, nValue);
                    BigInteger qw = BigInteger.Multiply(tValue, qq);
                    BigInteger d = BigInteger.ModPow(eCheckVal, (qw - 1), tValue);

                    dValue = d;
                    tbDValue.Text = d.ToString();
                    dCheck = 1;

                }
                else if (!coPrimeChecker && totientChecker)
                {
                    tbCheckE.Text = "The value is NOT coprime and is between 1 and the totient";
                    dCheck = 0;
                }
                else if (coPrimeChecker && !totientChecker)
                {
                    tbCheckE.Text = "The value is coprime and is NOT between 1 and the totient";
                    dCheck = 0;
                }
                else
                {
                    tbCheckE.Text = "The value is NOT coprime and is NOT between 1 and the totient";
                    dCheck = 0;
                }
            }
            catch (Exception ex)
            {
                string responseString = "";
                if (string.IsNullOrWhiteSpace(tbEValue.Text)) { responseString = "No e value found; "; }
                if (string.IsNullOrWhiteSpace(tbTValue.Text)) { responseString = responseString + "No t value found; "; }
                if (string.IsNullOrWhiteSpace(tbNValue.Text)) { responseString = responseString + "No n value found; "; }
                MessageBox.Show(responseString);
            }
        }

        private void buttonSendValues_Click(object sender, EventArgs e)
        {
            try
            {
                if (nCheck == 1 & dCheck == 1 && tCheck == 1)
                {
                    fNValue = nValue;
                    fDValue = dValue;
                    fEValue = eValue;

                    PrimaryForm.variableValues.variableDValue = fDValue;
                    PrimaryForm.variableValues.variableNValue = fNValue;
                    PrimaryForm.variableValues.variableEValue = fEValue;

                    tbSendD.Text = fNValue.ToString();
                    tbSendN.Text = fNValue.ToString();
                    tbSendE.Text = fNValue.ToString();

                    MessageBox.Show("The values have been placed in the global variables. Please push the sync button on the primary form.");

                }
                else if (nCheck == 1 & dCheck == 1 && tCheck == 0)
                {
                    MessageBox.Show("The n and d values are correct");
                }
                else if (nCheck == 1 & dCheck == 0 && tCheck == 1)
                {
                    MessageBox.Show("The n and t values are correct");
                }
                else if (nCheck == 1 & dCheck == 1 && tCheck == 0)
                {
                    MessageBox.Show("The n and d values are correct");
                }
                else if (nCheck == 0 & dCheck == 1 && tCheck == 1)
                {
                    MessageBox.Show("The d and t values are correct");
                }
                else if (nCheck == 0 & dCheck == 1 && tCheck == 0)
                {
                    MessageBox.Show("The d value is correct");
                }
                else if (nCheck == 0 & dCheck == 0 && tCheck == 1)
                {
                    MessageBox.Show("The t value is correct");
                }
                else
                {
                    MessageBox.Show("None of the values are correctly inputted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sending of variables failed");
            }
        }
    }


}
