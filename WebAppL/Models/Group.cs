namespace WebAppL.Models
{
    public class Group
    {
        public string Number { get; set; }

        public List<PersonModel> Persons { get; set; }

        public Group(string GroupNum)
        {
            Number = GroupNum;
            Persons = new List<PersonModel>();
        }

        public Group()
        {
            Number = "";
            Persons = new List<PersonModel>();
        }
    }
}
