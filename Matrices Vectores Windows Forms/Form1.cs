using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices_Vectores_Windows_Forms
{
    public partial class Form1 : Form
    {
        private int tamanioVector = 5;
        private int contador = 0;
        private int[] vector;
        private int[,] matriz;

        public Form1()
        {
            InitializeComponent();
            vector = new int[tamanioVector];
            dataGridView1.AutoGenerateColumns = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(contador <= vector.Length)
            {

                if(int.TryParse(vectorImput.Text, out int numero)) 
                {
                    vector[contador] = numero;
                    contador++;
                    vectorImput.Clear();

                    MessageBox.Show("Numero Guardado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if(contador == vector.Length)
                    {
                        MessageBox.Show("Vector Llenado", "Infomracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, Ingresa un número valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarVector_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";

            if(contador > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < contador; i++)
                {
                    sb.Append(vector[i].ToString() + " ");
                }

                mostrar.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("El vector esta vacio.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contador = 0;

            mostrar.Text = "";

            button1.Enabled = true;

            if (matriz != null)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = 0; 
                    }
                }
            }

            if (dataGridView1 != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }

        }


        private void buttonCrearMatriz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(matrizN.Text, out int filas) && int.TryParse(matrizM.Text, out int columnas))
            {
                if (filas > 0 && columnas > 0)
                {
                    matriz = new int[filas, columnas];
                    ConfigurarDataGridView(filas, columnas); // Método para configurar el DataGridView.

                    MessageBox.Show($"Matriz de {filas}x{columnas} creada exitosamente.", "Matriz Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonCrearMatriz.Enabled = false; // Opcional: deshabilita el botón después de crear la matriz.
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores mayores que 0 para filas y columnas.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, asegúrese de ingresar números enteros válidos en ambos campos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView(int filas, int columnas)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.AllowUserToAddRows = false;

            // Configura las columnas
            for (int i = 0; i < columnas; i++)
            {
                dataGridView1.Columns.Add($"Column{i}", $"Columna {i + 1}");
            }

            // Configura las filas
            dataGridView1.Rows.Add(filas); // DataGridView maneja la cuenta de filas de manera diferente.

            // Opcional: ajusta el tamaño de las celdas si es necesario
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void buttonGuardarValorMatriz_Click(object sender, EventArgs e)
        {
            if (matriz == null)
            {
                MessageBox.Show("Primero debe crear la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder errores = new StringBuilder();
            bool tieneErrores = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Asegúrate de que el valor en la celda no es null o vacío
                    if (dataGridView1.Rows[i].Cells[j].Value != null && !string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                    {
                        string valorCelda = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        if (int.TryParse(valorCelda, out int valor))
                        {
                            matriz[i, j] = valor;
                        }
                        else
                        {
                            errores.AppendLine($"Valor no válido '{valorCelda}' en la celda [{i},{j}]. Se esperaba un número entero.");
                            tieneErrores = true;
                        }
                    }
                    else
                    {
                        errores.AppendLine($"Ingrese un valor en la celda [{i},{j}].");
                        tieneErrores = true;
                    }
                }
            }

            if (tieneErrores)
            {
                MessageBox.Show("Se encontraron errores al guardar los valores en la matriz:\n" + errores.ToString(), "Errores Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Todos los valores han sido guardados correctamente en la matriz.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mostrarMatriz_Click(object sender, EventArgs e)
        {
            if (matriz == null)
            {
                MessageBox.Show("La matriz no ha sido creada o está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Añade cada elemento de la matriz al StringBuilder, seguido de un espacio
                    sb.Append(matriz[i, j] + " ");
                }
                // Añade un salto de línea después de cada fila para formatear la salida como una matriz
                sb.AppendLine();
            }

            // Establece el texto del labelMostrar con la cadena formateada
            mostrar.Text = sb.ToString();
        }

    }
}
