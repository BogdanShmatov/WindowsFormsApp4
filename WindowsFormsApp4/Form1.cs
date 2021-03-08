using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                // Получаем номер выделенной строки
                int index = listBox1.SelectedIndex;
                // Считываем строку в перменную str
                string str = (string)listBox1.Items[index];
                var result = CultureInfo.InvariantCulture.TextInfo.ToLower(str);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, result);
                Console.WriteLine(result);
                // Узнаем количество символов в строке
                int len = str.Length;
                // Считаем, что количество пробелов равно 0
                int count = 0;
                // Устанавливаем счетчик символов в 0
                int i = 0;
                //Организуем цикл перебора всех символов в строке
                while (i < len - 1)
                {
                    // Если нашли пробел, то увеличиваем
                    // счетчик пробелов на 1
                    if (str[i] == ' ')
                        count++;
                    i++;
                }
                label1.Text = "Количество пробелов = " +
                count.ToString();
                label2.Text = result;
            }
            catch (ArgumentOutOfRangeException)
            {
                label1.Text = "Для продолжения выберете строку!";
                label2.Text = "Элемент не выбран!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            { 
                int index = listBox1.SelectedIndex;
                // Считываем строку в перменную str
                string str = (string)listBox1.Items[index];
                var result = CultureInfo.InvariantCulture.TextInfo.ToUpper(str);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, result);
                label2.Text = result;
            } catch (ArgumentOutOfRangeException)
            {
                label1.Text = "Для продолжения выберете строку!";
                label2.Text = "Элемент не выбран!";
            }
}

        private void button6_Click(object sender, EventArgs e)
        { 
            try
            {
                int index = listBox1.SelectedIndex;
                // Считываем строку в перменную str
                string str = (string)listBox1.Items[index];
                var result1 = CultureInfo.InvariantCulture.TextInfo.ToLower(str);
                var result = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(result1);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, result);
                label2.Text = result;

            } catch (ArgumentOutOfRangeException)
            {
                label1.Text = "Для продолжения выберете строку!";
                label2.Text = "Элемент не выбран!";
            }
        }
    }
}
