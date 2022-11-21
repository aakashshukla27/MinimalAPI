using DotNet6MinApi.Models;
using DotNet6MinAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNet6MinApi.Data{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDBContext _context;

        public CommandRepo(AppDBContext context)
        {
            _context = context;
        }

        public async Task CreateCommand(Command command)
        {
            if(command == null){
                throw new ArgumentNullException(nameof(command));
            }

            await _context.AddAsync(command);

        }

        public void DeleteCommand(Command command)
        {
            if(command == null){
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Remove(command);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.Commands.ToListAsync();
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.Commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}