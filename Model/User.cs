namespace user.Model
{
    public class User : Identifier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}