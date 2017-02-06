using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClienteXna
{
    class ControleApp
    {
        /// <summary>
        /// Retorna uma mensagem
        /// </summary>
        /// <param name="msg"></param>
        public void Message(string msg)
        {
            App.Current.MainPage.DisplayAlert("Aviso:", msg, "Ok");
        }

        /// <summary>
        /// carrega a pagina especificada por parametro.
        /// </summary>
        /// <param name="page"></param>
        public async void NavigationApp(Page page)
        {
            await App.Current.MainPage.Navigation.PushAsync(page, true);
        }
    }
}
