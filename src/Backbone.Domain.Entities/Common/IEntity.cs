namespace Backbone.Domain.Entities.Common;

/// <summary>
/// Defines an entity within the system.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Gets or sets the entity ID.
    /// </summary>
    public Guid Id { get; set; }
}