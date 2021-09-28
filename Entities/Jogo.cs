using System;

namespace SwaggerWebApi.Entities
{
    public class Jogo // pq é igual a view model?
    {
        public Guid Id{get; set;}

        public string Nome{get; set;}

        public string Produtora{get; set;}

        public double Preco{get; set;}
    }
}