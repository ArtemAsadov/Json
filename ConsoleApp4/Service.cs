using System.Runtime.Serialization;
using System;
using static ConsoleApp4.Program;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    public static class Service
    {
        private const string _path = "DBPersons.json";
        public static DB db = new DB();
        public static void CreatePerson(string name, int speed, int time)
        {
            Person person = new Person(name, speed, time);
            person.Move();
            db.persons.Add(person);
            Save(db);
        }
        public static void Save(DB db)
        {
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.Create))
                {

                    string serialized = JsonConvert.SerializeObject(db.persons);
                    byte[] array = System.Text.Encoding.Default.GetBytes(serialized);
                    fs.Write(array, 0, array.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public static void Open()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_path))
                {
                    string json = sr.ReadToEnd();
                    List<Person> items = JsonConvert.DeserializeObject<List<Person>>(json);
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

    }

}
