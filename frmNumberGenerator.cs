using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise5
{
    public partial class frmNumberGenerator : Form
    {
        public frmNumberGenerator()
        {
            InitializeComponent();
        }

        private void buttonLucky_Click(object sender, EventArgs e)
        {


            int number;

            if (int.TryParse(txtLuckyNumber.Text, out number) && (number <= 10))
            {
                frmLuckyNumber luckyForm = new frmLuckyNumber();
                Point pointLocation = new Point(5, 5); // Set whatever you want for initial location
                
                Random rand = new Random();

                for (int i = 0; i < number; ++i)
                {
                    Button b = new Button();
                    b.Text = Convert.ToString(rand.Next(0,number));
                    b.Size = new Size(200, 25);
                    b.Location = pointLocation;
                    pointLocation.Offset(0, b.Height + 5);
                    luckyForm.Controls.Add(b);
                }
                luckyForm.ShowDialog();
            }
            else
            {
                txtLuckyNumber.Text = "";
                this.ActiveControl = txtLuckyNumber;
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
