using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollectionSample
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Bir student interface döndüren method
        public IList<Student> GetStudentList()
        {
            IList<Student> students = new List<Student>()
            {
                new Student ()
                {
                    StudentID = 1,
                    FirstName = "Jax",
                    LastName = "Teller",
                    Age = 28,
                },

                new Student ()
                {
                    StudentID = 2,
                    FirstName = "Tony",
                    LastName = "Montana",
                    Age = 32,
                },

                new Student ()
                {
                    StudentID = 3,
                    FirstName = "Tony",
                    LastName = "Soprano",
                    Age = 37,
                },

                new Student ()
                {
                    StudentID = 4,
                    FirstName = "Ross",
                    LastName = "Geller",
                    Age = 29,
                }
            };

            return students;
        }
    }
}
