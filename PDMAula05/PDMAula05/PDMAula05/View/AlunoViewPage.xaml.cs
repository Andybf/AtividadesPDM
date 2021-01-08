using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMAula05.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoViewPage : ContentPage {

        ViewModel.AlunoViewModel vmAluno;
        public AlunoViewPage() {
            var aluno = ViewModel.AlunoViewModel.GetAluno();
            vmAluno = new ViewModel.AlunoViewModel(aluno);
            BindingContext = vmAluno;
            InitializeComponent();
        }
    }
}