using CheckDatabaseFromEF;
using KmiEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIRepository
{
   public class UserRepository
    {

        string userQuery = "Select  u.Id, FirstName, LastName, Age, Dept_Id, Gender,  address , d.Name as Department from [dbo].[User] u inner join [dbo].[Department] d on u.Dept_Id=d.Id ";

        string userCountQuery = "Select count(1) as count from [dbo].[User] u inner join [dbo].[Department] d on u.Dept_Id=d.Id ";
        public  UserRepository()
        {
            WorkdayContext = new WorkdayContext();
        }

        public WorkdayContext WorkdayContext { get; set; }
        public List<User> GetAll()
        {
           
            var userList = WorkdayContext.Users.Include("Department").ToList();
            return userList;
        }



        public int GetCount(UserSearch userSearch)
        {
            //var userList = WorkdayContext.Users.Include("Department").ToList();
            //return userList;


            var UserSearchQuery = userCountQuery + userSearch.GetSearchString();//  +userSearch.GetOrderByString()  +userSearch.GetPageString();
            int count = WorkdayContext.Database.SqlQuery<int>(UserSearchQuery).FirstOrDefault();

            return count;
        }

        public bool Delete(int id)
        {
          var user=  WorkdayContext.Users.FirstOrDefault(X => X.Id==id);

            if (user == null)
            {
                return false;
            }else
            {
                WorkdayContext.Users.Remove(user);
                WorkdayContext.SaveChanges();
                return true;
            }
             
        }

        public bool Delete(User user)
        {
            WorkdayContext.Users.Remove(user);
            WorkdayContext.SaveChanges();
            return true;
        }



        public List<User> GetAll2(UserSearch userSearch)
        {
            //var userList = WorkdayContext.Users.Include("Department").ToList();
            //return userList;


            var UserSearchQuery = userQuery + userSearch.GetSearchString() + userSearch.GetOrderByString() + userSearch.GetPageString();
            List<User> data = WorkdayContext.Database.SqlQuery<User>(UserSearchQuery).ToList();

            List<int> deptIds = data.Where(X => X.Dept_Id != null).Select(X => X.Dept_Id == null ? 0 : X.Dept_Id.Value).Distinct<int>().ToList();

            var dept = WorkdayContext.Departments.Where(X => deptIds.Contains(X.Id)).ToList();

            foreach (var item in data)
            {

                item.Department = dept.FirstOrDefault(x => x.Id == item.Dept_Id);

            }


            return data;
        }

        public List<User> GetAll(UserSearch userSearch)
        {
            //var userList = WorkdayContext.Users.Include("Department").ToList();
            //return userList;


            var UserSearchQuery = userQuery + userSearch.GetSearchString() + userSearch.GetOrderByString() + userSearch.GetPageString();
            List<UserDepartment> dataUd = WorkdayContext.Database.SqlQuery<UserDepartment>(UserSearchQuery).ToList();

            var data = dataUd.Select(x => new User
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Dept_Id = x.Dept_Id,
                Gender = x.Gender,
                Department = x.Dept_Id.HasValue && x.Dept_Id != 0 ? new Department
                {
                    Id = x.Dept_Id.Value,
                    Name = x.Department
                } : null

            }).ToList();


            return data;
        }

        public User GetById(int id)
        {
            var User = WorkdayContext.Users.Include("Department").FirstOrDefault(X=>X.Id==id);
            return User;
        }

        public User Save(User user)
        {
            if (user.Id == 0)
            {
                WorkdayContext.Entry(user).State = EntityState.Added;
            }
            else
            {
                WorkdayContext.Entry(user).State = EntityState.Modified;
            }
            WorkdayContext.SaveChanges();
            return user;
        }
    }
}
