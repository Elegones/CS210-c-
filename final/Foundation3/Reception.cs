class Reception : Event
{
    private string _RSVP;

        public Reception (string title,string description,string date,string time, Address place,string RSVP):base(title,description,date,time,place)
    {
        _RSVP=RSVP;
        _type="Recpetion";

    }

    public void DisplayFullLecture()
    {
         Console.WriteLine($"{_title}\n {_type}: {_description}\nDate:{_date},Time:{_time}\n ");
         DisplayAddress();
         Console.WriteLine($"RSVP at:{_RSVP}");
         Console.WriteLine();
    }

}