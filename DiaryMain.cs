using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсова_Робота__Щоденник_
{
    public partial class DiaryMain : Form
    {
        public DiaryMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            PanelOfButton.Visible = false;




        }

        private void DiaryMain_Load(object sender, EventArgs e)
        {

        }

        private void DiaryMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Кнопка для запису щоденника
        private void DiaryButton_Click(object sender, EventArgs e)
        {
            PanelOfButton.Visible = !PanelOfButton.Visible; // Перемикач
        }

        
        // Панель від кнопки
        private void PanelOfButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
