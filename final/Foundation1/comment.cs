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
        //$"{splitcomment[1]}:\n{splitcomment[2]}"
    }
    public string GetComment()
    {
        return $"{commenter_}: {comment_}";
    }

}