namespace Types;
record Video(string Title, TimeSpan Begining, TimeSpan Duration)
{
    public static Video Create(string title, TimeSpan duration) =>
        new(
                Title: title ?? throw new ArgumentNullException(nameof(title)),
                Begining: TimeSpan.Zero,
                Duration: duration
            );
}