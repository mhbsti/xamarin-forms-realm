using ClienteXna.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClienteXna.View
{
	public partial class Cliente : ContentPage
	{
		public Cliente ()
		{
			InitializeComponent ();

            BindingContext = new ClienteViewModel();
        }
	}
}
