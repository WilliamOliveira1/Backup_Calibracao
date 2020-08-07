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

        public void createBackup()
        {
            try
            {
                DateTime dataAgora = DateTime.Now;
                string data = String.Format("{0:dd_MM_yyyy}", dataAgora);
                string path = "D:\\" + nomeComputador + "\\" + data; //nome do diretorio a ser criado
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Pasta de backup ja existente");
                }
                if (!Directory.Exists(path))
                {
                    string curFile = @"c:\arquivo.txt";
                    if (File.Exists(curFile))
                    {
                        //Criamos um com o nome folder
                        Directory.CreateDirectory(path);
                        File.Copy(@"C:\arquivo.txt", "D:\\" + nomeComputador + "\\" + data + "\\pathloss.csv");
                        MessageBox.Show("Arquivo de calibração da jiga WFFT01 copiado");
                    }
                    else
                    {
                        MessageBox.Show("não existe arquivo pathloss.csv no diretório D:\\");
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao gerar backup!");
                }
            }
            catch (FileNotFoundException ex)
            {
                string ex1 = ex.ToString();
                MessageBox.Show("Arquivo não localizado ou não existente!\n"+ex1);
            }
        }
        

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
                    createBackup();
                    break;
                case "WFFT02":

                    break;
                case "WFFT03":
                    createBackup();
                    break;
                case "WFFT04":
                    createBackup();
                    break;
                case "WFFT05":
                    createBackup();
                    break;
                case "WFFT06":
                    createBackup();
                    break;
                case "WFFT07":
                    createBackup();
                    break;
                case "WFFT12":
                    createBackup();
                    break;
                case "WFFT13":
                    createBackup();
                    break;
                case "WFFT15":
                    createBackup();
                    break;
                case "WFFT16":
                    createBackup();
                    break;
                case "FOQM":
                    createBackup();
                    break;
                case "FOQM01":
                    createBackup();
                    break;
                case "FOQM02":
                    createBackup();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
