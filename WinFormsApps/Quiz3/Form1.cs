using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class Quiz3Form : Form
    {
        public Quiz3Form()
        {
            InitializeComponent();
        }

        private void Quiz3Form_Load(object sender, EventArgs e)
        {
            cifraTxt.Focus();

            fromList.Text = "Seleccione una moneda";
            toList.Text = "Seleccione una moneda";

            fromList.Items.Add("USD");
            fromList.Items.Add("EUR");
            fromList.Items.Add("COP");

            toList.Items.Add("USD");
            toList.Items.Add("EUR");
            toList.Items.Add("COP");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fromList.Text = "Seleccione una moneda";
            toList.Text = "Seleccione una moneda";

            convertedTxt.Text = string.Empty;
            cifraTxt.Text = string.Empty;
            messageTxt.Text = string.Empty;

            monedaCb.Checked = false;

            cifraTxt.Focus();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (cifraTxt.Text == string.Empty || !double.TryParse(cifraTxt.Text, out double cifra))
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese una cifra!";
                return;
            }

            if (cifra < 1)
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese una cifra mayor a 1!";
                return;
            }

            if (fromList.SelectedIndex == toList.SelectedIndex)
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor seleccione monedas diferentes!";
                return;
            }

            double monedaConvertida = ConvertirMoneda(cifra);
            
            if (monedaCb.Checked)
            {
                convertedTxt.Text = monedaConvertida.ToString("C");
            } else 
            { 
                convertedTxt.Text = monedaConvertida.ToString("F2");
            }


            messageTxt.ForeColor = Color.Green;
            messageTxt.Text = "Cálculo completado correctamente!";
        }

        public double ConvertirMoneda(double moneda)
        {
            double cifra = moneda;

            double tasaCOPaUSD = 1 / 4000.0;    // 1 COP = 0.00025 USD
            double tasaCOPaEUR = 1 / 4200.0;    // 1 COP = 0.000238 EUR
            double tasaUSDaCOP = 4000;          // 1 USD = 4000 COP
            double tasaEURaCOP = 4200;          // 1 EUR = 4200 COP
            double tasaUSDaEUR = 4200 / 4000.0; // 1 USD = 1.05 EUR
            double tasaEURaUSD = 4000 / 4200.0; // 1 EUR = 0.9524 USD

            if (fromList.SelectedIndex == 2)
            {
                if (toList.SelectedIndex == 0) return cifra * tasaCOPaUSD;
                if (toList.SelectedIndex == 1) return cifra * tasaCOPaEUR;
            }
            else if (fromList.SelectedIndex == 0)
            {
                if (toList.SelectedIndex == 2) return cifra * tasaUSDaCOP;
                if (toList.SelectedIndex == 1) return cifra * tasaUSDaEUR;
            }
            else if (fromList.SelectedIndex == 1)
            {
                if (toList.SelectedIndex == 2) return cifra * tasaEURaCOP;
                if (toList.SelectedIndex == 0) return cifra * tasaEURaUSD;
            }

            return cifra;

        }
    }
}
