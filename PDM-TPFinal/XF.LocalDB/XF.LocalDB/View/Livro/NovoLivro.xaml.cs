using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.LocalDB.View.Livro {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoLivro : ContentPage {

        private int livroId = 0;
        public NovoLivro() {
            InitializeComponent();
        }

        public NovoLivro(Model.Livro livro) {
            InitializeComponent();
            txtNome.Text = livro.NomeLivro;
            txtAutor.Text = livro.NomeAutor;
            txtEmail.Text = livro.Email;
            txtIsbn.Text = livro.ISBN.ToString();
            livroId = livro.Id;
        }

        public NovoLivro(int Id) {
            InitializeComponent();
            var livro = App.LivroModel.GetLivro(Id);
            txtNome.Text = livro.NomeLivro;
            txtAutor.Text = livro.NomeAutor;
            txtEmail.Text = livro.Email;
            txtIsbn.Text = livro.Email;
            livroId = livro.Id;
        }
        public void OnSalvar(object sender, EventArgs args) {
            XF.LocalDB.Model.Livro livro = new XF.LocalDB.Model.Livro() {
                NomeLivro = txtNome.Text,
                NomeAutor = txtAutor.Text,
                Email = txtEmail.Text,
                ISBN = Int32.Parse(txtIsbn.Text),
                Id = livroId
            };
            Limpar();
            App.LivroModel.SalvarLivro(livro);
            
            Navigation.PopAsync();
        }

        public void Remover(object sender, EventArgs args) {
            Limpar();
            Navigation.PopAsync();
        }

        public void OnCancelar(object sender, EventArgs args) {
            Limpar();
            Navigation.PopAsync();
        }
        private void Limpar() {
            txtNome.Text = txtAutor.Text = txtEmail.Text = string.Empty;
        }
    }
}