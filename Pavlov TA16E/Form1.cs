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
    public partial class PavlovMAIN : Form
    {
        Form f1 = new PA_09_03_2017();
        Form f2 = new PA_30_03_2017();
        Form f3 = new PA_06_04_2017();
        Form f4 = new PA_IseseisvaltToo();
        Form f5 = new IseseisvaltTooTehtud();
        public PavlovMAIN()
        {
            InitializeComponent();
        }

        private void PA_09_03_2017_Click(object sender, EventArgs e)
        {
            if (f1.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f1 = new PA_09_03_2017();
            }
            f1.Visible = true;
            f1.Activate();
        }

        private void PA_exit_Click(object sender, EventArgs e)
        {
            f1 = new IseseisvaltTooTehtud();
            f1.Close();
            this.Close(); //закрыть форму
            f1 = new IseseisvaltTooTehtud();
            f1.Close();
        }

        private void PavlovMAIN_Load(object sender, EventArgs e)
        {
           
        }

        private void PA_30_03_2017_Click(object sender, EventArgs e)
        {
            if (f2.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f2 = new PA_30_03_2017();
            }
            f2.Visible = true;
            f2.Activate();
        }

        private void PA_06_04_2017_Click(object sender, EventArgs e)
        {
            if (f3.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f3 = new PA_06_04_2017();
            }
            f3.Visible = true;
            f3.Activate();
        }

        private void PA_too_Click(object sender, EventArgs e)
        {
            if (f4.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f4 = new PA_IseseisvaltToo();
            }
            f4.Visible = true;
            f4.Activate();

            if (f5.Visible == false) // проверка видна ли форма / если нет то показать
            {
                f5 = new IseseisvaltTooTehtud();
            }
            f5.Visible = true;
            f5.Activate();
        }
    }
    }

