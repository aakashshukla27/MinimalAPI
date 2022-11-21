using DotNet6MinApi.Models;

namespace DotNet6MinAPI.Data{
    public interface ICommandRepo{
        
        Task SaveChanges();
        Task<Command?> GetCommandById(int id);
        Task<IEnumerable<Command>> GetAllCommands();
        Task CreateCommand(Command command);
        void DeleteCommand(Command command);
    }
}