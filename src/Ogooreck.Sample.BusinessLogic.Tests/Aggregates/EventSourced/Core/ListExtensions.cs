namespace Ogooreck.Sample.BusinessLogic.Tests.Aggregates.EventSourced.Core;

public static class ListExtensions
{
    public static IList<T> Replace<T>(this IList<T> list, T existingElement, T replacement)
    {
        var indexOfExistingItem = list.IndexOf(existingElement);

        if (indexOfExistingItem == -1)
            throw new ArgumentOutOfRangeException(nameof(existingElement), "Element was not found");

        list[indexOfExistingItem] = replacement;

        return list;
    }
}