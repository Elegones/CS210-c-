using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> tasks = new List<Goal>();
        int choice = 0;
        string name;
        string description;
        int points;
        int total;
        int bonus;
        int sessionScore=0;
        while (choice != 6)
        {
            Console.WriteLine($"Total points:{score}");
            if(score>sessionScore)
            {
                Console.WriteLine($"Current points:{sessionScore}");
            }
            
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1: List Goals");
            Console.WriteLine(" 2: Add goal");
            Console.WriteLine(" 3: Record Event");
            Console.WriteLine(" 4: Save Goals");
            Console.WriteLine(" 5: Load Goals");
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
                int i = -1;
                foreach (Goal goal in tasks)
                {
                    i++;
                    Console.Write($"{i}: ");
                    goal.Display();


                }

                int choiceTask = int.Parse(Console.ReadLine());
                int tasknum = 0;

                foreach (Goal goal in tasks)
                {
                    if (tasknum == choiceTask)
                    {
                        int x=goal.CompleteGoal();
                        score += x;
                        sessionScore+=x;
                    }
                    tasknum++;


                }




            }

            if (choice == 4)
            {
                string filename;
                Console.WriteLine("enter file name.");
                filename=Console.ReadLine();

                using (StreamWriter OutputFile = new StreamWriter(filename))
                {

                    OutputFile.WriteLine(score);


                    foreach (Goal trial in tasks)
                    {

                        OutputFile.WriteLine(trial.SaveGoals());
                      

                    }

                }

            }

            if(choice==5)
            {
                string filename;
                Console.WriteLine("enter file name.");
                filename=Console.ReadLine();

                using (StreamReader InputFile = new StreamReader(filename))
                {
                    string line;
                    string [] data=new string[1];

                    score+=int.Parse(InputFile.ReadLine());

                    while((line=InputFile.ReadLine())!= null)
                    {
                        data=line.Split('^');

                        if(data[0]=="Simple")
                        {
                            Simple simp = new Simple(data[2], data[3], int.Parse(data[4]),bool.Parse(data[1]) );
                            tasks.Add(simp); 
                        }

                        if(data[0]=="Eternal")
                        {
                            Eternal life = new Eternal( data[1], data[2],int.Parse(data[3]) );
                            tasks.Add(life); 
                        }
                        
                        if(data[0]=="Checklist")
                        {
                            CheckList cl=new CheckList( data[1], data[2],int.Parse(data[3]),int.Parse(data[4]),int.Parse(data[5]),int.Parse(data[6]) );
                            tasks.Add(cl);
                        }
                    }

                }
                

            }
        }

    }
}