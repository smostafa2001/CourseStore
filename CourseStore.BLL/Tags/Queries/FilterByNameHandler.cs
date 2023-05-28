using CourseStore.BLL.Framework;
using CourseStore.DAL.DbContexts;
using CourseStore.DAL.Tags;
using CourseStore.Model.Tags.Queries;

namespace CourseStore.BLL.Tags.Queries;
public class FilterByNameHandler : BaseApplicationServiceHandler<FilterByName, List<TagQueryResult>>
{
    public FilterByNameHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }

    protected override async Task HandleRequest(FilterByName request, CancellationToken cancellationToken)
    {
        var result = await _courseStoreDbContext.Tags.WhereOver(request.TagName).ToTagQueryResultsAsync();
        AddResult(result);
    }
}
