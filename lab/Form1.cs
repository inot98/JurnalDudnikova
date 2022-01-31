using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void StudentFormBut_Click(object sender, EventArgs e)
        {
            StudentsForm stf = new StudentsForm();
            stf.Show();
        }

        private void SubjectBut_Click(object sender, EventArgs e)
        {
            SubjectForm sbf = new SubjectForm();
            sbf.Show();
        }

        private void AcadPerfBut_Click(object sender, EventArgs e)
        {
            AcadPerfForm lf = new AcadPerfForm();
            lf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LessonsForm apf = new LessonsForm();
            apf.Show();
        }
    }
}
