using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;
#pragma warning disable

namespace Homework_12
{
    // В программе описать классы:
    // Human(имя);
    // Professor(наследник Human);
    // Department(название, композиционно включает список сотрудников – объекты типа Human);
    // University(название, агрегационно включает список департаментов). 
    // Задать массив университетов.Сериализовать и десериализовать бинарной/xml/json.

    [Serializable]
    [DataContract]
    public class Human
    {
        [DataMember]
        public string Name { get; set; }
        public Human(string name) => Name = name;
        public Human() : this("Steve2.0") { }
    }

    [Serializable]
    [DataContract]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }
        public Professor() : base() { }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    [KnownType(typeof(Professor))]
    [KnownType(typeof(Human))]
    [DataContract]
    public class Department
    {
        [DataMember]
        public List<Human> employees = new();
        public Department() { }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    [XmlInclude(typeof(Department))]
    [KnownType(typeof(Professor))]
    [KnownType(typeof(Human))]
    [DataContract]
    public class Univercity
    {
        [DataMember]
        public string Name;

        [DataMember]
        public List<Department> Deps;

        public Univercity(string name, List<Department> deps) => (Name, Deps) = (name, deps);
        public Univercity() { }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Human[] employees = { new("Bob"), new Professor("Steve"), new("Anna"), new("Emy"), new("Samuel"), 
                new Professor("Tina") };

            Department dep1 = new();
            Department dep2 = new();
            Department dep3 = new();
            Department dep4 = new();

            dep1.employees.Add(employees[0]);
            dep1.employees.Add(employees[3]);
            dep2.employees.Add(employees[1]);
            dep3.employees.Add(employees[2]);
            dep3.employees.Add(employees[4]);
            dep3.employees.Add(employees[5]);
            dep4.employees.Add(employees[1]);

            List<Department> deps1 = new();
            List<Department> deps2 = new();
            List<Department> deps3 = new();
            deps1.Add(dep1);
            deps1.Add(dep4);
            deps2.Add(dep3);
            deps3.Add(dep2);

            Univercity[] mas = { new("U1", deps1), new("U2", deps2), new("U3", deps3) };
            Univercity[] res1, res2, res3;


            var bin = new BinaryFormatter();
            using(FileStream fs = new FileStream("Array.bin", FileMode.Create, FileAccess.Write))
            {
                bin.Serialize(fs, mas);
            }
            using (FileStream fs = new FileStream("Array.bin", FileMode.Open, FileAccess.Read))
            {
                res1 = (Univercity[])bin.Deserialize(fs);
            }

            var xml = new XmlSerializer(typeof(Univercity[]));
            using (FileStream fs = new FileStream("Array.xml", FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(fs, mas);
            }
            using (FileStream fs = new FileStream("Array.xml", FileMode.Open, FileAccess.Read))
            {
                res2 = (Univercity[])xml.Deserialize(fs);
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(Univercity[]));
            using (FileStream fs = new FileStream("Array.json", FileMode.Create, FileAccess.Write))
            {
                jsonFormatter.WriteObject(fs, mas);
            }

            using (FileStream fs = new FileStream("Array.json", FileMode.Open, FileAccess.Read))
            {
                res3 = (Univercity[])jsonFormatter.ReadObject(fs);
            }




        }
    }
}
