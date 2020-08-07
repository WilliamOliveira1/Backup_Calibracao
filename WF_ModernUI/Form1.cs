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

namespace WF_ModernUI
{
    public partial class Form1 : Form
    {
        string nomeComputador = Environment.MachineName;
        

        public Form1()
        {
            InitializeComponent();
            this.button1.Enabled = false;
            comboBox1.Items.Add(nomeComputador);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length > 0)
            {
                this.button1.Enabled = true;
            }
            if (comboBox1.Text.Length == 0)
            {
                this.button1.Enabled = false;
            }

            switch (comboBox1.Text)
            {
                case "DESKTOP-S4H6C5I":
                    try
                    {
                        DateTime dataAgora = DateTime.Now;
                        string data = String.Format("{0:dd_MM_yyyy}", dataAgora);
                        string path = "d:\\" + data; //nome do diretorio a ser criado
                        if (Directory.Exists(path))
                        {
                            MessageBox.Show("Pasta de backup ja existente");
                        }
                        if (!Directory.Exists(path))
                        {
                            //Criamos um com o nome folder
                            Directory.CreateDirectory(path);
                            File.Copy(@"C:\arquivo.txt", "D:\\" + data + "\\arquivo.txt");
                            MessageBox.Show("Arquivo de calibração da jiga WFFT01 copiado");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gerar backup!");
                        }
                    }catch
                    {
                        MessageBox.Show("erro!");
                    }
                    break;
                case "WFFT02":
                    MessageBox.Show("WFFT02");
                    break;
                case "WFFT03":
                    MessageBox.Show("WFFT03");
                    break;
                case "WFFT04":
                    MessageBox.Show("WFFT04");
                    break;
                case "WFFT05":
                    MessageBox.Show("WFFT05");
                    break;
                case "WFFT06":
                    MessageBox.Show("WFFT06");
                    break;
                case "WFFT07":
                    MessageBox.Show("WFFT07");
                    break;
                case "WFFT12":
                    MessageBox.Show("WFFT12");
                    break;
                case "WFFT13":
                    MessageBox.Show("WFFT13");
                    break;
                case "WFFT15":
                    MessageBox.Show("WFFT15");
                    break;
                case "WFFT16":
                    MessageBox.Show("WFFT16");
                    break;
                case "FOQM":
                    MessageBox.Show("FOQM");
                    break;
                case "FOQM01":
                    MessageBox.Show("FOQM01");
                    break;
                case "FOQM02":
                    MessageBox.Show("FOQM02");
                    break;
                default:
                    MessageBox.Show("Selecione uma jiga valida");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (comboBox1.Text.Length > 0)
            {
                this.button1.Enabled = true;
            }
        }
    }
}
