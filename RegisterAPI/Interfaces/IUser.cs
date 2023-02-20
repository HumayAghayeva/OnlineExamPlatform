using OnlineExamAPI.Models;

namespace OnlineExamAPI.Interfaces
{
    public interface IUser
    {
        public List<User> GetUsers();
        public User GetUser(int Id);
        public void AddUser(User user);
        public User Login(string email,string password);
        public User UpdateUser(User user);
        public void DeleteUser(int Id);
    }
}
