using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Jogador
    {        
        public string GestoAdversario { get; set; }
        public int GestoNumerico {  get; set; }

        public string Jogar()
        {
            GestoNumerico = new Random().Next(3);
            if (GestoNumerico == 0)
            {
                GestoAdversario = "Pedra";
            }
            if (GestoNumerico == 1) 
            {
                GestoAdversario = "Papel";
            }
            if (GestoNumerico == 2)
            {
                GestoAdversario = "Tesoura";
            }
            return GestoAdversario;
        }
    }
}
