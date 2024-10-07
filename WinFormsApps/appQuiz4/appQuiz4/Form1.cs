using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQuiz4
{
    public partial class frmConcesionaria : Form
    {
        public frmConcesionaria()
        {
            InitializeComponent();
        }

        public static decimal logan = 38000000, sportage = 65000000, aveo = 32000000, 
                              automatico = 1000000, vidrios = 500000, aire = 1500000;
        private void frmConcesionaria_Load(object sender, EventArgs e)
        {
            rbAutomatico.Checked = true;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == string.Empty || cbMarca.Text == "Seleccione una marca")
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese todos los datos!";
                return;
            }

            decimal valor = 0;

            switch (cbMarca.SelectedIndex)
            {
                case 0:
                    valor += logan; break;

                case 1:
                    valor += aveo; break;

                case 2:
                    valor += sportage; break;
            }

            decimal transmision = 0;

            if (rbAutomatico.Checked)
            {
                transmision += automatico;
            }

            decimal adicional = 0;

            if (chkAireAcondicionado.Checked)
            {
                adicional += aire;
            }

            if (chkElevaVidrios.Checked)
            {
                adicional += vidrios;
            }

            decimal total = calcularTotal(valor, transmision, adicional);

            lblVlrTotal.Text = total.ToString("C");

            messageTxt.ForeColor = Color.Green;
            messageTxt.Text = "Cálculo completado correctamente!";
        }

        public decimal calcularTotal(decimal valor, decimal transimision, decimal adicional) 
        {
            decimal total = valor + transimision + adicional;
            return total;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Text = string.Empty;
            cbMarca.Text = "Seleccione una marca";
            txtPrecio.Text = string.Empty;

            rbAutomatico.Checked = true;

            chkAireAcondicionado.Checked = false;
            chkElevaVidrios.Checked = false;

            messageTxt.Text = string.Empty;
            lblVlrTotal.Text = string.Empty;

            txtPlaca.Focus();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex == 0)
            {
                txtPrecio.Text = logan.ToString();
                return;
            }

            if (cbMarca.SelectedIndex == 1)
            {
                txtPrecio.Text = aveo.ToString();
                return;
            }

            if (cbMarca.SelectedIndex == 2)
            {
                txtPrecio.Text = sportage.ToString();
                return;
            }
        }
    }
}
