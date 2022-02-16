using System;
using System.Collections.Generic;
using System.Text;


namespace Services{
    class Post{
      public DateTime Moment { get; set; }
      public string Title { get; set; }
      public string Content { get; set; }
      public int Likes { get; set; }
      public List<Comment> Comments {get; set;} = new List<Comment>();
    
    public Post(){
    }
    public Post(DateTime moment, string title, string content,int likes ){
       Moment= moment;
       Title = title;
       Content = content;
       Likes = likes;
    }
    public void AddComment(Comment comment){
        Comments.Add(comment);
    }
    public void RemoveComment(Comment comment){
        Comments.Remove(comment);
    }
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss")+"  Likes: "+Likes);
            sb.AppendLine("");
            sb.AppendLine("Titulo: "+Title);
            sb.AppendLine(Content);
            sb.AppendLine("");
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(" ==> "+ c.Text);
            }
            sb.AppendLine("");
            sb.AppendLine("-------------------");
            sb.AppendLine("");
            return sb.ToString();
    }



    }
}