using CourseStore.Model.Tags.Entities;
using CourseStore.Model.Tags.Queries;
using Microsoft.EntityFrameworkCore;

namespace CourseStore.DAL.Tags;
public static class TagQueryExtentions
{
    public static IQueryable<Tag> WhereOver(this IQueryable<Tag> tags, string tagName)
    {
        if (string.IsNullOrEmpty(tagName)) tags = tags.Where(t => t.TagName.Contains(tagName));
        return tags;
    }

    public static async Task<List<TagQueryResult>> ToTagQueryResultsAsync(this IQueryable<Tag> tags) =>
        await tags.Select(t => new TagQueryResult
        {
            Id = t.Id,
            TagName = t.TagName,
        }).ToListAsync();
}
