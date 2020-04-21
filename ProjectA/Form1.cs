using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Form1 : Form
    {   SpaceLogic mySpaceLogic;
        public Form1()
        {
            InitializeComponent();
            mySpaceLogic = new SpaceLogic();
            mySpaceLogic.SpaceMoved += mySpaceLogic_SpaceMoved;
        }

        private void mySpaceLogic_SpaceMoved()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        

        private void tickdol(object sender, KeyEventArgs e)
        {

        }

        private void tickgora(object sender, KeyEventArgs e)
        {

        }

      
    }
}
