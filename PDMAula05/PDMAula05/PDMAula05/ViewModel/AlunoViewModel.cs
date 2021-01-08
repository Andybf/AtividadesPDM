using System;
using System.Collections.Generic;
using System.Text;

namespace PDMAula05.ViewModel {
    public class AlunoViewModel {
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        public AlunoViewModel(Model.Aluno aluno) {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }

        public static Model.Aluno GetAluno() {
            var aluno = new Model.Aluno() {
                Id = Guid.NewGuid(),
                RM = "54621",
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com"
            };
            return aluno;

        }
    }
}
