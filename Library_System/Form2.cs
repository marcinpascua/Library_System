using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void fiction_button_Click(object sender, EventArgs e)
        {
            this.fictionControl1.BringToFront();
        }

        private void thriller_button_Click(object sender, EventArgs e)
        {
            this.thrillerControl1.BringToFront();
        }

        private void romance_button_Click(object sender, EventArgs e)
        {
            this.romanceControl1.BringToFront();
        }

        private void fantasy_button_Click(object sender, EventArgs e)
        {
            this.fantasyControl1.BringToFront();
        }

        private void fictionControl1_Load(object sender, EventArgs e)
        {

        }

        private void horror_button_Click(object sender, EventArgs e)
        {
            this.horrorControl1.BringToFront();
        }
    }
}
