using System;
using NLog;
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
        private readonly Logger logger;
        public FormDocks()
        {
            InitializeComponent();
            docksCollection = new DocksCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn("название не введено");
                return;
            }
            logger.Info($"Добавили док {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили док { listBoxDocks.SelectedItem.ToString()}");
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
                try
                {
                    if ((docksCollection[listBoxDocks.SelectedItem.ToString()]) + car)
                    {
                        Draw();
                        logger.Info($"Добавлен корабль {car}");
                    }
                    else
                    {
                        MessageBox.Show("корабль не удалось причалить");
                    }
                    Draw();
                }
                catch (DocksOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
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
                try
                {
                    var ship = docksCollection[listBoxDocks.SelectedItem.ToString()] -
                    Convert.ToInt32(maskedTextBoxNumberPlace.Text);
                    if (ship != null)
                    {
                        FormCruiser form = new FormCruiser();
                        form.SetShip(ship);
                        form.ShowDialog();
                        logger.Info($"Изъят корабль {ship} с места{ textBoxNewLevelName.Text}");
                    Draw();
                    }
                }
                catch (DocksNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
                }
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на док { listBoxDocks.SelectedItem.ToString()}");
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDocks.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    docksCollection.SaveData(saveFileDialogDocks.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogDocks.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDocks.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    docksCollection.LoadData(openFileDialogDocks.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogDocks.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DocksOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Занятое место");
                }
            }
        }
    }
}
