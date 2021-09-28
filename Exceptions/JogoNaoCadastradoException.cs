using System;

namespace SwaggerWebApi.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() : base("Este jogo não esta Cadastrado") 
        {
            
        }
    }
}