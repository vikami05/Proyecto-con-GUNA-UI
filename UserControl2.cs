using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Diseño_UI_GUNA
{
    public partial class UserControl2 : UserControl
    {
        // 🔔 Evento que informa si se seleccionó (true) o deseleccionó (false)
        public event Action<bool> PrendaSeleccionada;

        // Estado de selección
        private bool seleccionado = false;

        // 📌 Nombre de la prenda (para mostrar en el comprobante)
        public string NombrePrenda { get; set; }

        // 📌 Saber si está seleccionada
        public bool Seleccionado => seleccionado;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void ToggleSeleccion()
        {
            seleccionado = !seleccionado;

            guna2GradientButton1_valid.Visible = seleccionado;
            guna2Panel1_valid.Visible = seleccionado;

            // Notificar al formulario
            PrendaSeleccionada?.Invoke(seleccionado);
        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
            ToggleSeleccion();
        }

        private void guna2Panel1_valid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_valid_Click(object sender, EventArgs e)
        {
            ToggleSeleccion();
        }
    }
}