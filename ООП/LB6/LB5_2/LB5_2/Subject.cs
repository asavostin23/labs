using System;
using System.Collections.Generic;



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

        public override bool Equals(object obj)
        {
            if (obj is Subject)
            {
                Subject temp = (Subject)obj;
                return 
                       Name == temp.Name &&
                       //EqualityComparer<List<int>>.Default.Equals(Term, temp.Term) &&
                       //EqualityComparer<List<int>>.Default.Equals(Course, temp.Course) &&
                       LectureCount == temp.LectureCount &&
                       LaboratoryCount == temp.LaboratoryCount &&
                       TypeControl == temp.TypeControl /*&&*/
                       /*EqualityComparer<List<Lecturer>>.Default.Equals(Lecturers, temp.Lecturers)*/;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 1496227704;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(Term);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(Course);
            hashCode = hashCode * -1521134295 + LectureCount.GetHashCode();
            hashCode = hashCode * -1521134295 + LaboratoryCount.GetHashCode();
            hashCode = hashCode * -1521134295 + TypeControl.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Lecturer>>.Default.GetHashCode(Lecturers);
            return hashCode;
        }
    }
}
