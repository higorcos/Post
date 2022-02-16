using System;
using System.Globalization;
using Services;

namespace PostAndComments{
    class Program{
        static void Main(){
        //Criação dos posts
            Post post1 = new Post(
              DateTime.Parse("21/12/2021 22:05:14"),
                    "Cultura do c#",
                    "A linguagem está presentes como linguagem principal de muitas empresas",
                    6);

            Post post2 = new Post(
              DateTime.Parse("25/12/2021 23:24:24"),
                    "Natal",
                    "Feliz Natal a todos!!",
                    10);
       //Criação Comentários para os posts
            Comment comment1 = new Comment("Sou um dos que segue essa cultura");
            Comment comment2 = new Comment("Feliz Natal!!");
            Comment comment3 = new Comment("Feliz Ano Novo também!!");

            post1.AddComment(comment1);
            post2.AddComment(comment2);
            post2.AddComment(comment3); 

            Console.WriteLine(post2.ToString());
            Console.WriteLine(post1.ToString());


        }
    }
}