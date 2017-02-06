using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ClienteXna.View;

namespace ClienteXna.ViewModel
{
    class MainPageViewModel
    {
        private ControleApp controle;

        public ICommand CadastroCommand { get; set; }
        public ICommand ListagemCommand { get; set; }


        public MainPageViewModel()
        {
            controle = new ControleApp();
            CadastroCommand = new Command(bt_Cadastro_Clicked);
            ListagemCommand = new Command(bt_Listagem_Clicked);
        }

        private void bt_Cadastro_Clicked(object obj)
        {
           controle.NavigationApp(new Cliente());
        }

        private void bt_Listagem_Clicked(object obj)
        {            
            controle.NavigationApp(new Listar());
        }


    }
}
