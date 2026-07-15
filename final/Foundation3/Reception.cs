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
         Console.WriteLine($"Title:{_title},Summary:{_description},Date:{_date},Time:{_time},Event:{_type},Location:{_location},RSVP at:{_RSVP}");
    }

}