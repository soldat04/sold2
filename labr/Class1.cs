using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace labr
{

    public class Сlass1
    {
        public static int Practos(DataGridView table)
        {
            int proiz = 1;
            // просматриваем элементы таблицы
            for (int i = 0; i < table.ColumnCount; i++)
            {
                // если таблица не пуста
                if (Int32.TryParse(Convert.ToString(table[i, 0].Value), out int dop) == true) //Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
                {
                    // Элемент массива не должен быть равен 0. Если он будет равен нулю, то программа не учитывает это число
                    if (dop != 0)
                    {
                        //считаем произведение
                        proiz = proiz * dop;
                    }
                }
                else
                {
                    // иначе выводим подсказку
                    MessageBox.Show("Неверный ввод");
                    // сбрасываем значение произведения чтобы не выводить его
                    proiz = 1;
                    break;
                }
            }
            // если произведение удалось посчитать (т.е. если массив не было ошибки конвертации), то выводим результат
            return proiz;
        }   
    }
   

}
    

