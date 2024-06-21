using Jokenpo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jokenpo.ViewModels
{
    public partial class JokenpoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string escolha;

        [ObservableProperty]
        private int jogadorPontuacao = 0;

        [ObservableProperty]
        private int botPontuacao = 0;        

        [ObservableProperty]
        private string resultado;        
            
        public ICommand JogarCommand { get; set; }

        public JokenpoViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            Jogador jogador = new Jogador();
            jogador.Jogar();
            int valor = 0;

            if (Escolha == "Papel")            
                valor = 1;
            if (Escolha == "Tesoura")
                valor = 2;

            if (valor == jogador.GestoNumerico)
            {
                Resultado = "Empate";
            }
            if (valor > jogador.GestoNumerico)
            {
                Resultado = "Ganhou";
                JogadorPontuacao++;
            }
            if (valor < jogador.GestoNumerico) 
            {
                Resultado = "Perdeu";
                BotPontuacao++;
            }

            if (JogadorPontuacao == 10)
            {
                Resultado = "Jogador Venceu";
            }
            if (BotPontuacao == 10)
            {
                Resultado = "Bot Venceu";
            }
        }
    }
}
