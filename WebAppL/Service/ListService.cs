using WebAppL.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WebAppL.Service
{
    public class ListService
    {
        private readonly string _filePath = "Persons.json";
        private List<PersonModel> _persons;

        public ListService()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _persons = JsonSerializer.Deserialize<List<PersonModel>>(json) ?? new List<PersonModel>();
            }
            else
            {
                _persons = new List<PersonModel>();
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
            var json = JsonSerializer.Serialize(_persons);
            File.WriteAllText(_filePath, json);
        }

    }
}
