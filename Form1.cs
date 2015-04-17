using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Blackjack
{

    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck.Take_card(this, game);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game_panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.End(this);
            // Измени эту кнопку на ставку
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            game.Begin(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


// Работа с мышкой
/*
bool isDown = false;
public void pictureBox1_Click(object sender, EventArgs e)
{
    if (isDown == false)
    {
        isDown = true;
        Label5.Text = "Is down";
    }
    else
    {
        isDown = false;
        Label5.Text = "Is up";
    }
}

       
private void   pictureBox1_MouseDown(object sender, MouseEventArgs e)
{
    isDown = true;
    Label5.Text = "Is down";
}
        

public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
{
    //Control c = sender as Control;
    if (isDown == true)
    {
        Form form = new Form();
        pictureBox1.Location = form.PointToClient( MousePosition);
    }
}

private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
{
    isDown = false;
    Label5.Text = "Is down";
}

*/
// Конец работы с мышкой
