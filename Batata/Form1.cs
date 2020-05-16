using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Trident;
using BLL_chuchu;



namespace UI_Batata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Login obj = new DTO_Login();
                BLL_Login obj2 = new BLL_Login();
                obj.Usuario = textBox1.Text;
                obj.Senha = textBox2.Text;
                if(obj2.ValidarLogin(obj) == true)
                {
                    MessageBox.Show("deu certo ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
