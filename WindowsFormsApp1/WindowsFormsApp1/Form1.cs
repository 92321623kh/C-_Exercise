using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CRUD_console;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        sqlconnect con = new sqlconnect("0001", "Tシャツ", "衣服", 1000, 500);
        public Form1()
        {
            InitializeComponent();

           
        }
        private void dataGridView2_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                //データグリッドビューで選択された値をテキストボックスに格納
                this.textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                this.textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                this.textBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                this.textBox6.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                this.textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shohin_id = this.textBox20.Text;
            string shohin_mei = this.textBox22.Text;
            string shohin_bunrui = this.textBox19.Text;
            int hanbai_tanka = int.Parse(this.textBox23.Text);
            int shiire_tanka = int.Parse(this.textBox21.Text);
            string torokubi = this.textBox24.Text;

            con.Insert(shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka, torokubi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string shohin_id = this.textBox3.Text;
            string shohin_mei = this.textBox2.Text;
            string shohin_bunrui = this.textBox1.Text;
            int hanbai_tanka = int.Parse(this.textBox6.Text);
            int shiire_tanka = int.Parse(this.textBox5.Text);                                    
            
            //テキストボックスに入力されたデータを渡す
            con.Update(shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka);                            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //データグリッドビューの選択されている行の列の値取得
            string shohin_id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            con.Delete(shohin_id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<object[]> a = con.read();

            dataGridView2.ColumnCount = 6;
            dataGridView2.RowCount = a.Count;

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dataGridView2[j, i].Value = a[i][j];
                }

            }
        }

        //Insertボタン
        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        //Updateボタン
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //テキストの値が変更されたら実行

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
                                                           
    


    

