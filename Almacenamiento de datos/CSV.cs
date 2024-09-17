using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Almacenamiento_de_datos
{
    public partial class CSV : Form
    {
        private string filePath = @"C:\Almacenamiento de datos.csv";

        public CSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Contenido");

                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        dataTable.Rows.Add(line);
                    }

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.ScrollBars = ScrollBars.Both;
                    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files|*.csv";
                    saveFileDialog.Title = "Guardar archivo editado";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, GetDataGridViewContent());
                        MessageBox.Show("Archivo editado y guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe. No se puede editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al editar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    dataGridView1.DataSource = null;
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

        private string GetDataGridViewContent()
        {
            var content = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                content += row.Cells[0].Value?.ToString() + Environment.NewLine;
            }
            return content;
        }
    }
}
