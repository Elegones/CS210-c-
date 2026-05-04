using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1= new Job();
       job1._jobTitle=" Aprentace Electrical Engineer";
       job1._company="PNL";
       job1._startYear= 2009;
       job1._endYear=2015;


       Job job2= new Job();
       job2._jobTitle="Master Electrical Engineer";
       job2._company="Lockhead Martin ";
       job2._startYear= 2015;
       job2._endYear=2025;

      Resume r1 =new Resume();
      r1._name="Ethan Legones";
      r1._jobs.Add(job1);
      r1._jobs.Add(job2);

      r1.DisplayResume();
    }
}