using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.LocalDB.Data;

namespace XF.LocalDB.Model {
    public class Livro {
        
        public Livro() {
            database = DependencyService.Get<Data.ISQLite>().GetConexao();
            database.CreateTable<Livro>();
        }

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public string Email { get; set; }
        public int ISBN { get; set; }

        #endregion
        #region Livro Local Database

        private SQLiteConnection database;
        static object locker = new object();
        public int SalvarLivro(Livro livro) {
            lock (locker) {
                if (livro.Id != 0) {
                    database.Update(livro);
                    return livro.Id;
                } else {
                    return database.Insert(livro);
                }
            }
        }
        public IEnumerable<Livro> GetLivros() {
            lock (locker) {
                return (from c in database.Table<Livro>() select c).ToList();
            }
        }

        public Livro GetLivro(int Id) {
            lock (locker) { // return database.Query< Livro>("SELECT * FROM [Aluno] WHERE [Id] = " + Id);
                return database.Table<Livro>().Where(c => c.Id == Id).FirstOrDefault();
            }
        }

        public int RemoverLivro(int Id) {
            lock (locker) {
                return database.Delete<Livro>(Id);
            }
        }
        #endregion
    }
}
