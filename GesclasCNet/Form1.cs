using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int px;
        int py;
        Boolean mover;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtUsuario.BackColor = Color.FromArgb(230, 237, 246);
            TxtPassword.BackColor = Color.FromArgb(230, 237, 246);

          
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover==true)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X-px, MousePosition.Y - Location.Y - px));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Text = "";
            TxtPassword.SelectionStart = 1;
        }

        private void TxtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            TxtUsuario.ForeColor = Color.Black;
            TxtUsuario.Text = "";
            TxtUsuario.SelectionStart = 1;
        }

        private void TxtUsuario_GotFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("You are in the Control.GotFocus event.");
        }
    }
}
