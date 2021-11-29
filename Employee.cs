using System;

namespace Employee
{
    class Employee
    {
        public int Id { get; set; }
        public string surname;
        public string name;
        public string patronymic;
        public string department;
        public int phone;

        private string[] surnames = new string[] { "Ptahin","Moiseenko","Bradu", "Makalich","Yretya" };
        private string[] names = new string[] { "Sasha", "Vitaliy","Alexey", "Denis","Vadim" };
        private string[] patronymics= new string[] { "Alexandrovich", "Vitalievich","Alexeevich", "Denisovich","Vadimovich" };
        private string[] departments = new string[] { "Dex", "Рос-Нефть", "ПГУ","IDC","Sherif" };

        public Employee()
        {
            Random rand = new Random();

            surname = surnames[new Random().Next(0, surnames.Length)];
            name = names[new Random().Next(0, names.Length)];
            patronymic = patronymics[new Random().Next(0, patronymics.Length)];
            department = departments[new Random().Next(0, departments.Length)];
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Id,-9}│{surname,-14}│{name,-14}│{patronymic,-15}│{department,-15}│{phone,-20}");
        }
    }
}
