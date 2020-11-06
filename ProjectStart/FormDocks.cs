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
    public partial class FormDocks : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly DocksCollection docksCollection;
        public FormDocks()
        {
            InitializeComponent();
            docksCollection = new DocksCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxDocks.SelectedIndex;
            listBoxDocks.Items.Clear();
            for (int i = 0; i < docksCollection.Keys.Count; i++)
            {
                listBoxDocks.Items.Add(docksCollection.Keys[i]);
            }
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >=
           listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;
            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index <
           listBoxDocks.Items.Count)
            {
                listBoxDocks.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                docksCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDocks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            docksCollection.AddDocks(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelDocks_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    docksCollection.DelDocks(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Причалить корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetMilShip_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(AddShip);
            formShipConfig.Show();
        }
        private void AddShip(Vehicle car)
        {
            if (car != null && listBoxDocks.SelectedIndex > -1)
            {
                if ((docksCollection[listBoxDocks.SelectedItem.ToString()]) + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось причалить");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1 && maskedTextBoxNumberPlace.Text != "")
            {
                var ship = docksCollection[listBoxDocks.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBoxNumberPlace.Text);
                if (ship != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

    }
}
