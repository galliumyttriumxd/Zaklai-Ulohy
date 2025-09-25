namespace Zaklai_Ulohy.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public List<string> Predmet { get; set; }
    }
}
