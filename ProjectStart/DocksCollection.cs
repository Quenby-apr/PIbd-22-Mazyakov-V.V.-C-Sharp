using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class DocksCollection 
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Docks<Vehicle>> docksStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => docksStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DocksCollection(int pictureWidth, int pictureHeight)
        {
            docksStages = new Dictionary<string, Docks<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddDocks(string name)
        {
            if (docksStages.ContainsKey(name))
            {
                return;
            }
            docksStages.Add(name, new Docks<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelDocks(string name)
        {
            if (docksStages.ContainsKey(name))
            {
                docksStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Docks<Vehicle> this[string ind]
        {
            get
            {
                if (docksStages.ContainsKey(ind))
                {
                    return docksStages[ind];
                }
                return null;
            }
        }
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("DocksCollection");
                foreach (var level in docksStages)
                {
                    sw.WriteLine($"Docks{separator}{level.Key}");

                    foreach (ITransport ship in level.Value)
                    {
                        if (ship.GetType().Name == "MilitaryShip")
                        {
                            sw.Write($"MilitaryShip{separator}");
                        }
                        if (ship.GetType().Name == "Cruiser")
                        {
                            sw.Write($"Cruiser{separator}");
                        }
                        //Записываемые параметры
                        sw.WriteLine(ship);
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                Vehicle ship = null;
                string key = string.Empty;
                string line = sr.ReadLine();
                if (line.Contains("DocksCollection"))
                {
                    //очищаем записи
                    docksStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new InvalidDataException("Неверный формат файла");
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Docks"))
                    {
                        //начинаем новую парковку
                        key = line.Split(separator)[1];
                        docksStages.Add(key, new Docks<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "MilitaryShip")
                    {
                        ship = new MilitaryShip(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Cruiser")
                    {
                        ship = new Cruiser(line.Split(separator)[1]);
                    }
                    var result = docksStages[key] + ship;
                    if (!result)
                    {
                        throw new IndexOutOfRangeException("Не удалось загрузить автомобиль на парковку");
                    }
                }
            }
        }
    }
}