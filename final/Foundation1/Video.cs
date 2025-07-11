using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using System.Reflection;

class Video
{
    private string title_;
    private string author_;
    private int length_;

    private List<Comment> comments_;
    public Video()
    {

    }
    public Video(string title, string author, int length)
    {
        title_ = title;
        author_ = author;
        length_ = length;
        comments_ = new List<Comment>();

    }
    public string GetVideo()
    {
        return $"Video Title: {title_}\nAuthor: {author_}\nLength: {length_} seconds\nNumber of Comments: {comments_.Count}";
    }
    public void AddComment(string commenter, string comment)
    {
        Comment commentobj = new Comment(commenter, comment);
        comments_.Add(commentobj);
    }
    public List<Comment> GetComments()
    {
        return comments_;
    }
}