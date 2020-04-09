using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5_2
{
    public class Lecturer //Лектор
    {
        public Lecturer() => ID = Guid.NewGuid();

        public Lecturer(
            string surname,
            string name,
            string patronymic,
            string pulpit,
            string auditorium,
            string dateOfBirth,
            int salary,
            int experience,
            string phone
            ) : base()
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Pulpit = pulpit;
            Auditorium = auditorium;
            DateOfBirth = dateOfBirth;
            Salary = salary;
            Experience = experience;
            Phone = phone;
        }

        public string Pulpit { get; set; } //Кафедра
        public string Surname { get; set; } //Фамилия
        public string Name { get; set; } //Имя
        public string Patronymic { get; set; } //Отчество
        public string Auditorium { get; set; } //Аудитория
        public string DateOfBirth { get; set; } //Дата рождения
        public int Salary { get; set; } //Зарплата
        public int Experience { get; set; } //Стаж
        public string Phone { get; set; } //Телефон
        public Guid ID; //id лектора

        public override bool Equals(object obj)
        {
            return obj is Lecturer lecturer &&
                   Pulpit == lecturer.Pulpit &&
                   Surname == lecturer.Surname &&
                   Name == lecturer.Name &&
                   Patronymic == lecturer.Patronymic &&
                   Auditorium == lecturer.Auditorium &&
                   DateOfBirth == lecturer.DateOfBirth &&
                   Salary == lecturer.Salary &&
                   Experience == lecturer.Experience &&
                   Phone == lecturer.Phone;
        }

        public override int GetHashCode()
        {
            int hashCode = -1788211264;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Pulpit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Patronymic);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Auditorium);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DateOfBirth);
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            hashCode = hashCode * -1521134295 + Experience.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            return hashCode;
        }
    }
}
