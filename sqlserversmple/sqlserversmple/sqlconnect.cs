using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;



namespace CRUD_console

{

    class sqlconnect: IDisposable
    {

        private SqlConnection connection;
        

        public sqlconnect(string shohin_id, string shohin_mei, string shohin_bunrui, int hanbai_tanka, int shiire_tanka)//.gitignore設定要
        {

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // 接続先の SQL Server インスタンス
                builder.UserID = "sa";              // 接続ユーザー名
                builder.Password = "9232Pascokh"; // 接続パスワード
                builder.InitialCatalog = "master";  // 接続するデータベース(ここは変えないでください)
                // SQL Server に接続
                Console.Write("SQL Server に接続しています... ");
                Console.WriteLine("接続成功。");

                this.connection = new SqlConnection(builder.ConnectionString);
                this.connection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void Dispose()
        {
            this.connection.Close();
        }
       
        public void read()
        {
            // READ デモ
            Console.WriteLine("テーブルからデータを読み取り中です。任意のキーを押して処理を続行します。...");

            Console.ReadKey(true);

            //string sql = "SELECT shohin_id, shohin_bunrui, shohin_mei FROM ShohinIns;";
            string sql = "SELECT * FROM ShohinIns;";
            using (SqlCommand command = new SqlCommand(sql, this.connection))
            {
               
                //Console.Write("ass");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}   ", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));

                    }
                }
                
            }
            /* try
             {
                 using (SqlConnection connection = new SqlConnection(cntstr))
                 {
                     connection.Open();
                     using (SqlCommand command = new SqlCommand(sql, connection))
                     {
                         //command.ExecuteNonQuery();
                         using (SqlDataReader reader = command.ExecuteReader())
                         {
                             while (reader.Read())
                             {
                                 Console.WriteLine($"{reader.GetString(0)}{reader.GetString(1)}");
                             }
                         }
                     }
                 }
             }
             catch (SqlException e)
             {
                 Console.WriteLine(e.ToString());
             }
             */
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
        
        public void Execute(string sql)
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