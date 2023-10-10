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
    public partial class Form2 : Form
    {
        homeUC homeUC = new homeUC();
        aboutUC aboutUC=new aboutUC();
        public List<Student> Students { get; set; }
        public Form2()
        {
            InitializeComponent();
            homeUC.Location = new Point(0, 150);
            aboutUC.Location = new Point(0, 150);

            Students = new List<Student>
            {
                 new Student
                 {
                     Name="Elnur",
                     Surname="Akberli",
                     Age=17
                 },
                 new Student
                 {
                     Name="Ruad",
                     Surname="Dunyamaliyev",
                     Age=15
                 },
                 new Student
                 {
                     Name="Hebib",
                     Surname="Veliyev",
                     Age=16
                 }
            };

            int x = 0;
            int y = 150;
            foreach (var item in Students)
            {
                var studentUC = new StudentUC();
                studentUC.Name=item.Name;
                studentUC.Surname = item.Surname;
                studentUC.Age = item.Age.ToString();
                studentUC.Location = new Point(x, y);
                y += 100;
                this.Controls.Add(studentUC);
            }


          //  this.Controls.Add(homeUC);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(homeUC);
            this.Controls.Add(aboutUC);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Add(homeUC);
            this.Controls.Remove(aboutUC);
        }
    }
}
