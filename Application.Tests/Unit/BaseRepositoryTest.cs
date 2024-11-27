using Application.Data.Context;
using Application.Data.Models;
using Application.Data.Repositories;

namespace Application.Tests.Unit;

public class BaseRepositoryTest
{
    private readonly List<TestEntity> _entities = [
        new TestEntity { Id = 1, Name = "Hello" },
        new TestEntity { Id = 2, Name = "World" }
    ];

    private async Task<BaseRepository<TestEntity>> CreateRepository()
    {
        var repository = new BaseRepository<TestEntity>(new TestContext());

        foreach (var entity in _entities)
        {
            repository.Add(entity);
        }

        await repository.SaveChangesAsync();

        return repository;
    }

    [Fact]
    public async Task GetAsync()
    {
        // Arrange
        var repository = await CreateRepository();

        // Act
        var result = await repository.GetAsync();

        // Assert
        Assert.Equal(_entities, result);
    }

    [Fact]
    public async Task GetByIdAsync()
    {
        // Arrange
        var repository = await CreateRepository();

        // Act
        var result = await repository.GetByIdAsync(1);

        // Assert
        Assert.Equal(_entities[0], result);
    }

    [Fact]
    public async Task UpdateAsync()
    {
        // Arrange
        var repository = await CreateRepository();
        var entity = _entities[0];
        entity.Name = "Updated";

        // Act
        repository.Update(entity);
        await repository.SaveChangesAsync();

        // Assert
        var result = await repository.GetByIdAsync(1);
        Assert.Equal(entity, result);
    }

    [Fact]
    public async Task DeleteAsync()
    {
        // Arrange
        var repository = await CreateRepository();
        var entity = _entities[0];

        // Act
        repository.Delete(entity);
        await repository.SaveChangesAsync();

        // Assert
        var result = await repository.GetByIdAsync(1);
        Assert.Null(result);
    }

    [Fact]
    public async Task DeleteByIdAsync()
    {
        // Arrange
        var repository = await CreateRepository();

        // Act
        repository.Delete(1);
        await repository.SaveChangesAsync();

        // Assert
        var result = await repository.GetByIdAsync(1);
        Assert.Null(result);
    }
}