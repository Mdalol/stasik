using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    /// <summary>
    ///     Описываем класс Изделие
    /// </summary>
    class Izdelie
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public int Kol { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Izdelie()
        {
        }
        /// <summary>
        /// Ввод объектов класса с клавиатуры
        /// </summary>
        public void Input()
        {
            Name = Console.ReadLine();
            Shift = Console.ReadLine();
            Kol = int.Parse(Console.ReadLine());
        }
    }
}
