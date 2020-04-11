using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Amel", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jono", 46, 190302, "logical information", "Dosen@teacher.amikom.ac.id");
            teacher.GetNameAndAge();

            Student student = new Student("Havid Pradipta Husada", 19, 2721, "havid.husada@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}