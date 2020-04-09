using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    class Prototype : ICloneable
    {
        public Data information;
        public class Data
        {
            public string name { get; set; }
            public int age { get; set; }
        }
        public Prototype(String name, int age)
        {
            information = new Data();
            information.name = name;
            information.age = age;
        }
        public Prototype()
        {

        }
        public object Clone()
        {
            Prototype clone = new Prototype();
            clone.information = new Data();
            clone.information.name = information.name;
            clone.information.age = information.age;
            return clone;
        }
        public override string ToString()
        {
            return $"Name: {information.name}, age: {information.age}";
        }
    }
}
