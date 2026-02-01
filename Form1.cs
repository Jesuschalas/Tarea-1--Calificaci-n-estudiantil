using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
                return;

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Title = "Guardar archivo de texto";
            guardar.Title = "Guardar archivo de empleado";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(guardar.FileName))
                {
                    sw.WriteLine("ID | Nombre | Apellidos | Dirección | Teléfono | Email | Cargo | Salario | Fecha Ingreso | Género");
                    sw.WriteLine(new string('-', 100));

                    string genero = rbMasculino.Checked ? "Masculino" : "Femenino";

                    sw.WriteLine($"{txtId.Text} | {txtNombre.Text} | {txtApellidos.Text} | {txtDireccion.Text} | " +
                                 $"{mtxtTelefono.Text} | {txtEmail.Text} | {cmbCargo.Text} | {txtSalario.Text} | " +
                                 $"{dtpIngreso.Value.ToShortDateString()} | {genero}");
                }
                MessageBox.Show("Archivo guardado exitosamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /* Vali de cargoxdd*/
                if (cmbCargo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cargo",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCargo.Focus();
                    return;
                }
                /* Vali de salario v:*/
                if (!mtxtTelefono.MaskCompleted)
                {
                    MessageBox.Show("Debe ingresar un número de teléfono válido",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtTelefono.Focus();
                    return;
                }
                /* Vali de salarioxdd*/
                double salario;
               
                if (!double.TryParse(txtSalario.Text, out salario) || salario <= 0)
                {
                    MessageBox.Show("Ingrese un salario válido",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalario.Focus();
                    return;
                }
                string salarioTexto = salario.ToString("0.00");

                /* Vali de email*/
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
    !txtEmail.Text.Contains("@") ||
    !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* Validar que en el campo de salario solo se ingresen números y un punto decimal XDD*/
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool CamposVacios()
        {
            if (txtId.Text == "" ||
                txtNombre.Text == "" ||
                txtApellidos.Text == "" ||
                txtDireccion.Text == "" ||
                mtxtTelefono.Text == "" ||
                txtEmail.Text == "" ||
                txtSalario.Text == "" ||
                cmbCargo.SelectedIndex == -1 ||
                (!rbMasculino.Checked && !rbFemenino.Checked))
            {
                MessageBox.Show("Debe completar todos los campos",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

  
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto|*.txt";
            abrir.Filter = "Abrir archivo de empleado";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(abrir.FileName))
                {
                    string contenido = sr.ReadToEnd();
                    MessageBox.Show(contenido, "Contenido del archivo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            mtxtTelefono.Clear();
            txtEmail.Clear();
            txtSalario.Clear();

            cmbCargo.SelectedIndex = -1;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;

            dtpIngreso.Value = DateTime.Now;
            txtId.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show(
    "¿Desea salir de la aplicación?",
    "Confirmación",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}