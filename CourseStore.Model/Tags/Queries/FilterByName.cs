using CourseStore.Model.Framework;
using CourseStore.Model.Tags.Entities;
using MediatR;

namespace CourseStore.Model.Tags.Queries;
public class FilterByName : IRequest<ApplicationServiceResponse<List<TagQueryResult>>>
{
    public string? TagName { get; set; }
}
