using RegisterAPI.Interfaces;
using RegisterAPI.Models;

namespace RegisterAPI.Services
{
    public class IUserService : IUser
    {
        private readonly DBConn dBConn;
        public IUserService(DBConn _dBConn)
        {
            dBConn = _dBConn;
        }
        public void AddUser(User user)
        {
           dBConn.Add<User>(user);
           dBConn.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            dBConn.Remove(Id);
            dBConn.SaveChanges();
        }

        public User GetUser(int Id)
        {
            return dBConn.Set<User>().Find(Id);
        }

        public User GetUsers()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {

            dBConn.Set<User>().Update(user);
            dBConn.SaveChanges();
            return user;
        }

        void IUser.AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
