namespace TugasPraktikumPAA1.Models
{
    public class PersonContext
    {
        private List<Person> list1 = new List<Person>();

        public PersonContext()
        {
            Object[,] arrayPerson = new Object[,]{
                {1, "Fairuz", "Jember", "fairuz@gmail.com" },
                {2, "Diki", "Banyuwangi", "diki@gmail.com" },
                {3, "Panji", "Lumajang", "panji@gmail.com" }
            };

            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                list1.Add(new Person()
                {
                    id_person = int.Parse(arrayPerson[i, 0].ToString()),
                    nama = arrayPerson[i, 1].ToString(),
                    alamat = arrayPerson[i, 2].ToString(),
                    email = arrayPerson[i, 3].ToString()
                });
            }
        }

        
        public List<Person> ListPerson()
        {
            return list1;
        }

   
        public Person? GetPersonById(int id)
        {
            return list1.FirstOrDefault(p => p.id_person == id);
        }
    }
}
