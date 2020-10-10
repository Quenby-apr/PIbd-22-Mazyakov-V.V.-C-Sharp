using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStart
{
	public partial class FormCruiser:Form
	{
		private ITransport ship;
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
			Graphics gr = Graphics.FromImage(bmp);
			ship.DrawTransport(gr);
			pictureBoxCruiser.Image = bmp;
		}

		public FormCruiser()
		{
			InitializeComponent();
		}
        private void buttonCreateMilShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new MilitaryShip (rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            ship.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxCruiser.Width,
           pictureBoxCruiser.Height);
            Draw();
        }
        private void buttonCreateCruiser_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Cruiser(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true,true,true);
            ship.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxCruiser.Width,
           pictureBoxCruiser.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
