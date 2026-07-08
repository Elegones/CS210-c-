public class Video
{
   private string _author;
   private string _title;
   private int _length;
    int num=0;

   public List<Comments> _commentSection=new List<Comments>();

   public Video(string author,string title, int length)
    {
        _author=author;
        _title=title;
        _length=length;

    }

    public int CommentCount()
    {
        int num=0;
        foreach(Comments coms in _commentSection)
        {
            num=num+1;
        }
        return num;
    }




}