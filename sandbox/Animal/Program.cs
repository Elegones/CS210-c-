
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {

        List<Animal> myAnimals=new List<Animal>();
        myAnimals.Add( new Animal("Liger"));
        myAnimals.Add( new Dog("pepper"));

        foreach (Animal critter in myAnimals)
        {
         critter.MakeNoise();
        }
     
    }


}
