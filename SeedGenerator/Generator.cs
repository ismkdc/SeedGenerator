namespace SeedGenerator
{
    public class Generator
    {
        private readonly Random _random = new();

        public T Random<T>(params T[] items)
        {
            if (items == null || items.Length == 0)
                return default;

            var randomIndex = _random.Next(items.Length);

            return items[randomIndex];
        }

        public T[] Array<T>(Func<T> func, int count)
        {
            var array = new T[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = func();
            }

            return array;
        }

        public int Integer(int max, int min = 0) => _random.Next(min, max);

        public string Firstname() => Random(Constants.Firstnames);

        public string Lastname() => Random(Constants.Lastnames);

        public string Company() => Random(Constants.Companies);

        public string Email(string domain = "test.com") => $"{Firstname()}.{Lastname()}@{domain}".ToLower();

        public DateTime Date(DateTime? min = null, DateTime? max = null)
        {
            if (min == null) min = new DateTime(1970, 1, 1);
            if (max == null) max = DateTime.Now.AddYears(1000);

            TimeSpan tspan = max.Value - min.Value;

            int randomDaysFromMin = _random.Next(tspan.Days);

            return min.Value.AddDays(randomDaysFromMin);
        }

        public string ImageUrl(int width = 200, int height = 200) => $"https://picsum.photos/{width}/{height}";

        public string Text(int length = 500)
        {
            if (length > 9500)
                length = 9500;

            return Constants.LoremIpsum.Substring(0, length);
        }
    }
}