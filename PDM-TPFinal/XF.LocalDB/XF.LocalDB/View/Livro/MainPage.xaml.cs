using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.ViewModel;

namespace XF.LocalDB.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage {

        LivroViewModel vmLivro;
        public MainPage() {
            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;
            InitializeComponent();
        }

        protected override void OnAppearing() {
            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args) {
            Navigation.PushAsync(new Livro.NovoLivro());
        }
        private async Task OnLivroTapped(object sender, ItemTappedEventArgs args) {
            Model.Livro selecionado = args.Item as XF.LocalDB.Model.Livro;
            String action = await DisplayActionSheet("Livro selecionado", "Ok", null, "Editar", "Deletar");
            //DisplayAlert(action, "", "Ok");
            if (action.Equals("Editar")) {
                Navigation.PushAsync(new Livro.NovoLivro(selecionado));
            } else if (action.Equals("Deletar")) {
                Navigation.PushAsync(new Livro.NovoLivro(selecionado));
                App.LivroModel.RemoverLivro(selecionado.Id);
                Navigation.PopAsync();
            }
        }
    }
}
