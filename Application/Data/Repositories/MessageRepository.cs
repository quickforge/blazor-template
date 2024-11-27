using Application.Data.Context;
using Application.Data.Models;

namespace Application.Data.Repositories;

public class MessageRepository(ApplicationContext context) : BaseRepository<Message>(context)
{
    public async Task<List<Message>> GetGreetingsAsync(string name)
    {
        return await GetAsync(
            filter: m => m.Name == name,
            orderBy: q => q.OrderBy(m => m.Greeting)
        );
    }
}