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

namespace ProductViwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("UNO");
                comboBox2.Items.Add("PALIO");               
            }
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ECOSPORT");
                comboBox2.Items.Add("KA");
            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CELTA");
                comboBox2.Items.Add("AGILE");
            }
            else if (comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("POLO");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diretorioImagens = Path.Combine(Application.StartupPath, "imagens");  // Uses relative path

            if (!Directory.Exists(diretorioImagens))
            {
                MessageBox.Show("The image folder was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] fotosDosCarros = Directory.GetFiles(diretorioImagens, "*.jpg"); // Filters only JPG images

            foreach (string caminhoCompleto in fotosDosCarros)
            {
                string nomeArquivo = Path.GetFileNameWithoutExtension(caminhoCompleto); // Gets the file name without extension

                if (comboBox2.Text == nomeArquivo)
                {
                    pictureBox2.BringToFront();
                    pictureBox2.ImageLocation = caminhoCompleto;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
