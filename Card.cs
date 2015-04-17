using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Blackjack
{
    class Card
    {

        //Конструкторы
        public Card()
        {
        }

        public string name;
        public int value;
        public Bitmap shirt = new Bitmap("images\\shirt.jpg");
        // пригодится для отрисовки количествка карт соперника

        //Методы
        public void Draw(Form1 form,int value_in, int pic_box_num) 
        {
            value = value_in;
            if (pic_box_num == 1)
            {
                name = value + "_card";      
                Bitmap bitmap = new Bitmap("images\\" + name + ".jpg");  
                form.pictureBox1.Image = bitmap;
            }

            if (pic_box_num == 2)
            {
                name = value + "_card";
                Bitmap bitmap = new Bitmap("images\\" + name + ".jpg");
                form.pictureBox2.Image = bitmap;
            }

            if (pic_box_num == 3)
            {
                name = value + "_card";
                Bitmap bitmap = new Bitmap("images\\" + name + ".jpg");
                form.pictureBox3.Image = bitmap;
            }

            if (pic_box_num == 4)
            {
                name = value + "_card";
                Bitmap bitmap = new Bitmap("images\\" + name + ".jpg");
                form.pictureBox4.Image = bitmap;
            }

            if (pic_box_num == 5)
            {
                //card_value = card_value;
                Bitmap bitmap = new Bitmap("images\\" + name + ".jpg");
                form.pictureBox5.Image = bitmap;
            }
        }

        public void Waste(Form1 form)
        {
            form.pictureBox1.Image = null;
            form.pictureBox2.Image = null;
            form.pictureBox3.Image = null;
            form.pictureBox4.Image = null;
            form.pictureBox5.Image = null;
        }
        // Сделать загрузку битмапов отдельно
    }
}
