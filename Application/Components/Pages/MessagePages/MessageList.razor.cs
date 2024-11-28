using Application.Data.Models;
using Application.Services;

using Microsoft.AspNetCore.Components;

namespace Application.Components.Pages.MessagePages;

public partial class MessageList
{
    [Inject]
    private MessageService MessageService { get; set; } = default!;

    private List<Message> _messages = [];

    protected override async Task OnInitializedAsync()
    {
        _messages = [];
    }
}