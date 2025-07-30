using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Diseño_UI_GUNA
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
            txtContra.UseSystemPasswordChar = true;
        }

        // ✅ Constructor que recibe Form1 como parámetro
        public Form2(Form1 form1) : this() // llama al constructor sin parámetros
        {
            this.form1 = form1;
        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContra.Text.Trim();

            labelCompletarCampos.Visible = false;

            if (usuario == "" || contrasena == "")
            {
                labelCompletarCampos.Text = "Por favor, complete todos los campos";
                labelCompletarCampos.Visible = true;
                return;
            }

            string cadenaConexion = "server=localhost;port=3306;user=root;password=1234;database=USUARIOS_GUNA;";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO usuarios (usuario, contrasena) VALUES (@usuario, @contrasena)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena); // sin encriptar
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cuenta creada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.form1.Show();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Usuario duplicado
                    {
                        labelCompletarCampos.Text = "Este nombre de usuario ya existe. Intente con otro.";
                        labelCompletarCampos.ForeColor = System.Drawing.Color.Red;
                        labelCompletarCampos.Visible = true;
                    }
                    else
                    {
                        labelCompletarCampos.Text = "Error en la base de datos. Intente más tarde.";
                        labelCompletarCampos.ForeColor = System.Drawing.Color.Red;
                        labelCompletarCampos.Visible = true;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.form1?.Show();
            this.Close();
        }
    }
}