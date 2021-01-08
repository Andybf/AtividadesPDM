using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using XF.LocalDB;
using XF.LocalDB.Android;
using XF.LocalDB.Data;
using System.IO;
using Xamarin.Forms;
using SQLitePCL;

[assembly: Dependency(typeof(SQLite_Android))]
namespace XF.LocalDB.Android {
    public class SQLite_Android : Data.ISQLite {
        public SQLite_Android() {
        }
        public SQLite.SQLiteConnection GetConexao() {
            var arquivodb = "ifspdb.db3";
            string caminho = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var local = Path.Combine(caminho, arquivodb);
            var conexao = new SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}