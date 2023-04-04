namespace CRUD.Models
{
    public class UserVM
    {
        public UserVM()
        {
            Users = new List<User>();
        }

        public User User { get; set; }
        public  ICollection<User> Users { get; set; }

    }
}
