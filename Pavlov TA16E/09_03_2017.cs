using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pavlov_TA16E
{
    public partial class PA_09_03_2017 : Form
    {

        public PA_09_03_2017()
        {
            InitializeComponent();
        }

        private void PA_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // закрыть эту форму
        }

        private void PA_btnLoeFile_Click(object sender, EventArgs e)
        {
            PA_openfileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_openfileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openfileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_openfileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            if (filenimi == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            PA_ListBox1.Items.Clear();
            StreamReader sr = new StreamReader(filenimi);//filenimi - пусть к текстовому фаилу
            string text;
            int n1 = 0, n2 = 0;

            while ((text = sr.ReadLine()) != null) //если фаил не пуст добавить текс из фаила в переменную text
            {
                PA_ListBox1.Items.Add(text);//записать текст из фаила в листбокс
                n1++;
                n2 += text.Length;
            }
            PA_lbl1.Text = " Ridu on " + n1.ToString() + " Teksti pikkus on " + n2.ToString();
            sr.Close();//закрыть StreamReader!!!!! обязательно
        }

        private void PA_09_03_2017_Load(object sender, EventArgs e)
        {

        }

        private void PA_btnlisa_Click(object sender, EventArgs e)
        {
            if (PA_ListBox1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Valitud > kui 1 element");
                return;//остановить если выбрано больше чем один элемент
            }
            int rn = PA_ListBox1.SelectedIndex;
            if (rn == -1)//если не вабрано не одного элемента добавить в конец 
            {
                PA_ListBox1.Items.Add(PA_xtxbox1.Text);
            }
            else
            {
                PA_ListBox1.Items.Insert(rn, PA_xtxbox1.Text);//если выделен элемент добавить на одну строку выше
            }
            PA_ListBox1.SelectedIndex = -1;//снять выделение
            PA_xtxbox1.Clear();//очистить форму для ввода текста
            // AP_Txt1.Text = "";
            PA_xtxbox1.Focus();//фокус на текстовое поле
        }

        private void PA_btnkustutada_Click(object sender, EventArgs e)
        {
            string tekst = "soovite kustutada: " + (char)(13) + (char)(13); // (char)(13)  сделать вниз отступ в 13 пикселей
            for (int i = 0; i < PA_ListBox1.Items.Count; i++)
            {

                if (PA_ListBox1.GetSelected(i))
                    tekst = tekst + PA_ListBox1.Items[i] + (char)(13);
            }
            DialogResult vastus = MessageBox.Show(tekst, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.No)
            {
                return;//остановить при отрицательном ответе
            }
            else
            {


                while (PA_ListBox1.SelectedItems.Count > 0)//удалять элементы пока не останится не одного выделенного элемента
                {
                    PA_ListBox1.Items.Remove(PA_ListBox1.SelectedItem);
                }

            }
        }

        private void PA_btnmuuda_Click(object sender, EventArgs e)
        {
            if (PA_ListBox1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Valitud > kui 1 element");
                return;//остановить если выбрано больше чем один элемент
            }

            int rn = PA_ListBox1.SelectedIndex;
            if (rn == -1)
            {
                MessageBox.Show("Valik puudub");
                return;//остановить если не выбрано не одного элемента
            }

            string tekst = "soovite muutuda:" + (char)(13) + PA_ListBox1.Items[rn] + (char)(13) + "sellega: " + (char)(13) + PA_xtxbox1.Text;//+AP_lb1.SelectedItem
            DialogResult vastus = MessageBox.Show(tekst, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.No)
            {
                return;//остановить если ответ отридцательный
            }
            else
            {
                PA_ListBox1.Items[rn] = PA_xtxbox1.Text;//AP_lb1.SelectedItem = AP_Txt1.Text;   заменить выбранный элемент на введунный в текст бокс
                PA_ListBox1.SelectedIndex = -1;//убрать выделение

            }
        }

        private void PA_tuhikud_Click(object sender, EventArgs e)
        {
            for (int rn = 0; rn < PA_ListBox1.Items.Count; rn++) //пройти весть текст в лист боксе
            {
                string t = PA_ListBox1.Items[rn].ToString();// t масств с тестом
                t = t.Trim(); //обрезать все пробелы в начале и в конце текста
                string tt = ""; //новй масств куда будут записыватся результаты 
                if (t.Length > 0)//если массив не пуст
                {
                    tt = t.Substring(0, 1);//придать tt значение (начиная с элемента в массиве t, количество элементов 1)
                    for (int i = 1; i < t.Length; i++)//пройти масств начиная со второго элемента до последнего элемента
                    {
                        if (t[i] != ' ' || t[i - 1] != ' ')
                            tt += t[i];    //если элемент и предыдущий элемент массива не равны ' ' добавить элемент в новый массив
                    }
                }
                PA_ListBox1.Items[rn] = tt;//после циклов вывести масств в лист бокс
            }

        }

        private void PA_ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = PA_ListBox1.SelectedIndex;//присоить переменной выделенный элемент
            if (n >= 0) PA_xtxbox1.Text = PA_ListBox1.Items[n].ToString();//вывести в текст бокс выделенный элемент в лист боксе
        }

        private void PA_fileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PA_btnsalvesta_Click(object sender, EventArgs e)
        {
            PA_saveFileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_saveFileDialog1.FileName = "";//чтобы при отмене выборв переменная пути оставалась пустой
            PA_saveFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_saveFileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            if (filenimi == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            StreamWriter sw = new StreamWriter(filenimi);//filenimi - пусть к текстовому фаилу
            for (int rn = 0; rn < PA_ListBox1.Items.Count; rn++)
                sw.WriteLine(PA_ListBox1.Items[rn].ToString()); //PA_ListBox1.Items[rn] элемнет массива
            sw.Close();//закрыть StreamWriter!!!!!  обязательно
        }

        private void PA_btnLoeTekst_Click(object sender, EventArgs e)
        {
            PA_openfileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_openfileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openfileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_openfileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            string txtfile = System.IO.File.ReadAllText(filenimi);//filenimi - пусть к текстовому фаилу
            PA_xtxbox2.Text = txtfile;//вывести тексть из фалиа по адресу txtfile
            int n = txtfile.Length;//присвоить переменной значение количество символов в тексте
            PA_lbl2.Text = " Teksti pikkus on " + n.ToString();
        }

        private void PA_btnsumb_Click(object sender, EventArgs e) // показать код каждого символа в тексте
        {
            string t = PA_xtxbox2.Text;//весть текст представить в массиве
            PA_listBoxsumb.Items.Clear();//отчистить поле PA_listBoxsumb от всех элементов
            for (int i = 0; i < t.Length; i++)
            {
                char sumb = t[i];
                byte numb = (byte)sumb;
                PA_listBoxsumb.Items.Add(sumb + " " + numb);
            }
        }

        private void PA_btnsalvesta2_Click(object sender, EventArgs e)
        {
            PA_saveFileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_saveFileDialog1.FileName = "";//чтобы при отмене выборв переменная пути оставалась пустой
            PA_saveFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_saveFileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            if (filenimi == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            string t = PA_xtxbox2.Text;
            System.IO.File.WriteAllText(filenimi, t);
        }

        private void PA_btnloemassiiv_Click(object sender, EventArgs e)
        {
            PA_openfileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_openfileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openfileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_openfileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            string[] tekstMas = System.IO.File.ReadAllLines(filenimi);//filenimi - пусть к текстовому фаилу
            PA_ListBox1.Items.Clear();
            for (int i = 0; i < tekstMas.Length; i++)
            {
                PA_ListBox1.Items.Add(tekstMas[i]);
            }

        }
    }
}
