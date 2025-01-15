namespace MovieService.Core.ValueObjects;

public sealed class ReleaseYear
{
    public const int MIN_RELEASE_YEAR = 1895;
    public const int MAX_RELEASE_YEAR = 99999;

    private ReleaseYear(int value)
    {
        Value = value;
    }

    public int Value { get; }

    /// <returns>
    ///     Null as return value indicator of failed operation for simplicity. In real project it's better to use a Result pattern.
    /// </returns>
    public static ReleaseYear? Create(int releaseYear)
    {
        if (releaseYear < MIN_RELEASE_YEAR || releaseYear > MAX_RELEASE_YEAR)
        {
            return null;
        }

        return new ReleaseYear(releaseYear);
    }
}