using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ProjectStart
{
	class Cruiser: MilitaryShip
	{
        public Color DopColor { private set; get; }
        public bool MissileSystem { private set; get; }
        /// <summary>
        /// Признак наличия ракетных установок
        /// </summary>
        public bool AntiaircraftComplex { private set; get; }
        /// <summary>
        /// Признак наличия зенитных установок
        /// </summary>
        public bool  ControlSystem { private set; get; }
        /// Признак наличия систем наведения
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="dopColor">Дополнительный цвет</param>
        
        public Cruiser(int maxSpeed, float weight, Color mainColor, Color dopColor, 
        bool missileSystem, bool antiaircraftComplex, bool controlSystem) :
            base(maxSpeed, weight, mainColor, 200,0)
        {
            DopColor = dopColor;
            MissileSystem = missileSystem;
            AntiaircraftComplex = antiaircraftComplex;
            ControlSystem = controlSystem;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(DopColor);
            pen.Width = 6.0F;
            // отрисуем сперва ракетную систему (чтобы потом отрисовкаавтомобиля на него "легла")
            if (MissileSystem)
            {
                g.DrawLine(pen, _startPosX + 125, _startPosY - 20, _startPosX + 140, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 15, _startPosY - 20, _startPosX + 140 + 15, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 30, _startPosY - 20, _startPosX + 140 + 30, _startPosY - 30);
                g.DrawLine(pen, _startPosX + 125 + 45, _startPosY - 20, _startPosX + 140 + 45, _startPosY - 30);
            }
            base.DrawTransport(g);
            if (AntiaircraftComplex)
            {
                Brush equip = new SolidBrush(DopColor);
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
        }
    }
}