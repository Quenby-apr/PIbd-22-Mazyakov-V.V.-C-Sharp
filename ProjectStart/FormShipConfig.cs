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
    public partial class FormShipConfig : Form
    {
        ITransport ship = null;

        Action<Vehicle> EventAddShip;
        public FormShipConfig()
        {
            InitializeComponent();
            // привязать panelColor_MouseDown к панелям с цветами
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;
            panelColorGreen.MouseDown += panelColor_MouseDown;
            panelColorFuchsia.MouseDown += panelColor_MouseDown;
            panelColorAqua.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(35, 140, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShip.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (EventAddShip == null)
            {
                EventAddShip = new Action<Vehicle>(ev);
            }
            else
            {
                EventAddShip += ev;
            }
        }
        private void labelMilShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelMilShip.DoDragDrop(labelMilShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelCruiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiser.DoDragDrop(labelCruiser.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный корабль":
                    ship = new MilitaryShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black);
                    break;
                case "Крейсер":
                    ship = new Cruiser((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black, Color.White,
                        checkBoxMissleSystem.Checked, checkBoxAntiaircraft.Checked, checkBoxControlSystem.Checked);
                    break;
            }
            DrawShip();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender as Control !=null)
            {
                ((Control)sender).DoDragDrop(((Control)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены базового цвета
            if (sender as Control != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }           
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
            if (sender as Control != null)
            {
                if (ship is Cruiser)
                {
                    ((Cruiser)ship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EventAddShip((Vehicle)ship);
            Close();
        }
    }
}
