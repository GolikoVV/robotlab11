using System;
using System.IO;
using System.Threading;

namespace RobotEvent
{
    // Класс, представляющий робота
    class Robot
    {
        // Событие выбора направления "назад"
        public event EventHandler Back;

        // Метод, выбирающий случайное направление и вызывающий событие
        public void ChooseDirection()
        {
            string[] directions = { "вперед", "назад", "влево", "вправо" };
            Random random = new Random();
            string direction = directions[random.Next(directions.Length)];

            Console.WriteLine("Робот движется {0}", direction);

            if (direction == "назад")
            {
                // Если выбрано направление "назад", вызываем событие
                OnBack(EventArgs.Empty);
            }
        }

        // Метод, вызывающий событие выбора направления "назад"
        protected virtual void OnBack(EventArgs e)
        {
            EventHandler handler = Back;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}