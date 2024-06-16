using WebAppL.Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WebAppL.Service
{
    public class ListService : IListService
    {
        private readonly string _filePath = "Persons.json";
        private List<PersonModel> _persons;

        public ListService()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _persons = JsonConvert.DeserializeObject<List<PersonModel>>(json) ?? new List<PersonModel>();
            }
            else
            {
                CreateJson(_filePath);

                try
                {
                    var json = File.ReadAllText(_filePath);
                    _persons = JsonConvert.DeserializeObject<List<PersonModel>>(json) ?? new List<PersonModel>();
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<PersonModel> GetAll()
        {
            return _persons;
        }

        public void Add(PersonModel item)
        {
            _persons.Add(item);
            
            Save();
        }

        public void Save()
        {
            string jsonData = JsonConvert.SerializeObject(_persons, Formatting.Indented);
            try
            {
                File.WriteAllText(_filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании JSON файла: {ex.Message}");
            }
        }

        public void CreateJson(string filePath)
        {
            _persons = new List<PersonModel>();
            _persons.Add(new PersonModel
            {
                Surname = "Гринев",
                Name = "Алексей",
                MidName = "Ярославович",
                Group = "571-2",
                TelNum = "87678787878",
                Email = "alexa@mvx.com"
            });
            Save();
        }

    }
}
