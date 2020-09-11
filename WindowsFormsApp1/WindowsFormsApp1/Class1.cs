using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace CRUD_console
{

    class sqlconnect : IDisposable
    {

        private SqlConnection connection;

        

        public sqlconnect(string shohin_id, string shohin_mei, string shohin_bunrui, int hanbai_tanka, int shiire_tanka)//.gitignore設定要
        {   //接続用
            //sqlconnect con = new sqlconnect(("0001", "Tシャツ", "衣服", 1000, 500));
            try
            {
                string db = ConfigurationManager.ConnectionStrings["DB1"].ToString();

               // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();


                /*
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // 接続先の SQL Server インスタンス
                builder.UserID = "sa";              // 接続ユーザー名
                builder.Password = "9232Pascokh"; // 接続パスワード
                builder.InitialCatalog = "master";  // 接続するデータベース(ここは変えないでください)
                // SQL Server に接続
                Console.Write("SQL Server に接続しています... ");
                Console.WriteLine("接続成功。");\\
                */
                //this.connection = new SqlConnection(builder.ConnectionString);
                this.connection = new SqlConnection(db);

                this.connection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public DataTable Csvsql(string filepath)
        {
             filepath = "C:\\Users\007287\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\csv";
            DataTable dt = new DataTable("ShohinIns");
            string csvDir = Path.GetDirectoryName(filepath);
            string csvFileName = Path.GetFileName(filepath);

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                    + csvDir + ";Extended Properties=\"text;HDR=Yes;FMT=Delimited\"";
            this.connection = new SqlConnection(connectionString);
            //OleDbConnection con = new OleDbConnection(connectionString);

            //csvファイルから取得
            string commText = "SELECT * FROM [" + csvFileName + "]";
            OleDbDataAdapter da = new OleDbDataAdapter(commText, connectionString);

            da.Fill(dt);

            return dt;

        }
        
        public void Dispose()
        {
            this.connection.Close();
        }
        

        public List<object[]> read()
        {
            // READ デモ
            Console.WriteLine("テーブルからデータを読み取り中です。任意のキーを押して処理を続行します。...");

            //Console.ReadKey(true);

            //string sql = "SELECT shohin_id, shohin_bunrui, shohin_mei FROM ShohinIns;";
            string sql = "SELECT * FROM ShohinIns;";

            List<object[]> a = new List<object[]>();

            using (SqlCommand command = new SqlCommand(sql, this.connection))
            {

                //readerにはsqlの実行結果入ってる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //
                    while (reader.Read())
                    {
                       
                        object[] hairetsu = new object[6];

                        //配列に8レコード挿入
                        hairetsu[0] = reader.GetString(0);
                        hairetsu[1] = reader.GetString(1);
                        hairetsu[2] = reader.GetString(2);
                        hairetsu[3] = reader.GetInt32(3);
                        hairetsu[4] = reader.GetInt32(4);
                        hairetsu[5] = reader.GetDateTime(5);

                        a.Add(hairetsu);
                        
                        //   Console.WriteLine("{0} {1} {2} {3} {4}   ", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));

                    }
                }

            }
            return a;
        }

        public void Insert(string shohin_id, string shohin_mei, string shohin_bunrui, int hanbai_tanka, int shiire_tanka, string torokubi)
        {
            StringBuilder sb = new StringBuilder();
            //sql文
            sb.Append($"USE master;");
            sb.Append($"INSERT INTO ShohinIns VALUES ('{shohin_id}', '{shohin_mei}', '{shohin_bunrui}' , {hanbai_tanka}, {shiire_tanka}, '{torokubi}');");
            string sql = sb.ToString();
            Execute(sql);

            //Console.WriteLine("データを登録しました。");
        }

        public void Update(string shohin_id, string shohin_mei, string shohin_bunrui, int hanbai_tanka, int shiire_tanka)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"USE master;");
            sb.Append($"UPDATE ShohinIns SET shohin_mei = '{shohin_mei}' ,shohin_bunrui = '{shohin_bunrui}' ,hanbai_tanka = '{hanbai_tanka}' ,shiire_tanka = '{shiire_tanka}' WHERE shohin_id = '{shohin_id}'");
            string sql = sb.ToString();
            Execute(sql);
            //Console.WriteLine($"データを更新しました。");

        }

        public void Delete(string shohin_id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"USE master;");
            sb.Append($"DELETE FROM ShohinIns WHERE shohin_id = '{shohin_id}'");
            string sql = sb.ToString();
            Execute(sql);
            //Console.WriteLine("データを削除しました。");

        }

        public void Execute(string sql)//sql文実行
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

}