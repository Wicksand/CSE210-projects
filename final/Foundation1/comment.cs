class Comment
{
    string commenter_;
    string comment_;

    public Comment()
    {

    }
    public Comment(string commenter, string comment)
    {
        commenter_ = commenter;
        comment_ = comment;
    }
    public string GetComment()
    {
        return $"{commenter_}: {comment_}";
    }

}