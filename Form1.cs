using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto_Diseño_UI_GUNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2Contra.UseSystemPasswordChar = true;
        }

        private void boton_LOGIN_Click_1(object sender, EventArgs e)
        {
            string usuario = guna2Usuario.Text.Trim();
            string contrasena = guna2Contra.Text.Trim();

            label_completar_campos.Visible = false;
            label_no_registrado.Visible = false;

            if (usuario == "" || contrasena == "")
            {
                label_completar_campos.Text = "Por favor, complete todos los campos";
                label_completar_campos.Visible = true;
                return;
            }

            string cadenaConexion = "server=localhost;port=3306;user=root;password=1234;database=USUARIOS_GUNA;";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            
                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide();
                        }
                        else
                        {
                            label_no_registrado.Text = "No se encuentra registrado, por favor, crea una cuenta";
                            label_no_registrado.Visible = true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    label_no_registrado.Text = "Error al conectar con la base de datos.";
                    label_no_registrado.Visible = true;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_completar_campos.Visible = false;
            label_no_registrado.Visible = false;
        }

        
    }

}

    