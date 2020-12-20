using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labr;

namespace soldat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void nudKol_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(nudKol.Value);
            table.RowCount = Convert.ToInt32(nudKo2.Value);
            textBox1.Clear();
            for (int i = 0; i < table.ColumnCount; i++) table[i, 0].Value = "";
            for (int j = 0; j < table.RowCount; j++) table[j, 0].Value = "";
        }

        private void nudKo2_ValueChanged(object sender, EventArgs e)
        {
            table.RowCount = Convert.ToInt32(nudKol.Value);
            textBox1.Clear();
            for (int j = 0; j < table.RowCount; j++) table[j, 0].Value = "";
        }

        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Таблица_Enter(object sender, EventArgs e)
        {
            table.ColumnCount = 5; //кол-во столбцов
            table.RowCount = 5; //кол-во строк
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //создаем объект рандом для генерации случайный значений
            //заполняем таблицу значениями
            for (int i = 0; i < table.ColumnCount; i++) table[i, 0].Value = rand.Next(Convert.ToInt32(nudValue.Value));
            for (int j = 0; j < table.RowCount; j++) table[j, 0].Value = rand.Next(Convert.ToInt32(nudValue.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //возвращаем начальные значения
            table.ColumnCount = 5;
            table.RowCount = 5;
            nudKol.Value = 5;
            nudKo2.Value = 5;
            nudValue.Value = 10;
            //очищаем поле вывода и заполяем массив "ничем"
            textBox1.Clear();
            for (int i = 0; i < table.ColumnCount; i++) table[i, 0].Value = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int proiz;
            proiz = labr.Сlass1.Practos(table);
            textBox1.Text = proiz.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 2\n" +
            "Ввести n целых чисел(>0 или <0). Найти произведение чисел. Результат вывести на экран.\n" +
            "Солдатова Анастасия ИСП-31");
        }
    }
}
