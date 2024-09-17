using System;
using System.IO;
using System.Windows.Forms;

namespace Almacenamiento_de_datos
{
    public partial class RTF : Form
    {
        private string filePath = @"C:\archivo.rtf";

        public RTF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Abrir archivo .rtf
        {
            try
            {
                if (File.Exists(filePath))
                {
                    richTextBox1.LoadFile(filePath);
                    MessageBox.Show("Archivo abierto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e) // Guardar archivo .rtf
        {
            try
            {
                if (File.Exists(filePath))
                {
                    richTextBox1.SaveFile(filePath);
                    MessageBox.Show("Archivo guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e) // Eliminar archivo .rtf
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    richTextBox1.Clear();
                    MessageBox.Show("Archivo eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
