using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Almacenamiento_de_datos
{
    public partial class XML : Form
    {
        private string filePath = @"C:\Almacenamiento de datos.xml";

        public XML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Abrir archivo XML
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string xmlContent = File.ReadAllText(filePath);
                    textBox1.Text = xmlContent;
                    MessageBox.Show("Archivo XML abierto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo no existe. Verifica la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Guardar archivo XML
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.WriteAllText(filePath, textBox1.Text);
                    MessageBox.Show("Archivo XML guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo no existe. No se puede guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Eliminar archivo XML
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    textBox1.Clear();
                    MessageBox.Show("Archivo XML eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo no existe. No se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
