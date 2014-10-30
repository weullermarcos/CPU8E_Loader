using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//http://stackoverflow.com/questions/2426190/how-to-read-file-binary-in-c

namespace CPU8EForm
{
    public partial class CPU8E_Form : Form
    {
        OpenFileDialog openFile;

        public CPU8E_Form()
        {
            InitializeComponent();
            timerCOM.Enabled = true;

            openFile = new OpenFileDialog();

            string directory = Directory.GetCurrentDirectory();

            if (Directory.Exists(directory + "\\" + "binarios"))
            {
                openFile.InitialDirectory = (directory + "\\" + "binarios");
            }
            else 
            {
                openFile.InitialDirectory = directory;
            }

            openFile.Filter = "Arquivos de Comandos (*.bin)|*.bin" + "|" + "Todos os Arquivos (*.*)|*.*";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;
        }

        private void btnReadConfigurations_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtCommand.Text = openFile.FileName;

                byte[] fileBytes = File.ReadAllBytes(openFile.FileName);

                string aux="";
                for (int i = 0; i < fileBytes.Length; i++ )
                {
                    if (fileBytes[i] < 16)
                    {
                        aux = "0" + fileBytes[i].ToString("X");
                    }
                    else 
                    {
                        aux = fileBytes[i].ToString("X");
                    }

                    txtContent.Text += aux + " ";

                }
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) //porta está aberta
            {
                string aux = txtContent.Text.Replace(" ", "");
                serialPort1.Write(aux);  //envia o texto presente no textbox

                serialPort1.Close();
                disableButtons();
                cbxCOM.Enabled = true;
                btnConnect.Text = "Conectar";

                System.Windows.Forms.MessageBox.Show("Dados enviados com sucesso", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("A porta serial não está aberta", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;
            
            //se a quantidade de portas mudou
            if (cbxCOM.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbxCOM.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            cbxCOM.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cbxCOM.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cbxCOM.SelectedIndex = 0;
        }

        private void CPU8E_Form_Load(object sender, EventArgs e)
        {
            //string directory = Directory.GetCurrentDirectory() + "\\" + "binarios";

            //if (!Directory.Exists(directory))
            //{
            //    Directory.CreateDirectory(directory + "\\" + "binarios");
            //}

            disableButtons();
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    if (cbxCOM.Items.Count > 0)
                    {
                        serialPort1.PortName = cbxCOM.Items[cbxCOM.SelectedIndex].ToString();
                        serialPort1.Open();
                    }
                    else 
                    {
                        System.Windows.Forms.MessageBox.Show("Selecione uma porta COM", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception ex)
                {
                    return;
                    throw new Exception("Erro: " + ex.Message);
                }
                if (serialPort1.IsOpen)
                {
                    btnConnect.Text = "Desconectar";
                    enableButtons();
                    cbxCOM.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    disableButtons();
                    cbxCOM.Enabled = true;
                    btnConnect.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void CPU8E_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();            //fecha a porta
        }

        private void enableButtons() 
        {
            btnExec.Enabled = true;
            btnReadConfigurations.Enabled = true;
        }
        private void disableButtons()
        {
            btnExec.Enabled = false;
            btnReadConfigurations.Enabled = false;
        }
    }
}
