using ExercicioComposicao02.Entities;
using System;

namespace ExercicioComposicao02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem!!");
            Comment c2 = new Comment("Muito toppp");

            Post p1 = new Post(
                    DateTime.Parse("04/04/2023 17:21:00"),
                    "Uma viagem para joao pessoa",
                    "vai ser maravilhoso voltar a essa cidade",
                    50
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("showwwwwwwwwwwwwwwwww");
            Comment c4 = new Comment("Vamos com tudo!");

            Post p2 = new Post(
                    DateTime.Parse("04/04/2022 13:21:00"),
                    "Uma viagem para maragogi",
                    "vai ser maravilhoso!",
                    50
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2d);

        }
    }
}