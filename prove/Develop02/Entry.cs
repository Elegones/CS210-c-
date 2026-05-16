using System;



    public class Entry()
    {
        public string _date;
        public string _prompt;
        public string _respose;
        public int _entryNum;

    public void Display()
    {
        Console.WriteLine($"Entry number# {_entryNum}\n Todays date is {_date}\n {_prompt}: {_respose} ");
    }


    }
