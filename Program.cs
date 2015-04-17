using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;


namespace Blackjack
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Game
    {
        public Game()
        {
        }
        //Deck deck = new Deck();

        public void Begin(Form1 form)
        {
            Deck.Start();
            Deck.Draw(form, 1);
            Deck.Generate(form);

            form.label2.Text = "0";
            form.Menu_panel.Visible = false;
            form.Game_panel.Visible = true;
            form.Take_button.Enabled = true;
            form.listBox.Visible = true;

        }

        public void Lose(Form1 form)
        {
            form.Take_button.Enabled = false;
            MessageBox.Show("You lose!");
        }
        public void End(Form1 form)
        {
            Card card = new Card();
            card.Waste(form);

            form.Menu_panel.Visible = true;
            form.Game_panel.Visible = false;
            form.Take_button.Enabled = false;
            form.listBox.Items.Clear();
            form.listBox.Visible = false;

            Deck.Draw(form, 0);
            Deck.Start();
        }
    }   
}

