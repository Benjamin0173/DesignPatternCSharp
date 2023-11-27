using System;

namespace Builder.Classes
{
    public class LiasseHtml : Liasse
    {
        public LiasseHtml()
        {
            documents = new List<string>();
        }

        public override void ajouteDocument(string document)
        {
            if (document.StartsWith("<HTML>"))
            {
                documents.Add(document);
            }
        }

        public override void imprime()
        {
            Console.WriteLine("Liasse HTML");
            foreach (string document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}