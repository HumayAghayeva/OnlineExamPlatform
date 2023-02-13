using RegisterAPI.Models;

namespace RegisterAPI.Interfaces
{
    public interface IUser
    {
        public User GetUsers();
        public User GetUser(int Id);
        public void AddUser(User user);
        public User UpdateUser(User user);
        public void DeleteUser(int Id);
    }
}
