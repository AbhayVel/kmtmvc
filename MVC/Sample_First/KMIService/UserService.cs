using CheckDatabaseFromEF;
using KmiEntities;
using KMIRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIService
{
  public   class UserService
    {

        public UserRepository UserRepository { get; set; }
        public UserService()
        {
            UserRepository  = new UserRepository();
        }
        public List<User> GetAll()
        {
            var userList = UserRepository.GetAll();
            return userList;
        }
     public int   GetCount(UserSearch userSearch)
        {
             var count = UserRepository.GetCount(userSearch);
            return count;
        }


        public List<User> GetAll(UserSearch userSearch)
        {
            var userList = UserRepository.GetAll(userSearch);
            return userList;
        }

        public User GetById(int id)
        {
            User user = UserRepository.GetById(id);
            return user;
        }

        public bool Delete(int id)
        {
            return UserRepository.Delete(id);
             
        }


        public bool Delete(User user)
        {
            return UserRepository.Delete(user);

        }
        public User Save(int id, User user)
        {

            //User userData = UserRepository.GetById(id);
            //if (userData == null)
            //{
            //    userData = new User();
            //}

            //userData.FirstName = user.FirstName;
            //userData.LastName = user.LastName;
            //userData.Age = user.Age;
            //userData.Dept_Id = user.Dept_Id;
            //userData.Gender = user.Gender;

            user = UserRepository.Save(user);

            return user;
        }
    }
}
