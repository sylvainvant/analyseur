using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficheAppli1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();         
        }          
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // locked lles groupeBox
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            // locked les text box
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            
            //paramètres retenus en visible
            //vitesse du melangeur
            groupBox3.Visible = true;
            // On vérifie si c'est le radio button 1 qui est sélectionné
            if (radioButton1.Checked == true)
            {
               // Radio bouton 1 séléctionné
                textBox1.Text = "100";           
            }

            // On vérifie si c'est le radio button 2 qui est sélectionné
            if (radioButton2.Checked == true)
            {
                //Radio bouton 2 séléctionné
                textBox1.Text = "200";
            }
            //On vérifie si c'est le radio button 3 qui est sélectionné
            if (radioButton3.Checked == true)
            {
               //Radio bouton 3 séléctionné
                textBox1.Text = "300";
            }
            // On vérifie si c'est le radio button 4 qui est sélectionné
            if (radioButton4.Checked == true)
            {
               // Radio bouton 3 séléctionné               
                textBox1.Text = "500";
            }


            //temperature du melangeur
            if (radioButton5.Checked == true)
            {
                // Radio bouton 1 séléctionné
                textBox2.Text = "50";
            }

            // On vérifie si c'est le radio button 2 qui est sélectionné
            if (radioButton6.Checked == true)
            {
                //Radio bouton 2 séléctionné
                textBox2.Text = "80";
            }
            //On vérifie si c'est le radio button 3 qui est sélectionné
            if (radioButton7.Checked == true)
            {
                //Radio bouton 3 séléctionné
                textBox2.Text = "100";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            // locked les text box
            textBox1.Enabled = true;
            textBox2.Enabled = true;

             // réinitialiser vitesse, température et paramètres retenus
             Init();
        }
        private void Init()
        {
            // réinitialiser vitesse, température et paramètres retenus
            this.radioButton1.Checked = true;
            this.radioButton5.Checked = true;

            this.textBox1.Text = this.radioButton1.Text;
            this.textBox1.Text = this.radioButton5.Text;
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
           
        }
    }
}
