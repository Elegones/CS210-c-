class Reception : Event
{
    private string _RSVP;

        public Reception (string title,string description,string date,string time, Address place,string RSVP):base(title,description,date,time,place)
    {
        _RSVP=RSVP;
        _type="Recpetion";

    }

}