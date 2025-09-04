using TodoApp.Entities;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Services;

public class TodoAppService : TodoAppAppService
{
    private readonly IRepository<TodoItem, Guid> _todoItemRepository;

    public TodoAppService(IRepository<TodoItem, Guid> todoItemRepository)
    {
        _todoItemRepository = todoItemRepository;
    }

    // TODO: Implement the methods here...
}
