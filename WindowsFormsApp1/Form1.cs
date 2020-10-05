//Условие ввода только чисел!! строка 46

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        //Объявление рандомной переменной rnd
        private static Random rnd = new Random();

        public static int GetNumber()
        {
            //Создание рандомного числа
            int value = rnd.Next();
            return value;
        }
        //Объявление массива
        private static int[] mass;
        private void button1_Click(object sender, EventArgs e)
        {
            
            //Условие
            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) > 0)
            {
                //Обнуление label1
                label1.Text = "";

                int Enter_Number = Convert.ToInt32(textBox1.Text);

                //Создание массива
                mass = new int[Enter_Number];

                //Запись рандомных чисел в массив
                for (int i = 0; i < Enter_Number; i++)
                {
                    mass[i] = GetNumber();
                }
                // [0, 1, 2, 3];

                //Счетчик элементов массива
                int counter = 0;

                //Вывод массива в label1
                foreach (int a in mass)
                {
                    label1.Text += "[" + counter + "] " + Convert.ToString(a) + "\n";
                    counter++;
                }
            }
            else
            {
                //Предупреждение
                label1.Text = "Введите положительное число!";

            }













        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int len_mass = mass.Length;
            for (int i=0; i < len_mass; i++)
            {
                mass[i] = 0;
                label1.Text += "[" + i + "] " + mass[i].ToString() + "\n";
            }
        }
    }
}
