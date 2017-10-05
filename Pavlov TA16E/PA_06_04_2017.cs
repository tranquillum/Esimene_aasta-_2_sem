using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavlov_TA16E
{
    public partial class PA_06_04_2017 : Form
    {

        string[] TekstMas;
        public PA_06_04_2017()
        {
            InitializeComponent();
        }

        private void PA_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // закрыть эту форму
            
        }

        private void PA_loefile_Click(object sender, EventArgs e)
        {
            PA_openFileDialog1.Filter = "Tekstifailid|*.txt"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_openFileDialog1.FileName; //сохрать путь к фаилу в переменную

            TekstMas = System.IO.File.ReadAllLines(filenimi);
            PA_listBox1.Items.Clear();
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }

        private void PA_btnsalvesat_Click(object sender, EventArgs e)
        {
            PA_saveFileDialog1.Filter = "Tekstifailid|*.txt"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_saveFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_saveFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_saveFileDialog1.FileName; //сохрать путь к фаилу в переменную
            System.IO.File.WriteAllLines(filenimi, TekstMas);

        }

        private void PA_06_04_2017_Load(object sender, EventArgs e)
        {

        }

        private void PA_jaresta1_Click(object sender, EventArgs e)
        {
            Array.Sort(TekstMas);//сортировка по алфавиту

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PA_jaresta2_Click(object sender, EventArgs e)
        {
            
            //Array.Reverse(TekstMas);//развернуть массив в обратную сторону

            int n = TekstMas.Length;
            string[] VaheMas = new string[n];//промежуточный массив в длинну массива TekstMas
            for (int i1 = 0, i2 = n -1; i1<n;i1++, i2--)//проходя массив TekstMas от конца к началу добовалять элементы в промежуточный массив
            {
                VaheMas[i2] = TekstMas[i1];//присвить элеиенту промежуточного массива значение
            }
            TekstMas = VaheMas;//присвоить TekstMas значение промежуточного массива

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PA_jaresta3_Click(object sender, EventArgs e)
        {
            int n = TekstMas.Length;//присвоить переменной значения длинны массива
            string temp = "";//добавить массив для временного сохранения
            for (int i1=0;i1<n;i1++)//проходить массив от начала к концу
            {
                for(int i2 = i1 +1;i2<n;i2++)//пройти массив от начала к концу со сдивигом на одни элемент
                {
                    if (TekstMas[i2].Length<TekstMas[i1].Length)//если элемент меньше предыдущего
                    {
                        temp = TekstMas[i1];//сохранить его в temp
                        TekstMas[i1] = TekstMas[i2];//примвоить значение большего элемента
                        TekstMas[i2] = temp;//присвоить значение меньшего элемента
                    }
                }
            }

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);


        }

        private void PA_jaresta4_Click(object sender, EventArgs e)
        {
            
            char m = PA_sortTaht.Text[0];
            int n = TekstMas.Length;//присвоить переменной значения длинны массива
            string temp = "";

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = i1 + 1; i2 < n; i2++)
                {
                   
                    if (TekstMas[i2].ToString().Where(i => i == m).Count() > TekstMas[i1].ToString().Where(i => i == m).Count())//сравнить количество совпадающих с ткстбоксом
                    {
                        temp = TekstMas[i1];//сохранить его в temp
                        TekstMas[i1] = TekstMas[i2];//примвоить значение большего элемента
                        TekstMas[i2] = temp;//присвоить значение меньшего элемента
                    }
                }
            }

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);

        }

        private void PA_jaresta3_2_Click(object sender, EventArgs e)
        {
            int n = TekstMas.Length;
            string[] VaheMas = new string[n];//промежуточный массив в длинну массива TekstMas
            for(int i = 0; i<n;i++)//формирование массива(разобраться до конца, пока не понятно!!!)
            {
                VaheMas[i] = (1000+TekstMas[i].Length).ToString() + TekstMas[i];
            }
            Array.Sort(VaheMas);//сортировка промежуточногоного массива по алфавиту
            for (int i = 0; i < n; i++)
            {
                TekstMas[i] = VaheMas[i].Substring(4);//присвоить элемиентту массива значения элемента промежуточного массива без первых 4х символов
            }


                PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }

        private void PA_jaresta5_Click(object sender, EventArgs e) //сортеровка по количеству слов
        {

            
            int n = TekstMas.Length;//присвоить переменной значения длинны массива
            string temp = "";
            string[] TekstMas2= new string[n];
            
            

            for (int rn = 0; rn < n; rn++) //пройти весть текст в лист боксе
            {
                string t = TekstMas[rn];// t масств с тестом
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
                TekstMas2[rn] = tt;
            }





            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = i1 + 1; i2 < n; i2++)
                {

                    if (TekstMas2[i2].ToString().Where(i => i == ' ').Count() > TekstMas2[i1].ToString().Where(i => i == ' ').Count()|| TekstMas2[i1].Length<2)//опусткать строчку вниз если в ней меньше пробелов и есил трока меньше 2х символов
                    {
                        temp = TekstMas[i1];//сохранить его в temp
                        TekstMas[i1] = TekstMas[i2];//примвоить значение большего элемента
                        TekstMas[i2] = temp;//присвоить значение меньшего элемента
                    }
                }
            }

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }


        private int sonadearv(string t)
        {


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
            char s = ' ';
            int arv = 0;

            for (int i = 0; i < tt.Length; i++)
            {
                if (tt[i] == s) arv++;
            }
            return arv;
        }


        private void PA_jaresta5_1_Click(object sender, EventArgs e)
        {
            int n = TekstMas.Length;//присвоить переменной значения длинны массива
            string temp = "";
         
            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = i1 + 1; i2 < n; i2++)
                {

                    if (sonadearv(TekstMas[i2])> sonadearv(TekstMas[i1]) || TekstMas[i1].Trim().Length < 2)//опусткать строчку вниз если в ней меньше пробелов и есил трока меньше 2х символов
                    {
                        temp = TekstMas[i1];//сохранить его в temp
                        TekstMas[i1] = TekstMas[i2];//примвоить значение большего элемента
                        TekstMas[i2] = temp;//присвоить значение меньшего элемента
                    }
                }
            }

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }


        private int symbolitearv (string t , char s)//функцмя для подсчета указанных символов в массиве
        {

            int arv = 0;
            for(int i = 0; i<t.Length;i++)
            {
                if (char.ToUpper(t[i]) == s||char.ToLower(t[i]) ==s) arv++; //считать все символы не завилимо от риестра
            }
            return arv;
        }



      


        private void PA_jaresta4_1_Click(object sender, EventArgs e)
        {
            char symb = PA_sortTaht_2.Text[0];


            int n = TekstMas.Length;//присвоить переменной значения длинны массива
            string temp = "";//добавить массив для временного сохранения
            for (int i1 = 0; i1 < n; i1++)//проходить массив от начала к концу
            {
                for (int i2 = i1 + 1; i2 < n; i2++)//пройти массив от начала к концу со сдивигом на одни элемент
                {
                    if (symbolitearv(TekstMas[i2],symb) < symbolitearv(TekstMas[i1], symb))//если элемент меньше предыдущего
                    {
                        temp = TekstMas[i1];//сохранить его в temp
                        TekstMas[i1] = TekstMas[i2];//примвоить значение большего элемента
                        TekstMas[i2] = temp;//присвоить значение меньшего элемента
                    }
                }
            }

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            char s = PA_sortTaht_3.Text[0];
            int n = TekstMas.Length;
            string[] VaheMas = new string[n];//промежуточный массив в длинну массива TekstMas
            for (int i = 0; i < n; i++)//формирование массива(разобраться до конца, пока не понятно!!!)
            {
                VaheMas[i] = (1000 + symbolitearv(TekstMas[i], s)).ToString() + TekstMas[i];
            }
            Array.Sort(VaheMas);//сортировка промежуточногоного массива по алфавиту
            for (int i = 0; i < n; i++)
            {
                TekstMas[i] = VaheMas[i].Substring(4);//присвоить элемиентту массива значения элемента промежуточного массива без первых 4х символов
            }


            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }

        private void PA_jaresta5_2_Click(object sender, EventArgs e)
        {
            char s = PA_sortTaht_3.Text[0];
            int n = TekstMas.Length;
            string[] VaheMas = new string[n];//промежуточный массив в длинну массива TekstMas
            for (int i = 0; i < n; i++)//формирование массива(разобраться до конца, пока не понятно!!!)
            {
                VaheMas[i] = (1000 + sonadearv(TekstMas[i])).ToString() + TekstMas[i];
            }
            Array.Sort(VaheMas);//сортировка промежуточногоного массива по алфавиту
            for (int i = 0; i < n; i++)
            {
                TekstMas[i] = VaheMas[i].Substring(4);//присвоить элемиентту массива значения элемента промежуточного массива без первых 4х символов
            }
           

            PA_listBox1.Items.Clear();//очистить листбокс и заполнить его по новой
            for (int i = 0; i < TekstMas.Length; i++)
                PA_listBox1.Items.Add(TekstMas[i]);
        }
    }
}
