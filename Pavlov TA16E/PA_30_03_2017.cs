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
    public partial class PA_30_03_2017 : Form
    {
        public PA_30_03_2017()
        {
            InitializeComponent();
        }

        private void PA_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // закрыть эту форму
            this.DialogResult = DialogResult.OK; //при закрывании этого окна закрывается PavlovMAIN !!!!!Удалить после завершания формы!!!!
        }

        private void PA_30_03_2017_Load(object sender, EventArgs e)
        {

        }

        private void PA_btnLoeFile_Click(object sender, EventArgs e)
        {
            PA_openfileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|RTF filr|*.rtf*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            PA_openfileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openfileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string filenimi = PA_openfileDialog1.FileName; //сохрать путь к фаилу в переменную
            PA_FileName.Text = filenimi;//написать в лэйбл путь к фаилу
            if (filenimi == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }

            PA_textbox1.Text = System.IO.File.ReadAllText(filenimi);//filenimi - пусть к текстовому фаилу
            //PA_richTextBox1.Text = System.IO.File.ReadAllText(filenimi);//filenimi - пусть к текстовому фаилу
            //PA_richTextBox1.Rtf = System.IO.File.ReadAllText(filenimi);//filenimi - пусть к текстовому фаилу

            string laiend = filenimi.Substring(filenimi.Length - 3); //записать  в переменную последние 3 буквы из filenimi
            if (laiend == "txt")//если расширение .txt то отобразить текст в окне PA_richTextBox1 как обычный текст
            {
                PA_richTextBox1.Text = System.IO.File.ReadAllText(filenimi);
            }

            if (laiend == "rtf")//если расширение .rtf то отобразить текст в окне PA_richTextBox1 как rtf текст 
            {
                PA_richTextBox1.Rtf = System.IO.File.ReadAllText(filenimi);
            }

        }

        private void PA_FileName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PA_btnRTFtoText_Click(object sender, EventArgs e)
        {
            PA_textbox1.Text = PA_richTextBox1.Rtf;
        }

        private void PA_btnTexttoRTF_Click(object sender, EventArgs e)
        {
            PA_richTextBox1.Text = PA_textbox1.Text;
        }

        private void AP_FontDialog_Click(object sender, EventArgs e)
        {

            if (AP_fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (PA_richTextBox1.SelectionFont  != null)
                    PA_richTextBox1.SelectionFont = AP_fontDialog1.Font;
                
            }
            


        }

        private void AP_colorfont_Click(object sender, EventArgs e)
        {
            //if (AP_colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    PA_richTextBox1.ForeColor = AP_colorDialog1.Color;

            if (AP_colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (PA_richTextBox1.SelectionColor != null)
                    PA_richTextBox1.SelectionColor = AP_colorDialog1.Color;
                
            }
            
        }

        private void AP_salvesta_Click(object sender, EventArgs e)
        {
            //AP_saveFileDialog1.Filter = "Tekstifailid|*.txt;*.log;*.cs|Koik failid|*.*"; //filtri maaramine  имя фильтра в выпадающем меню|перечень расширений (*.расширение)|имя....  / (*.* =все форматы)
            //AP_saveFileDialog1.FileName = "";//чтобы при отмене выборв переменная пути оставалась пустой
            //AP_saveFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            SaveFileDialog saveFile1 = new SaveFileDialog();

            
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                
                PA_richTextBox1.SaveFile(saveFile1.FileName);
            }

        }
    }
}
