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
    public partial class PA_IseseisvaltToo : Form
    {
        Form f1 = new IseseisvaltTooTehtud();
        private bool kontroll(string t)//функция проверки что в исикукоде не содержится симфолов кроме цифр
        {
            for (int i = 0; i < t.Length; i++)
                if (t[i] < '0' || t[i] > '9') return false;//вернуть ошибку если в масстве содержится символы тличные от цифр 0-9
            return true;
        }

        private string korraliknimi(string t) //функция для обрезания пробелов в начале и в конце и удаление лишних пробелов
        {


            t = t.Trim(); //обрезать все пробелы в начале и в конце массива
            string tt = ""; //новый массив куда будут записыватся результаты 
            if (t.Length > 0)//если массив не пуст
            {
                tt = t.Substring(0, 1);//придать tt значение (начиная с элемента в массиве t, количество элементов 1)
                for (int i = 1; i < t.Length; i++)//пройти масств начиная со второго элемента до последнего элемента
                {
                    if (t[i] != ' ' || t[i - 1] != ' ')//если элемент и чледующий элемент начиная со второго элемента масства " " ...
                        tt += t[i];    //если элемент и предыдущий элемент массива не равны ' ' добавить элемент в новый массив                      
                }
            }

            return tt;//вернуть массив
        }



        public PA_IseseisvaltToo()
        {
            InitializeComponent();
        }

        private void IseseisvaltToo_Load(object sender, EventArgs e)
        {
            
        }

        private void PA_exit_Click(object sender, EventArgs e)
        {
            this.Close();//закрыть форму

        }

        private void AP_Read_Click(object sender, EventArgs e) //чтение фаила и добавление в листбокс
        {
            AP_openFileDialog1.Filter = "Tekstifailid|*.txt"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений 
            AP_openFileDialog1.FileName = "";//чтобы при отмене выбора не возникала ошибка
            AP_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = AP_openFileDialog1.FileName; //сохрать путь к фаилу в переменную
            if (filenimi == "") //остановится если путь пуст
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            PA_Nimikiri.Items.Clear();//очистить лист боес PA_Nimikiri 
            StreamReader sr = new StreamReader(filenimi);//filenimi - пусть к текстовому фаилу
            string text;
            while ((text = sr.ReadLine()) != null) //если фаил не пуст добавить текс из фаила в переменную text
            {
                PA_Nimikiri.Items.Add(text);//записать текст из фаила в листбокс                
            }
            sr.Close();//закрыть StreamReader!!!!! обязательно
        }

        private void AP_Write_Click(object sender, EventArgs e)//забись в фаил содержимое литбокса
        {

            AP_saveFileDialog1.Filter = "Tekstifailid|*.txt"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений 
            AP_saveFileDialog1.FileName = "";//чтобы при отмене выбора не возникала ошибка
            AP_saveFileDialog1.ShowDialog(); // открыть эксплорер фаилов
            string filenimi = AP_saveFileDialog1.FileName; //сохрать путь к фаилу в переменную

            if (filenimi == "")//остановится если путь пуст
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            StreamWriter sw = new StreamWriter(filenimi);//filenimi - пусть к текстовому фаилу
            for (int rn = 0; rn < PA_Nimikiri.Items.Count; rn++)
                sw.WriteLine(PA_Nimikiri.Items[rn].ToString()); //PA_ListBox1.Items[rn] элемнет массива
            sw.Close();//закрыть StreamWriter!!!!!  обязательно
        }

        private void AP_Delite_Click(object sender, EventArgs e) //удаление элемента из литбокса
        {
            string tekst = "soovite kustutada: " + (char)(13) + (char)(13); // (char)(13)  сделать вниз отступ в 13 пикселей
            for (int i = 0; i < PA_Nimikiri.Items.Count; i++)
            {

                if (PA_Nimikiri.GetSelected(i))
                    tekst = tekst + PA_Nimikiri.Items[i] + (char)(13);
            }
            DialogResult vastus = MessageBox.Show(tekst, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.No)
            {
                return;//остановить при отрицательном ответе
            }
            else
            {
                while (PA_Nimikiri.SelectedItems.Count > 0)//удалять элементы пока не останится не одного выделенного элемента
                {
                    PA_Nimikiri.Items.Remove(PA_Nimikiri.SelectedItem);
                }

            }
            PA_Kood.Clear();//отчистить поле исикукод
            PA_Nimi.Clear();//отчистить поле имени
        }

        private void AP_Add_Click(object sender, EventArgs e)
        {
            string t = PA_Kood.Text; //записать в массив t текст из поля исикукод
            string tt = PA_Nimi.Text;//записать в массив tt текст из поля имя
            if (t.Length == 0 && tt.Length == 0)//если оба поля пусты
            {
                MessageBox.Show("sisestage isikukood ja nimi");//предупреждение если оба поля пустые
                return;//остановится
            }

            if (t.Length == 0)//предупреждение о пустом поле исикукода
            {
                MessageBox.Show("sisestage isikukood");
                return;//остановится
            }

            if (kontroll(t) == false|| t.Length<11) //предупреждение если не исикукод введун не коректно
            {
                MessageBox.Show("Isikukood sisestatud valesti");
                return;//остановится
            }

            if (tt.Length == 0)//предупреждение если поля имя пустое
            {
                MessageBox.Show("sisestage Nimi");
                return;//остановится
            }

            PA_Nimikiri.Items.Add(korraliknimi(tt) + " " + PA_Kood.Text);//записать в строку листбокса тексти из поля имя +" "+ текст из поля исикукод
            PA_Kood.Clear();//отчистить поле исикукод
            PA_Nimi.Clear();//очтчитсять поле имя


        }

        

        private void PA_Nimikiri_SelectedIndexChanged(object sender, EventArgs e)//действия при выделение обекта в лист боксе
        {

            //int n = PA_Nimikiri.SelectedIndex;//присвоить переменной выделенный элемент
            //if (n >= 0)//если есть выделенные элементы
            //{
            //    string t = PA_Nimikiri.Items[n].ToString(); //записать в масств содержимое строки литбокса
            //    PA_Kood.Text = t.Substring(t.Length - 11);//вывести в текст бокс isikukood
            //    string tt = t.Remove(t.Length - 12, 12);//сохранить в масств tt все элементы массива t без последних 12 элементов
            //    PA_Nimi.Text = tt;//вывести в текст бокс имя

            //}
        }

       

        private void AP_Update_Click(object sender, EventArgs e)//замена выделенного эдемента в лист боксе на содержимое полей
        {
           
            int rn = PA_Nimikiri.SelectedIndex;//rn количество выделенных элементов
            if (rn == -1)//если не выбрано не одного элеиента
            {
                MessageBox.Show("Valik puudub");
                return;//остановить если не выбрано не одного элемента
            }

            string tekst = "soovite muutuda:" + (char)(13) + PA_Nimikiri.Items[rn] + (char)(13) + "sellega: " + (char)(13) + PA_Nimi.Text+" "+PA_Kood.Text;//+AP_lb1.SelectedItem
            DialogResult vastus = MessageBox.Show(tekst, "Hoiatus", MessageBoxButtons.YesNo);//подтверждение удаления выделенных элементов
            if (vastus == DialogResult.No)//если ответ отритцательный
            {
                return;//остановить если ответ отридцательный
            }
            else
            {
                string t = PA_Kood.Text;//записать в массив текст из поля исикукод  
                string tt = PA_Nimi.Text;//записать в масств текст из поля имя
                if (t.Length == 0) //если поля имени пусто
                {
                    MessageBox.Show("sisestage isikukood");
                    return;//остановится
                }

                if (kontroll(t) == false||t.Length<11)//если в поле исикукод не правельно заполнено
                {
                    MessageBox.Show("Isikukood sisestatud valesti");
                    return;//остановиться
                }

                if (tt.Length == 0)//если поле имя пусто
                {
                    MessageBox.Show("sisestage Nimi");
                    return;//остановится
                }
                PA_Nimikiri.Items[rn] = korraliknimi(tt) + " " + PA_Kood.Text;//записать в строку лист бокса тексти из поля имя +" "+ текст из поля исикукод

            }
            PA_Nimikiri.SelectedIndex = -1;//снять выделение с листбокса
            PA_Nimi.Clear();//отчитстить поле имя
            PA_Kood.Clear();//отчистить поле исикукод


        }

        private void PA_Nimikiri_DoubleClick(object sender, EventArgs e)//при двойном нажатии на сроку в лист боксе 
        {
            int n = PA_Nimikiri.SelectedIndex;//присвоить переменной выделенный элемент
            if (n >= 0)//если есть выделенные элементы
            {
                string t = PA_Nimikiri.Items[n].ToString(); //записать в масств содержимое строки литбокса
                PA_Kood.Text = t.Substring(t.Length - 11);//вывести в текст бокс isikukood
                string tt = t.Remove(t.Length - 12, 12);//сохранить в масств tt все элементы массива t без последних 12 элементов
                PA_Nimi.Text = tt;//вывести в текст бокс имя

            }
        }

        private void PA_Nimikiri_MouseDown(object sender, MouseEventArgs e)
        {
          


        }

        private void PA_too_Click(object sender, EventArgs e) 
        {
            if (f1.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f1 = new IseseisvaltTooTehtud();
            }
            f1.Visible = true;
            f1.Activate();
        }
    }
}
