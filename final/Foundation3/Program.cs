using System;

class Program
{
    static void Main(string[] args)
    {
        Address place= new Address("Athens ave","Pompei","West","Greece");
        Lectures pythagrius=new Lectures("Triangles" ,"How to find the shortest distace between two points","3000 BC","5:30",place,"Pythagreouse",152 );
        pythagrius.DisplayFullLecture();
        pythagrius.DisplayShort();
        pythagrius.DisplayStandard();


         

        Address place2= new Address("Stone ave","Yellow city","Idaho","USA");
        Outdoor hike =new Outdoor("Hike","a walk through Yellow stone park","8/19/2026","8:30 in the moring",place2,"cloudy with a tempature of 89F");
        hike.DisplayFullOutdoorGathering();
        hike.DisplayShort();
        hike.DisplayStandard();
        

        Address place3= new Address("New ave","Las Vegas","Nevada","USA");
        Reception wedding=new Reception("Wedding Recpetion","We are here today for marriage","May 1st 2029","4:20 pm",place3,"emai@gmail.com");
        wedding.DisplayFullLecture();
        wedding.DisplayShort();
        wedding.DisplayStandard();
         
        

    }
}