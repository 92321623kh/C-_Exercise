using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CRUD_console
{
    class Program
    {
        static void Main(string[] args)

        {

            using (sqlconnect con = new sqlconnect("0001", "Tシャツ", "衣服", 1000, 500))
            {                
                con.read();
                con.Insert("0010", "スプーン", "食器", 3000, 340, "2020-08-24");
                con.Update("0010", "セロリ", "食事", 222000, 300);
                con.Delete("0009");

                Console.WriteLine("全て完了しました。任意のキーを押して終了します...");
                Console.ReadKey(true);
            }            
        }

    }

}