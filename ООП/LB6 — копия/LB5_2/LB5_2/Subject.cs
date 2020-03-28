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
        public List<int> Term { get; set; } = new List<int>();//Семестр
        public List<int> Course { get; set; } = new List<int>(); //Курс
        public int LectureCount { get; set; } //Количество лекций
        public int LaboratoryCount { get; set; } //Количество лабораторных
        public TypeControlEnum TypeControl { get; set; } //Тип контроля
        public List<Lecturer> Lecturers { get; set; } = new List<Lecturer>();//Лекторы
        public Guid ID; //id дисциплины

        //public object Clone()
        //{
        //    Subject temp = new Subject();
        //    temp.Name = Name;
        //    temp.Term.AddRange(Term);
        //    temp.Course.AddRange(Course);
        //    temp.LectureCount = LectureCount;
        //    temp.LaboratoryCount = LaboratoryCount;
        //    temp.TypeControl = TypeControl;
        //    temp.ID = ID;
        //    temp.Lecturers = new List<Lecturer>();
        //    foreach (var lecturer in Lecturers)
        //        temp.Lecturers.Add((Lecturer)lecturer.Clone());
        //    return temp;
        //}

        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   Name == subject.Name &&
                   EqualityComparer<List<int>>.Default.Equals(Term, subject.Term) &&
                   EqualityComparer<List<int>>.Default.Equals(Course, subject.Course) &&
                   LectureCount == subject.LectureCount &&
                   LaboratoryCount == subject.LaboratoryCount &&
                   TypeControl == subject.TypeControl &&
                   EqualityComparer<List<Lecturer>>.Default.Equals(Lecturers, subject.Lecturers);
        }

       
    }
}
