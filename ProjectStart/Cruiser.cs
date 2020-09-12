using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ProjectStart
{
	class Cruiser
	{
        private float _startPosX;
        /// <summary>
        /// Левая нижняя координата автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        
 
        private readonly int shipWidth = 200;
        
        private readonly int shipHeight = 0;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес корабля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет 
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        
        public bool MissileSystem { private set; get; }
        /// <summary>
        /// Признак наличия ракетных установок
        /// </summary>
        public bool Deckhouse { private set; get; }
        /// <summary>
        /// Признак наличия рубки
        /// </summary>
        public bool AntiaircraftComplex { private set; get; }
        /// <summary>
        /// Признак наличия зенитных установок
        /// </summary>
        public bool  ControlSystem { private set; get; }
        /// Признак наличия систем наведения
        public bool Radarsurvey { private set; get; }
        /// Признак наличия радаров
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="dopColor">Дополнительный цвет</param>
        
        public Cruiser(int maxSpeed, float weight, Color mainColor, Color dopColor, 
        bool missileSystem, bool deckhouse, bool antiaircraftComplex, bool controlSystem,bool radarsurvey)
        {
            MaxSpeed = maxSpeed;           
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            MissileSystem = missileSystem;
            Deckhouse = deckhouse;
            AntiaircraftComplex = antiaircraftComplex;
            ControlSystem = controlSystem;
            Radarsurvey = radarsurvey;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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

        public void DrawTransport(Graphics g)
        {

            Pen pen = new Pen(Brushes.Gray);
            pen.Width = 6.0F;
            // отрисуем сперва ракетную систему (чтобы потом отрисовкаавтомобиля на него "легла")
            if (MissileSystem)
            {
                g.DrawLine(pen, _startPosX + 125, _startPosY - 20, _startPosX + 140, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 15, _startPosY - 20, _startPosX + 140 + 15, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 30, _startPosY - 20, _startPosX + 140 + 30, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 45, _startPosY - 20, _startPosX + 140 + 45, _startPosY - 30);

            }
            // корпус
            pen.Width = 6.0F;
            Brush body = new SolidBrush(DopColor);
            FillPolygonPoint(g);
            void FillPolygonPoint(Graphics gr)
            {

                Point point1 = new Point((int)_startPosX, (int)_startPosY);
                Point point2 = new Point((int)_startPosX - 25, (int)_startPosY - 25);
                Point point3 = new Point((int)_startPosX + 200, (int)_startPosY - 25);
                Point point4 = new Point((int)_startPosX + 175, (int)_startPosY);

                Point[] curvePoints = { point1, point2, point3, point4 };

                gr.FillPolygon(body, curvePoints);

                if (Radarsurvey)
                {
                    Brush equip = new SolidBrush(MainColor);
                    Point rad1 = new Point((int)_startPosX + 44, (int)_startPosY - 25);
                    Point rad2 = new Point((int)_startPosX + 44, (int)_startPosY - 50);
                    Point rad3 = new Point((int)_startPosX + 65, (int)_startPosY - 50);
                    Point rad4 = new Point((int)_startPosX + 75, (int)_startPosY - 25);

                    Point[] radar = { rad1, rad2, rad3, rad4 };
                    gr.FillPolygon(equip, radar);
                }
                if (Deckhouse)
                {
                    Brush equip = new SolidBrush(MainColor);
                    Point deck1 = new Point((int)_startPosX + 80, (int)_startPosY - 25);
                    Point deck2 = new Point((int)_startPosX + 80, (int)_startPosY - 50);
                    Point deck3 = new Point((int)_startPosX + 85, (int)_startPosY - 60);
                    Point deck4 = new Point((int)_startPosX + 90, (int)_startPosY - 60);
                    Point deck5 = new Point((int)_startPosX + 95, (int)_startPosY - 50);
                    Point deck6 = new Point((int)_startPosX + 95, (int)_startPosY - 25);

                    Point[] deck = { deck1, deck2, deck3, deck4, deck5, deck6 };
                    gr.FillPolygon(equip, deck);
                }

                if (AntiaircraftComplex)
                {
                    Brush equip = new SolidBrush(MainColor);
                    g.FillRectangle(equip, _startPosX - 20, _startPosY - 30, 19, 5);
                    g.FillRectangle(equip, _startPosX + 21, _startPosY - 30, 19, 5);


                }
                if (ControlSystem)
                {
                    Brush equip = new SolidBrush(MainColor);
                    g.FillRectangle(equip, _startPosX, _startPosY - 40, 20, 15);
                    g.FillRectangle(equip, _startPosX + 6, _startPosY - 50, 12, 10);
                    g.FillEllipse(equip, _startPosX + 6, _startPosY - 60, 12, 10);

                }
                if (Radarsurvey)
                {
                    Brush equip = new SolidBrush(MainColor);
                    g.FillRectangle(equip, _startPosX + 53, _startPosY - 60, 3, 10);
                    g.FillEllipse(equip, _startPosX + 48, _startPosY - 75, 15, 15);
                }
                if (Deckhouse)
                {
                    Brush equip = new SolidBrush(MainColor);
                    g.FillRectangle(equip, _startPosX + 80, _startPosY - 75, 15, 15);
                    g.FillRectangle(equip, _startPosX + 95, _startPosY - 50, 25, 25);
                    g.FillRectangle(equip, _startPosX + 107, _startPosY - 56, 3, 6);

                }

            }
        }
    }
}
