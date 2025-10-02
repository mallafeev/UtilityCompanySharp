using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Models.Enums
{
    public static class EnumExtensions
    {
        public static List<string> ToListWithAll<T>()
        {
            var list = new List<string> { "Все" }; // Добавляем "Все" в начало
            list.AddRange(Enum.GetValues(typeof(T)).Cast<T>().Select(e => e.ToString()));
            return list;
        }
    }
}
