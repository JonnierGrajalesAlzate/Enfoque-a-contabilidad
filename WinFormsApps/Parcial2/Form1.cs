using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class parcial2Form : Form
    {
        public parcial2Form()
        {
            InitializeComponent();
        }

        private void parcial2Form_Load(object sender, EventArgs e)
        {
            idTxt.Focus();
            viviendaRb.Checked = true;
            cuotas12Rb.Checked = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTxt.Text = string.Empty;
            nameTxt.Text = string.Empty;
            prestamoTxt.Text = string.Empty;

            viviendaRb.Checked = true;
            cuotas12Rb.Checked = true;

            cuotaManejoCb.Checked = false;

            deudaTxt.Text = string.Empty;
            cuotasTxt.Text = string.Empty;
            messageTxt.Text = string.Empty;
        }

        public static double cuotas, interes, cuotaManejo, cuotaMensual;

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Validar que el nombre y el id no esten vacios
            if (idTxt.Text == string.Empty || nameTxt.Text == string.Empty)
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese todos los datos!";
                return;
            }

            // Validar que se ingrese un valor valido en el prestamo y que cumpla con las condiciones del valor  y se asigna el valor del prestamo//
            if (!double.TryParse(prestamoTxt.Text, out double prestamo))
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese un prestamo valido!";
                return;
            }
            else if (prestamo < 2000000 || prestamo > 100000000)
            {
                messageTxt.ForeColor = Color.Red;
                messageTxt.Text = "Por favor ingrese un prestamo mayor a 2 millones o menor a 100 millones!";
                return;
            }

            //Asignar la cantidad de cuotas
            if (cuotas12Rb.Checked) cuotas = 12;
            else if (cuotas24Rb.Checked) cuotas = 24;
            else if(cuotas36Rb.Checked) cuotas = 36;

            //Asignar el valor de interes segun el tipo de prestamo
            if (viviendaRb.Checked) interes = 0.01;
            else if (educacionRb.Checked) interes = 0.005;
            else if (vehiculoRb.Checked) interes = 0.025;

            //Asignar el valor de la cuota de manejo
            cuotaManejo = cuotaManejoCb.Checked ? 12000 : 0;

            //Calcular las cuotas mensuales
            cuotaMensual = calcularIntereses(prestamo, interes, cuotas) + cuotaManejo;

            // Calcular interés total y valor total a pagar
            double interesTotal = calcularInteresesTotales(cuotas, cuotaMensual, prestamo);
            double valorTotal = prestamo + interesTotal;

            //Mostrar informacion
            cuotasTxt.Text = cuotaMensual.ToString("C");
            deudaTxt.Text = valorTotal.ToString("C");

            messageTxt.ForeColor = Color.Green;
            messageTxt.Text = "Calculo completado correctamente";
        }

        public double calcularIntereses (double capital, double tasaInteres, double cuotas)
        {
            return capital * tasaInteres * cuotas;
        }

        public double calcularInteresesTotales(double cuotas, double cuotaMensual, double prestamo)
        {
            return cuotaMensual * cuotas - prestamo;
        }
    }
}
