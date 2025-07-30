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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            guna2GradientButton3.Click += guna2GradientButton3_Click;
        }

        private int cantidadSeleccionada = 0;
        private const int precioPrenda = 15000;

        private void Form3_Load(object sender, EventArgs e)
        {
            // Activar scroll personalizado en flowLayoutPanel1 con la barra vertical
            Guna.UI2.WinForms.Helpers.PanelScrollHelper flowpan = new Guna.UI2.WinForms.Helpers.PanelScrollHelper(flowLayoutPanel1, guna2vScrollBar1, true);

            // Asociar eventos de los UserControls
            userControl21.PrendaSeleccionada += ManejarSeleccion;
            userControl22.PrendaSeleccionada += ManejarSeleccion;
            userControl23.PrendaSeleccionada += ManejarSeleccion;
            userControl24.PrendaSeleccionada += ManejarSeleccion;
            userControl25.PrendaSeleccionada += ManejarSeleccion;
            userControl26.PrendaSeleccionada += ManejarSeleccion;

            // Asignar nombres de las prendas
            userControl21.NombrePrenda = "Remera SUNHONEY Rosa";
            userControl22.NombrePrenda = "Remera SUNHONEY Negra";
            userControl23.NombrePrenda = "Remera SUNHONEY Azul";
            userControl24.NombrePrenda = "Remera SUNHONEY Blanca";
            userControl25.NombrePrenda = "Remera SUNHONEY Amarilla";
            userControl26.NombrePrenda = "Remera SUNHONEY Par La Mer Amarilla";

            label1.Text = ""; // Inicializar el label vacío
            label2.Text = ""; // Subtotal
            label3.Text = ""; //Total
        }

        private void ManejarSeleccion(bool fueSeleccionado)
        {
            cantidadSeleccionada += fueSeleccionado ? 1 : -1;

            // Actualizar label1 con la cantidad
            label1.Text = cantidadSeleccionada > 0 ? cantidadSeleccionada.ToString() : "";

            // Calcular y mostrar subtotal en label2
            int subtotal = cantidadSeleccionada * precioPrenda;
            label2.Text = subtotal > 0 ? "$" + subtotal.ToString("N0") : "";

            // Total
            int total = cantidadSeleccionada * precioPrenda;
            label3.Text = total > 0 ? "$" + total.ToString("N0") : "";
        }

        // Eventos no utilizados (pueden eliminarse si no los usás)
        private void guna2Button1_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }
        private void guna2CircleButton1_Click(object sender, EventArgs e) { }
        private void guna2CircleButton3_Click(object sender, EventArgs e) { }
        private void guna2PictureBox2_SizeModeChanged(object sender, EventArgs e) { }
        private void guna2Button7_ParentChanged(object sender, EventArgs e) { }
        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e) { }

        // ✅ CAMBIO AQUÍ:
        private void guna2GradientButton3_Click(object? sender, EventArgs e)
        {
            int total = cantidadSeleccionada * precioPrenda;

            if (cantidadSeleccionada == 0)
            {
                MessageBox.Show("No hay productos seleccionados.");
                return;
            }

            List<string> prendasSeleccionadas = new List<string>();

            if (userControl21.Seleccionado) prendasSeleccionadas.Add(userControl21.NombrePrenda);
            if (userControl22.Seleccionado) prendasSeleccionadas.Add(userControl22.NombrePrenda);
            if (userControl23.Seleccionado) prendasSeleccionadas.Add(userControl23.NombrePrenda);
            if (userControl24.Seleccionado) prendasSeleccionadas.Add(userControl24.NombrePrenda);
            if (userControl25.Seleccionado) prendasSeleccionadas.Add(userControl25.NombrePrenda);
            if (userControl26.Seleccionado) prendasSeleccionadas.Add(userControl26.NombrePrenda);

            StringBuilder comprobante = new StringBuilder();

            comprobante.AppendLine("╔══════════════════════════════════╗");
            comprobante.AppendLine("          TICKET DE COMPRA          ");
            comprobante.AppendLine("╠══════════════════════════════════╣");
            comprobante.AppendLine("Fecha: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            comprobante.AppendLine();
            comprobante.AppendLine("Cantidad de prendas: " + cantidadSeleccionada);
            comprobante.AppendLine("Precio unitario: $" + precioPrenda.ToString("N0"));
            comprobante.AppendLine("Subtotal: $" + total.ToString("N0"));
            comprobante.AppendLine();
            comprobante.AppendLine("Productos seleccionados:");
            foreach (var prenda in prendasSeleccionadas)
            {
                comprobante.AppendLine(" - " + prenda);
            }
            comprobante.AppendLine();
            comprobante.AppendLine("TOTAL: $" + total.ToString("N0"));
            comprobante.AppendLine("╚══════════════════════════════════╝");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
            saveFileDialog.FileName = "comprobante_compra.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, comprobante.ToString());
                MessageBox.Show("¡Comprobante guardado con éxito!");

                // Mostrar ticket en MessageBox
                MessageBox.Show(comprobante.ToString(), "Ticket de Compra");
            }
        }
    }
}