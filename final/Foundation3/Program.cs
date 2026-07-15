using System;

class Program
{
    static void Main(string[] args)
    {
        Address place= new Address("Athens ave","Pompei","West","Greece");
        Lectures pythagrius=new Lectures("Triangles" ,"How to find the shortest between two points","3000 BC","5:30",place,"Pythagreouse",152 );
        pythagrius.DisplayFullLecture();
        pythagrius.DisplayShort();
        pythagrius.DisplayStandard();

    }
}