using API.Interfaces;
using API.Models;

namespace API.Services
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
        public User Login(string email,string password)
        {
            var user = dBConn.Set<User>().Where(w=>w.Email==email&w.Password==password).FirstOrDefault();
            return user;
        }
        public List<User> GetUsers()
        {
            return dBConn.Set<User>().ToList(); 
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
