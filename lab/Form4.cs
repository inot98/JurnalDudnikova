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
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            InitializeComponent();
        }

        private void AcadPerfForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jurnallabDataSet.График_занятий". При необходимости она может быть перемещена или удалена.
            this.график_занятийTableAdapter.Fill(this.jurnallabDataSet.График_занятий);

        }
    }
}
