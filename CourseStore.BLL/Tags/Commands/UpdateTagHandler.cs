using CourseStore.BLL.Framework;
using CourseStore.DAL.DbContexts;
using CourseStore.Model.Tags.Commands;
using CourseStore.Model.Tags.Entities;

namespace CourseStore.BLL.Tags.Commands;

public class UpdateTagHandler : BaseApplicationServiceHandler<UpdateTag, Tag>
{
    public UpdateTagHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }
    protected override async Task HandleRequest(UpdateTag request, CancellationToken cancellationToken)
    {
        Tag tag = _courseStoreDbContext.Tags.SingleOrDefault(t => t.Id == request.Id);
        if (tag is null) AddError($"تگ با شناسه {request.Id} یافت نشد.");
        else
        {
            tag.TagName = request.TagName;
            await _courseStoreDbContext.SaveChangesAsync();
            AddResult(tag);
        }
    }
}