using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempesta.Capstone
{
    public partial class frmMoneyWords : Form
    {
        public frmMoneyWords()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            lblWordsOutput.Text = "";

            CreateMillionsThousandsHundredsCantsStrings create = new CreateMillionsThousandsHundredsCantsStrings(txtMoneyInput.Text);
            String[] convertedInput = create.getInputBrokenIntoPieces();

            if (convertedInput[0] != null)
            {
                moneyConvertWords convert = new moneyConvertWords(convertedInput[0]);
                lblWordsOutput.Text = convert.getWordsConversion() + " million  ";
            }

            if (convertedInput[1] != null)
            {
                moneyConvertWords convert = new moneyConvertWords(convertedInput[1]);
                lblWordsOutput.Text += convert.getWordsConversion() + " thousand ";
            }

            if (convertedInput[2] != null)
            {
                moneyConvertWords convert = new moneyConvertWords(convertedInput[2]);
                lblWordsOutput.Text += convert.getWordsConversion() + " hundred ";
            }

            if (convertedInput[3] != null)
            {
                moneyConvertWords convert = new moneyConvertWords(convertedInput[3]);
                lblWordsOutput.Text += convert.getWordsConversion() + " dollars ";
            }

            if (convertedInput[4] != null)
            {
                moneyConvertWords convert = new moneyConvertWords(convertedInput[3]);
                lblWordsOutput.Text += convert.getWordsConversion() + " Cents ";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWordsOutput.Text = string.Empty;
            txtMoneyInput.Text = String.Empty;

        }
    }
}
