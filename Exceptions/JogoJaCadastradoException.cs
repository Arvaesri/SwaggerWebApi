using System;

namespace SwaggerWebApi.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        // Perguntar para alice oque essa linha faz
        public JogoJaCadastradoException() : base("Este jogo já esta Cadastrado") 
        {
            
        }
    }
}