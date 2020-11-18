using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class MilitaryShip : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int shipWidth = 200;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int shipHeight = 0;
        protected readonly char separator = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public MilitaryShip(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public MilitaryShip(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected MilitaryShip(int maxSpeed, float weight, Color mainColor, int shipWidth, int
       shipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            int leftbody = 30;//выступ левой части
            int topbody = 76;//выступ основной части корабля
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > leftbody)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > topbody)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Brushes.Gray);
            // корпус
            pen.Width = 6.0F;
            Brush body = new SolidBrush(MainColor);
            FillPolygonPoint(g);
            void FillPolygonPoint(Graphics gr)
            {
                Point point1 = new Point((int)_startPosX, (int)_startPosY);
                Point point2 = new Point((int)_startPosX - 25, (int)_startPosY - 25);
                Point point3 = new Point((int)_startPosX + 200, (int)_startPosY - 25);
                Point point4 = new Point((int)_startPosX + 175, (int)_startPosY);

                Point[] curvePoints = { point1, point2, point3, point4 };
                gr.FillPolygon(body, curvePoints);


                Brush equip = new SolidBrush(MainColor);
                Point rad1 = new Point((int)_startPosX + 44, (int)_startPosY - 25);
                Point rad2 = new Point((int)_startPosX + 44, (int)_startPosY - 50);
                Point rad3 = new Point((int)_startPosX + 65, (int)_startPosY - 50);
                Point rad4 = new Point((int)_startPosX + 75, (int)_startPosY - 25);

                Point[] radar = { rad1, rad2, rad3, rad4 };
                gr.FillPolygon(equip, radar);

                Point deck1 = new Point((int)_startPosX + 80, (int)_startPosY - 25);
                Point deck2 = new Point((int)_startPosX + 80, (int)_startPosY - 50);
                Point deck3 = new Point((int)_startPosX + 85, (int)_startPosY - 60);
                Point deck4 = new Point((int)_startPosX + 90, (int)_startPosY - 60);
                Point deck5 = new Point((int)_startPosX + 95, (int)_startPosY - 50);
                Point deck6 = new Point((int)_startPosX + 95, (int)_startPosY - 25);

                Point[] deck = { deck1, deck2, deck3, deck4, deck5, deck6 };
                gr.FillPolygon(equip, deck);

                g.FillRectangle(equip, _startPosX + 53, _startPosY - 60, 3, 10);
                g.FillEllipse(equip, _startPosX + 48, _startPosY - 75, 15, 15);
                g.FillRectangle(equip, _startPosX + 80, _startPosY - 75, 15, 15);
                g.FillRectangle(equip, _startPosX + 95, _startPosY - 50, 25, 25);
                g.FillRectangle(equip, _startPosX + 107, _startPosY - 56, 3, 6);
            }
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}

