using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class RoutineController
    {
        private RoutineRepository routineRepository;
        private UserRepository userRepository;
        
        public void Options(UserRepository userRepository, RoutineRepository routineRepository)
        {
            this.userRepository = userRepository;
            this.routineRepository = routineRepository;
            string choice;
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 to create: ");
                Console.WriteLine("Enter 2 to list:");
                Console.WriteLine("Enter 3 to delete");
                Console.WriteLine("Enter 4 to edit");
                Console.WriteLine("Enter 5 to exit");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your choice");
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
            User user = null;
            string startTime = null;
            string endtime = null;
            string sets = null;
            string reps = null;
            DateTime stime ;
            DateTime etime;

            Console.WriteLine("Enter id :");
            if (id <= 0)
            {
                id = Convert.ToInt32(Console.ReadLine());
            }

            List<User> userList = userRepository.ShowAll();
            if (user == null)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("User List :");
                foreach(User u in userList)
                    Console.WriteLine(u);
                Console.WriteLine("----------------------");

                int userId = 0;
                while (userId <= 0)
                {
                    Console.WriteLine("Enter user id :");
                    userId = Convert.ToInt32(Console.ReadLine());
                    user = userRepository.ShowById(userId);
                }
            }

            
            Console.WriteLine("Enter start date time (yyyy-mm-dd hh:mm:ss): ");
            if(startTime == null)
                startTime = Console.ReadLine();
            stime = Convert.ToDateTime(startTime);
            
            
            Console.WriteLine("Enter end date time (yyyy-mm-dd hh:mm:ss): ");
            if(endtime == null)
                endtime = Console.ReadLine();
            etime = Convert.ToDateTime(endtime);
            
            Console.WriteLine("Enter sets : ");
            if (sets == null)
            {
                sets = Console.ReadLine();
            }

            Console.WriteLine("Enter reps : ");
            if (reps == null)
            {
                reps = Console.ReadLine();
            }

            Routine routine = new Routine(id, user, stime, etime, sets, reps);
            routineRepository.Create(routine);
            Console.WriteLine("Created Successfully");
        }

        public void ShowAll()
        {
            List<Routine> routines = routineRepository.ShowAll();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Routine List :");
            Console.WriteLine("---------------------------");
            foreach (Routine routine in routines)
            {
                Console.WriteLine(routine);
                Console.WriteLine("---------------------------");
            }
        }

        public void Delete()
        {
            int id;
            Console.WriteLine("Enter id to delete : ");
            id = Convert.ToInt32(Console.ReadLine());
            Routine routine = routineRepository.ShowById(id);
            if(routine == null)
            {
                Console.WriteLine("Routine with id " + id + " not found");
            }
            else
            {
                routineRepository.Delete(routine);
                Console.WriteLine("Deletion Sucessfull");
            }
        }

        public void Edit()
        {
            int id = 0;
            User user = null;
            string startTime = null;
            string endtime = null;
            string sets = null;
            string reps = null;
            DateTime stime;
            DateTime etime;

            Console.WriteLine("Enter id to edit :");
            id = Convert.ToInt32(Console.ReadLine());

            Routine r = routineRepository.ShowById(id);
            if (r == null)
            {
                Console.WriteLine("Routine with id " + id + " not found");
            }

            else {
                List<User> userList = userRepository.ShowAll();
                if (user == null)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("User List :");
                    foreach (User u in userList)
                        Console.WriteLine(u);
                    Console.WriteLine("----------------------");

                    int userId = 0;
                    while (userId <= 0)
                    {
                        Console.WriteLine("Enter user id :");
                        userId = Convert.ToInt32(Console.ReadLine());
                        user = userRepository.ShowById(userId);
                    }
                }


                Console.WriteLine("Enter start date time (yyyy-mm-dd hh:mm:ss): ");
                if (startTime == null)
                    startTime = Console.ReadLine();
                stime = Convert.ToDateTime(startTime);


                Console.WriteLine("Enter end date time (yyyy-mm-dd hh:mm:ss): ");
                if (endtime == null)
                    endtime = Console.ReadLine();
                etime = Convert.ToDateTime(endtime);

                Console.WriteLine("Enter sets : ");
                if (sets == null)
                {
                    sets = Console.ReadLine();
                }

                Console.WriteLine("Enter reps : ");
                if (reps == null)
                {
                    reps = Console.ReadLine();
                }

                Routine routine = new Routine(id, user, stime, etime, sets, reps);
                routineRepository.Edit(routine);
                Console.WriteLine("Edited Successfully");
            }
        }
    }
}
