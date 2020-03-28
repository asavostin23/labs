using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5_2
{
    public enum TypeControlEnum { Exam, Credit } //Тип контроля дисциплины - экзамен или зачет
    public class Subject //Дисциплина
    {
        public Subject() => ID = Guid.NewGuid();

        public Subject(
            string name,
            List<int> term,
            List<int> course,
            int lectureCount,
            int laboratoryCount,
            TypeControlEnum typeControl
            ) : base()
        {
            Name = name;
            Term = term;
            Course = course;
            LectureCount = lectureCount;
            LaboratoryCount = laboratoryCount;
            TypeControl = typeControl;
        }

        public string Name { get; set; } //Название дисциплины
        public List<int> Term { get; set; } //Семестр
        public List<int> Course { get; set; } //Курс
        public int LectureCount { get; set; } //Количество лекций
        public int LaboratoryCount { get; set; } //Количество лабораторных
        public TypeControlEnum TypeControl { get; set; } //Тип контроля
        public List<Lecturer> Lecturers { get; set; } = new List<Lecturer>();//Лекторы
        public Guid ID; //id дисциплины
    }
}
