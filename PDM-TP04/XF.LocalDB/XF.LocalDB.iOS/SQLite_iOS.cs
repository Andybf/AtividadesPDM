using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XF.LocalDB.iOS;

using Xamarin.Forms;
using XF.LocalDB.Data;
using SQLitePCL;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace XF.LocalDB.iOS {
    public class SQLite_iOS : sqlite3 {
        public SQLite_iOS() {
        }
        public SQLite.SQLiteConnection GetConexao() {
            var arquivodb = "ifspdb.db3";
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string bibliotecaPessoal = Path.Combine(caminho, "..", "Library");
            var local = Path.Combine(bibliotecaPessoal, arquivodb);
            var conexao = new SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}
