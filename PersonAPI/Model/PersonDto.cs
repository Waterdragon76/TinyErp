namespace PersonAPI.Model
{
    public class PersonDto
    {
        public PersonDto(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonDto()
        {
        }

        public int Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
