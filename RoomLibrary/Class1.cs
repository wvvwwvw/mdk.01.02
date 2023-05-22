using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght; //длина комнаты
        double roomWidth; //ширина комнаты
        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLenght + roomWidth);
        }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }
        /// <summary>
        /// метод вычисляет число квадратных метров 
        /// на одного человека
        /// </summary>
        /// <param name="np">число человек</param>
        /// <returns>возвращает число квадратных метров</returns>
        public double PersonaArea(int np)
        {
            return RoomArea() / np;
        }
        /// <summary>
        /// информация о комнате
        /// </summary>
        /// <returns>возвращает строку</returns>
        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }
    /// <summary>
    /// класс "жилая комната"
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin; //число окон
        public int NumWin
        {
            get { return numWin; }
            set { numWin = value; }
        }
        /// <summary>
        /// метод возвращает информацию о комнате
        /// </summary>
        /// <returns>возвразается строка с информацией</returns>
        public override string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами";
        }
    }
    public class Office : Room
    {
        int numSockets; //число розеток
        public int NumSockets
        { get { return numSockets; } set { numSockets = value; } }
        /// <summary>
        /// возвращает максимально возможное число рабочих мест
        /// </summary>
        /// <returns>возвращает число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        /// <summary>
        /// метод возвращает информацию об офисе
        /// </summary>
        /// <returns>возвращается строка с информацией</returns>
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
