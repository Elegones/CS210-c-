class Lectures:Event
{
    private string _speaker;
    private int _capacity;
    

    public Lectures(string title,string description,string date,string time, Address place,string speaker,int cap):base(title,description,date,time,place)
    {
        _speaker=speaker;
        _capacity=cap;
        _type="Lecture";
    }

        public void DisplayFullLecture()
    {
        
         Console.WriteLine($"{_type}:{_title} by {_speaker} \n Summary:{_description} \n Date:{_date} at {_time}\n Total capacity {_capacity}");
         DisplayAddress();
         Console.WriteLine();
    }
}