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
using System.Collections;
using System.Security.Cryptography;

namespace RSA_App
{
    public partial class ValueCalculateForm : Form
    {
        //globals
        BigInteger nValue = 1;
        BigInteger tValue = 1;
        BigInteger dValue = 1;
        BigInteger eValue;

        int nCheck = 0;
        int tCheck = 0;
        int dCheck = 0;

        BigInteger fNValue;
        BigInteger fDValue;
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



        public static BigInteger GetGCDByModulus(BigInteger value1, BigInteger value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                    value1 %= value2;
                else
                    value2 %= value1;
            }
            return BigInteger.Max(value1, value2);
        }

        public static bool Coprime(BigInteger value1, BigInteger value2)
        {
            return GetGCDByModulus(value1, value2) == 1;
        }

        private void buttonCheckPrime_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                BigInteger n1 = BigInteger.Parse(textPrimeOne.Text);
                BigInteger n2 = BigInteger.Parse(textPrimeTwo.Text);
                string responseS = "";

                Boolean n1b = false;
                Boolean n2b = false;

                n1b = BigIntegerExtensions.IsProbablePrime(n1, 1);
                n2b = BigIntegerExtensions.IsProbablePrime(n2, 2);

                //checks for both primes, 1 is prime, or none is prime then shows message based on that. If both are prime does math
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
                //variables
                BigInteger eCheckVal = 0;
                eCheckVal = BigInteger.Parse(tbEValue.Text);
                Boolean coPrimeChecker = Coprime(tValue, eCheckVal);
                Boolean totientChecker = false;


                //checks for coprime and within range, if true performs calculations
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

                    eValue = BigInteger.Parse(tbEValue.Text);

                    BigInteger qq = BigInteger.Multiply(tValue, nValue);
                    BigInteger qw = BigInteger.Multiply(tValue, qq);
                    BigInteger d = BigInteger.ModPow(eCheckVal, (qw - 2), tValue);

                    dValue = BigInteger.Parse(tbDValue.Text);
                    bool dAndeChecker = false;

                    BigInteger checker = BigInteger.ModPow(BigInteger.Multiply(dValue, eValue), 1, tValue);

                    if (checker == 1) { dAndeChecker = true; }

                    if (dAndeChecker)
                    {
                         tbCheckE.Text = "Value e and d are good";
                    }
                    else
                    {
                        tbCheckE.Text = "Value e and d are bad";
                    }
                    //dValue = d;
                    tbDValue.Text = dValue.ToString();
                    dCheck = 1;

                }
                else if (!coPrimeChecker && totientChecker)
                {
                    tbCheckE.Text = "The value is NOT coprime and is between 1 and the totient";
                }
                else if (coPrimeChecker && !totientChecker)
                {
                    tbCheckE.Text = "The value is coprime and is NOT between 1 and the totient";
                }
                else
                {
                    tbCheckE.Text = "The value is NOT coprime and is NOT between 1 and the totient";
                }
            }
            catch (Exception ex)
            {
                string responseString = "";
                if (string.IsNullOrWhiteSpace(tbEValue.Text)) { responseString = "No e value found; "; }
                if (string.IsNullOrWhiteSpace(tbTValue.Text)) { responseString = responseString + "No t value found; "; }
                if (string.IsNullOrWhiteSpace(tbNValue.Text)) { responseString = responseString + "No n value found; "; }
                if (string.IsNullOrWhiteSpace(tbDValue.Text)) { responseString = responseString + "No d value found; "; }
                MessageBox.Show(responseString);
            }
        }

        private void buttonSendValues_Click(object sender, EventArgs e)
        {
            try
            {
                //variables and sends data if all calculatiosn have been performed
                if (nCheck == 1 & dCheck == 1 && tCheck == 1)
                {
                    fNValue = nValue;
                    fDValue = dValue;
                    fEValue = eValue;

                    globalVariables.variableDValue = fDValue;
                    globalVariables.variableNValue = fNValue;
                    globalVariables.variableEValue = fEValue;

                    tbSendD.Text = fDValue.ToString();
                    tbSendN.Text = fNValue.ToString();
                    tbSendE.Text = fEValue.ToString();

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
            catch (Exception)
            {
                MessageBox.Show("Sending of variables failed");
            }
        }

        //small prime numbers
        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger a = 151;
            BigInteger b = 349;
            BigInteger c = 8219;
            BigInteger d = 45779;

            textPrimeOne.Text = a.ToString();
            textPrimeTwo.Text = b.ToString();
            tbEValue.Text = c.ToString();
            tbDValue.Text = d.ToString();
        }

        //medium prime numbers
        private void btnMediumPrime_Click(object sender, EventArgs e)
        {
            BigInteger a = 65499743;
            BigInteger b = 324899387;
            BigInteger c = 724897567;
            BigInteger d = BigInteger.Parse("431189203839839");

            textPrimeOne.Text = a.ToString();
            textPrimeTwo.Text = b.ToString();
            tbEValue.Text = c.ToString();
            tbDValue.Text = d.ToString();
        }

        //large prime numbers
        private void btnLargePrime_Click(object sender, EventArgs e)
        {
            BigInteger a = 92489625259;
            BigInteger b = 424896219269;
            BigInteger c = 965495171351;
            BigInteger d = BigInteger.Parse("11747526551953982329247");

            textPrimeOne.Text = a.ToString();
            textPrimeTwo.Text = b.ToString();
            tbEValue.Text = c.ToString(); 
            tbDValue.Text = d.ToString();
        }     

        
    }
}
