using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANDOM
{
    public partial class Form1 : Form
    {
        int chute;
        int i;
        int tentativas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            i = random.Next(0, 11);

            label1.Text = "Número de Tentativas: " + tentativas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                while (chute != i)
                {
                    tentativas++;
                    chute = Convert.ToInt32(textBox2.Text);

                    if (chute == i)
                    {
                        label1.Text = "Número de Tentativas " + tentativas;
                        MessageBox.Show("Parabéns, o Número Escolhido foi acertado, você acertou ele com  " + tentativas + " tentativas, era o número " + i); //botar o numero de tentativas, e botar o numero que seja igual da maquina 
                        Application.Exit();
                    }
                    else
                    {
                        label1.Text = "Número de Tentativas: " + tentativas;
                        MessageBox.Show("Você errou, tente outra vez");
                    }
                    textBox2.Clear();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro, insira algum número para poder continuar o jogo ");
            }
            }
        }
    }

