using Application.Data.Models;
using Application.Data.Repositories;
using Application.Shared.Enums;
using Application.Shared.Exceptions;

using Microsoft.IdentityModel.Tokens;

namespace Application.Services;

public class MessageService(MessageRepository repository)
{
    private readonly MessageRepository _repository = repository;

    public async Task<List<Message>> GetGreetingsAsync(string name)
    {
        return await _repository.GetGreetingsAsync(name);
    }

    public async Task AddMessageAsync(Message message)
    {
        if (message.Name.IsNullOrEmpty())
        {
            throw new BaseException(ExceptionCode.InvalidInput, "Name cannot be empty");
        }

        if (message.Name.StartsWith("Bob"))
        {
            throw new BaseException(ExceptionCode.InvalidInput, "Name cannot be Bob");
        }

        _repository.Add(message);
        await _repository.SaveChangesAsync();
    }
}