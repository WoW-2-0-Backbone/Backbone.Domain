namespace Backbone.Domain.Entities.Common;

/// <summary>
/// Defines an entity that the user last modified can be tracked.
/// </summary>
public interface IModificationAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the user who last modified the entity.
    /// </summary>
    public Guid? ModifiedByUserId { get; set; }
}