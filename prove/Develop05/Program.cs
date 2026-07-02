using System;

class Program
{
    static void Main(string[] args)
    {
        int score=0;
        List<Goal> tasks = new List<Goal>();
        int choice = 0;
        string name;
        string description;
        int points;
        int total;
        int bonus;
        while (choice != 6)
        {
            Console.WriteLine($"Total points:{score}");
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1: List Goals");
            Console.WriteLine(" 2: Add goal");
            Console.WriteLine(" 3: Record Event");
            Console.WriteLine(" 4: Load Goals");
            Console.WriteLine(" 5: save Goals");
            Console.WriteLine(" 6: Exit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                foreach (Goal goal in tasks)
                {
                    goal.Display();

                }

            }



            if (choice == 2)
            {
                Console.WriteLine("what type of goal do you want to add?");
                Console.WriteLine(" 1: Simple Goal");
                Console.WriteLine(" 2: Checklist goal");
                Console.WriteLine(" 3: Eternal Event");
                int choices = int.Parse(Console.ReadLine());



                if (choices == 1)
                {
                    Console.WriteLine("What is the Goals name?");
                    name = Console.ReadLine();

                    Console.WriteLine("Give a description of the Goal");
                    description = Console.ReadLine();

                    Console.WriteLine("How many points should this goal be worth");
                    points = int.Parse(Console.ReadLine());

                    Simple simp = new Simple(name, description, points);
                    tasks.Add(simp);

                }

                if (choices == 2)
                {
                    Console.WriteLine("What is the Goals name?");
                    name = Console.ReadLine();

                    Console.WriteLine("Give a description of the Goal");
                    description = Console.ReadLine();

                    Console.WriteLine("How many points should this goal be worth");
                    points = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many times should this goal be completed");
                    total = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many points should you get extra for completing it for the required amount");
                    bonus = int.Parse(Console.ReadLine());

                    CheckList check = new CheckList(name, description, points, total, bonus);

                    tasks.Add(check);

                }

                if (choices == 3)
                {
                    Console.WriteLine("What is the Goals name?");
                    name = Console.ReadLine();

                    Console.WriteLine("Give a description of the Goal");
                    description = Console.ReadLine();

                    Console.WriteLine("How many points should this goal be worth");
                    points = int.Parse(Console.ReadLine());

                    Eternal ent = new Eternal(name, description, points);
                    tasks.Add(ent);

                }

            }

            if (choice == 3)
            {
                Console.WriteLine("selesct which the goal number you want to record doing");
                int i=-1;
                foreach (Goal goal in tasks)
                {
                    i++;
                    Console.Write($"{i}: ");    
                    goal.Display();


                }

                int choiceTask=int.Parse(Console.ReadLine());
                int tasknum=0;

                foreach (Goal goal in tasks)
                {
                    if(tasknum==choiceTask)
                    {
                       score=+ goal.CompleteGoal();
                    }
                    tasknum++;


                }



            }

        }

    }
}