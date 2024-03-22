
namespace Bank_Project.classe
{
    public class Person
    {

        // propriétés
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public DateTime BirthDate { get; set; }
    }

}
