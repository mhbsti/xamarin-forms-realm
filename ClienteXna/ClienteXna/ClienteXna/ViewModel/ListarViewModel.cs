using System;
using System.Collections.Generic;
using System.Text;
using ClienteXna.Model;
using Realms;
using System.Linq;


namespace ClienteXna.ViewModel
{
    class ListarViewModel : ViewModelBase
    {
        private ControleApp controle;

        private List<Cliente> cliente;

        public List<Cliente> Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
                Notify("Cliente");
            }
        }

        public ListarViewModel()
        {
            controle = new ControleApp();

            var realm = Realm.GetInstance();

            Cliente = realm.All<Cliente>().ToList();
        }
    }
}
