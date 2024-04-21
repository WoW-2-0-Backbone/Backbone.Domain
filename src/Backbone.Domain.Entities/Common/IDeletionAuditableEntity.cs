namespace Backbone.Domain.Entities.Common;

/// <summary>
/// Defines an entity that the user deleted can be tracked.
/// </summary>
public interface IDeletionAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the user who deleted the entity.
    /// </summary>
    Guid? DeletedByUserId { get; set; }
}