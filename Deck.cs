using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    static class Deck
    {
        public const int num = 11;
        public static Card[] cards_in_deck = new Card[num]; // [36]

        //Values
        public static int selecter = 1;
        public static int deck_counter = 0;
        public static int point_counter = 0;
        public static Bitmap shirt = new Bitmap("images\\shirt.jpg");
        public static Random ran = new Random();
       
        //Methods
        public static void Start()
        {
            selecter = 1;
            deck_counter = 0;
            point_counter = 0;
        }

        public static void Draw(Form1 form, int check)
        {
            if (check == 1)
            {
                form.Deck_Top.Image = shirt;
                form.Deck_Back.Image = shirt;
            }
            else
            {
                form.Deck_Top.Image = null;
                form.Deck_Back.Image = null;
            }
        }

        public static void Generate(Form1 form)
        {
            for (int i = 0; i < num; i++)
            {
                cards_in_deck[i] = new Card();
            }

            int gen_value = 0;

            for (int i = 0; i < num; i++) 
            {
                gen_value = ran.Next(6, 9);  //2 - 4, 6 - 11
                cards_in_deck[i].value = gen_value;
                form.listBox.Items.Add(cards_in_deck[i].value);
            } 
        }

        public static void Take_card(Form1 form, Game game)
        {
            point_counter += cards_in_deck[deck_counter].value;
            form.label2.Text = "" + point_counter;

            if (deck_counter < num)  // check it
            {
                cards_in_deck[deck_counter].Draw(form, cards_in_deck[deck_counter].value, selecter);
                if (point_counter < 22)
                {
                    selecter ++;
                    deck_counter ++;
                    if (deck_counter > 6) // Половина колоды
                        form.Deck_Back.Image = null;
                }
                else
                {
                    if (selecter >= 5) selecter = 1;
                    else selecter++;
                    game.Lose(form);
                }
            }
            else
            {
                selecter = 1;
                MessageBox.Show("Deck is empty!");
                form.Take_button.Enabled = false;
                Deck.Draw(form, 0);
            }
        }
    }
}
