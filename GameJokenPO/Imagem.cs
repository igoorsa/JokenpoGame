using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameJokenPO
{
    internal class Jokenpo
    {
        
        
        


        public List<Image> imgFormas = new List<Image>()
        {
            {Image.FromFile("img/pedra.png") },
            {Image.FromFile("img/papel.png") },
            {Image.FromFile("img/tesoura.png") }
        };

        public static int numeroJogado { get; set; }
        public int[] numeros = new int[3] { 0, 1, 2 };

        public static int numeroGanhador;
        
        public void Jogar(int numSorteado)
        {
            Thread.Sleep(100);

            if(numeroJogado== 0)
            {
                if(numeroJogado == numSorteado)
                {
                    numeroGanhador = 0;
                }
                else if (numSorteado == 1)
                {
                    numeroGanhador = -1;
                }
                else
                {
                    numeroGanhador = 1;
                }
            }

            if(numeroJogado == 1)
            {
                if (numeroJogado == numSorteado)
                {
                    numeroGanhador = 0;
                }
                else if (numSorteado == 2)
                {
                    numeroGanhador = -1;
                }
                else
                {
                    numeroGanhador = 1;
                }
            }
            if (numeroJogado == 2)
            {
                if (numeroJogado == numSorteado)
                {
                    numeroGanhador = 0;
                }
                else if (numSorteado == 0)
                {
                    numeroGanhador = -1;
                }
                else
                {
                    numeroGanhador = 1;
                    
                }
            }
            
        
        }

        
    }
}
