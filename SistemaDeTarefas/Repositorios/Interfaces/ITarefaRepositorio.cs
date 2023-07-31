using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(UsuarioModel tarefa);
        Task<TarefaModel> Atualizar(UsuarioModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
