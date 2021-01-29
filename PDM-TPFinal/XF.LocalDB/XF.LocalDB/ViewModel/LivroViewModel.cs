using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF.LocalDB.Model;

namespace XF.LocalDB.ViewModel {
    class LivroViewModel {

        public LivroViewModel() {
        }

        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Model.Livro> Livros {
            get {
                return App.LivroModel.GetLivros().ToList();
            }
        }
        #endregion
    }
}
