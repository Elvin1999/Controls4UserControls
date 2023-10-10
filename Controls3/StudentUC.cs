using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls3
{
    public partial class StudentUC : UserControl
    {
        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public string Surname
        {
            get { return surnameLbl.Text; }
            set { surnameLbl.Text = value; }
        }

        public string Age
        {
            get { return ageLbl.Text; }
            set { ageLbl.Text = value; }
        }

        public StudentUC()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Name} {Surname} {Age}");
        }
    }
}
