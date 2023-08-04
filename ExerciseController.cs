using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class ExerciseController
    {
        private ExerciseRepository exerciseRepository;

        public void Options(ExerciseRepository exerciseRepository)
        {
            this.exerciseRepository = exerciseRepository;
            string choice;

            do
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 to Create");
                Console.WriteLine("Enter 2 to Show");
                Console.WriteLine("Enter 3 to Delete");
                Console.WriteLine("Enter 4 to Edit");
                Console.WriteLine("Enter 5 or any key to exit");
                Console.WriteLine("*****************************");
                Console.WriteLine("Enter your choice :");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Create();
                        break;
                    case "2":
                        ShowAll();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Edit();
                        break;
                    default:
                        return;
                }
            } while (choice != "0");
        }

        public void Create()
        {
            int id = 0;
            string name = null;
            string type = null;

            while (id <= 0)
            {
                Console.WriteLine("Enter Exercise ID : ");
                id = Convert.ToInt32(Console.ReadLine());
            }

            while (name == null)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
            }

            while (type == null)
            {
                Console.WriteLine("Enter type : ");
                type = Console.ReadLine();
            }

            Exercise exercise = new Exercise(id, name, type);
            exerciseRepository.Create(exercise);
            Console.WriteLine("Created Successfully");
        }
        public void ShowAll()
        {
            List<Exercise> list = exerciseRepository.ShowAll();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Exercise List");
            foreach (Exercise e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------------");
        }
        public void Delete()
        {
            int id;
            Console.WriteLine("Enter Id to delete:");
            id = Convert.ToInt32(Console.ReadLine());
            Exercise exercise = exerciseRepository.ShowById(id);
            if (exercise == null)
            {
                Console.WriteLine("Exercise of Id " + id + " not found");
            }
            else
            {
                exerciseRepository.Delete(exercise);
                Console.WriteLine("Deletion Sucessfull");
            }
        }
        public void Edit()
        {
            int id;
            string name = null;
            string type = null;

            Console.WriteLine("Enter Id to edit:");
            id = Convert.ToInt32(Console.ReadLine());
            Exercise e = exerciseRepository.ShowById(id);
            if (e == null)
            {
                Console.WriteLine("Exercise of Id " + id + " not found");
            }
            else
            {
                while (name == null)
                {
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                }

                while (type == null)
                {
                    Console.WriteLine("Enter type : ");
                    type = Console.ReadLine();
                }

                Exercise exercise = new Exercise(id, name, type);
                exerciseRepository.Edit(exercise);
                Console.WriteLine("Created Successfully");
            }

        }
    }
}
