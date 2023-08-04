using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class WorkoutController
    {
        private WorkoutRepository workoutRepository;
        private RoutineRepository routineRepository;

        public void Options(WorkoutRepository workoutRepository, RoutineRepository routineRepository)
        {
            this.routineRepository = routineRepository;
            this.workoutRepository = workoutRepository;

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
            Routine routine = null;
            string name = null;
            string type = null;

            while (id <= 0)
            {
                Console.WriteLine("Enter Workout Id :");
                id = Convert.ToInt32(Console.ReadLine());
            }

            List<Routine> routineList = routineRepository.ShowAll();

            while (routine == null)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Routine List :");
                foreach (Routine r in routineList)
                    Console.WriteLine(r);
                Console.WriteLine("----------------------");

                int routineId = 0;
                while (routineId <= 0)
                {
                    Console.WriteLine("Enter routine id :");
                    routineId = Convert.ToInt32(Console.ReadLine());
                    routine = routineRepository.ShowById(routineId);
                }
            }

            while (name == null)
            {
                Console.WriteLine("Enter workout name :");
                name = Console.ReadLine();
            }

            while (type == null)
            {
                Console.WriteLine("Enter workout type : ");
                type = Console.ReadLine();
            }

            Workout workout = new Workout(id, routine, name, type);
            workoutRepository.Create(workout);
            Console.WriteLine("Created Successfully");
        }

        public void ShowAll()
        {
            List<Workout> workoutList = workoutRepository.ShowAll();
            Console.WriteLine("------------------------");
            Console.WriteLine("Workout List :");
            foreach (Workout w in workoutList)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("------------------------");
        }

        public void Delete()
        {
            int id;
            Console.WriteLine("Enter Id to delete : ");
            id = Convert.ToInt32(Console.ReadLine());
            Workout workout = workoutRepository.ShowById(id);
            if (workout == null)
            {
                Console.WriteLine("Workout with id " + id + " not found");
            }
            else
            {
                workoutRepository.Delete(workout);
                Console.WriteLine("Deletion Successfull");
            }

        }

        public void Edit()
        {
            Routine routine = null;
            string name = null;
            string type = null;
            int id;

            Console.WriteLine("Enter Id to edit : ");
            id = Convert.ToInt32(Console.ReadLine());
            Workout w = workoutRepository.ShowById(id);
            if (w == null)
            {
                Console.WriteLine("Workout with id " + id + " not found");
            }
            else
            {
                List<Routine> routineList = routineRepository.ShowAll();

                while (routine == null)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Routine List :");
                    foreach (Routine r in routineList)
                        Console.WriteLine(r);
                    Console.WriteLine("----------------------");

                    int routineId = 0;
                    while (routineId <= 0)
                    {
                        Console.WriteLine("Enter routine id :");
                        routineId = Convert.ToInt32(Console.ReadLine());
                        routine = routineRepository.ShowById(routineId);
                    }
                }

                while (name == null)
                {
                    Console.WriteLine("Enter workout name :");
                    name = Console.ReadLine();
                }

                while (type == null)
                {
                    Console.WriteLine("Enter workout type : ");
                    type = Console.ReadLine();
                }

                Workout workout = new Workout(id, routine, name, type);
                workoutRepository.Edit(workout);
                Console.WriteLine("Edited Successfully");
            }

        }
    }
}