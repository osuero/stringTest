namespace Encora.String.services
{
    public static class StringSorter
    {
        public static string SortStringByFrequency(string input)
        {
            var frecuencyMap = input.GroupBy(c => c)
                                              .ToDictionary(g => g.Key, g => g.Count());

            var sortedCharacters = frecuencyMap.OrderByDescending(a => a.Value)
                                                       .ThenBy(a => a.Key)
                                                       .SelectMany(a => Enumerable.Repeat(a.Key, a.Value))
                                                       .ToArray();

            return new string(sortedCharacters);
        }
    }
}
