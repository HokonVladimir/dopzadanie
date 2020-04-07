using System;
using System.IO;
using System.Windows.Forms;

namespace ATask
{
    public partial class Form1 : Form
    {
        private string[] readText;

        public Form1()
        {
            InitializeComponent();

            // Открытие файла и считывание
            button1.Click += Button1_Click;

            // Выгрузка в программу
            button2.Click += Button2_Click;

            // Обработка текста
            button3.Click += Button3_Click;

            // Сохранить
            button4.Click += Button4_Click;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string x in readText)
                {
                    File.AppendAllText(textBox5.Text, x);
                }
            }
            catch (IOException error)
            {
                textBox2.Text = error.Message;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int shortLine = readText[0].Length;
                int longLine = readText[0].Length;

                // Определение длиных и коротких
                for (int z = 0; z < readText.Length; ++z)
                {
                    if (readText[z].Length < shortLine)
                    {
                        shortLine = readText[z].Length;
                    }
                    if (readText[z].Length > longLine)
                    {
                        longLine = readText[z].Length;
                    }
                }

                // Отбрасывание длиных и коротких
                int amountAdded = 0;
                string[] bufferText = new string[readText.Length];
                for (int z = 0; z < readText.Length; ++z)
                {
                    if (readText[z].Length != shortLine &&
                        readText[z].Length != longLine)
                        bufferText[amountAdded++] = readText[z];
                }

                // Отбрасывание пустых строк
                bufferText = copy(bufferText, amountAdded);


                // Заменяет пробелы на запятые, а запятые на пробелы
                for (int z = 0; z < bufferText.Length; ++z)
                {
                    char[] buf = bufferText[z].ToCharArray();

                    for (int x = 0; x < buf.Length; x++)
                    {
                        if (buf[x] == ' ') buf[x++] = ',';
                        if (buf[x] == ',') buf[x] = ' ';
                    }

                    bufferText[z] = new string(buf);
                }

                foreach (string x in bufferText)
                {
                    textBox4.Text += (x + "\r\n");
                }

            }
            catch (IndexOutOfRangeException error)
            {
                textBox2.Text = error.Message;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Join("\r\n", readText);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                readText = File.ReadAllLines(textBox1.Text);
                textBox2.Text = "Успешно открыт!";
            }
            catch (IOException error)
            {
                textBox2.Text = error.Message;
            }
        }

        // Копирование
        private string[] copy(string[] c, int amountAdded)
        {
            string[] b = new string[amountAdded];
            for (int z = 0; z < amountAdded; ++z)
            {
                b[z] = c[z];
            }
            return b;
        }
    }
}
