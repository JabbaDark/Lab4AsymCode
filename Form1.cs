using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assym
{
    public partial class Form1 : Form
    {
        Random rand = new Random();// функция под рандом
        int p_num, q_num, n_num, Fe_num, e_num, d_num;

        private void Decode_Click(object sender, EventArgs e)// декодирование сообщения
        {
            if (p_num == 0) return;
            List<byte> bytes = new List<byte>();// массив в виде листа
            foreach (var item in Output.Items)// для каждого элемента в листбоксе Output
            {
                bytes.Add((byte)FastPower((int)item, d_num));//добавляется результат возведения в степень по модулю в лист bytes
            }
            Input.Text = Encoding.UTF8.GetString(bytes.ToArray());// переводим в формат UTF8 и выводим в окно Input
            Output.Items.Clear();// очищаем листбокс Output
        }

        private void Code_Click(object sender, EventArgs e)// кодирвоание сообщения
        {
            if (p_num == 0) return;
            Output.Items.Clear();// очищаем листбокс Output
            var bytes = Encoding.UTF8.GetBytes(Input.Text);// переводим в массив байтов текст из окна Input
            foreach (var b in bytes)// для каждого элемента в массиве bytes
            {
                Output.Items.Add(FastPower(b, e_num));// добавляем в листбокс Output новый элемент
            }
            Input.Text = string.Empty;// очщаем текстовое окно Input
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Params_Click(object sender, EventArgs e)// рассчет параметров
        {
            p_num = GeneratePrimeNumber(rand.Next(15, 100));// поиск простого числа, начиная от случайного
            q_num = GeneratePrimeNumber(rand.Next(15, 100));
            n_num = p_num * q_num;// условно значение p
            Fe_num = (p_num - 1) * (q_num - 1);// функция Эйлера
            for (int i = Fe_num - 1; i > 0; i--)//определение числа е, части открытого ключа (открытый ключ - e*n)
            {
                if (IsPrime(i) && Fe_num % i != 0)
                {
                    e_num = i;
                    break;
                }
            }
            for (int i = 1; ; i++)// определение числа d, части закрытого ключа (закрытый ключ - d*n)
            {
                if ((i * e_num) % Fe_num == 1 && i != e_num)
                {
                    d_num = i;
                    break;
                }
            }
            p.Text = p_num.ToString();
            q.Text = q_num.ToString();
            n.Text = n_num.ToString();
            Fe.Text = Fe_num.ToString();
            en.Text = e_num.ToString();
            d.Text = d_num.ToString();
        }
        int GeneratePrimeNumber(int lessthen)// проверка на простое число
        {
            for (int i = lessthen - 1; i > 0; i--)
            {
                if (IsPrime(i)) return i;
            }
            return 1;
        }

        bool IsPrime(int number)// генерация простого числа
        {
            if (number < 3) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        int FastPower(int a, int x)// быстрое возведение в степень
        {
            int result = 1;
            int tmp = a % n_num;
            while (x > 0)
            {
                if (x % 2 != 0) result = (result * tmp) % n_num;
                tmp = (tmp * tmp) % n_num;
                x /= 2;
            }
            return result;
        }
    }
}
