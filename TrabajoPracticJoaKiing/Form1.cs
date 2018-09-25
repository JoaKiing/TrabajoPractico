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

namespace TrabajoPracticJoaKiing {
    public partial class Form1 : Form {
        private String texto;
        private int contVocales = 0;
        private int contConsonantes = 0;
        private int contEspacios = 0;
        private int contPalabras = 0;
        private int contCaracteres = 0;
        private int contTab = 0;

        public Form1() {
            InitializeComponent();
            cargarComboBox();

        }

        public void cargarComboBox() {
            cboQuitar.Items.Add("Espacios Blanco");
            cboQuitar.Items.Add("Vocales");
            cboQuitar.Items.Add("Consonantes");
        }

        private void btnExaminar_Click(object sender, EventArgs e) {
            OpenFileDialog cajaBusqueda = new OpenFileDialog();

            cajaBusqueda.Multiselect = false;
            cajaBusqueda.Filter = "txt files (*.txt)|*.txt";

            if (cajaBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                TextReader archivo = new StreamReader(cajaBusqueda.FileName);
                String rutaArchivo = cajaBusqueda.FileName;

                texto = archivo.ReadToEnd();
                texto = texto.ToLower();

                lblRutaArchivo.Text = rutaArchivo;
                txtTexto.Text = texto;

                

                for (int i = 0; i < texto.Length; i++) {
                    contCaracteres++;
                }
                lblCaracteres.Text = contCaracteres.ToString();

                for (int i = 0; i < texto.Length; i++) {
                    if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u') {
                        contVocales++;
                    }

                    if (texto[i] == ' ') {
                        contEspacios++;
                        contPalabras++;
                    }

                    if (texto[i] == '\t') {
                        contTab++;
                    }
                }
                contConsonantes = contCaracteres - (contEspacios + contVocales);
                contPalabras++;

                

                lblVocales.Text = contVocales.ToString();
                lblEspacios.Text = contEspacios.ToString();
                lblConsonantes.Text = contConsonantes.ToString();
                lblPalabras.Text = contPalabras.ToString();
                lblTab.Text = contTab.ToString();
                lblLineas.Text = txtTexto.Lines.Count().ToString();
                

                archivo.Close();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e) {

            if (cboQuitar.SelectedIndex == 0) {
                txtTexto.Text = texto.Replace(" ","");
                contEspacios = 0;
                lblEspacios.Text = contEspacios.ToString();
            }

            if (cboQuitar.SelectedIndex == 1) {
                txtTexto.Text = texto.Replace("a","");
                txtTexto.Text = texto.Replace("e", "");
                txtTexto.Text = texto.Replace("i", "");
                txtTexto.Text = texto.Replace("o", "");
                txtTexto.Text = texto.Replace("u", "");
            }
            

            if (cboQuitar.SelectedIndex == 2) {
                for (int i = 0; i<texto.Length; i++) {
                    if (texto[i] != 'a' || texto[i] != 'e' || texto[i] != 'i' || texto[i] != 'o' || texto[i] != 'u' || texto[i] != ' ') {
                        txtTexto.Text = texto.Replace("b", "");
                        txtTexto.Text = texto.Replace("c", "");
                        txtTexto.Text = texto.Replace("d", "");
                        txtTexto.Text = texto.Replace("f", "");
                        txtTexto.Text = texto.Replace("g", "");
                        txtTexto.Text = texto.Replace("h", "");
                        txtTexto.Text = texto.Replace("j", "");
                        txtTexto.Text = texto.Replace("k", "");
                        txtTexto.Text = texto.Replace("l", "");
                        txtTexto.Text = texto.Replace("m", "");
                        txtTexto.Text = texto.Replace("n", "");
                        txtTexto.Text = texto.Replace("ñ", "");
                        txtTexto.Text = texto.Replace("p", "");
                        txtTexto.Text = texto.Replace("q", "");
                        txtTexto.Text = texto.Replace("r", "");
                        txtTexto.Text = texto.Replace("s", "");
                        txtTexto.Text = texto.Replace("t", "");
                        txtTexto.Text = texto.Replace("v", "");
                        txtTexto.Text = texto.Replace("w", "");
                        txtTexto.Text = texto.Replace("x", "");
                        txtTexto.Text = texto.Replace("y", "");
                        txtTexto.Text = texto.Replace("z", "");
                    }
                }    
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            SaveFileDialog cajaGuardar = new SaveFileDialog();
            cajaGuardar.Filter = "txt files (*.txt)|*.txt";

            if (cajaGuardar.ShowDialog() == DialogResult.OK) {
                StreamWriter ruta = File.CreateText(cajaGuardar.FileName);
                ruta.Write(txtTexto.Text);
                ruta.Flush();

                MessageBox.Show("El archivo se guardo correctamente","Guardar");
            }
        }
    }
}
