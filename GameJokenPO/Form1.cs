using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameJokenPO
{
    public partial class Form1 : Form
    {
        private double result = 1000;
        public Form1()
        {
            InitializeComponent();
            Resultado.Text = $"{result:C}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Jokenpo imagens= new Jokenpo();
            pictureYou.BackgroundImage = imagens.imgFormas[0];

            Jokenpo.numeroJogado = 0;

        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jokenpo imagens = new Jokenpo();
            pictureYou.BackgroundImage = imagens.imgFormas[1];


            Jokenpo.numeroJogado = 1;
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jokenpo imagens = new Jokenpo();
            pictureYou.BackgroundImage = imagens.imgFormas[2];


            Jokenpo.numeroJogado = 2;
        }

        private void btnJOGAR_Click_1(object sender, EventArgs e)
        {
            
            Jokenpo jogar = new Jokenpo();

            Random random = new Random();

            int numSorteado = random.Next(jogar.numeros.Length);

            var ttask = Task.Run(async () => {
                int a = 0;
                for (int i =0;i<20 ;i++ )
                {
                    await Task.Delay(60);
                    pictureBox2.BackgroundImage = jogar.imgFormas[a];
                    if (a == 2)
                    {
                        a = 0;
                    }
                    else
                    {
                        a++;
                    }
                }
                pictureBox2.BackgroundImage = jogar.imgFormas[numSorteado];
                jogar.Jogar(numSorteado);

                if (Jokenpo.numeroGanhador == 0)
                {
                    DialogResult res =  MessageBox.Show("VOCÊ EMPATOU", "Você:", MessageBoxButtons.OK);
                    if(res == DialogResult.OK)
                    {
                        double aposta = ((double)Aposta.Value);
                    }
                    
                }
                else if(Jokenpo.numeroGanhador > 0)
                {
                    DialogResult res = MessageBox.Show("VOCÊ GANHOU", "Você:", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        double aposta = ((double)Aposta.Value);
                        result += aposta;
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("VOCÊ PERDEU", "Você:", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        double aposta = ((double)Aposta.Value);
                        result -= aposta;
                    }

                }
                
            });
            

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Resultado.Text = $"{result:C}"; 
        }
    }
}
