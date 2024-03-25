using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Class1
    {

        public string Name { get; set; }
        public string SubName { get; set; }
        public DateTime DateTime { get; set; }
        public int number { get; set; }
        public string Show()
        {
            return $"Имя {Name}\nФамилия: {SubName}\n  Дата рождения {DateTime.ToString("dd-MM-yyyy")}";
        }
        public void User(string _Name, string _SubName , DateTime _DateTime)
        {

            Name = _Name;
            SubName = _SubName;
            DateTime = _DateTime;
            

        }

    }
}
