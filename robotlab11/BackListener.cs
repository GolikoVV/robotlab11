using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotlab11
{
    // Класс, представляющий слушателя события выбора направления "назад"
    class BackListener
    {
        // Метод, вызываемый при возникновении события
        public void OnBack(object sender, EventArgs e)
        {
            Console.WriteLine("Робот выбрал направление назад");

            // Записываем сообщение в файл
            string text = "Робот выбрал направление назад";
            using (StreamWriter sw = new StreamWriter("test.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
}
