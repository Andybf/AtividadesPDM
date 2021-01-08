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
			MainPage = new NavigationPage(new View.Aluno.MainPage());
		}
		static Model.Aluno alunoModel;
		public static Model.Aluno AlunoModel {
			get {
				if (alunoModel == null) {
					alunoModel = new Model.Aluno();
				} return alunoModel;
			}
		}
	}
}
