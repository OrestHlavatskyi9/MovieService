namespace MovieService.Core.ValueObjects;

public sealed class PosterImageUrl
{
    private PosterImageUrl(string value)
    {
        Value = value;
    }

    public string Value { get; }

    /// <returns>
    ///     Null as return value indicator of failed operation for simplicity. In real project it's better to use a Result pattern.
    /// </returns>
    public static PosterImageUrl? Create(string posterImageUrl)
    {
        // Check if image url valid
        if (false) 
        {
        }

        return new PosterImageUrl(posterImageUrl);
    }
}