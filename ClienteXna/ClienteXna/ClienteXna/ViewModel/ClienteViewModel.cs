using Realms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ClienteXna.Model;
using System.Linq;

namespace ClienteXna.ViewModel
{
    class ClienteViewModel : ViewModelBase
    {
        private ControleApp _controle;
        private Realm _realm;

        private string txtNome;
        private string txtCidade;

        public ICommand SalvarCommand { get; set; }

        public string TxtNome
        {
            get
            {
                return txtNome;
            }

            set
            {
                txtNome = value;
                Notify("TxtNome");
            }
        }

        public string TxtCidade
        {
            get
            {
                return txtCidade;
            }

            set
            {
                txtCidade = value;
                Notify("TxtCidade");
            }
        }

        public ClienteViewModel()
        {
            _controle = new ControleApp();            

            SalvarCommand = new Command(bt_Salvar_Clicked);
        }

        private void bt_Salvar_Clicked(object obj)
        {
            string msg;

            _realm = Realm.GetInstance();

            using (var transaction = _realm.BeginWrite())
            {
                var cliente = _realm.CreateObject<Cliente>();
                cliente.Nome = TxtNome;
                cliente.Cidade = TxtCidade;
                
                transaction.Commit();
            }

            msg = "Temos : " + _realm.All<Cliente>().Count() + " Clientes";

            _realm.Close();

            _controle.Message(msg);
        }
    }
}
