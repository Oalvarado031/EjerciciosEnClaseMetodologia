using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazClaseViernes11Nov
{
    public partial class Form1 : Form
    { 
        Empleado Emp = new Empleado();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            Emp.NumEmpleado = Convert.ToInt32(txtNumero.Text);
            Emp.NombreEmplado = txtNombre.Text; 
            Emp.DiasLab = Convert.ToInt32(txtDiasLab.Text);
            Emp.SalDia = Convert.ToDecimal(txtSalarioDia.Text);
            MessageBox.Show("Registro guardado");
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtDevengado.Text = Emp.CalcularSalario(Emp.DiasLab, Emp.SalDia).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNumero.Clear();
            txtDiasLab.Clear();
            txtSalarioDia.Clear();
            txtDevengado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
