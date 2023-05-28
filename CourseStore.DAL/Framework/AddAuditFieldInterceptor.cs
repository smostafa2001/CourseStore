using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CourseStore.DAL.Framework;
public class AddAuditFieldInterceptor : SaveChangesInterceptor
{
    private static void SetShadowProperties(DbContextEventData eventData)
    {
        var changeTracker = eventData.Context.ChangeTracker;
        var addedEntities = changeTracker.Entries().Where(entity => entity.State == EntityState.Added);
        var modifiedEntities = changeTracker.Entries().Where(entity => entity.State == EntityState.Modified);
        DateTime now = DateTime.Now;
        foreach (var entity in addedEntities)
        {
            entity.Property("CreateBy").CurrentValue = "1";
            entity.Property("UpdateBy").CurrentValue = "1";
            entity.Property("CreateDate").CurrentValue = now;
            entity.Property("UpdateDate").CurrentValue = now;
        }

        foreach (var entity in modifiedEntities)
        {
            entity.Property("UpdateBy").CurrentValue = "1";
            entity.Property("UpdateDate").CurrentValue = now;
        }
    }
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        SetShadowProperties(eventData);
        return base.SavingChanges(eventData, result);
    }
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        SetShadowProperties(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}
