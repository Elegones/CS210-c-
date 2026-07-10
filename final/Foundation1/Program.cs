using System;

class Program
{
      
    static void Main(string[] args)
    {
        List<Video> Videos=new List<Video>();

        Video SmaceMarines=new Video("Lorecrimes","Ultramarines",2000);
        Comments com =new Comments("User1","Good video");
        SmaceMarines._commentSection.Add(com);
        Comments com1 =new Comments("User2","my favorite chapter");
        SmaceMarines._commentSection.Add(com1);
        Comments com2 =new Comments("User3","Do space sharks next");
        SmaceMarines._commentSection.Add(com2);
        Videos.Add(SmaceMarines);

        Video IronHands=new Video("PancreaseNoWorks","Iron Hands",1000);
        Comments comm =new Comments("User1","Iron Within, Iron without");
        IronHands._commentSection.Add(comm);
        Comments comm1 =new Comments("User2","Ferius Manus Lost his head");
        IronHands._commentSection.Add(comm1);
        Comments comm2 =new Comments("User3","The machine is strong, the flesh is weak");
        IronHands._commentSection.Add(comm2);
        Comments comm3 =new Comments("User4","Glory to the ominisiah");
        IronHands._commentSection.Add(comm3);
        Videos.Add(IronHands);



        Video LTR=new Video("Acceptible Losses","The fall of the mines of moria",10000);
        Comments commm =new Comments("User1","Dorians day");
        LTR._commentSection.Add(commm);
        Comments commm1 =new Comments("User2","The dwarves dug to deep");
        LTR._commentSection.Add(commm1);
        Comments commm2 =new Comments("User3","Flee you fools");
        LTR._commentSection.Add(commm2);
        Comments commm3 =new Comments("User4","A fool of a Took");
        LTR._commentSection.Add(commm3);
        Videos.Add(LTR);

       foreach(Video vid in Videos)
        {
            vid.Display();
        }


    }
}