using Balta.Domain.Shared.Aggregates.Abstractions;

namespace Balta.Domain.Shared.Repositories.Abstractions;

public interface IRepository<TEntity> where TEntity : IAgregateRoot;