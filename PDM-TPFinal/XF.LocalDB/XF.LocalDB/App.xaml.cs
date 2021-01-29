using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF.LocalDB.ViewModel;

namespace XF.LocalDB
{
	public partial class App : Application
	{
		public App() { // The root page of your application
			MainPage = new NavigationPage(new View.Livro.MainPage());
		}
		static Model.Livro livroModel;
		public static Model.Livro LivroModel {
			get {
				if (livroModel == null) {
					livroModel = new Model.Livro();
				} return livroModel;
			}
		}
	}
}
