using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using KMISMModels;
using KMISMDBContext;

namespace KMISMRepository
{
 public   class StudentRepository
    {

        string _studentQuery = "SELECT   S.[id],[FirstName],[LastName],[Doj],[Age],[SubjectID],Ts.Id as [subject.Id],TS.Name as [subject.Name]  FROM [students].[dbo].[TblStudents] s Left Join TblSubjects Ts  On s.SubjectID=Ts.Id";
        string _studentCountQuery = "SELECT  Count(1) as CountValue  FROM [students].[dbo].[TblStudents] s Left Join TblSubjects Ts  On s.SubjectID=Ts.Id";

        public StudentDBContext StudentDBContext { get; set; }
        public StudentRepository()
        {
            StudentDBContext = new StudentDBContext();
        }
        public  IQueryable<T> OrderByDynamic<T>(IQueryable<T> query, string sortColumn, bool descending)
        {
           var parameter = Expression.Parameter(typeof(T), "p");

            string command = "OrderBy";
            if (descending)
            {
                command = "OrderByDescending";
            }
            Expression resultExpression = null;
            var property = typeof(T).GetProperty(sortColumn);
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { typeof(T), property.PropertyType },
            query.Expression, Expression.Quote(orderByExpression));
            return query.Provider.CreateQuery<T>(resultExpression);
        }

        public Student SaveStudent(Student student)
        {
            if(student.Id.HasValue && student.Id.Value > 0)
            {
                this.StudentDBContext.StudentDbSet.Attach(student);
                this.StudentDBContext.Entry(student).State = System.Data.Entity.EntityState.Modified;
                this.StudentDBContext.SaveChanges();
            }else
            {
                this.StudentDBContext.StudentDbSet.Add(student);
                this.StudentDBContext.SaveChanges();
            }

            return student;
        }

        public void DeleteStudentById(int id)
        {
            Student student = this.StudentDBContext.StudentDbSet.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {

            } else
            {
                this.StudentDBContext.StudentDbSet.Remove(student);
                this.StudentDBContext.SaveChanges();
            }
        }

        public Student GetStudentById(int id)
        {
            Student Student = this.StudentDBContext.StudentDbSet.FirstOrDefault(x => x.Id == id);
            return Student;
        }

        public List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student>();
            lstStudent.Add(new Student
            {
                Id = 1,
                FirstName = "Shubham",
                LastName = "P",
                Subject = new Subject
                {
                    Id = 1,
                    Name = "Angular"
                },
                Age = 23


            });

            lstStudent.Add(new Student
            {
                Id = 2,
                FirstName = "Rituja",
                LastName = "K",
                Subject = new Subject
                {
                    Id = 2,
                    Name = "React"
                },
                Age = 21


            });

            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });

            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });


            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });


            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });



            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });



            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });


            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });


            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Abuzar",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Swapnil",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Salman",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Sanju",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Amy",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Aayvya",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Ind",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Vivek",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Alakh",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Sandeep",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Pradeep",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Mayank",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "Nitish",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });
            lstStudent.Add(new Student
            {
                Id = 3,
                FirstName = "manish",
                LastName = "s",
                Subject = new Subject
                {
                    Id = 3,
                    Name = "MVC"
                },
                Age = 20


            });














            return lstStudent;
        }

        public List<Student> GetStudents_INlineData(StudentSearchModel studentSearch)
        {
            var lstStudent = GetStudents();
            string columnName = studentSearch.ColumnName;
            string orderBy = studentSearch.OrderBy;
            lstStudent = studentSearch.GetWhere(lstStudent);
            if ("Id".Equals(columnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.OrdinalIgnoreCase))
                {
                    lstStudent = lstStudent.OrderBy(X => X.Id).ToList();
                }
                else
                {
                    lstStudent = lstStudent.OrderByDescending(X => X.Id).ToList();
                }
            }

            if ("FirstName".Equals(columnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.OrdinalIgnoreCase))
                {
                    lstStudent = lstStudent.OrderBy(X => X.FirstName).ToList();
                }
                else
                {
                    lstStudent = lstStudent.OrderByDescending(X => X.FirstName).ToList();
                }
            }



            return lstStudent.ToList();
        }

        public int GetStudentsCount(StudentSearchModel studentSearch)
        {
            
            var countQuery = _studentCountQuery + studentSearch.GetWhere();
            var count=this.StudentDBContext.Database.SqlQuery<int>(countQuery).FirstOrDefault();
            return count;
        }

            public List<Student> GetStudents(StudentSearchModel studentSearch)
           {

            var lst=   this.StudentDBContext.LoginUserDbSet.ToList();
            var count = GetStudentsCount(studentSearch);
            studentSearch.Pagination.GetPages(count);
            var query = _studentQuery + studentSearch.GetWhere()  + studentSearch.GetOrderBy() + studentSearch.GetPages();
            var studentList = this.StudentDBContext.Database.SqlQuery<Student>(query).ToList();
            return studentList;

         }

        public List<Student> GetStudentsWithLinq(StudentSearchModel studentSearch)
        {
            var studentIQ = studentSearch.GetWhere(StudentDBContext.StudentDbSet.Include("Subject").AsQueryable());
            var studentList = studentSearch.GetOrderBy(studentIQ).ToList();
            return studentList;

        }
            public List<Student> GetStudents(string columnName, string orderBy)
        {

          
        var lstStudent = GetStudents();
            if ("Id".Equals(columnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.OrdinalIgnoreCase))
                {
                    lstStudent = lstStudent.OrderBy(X => X.Id).ToList();
                }
                else
                {
                    lstStudent = lstStudent.OrderByDescending(X => X.Id).ToList();
                }
            }

            if ("FirstName".Equals(columnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("asc".Equals(orderBy, StringComparison.OrdinalIgnoreCase))
                {
                    lstStudent = lstStudent.OrderBy(X => X.FirstName).ToList();
                }
                else
                {
                    lstStudent = lstStudent.OrderByDescending(X => X.FirstName).ToList();
                }
            }



            return lstStudent;
        }


        public void AddUsers()
        {
            var lstStudent = GetStudents();

            foreach (var item in lstStudent)
            {
                StudentDBContext.StudentDbSet.Add(item);
            }

            StudentDBContext.SaveChanges();
        }

         
    }
}
