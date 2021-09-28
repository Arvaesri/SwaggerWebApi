using System;
using System.Threading.Tasks;
using SwaggerWebApi.ViewModel;
using System.Collections.Generic;
using SwaggerWebApi.InputModel;

namespace SwaggerWebApi.Services
{
    public interface IJogoServices : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}