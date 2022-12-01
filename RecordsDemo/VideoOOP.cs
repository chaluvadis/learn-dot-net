namespace RecordsDemo;
class VideoOOP
{
    public VideoOOP(string title, TimeSpan duration)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Begining = TimeSpan.Zero;
        Duration = duration;
    }

    public string Title { get; set; }
    public TimeSpan Begining { get; set; }
    public TimeSpan Duration { get; set; }

    public void CutOut(TimeSpan begin, TimeSpan duration)
    {
        if (begin >= Duration)
        {
            Begining += Duration;
            Duration = TimeSpan.Zero;
        }
        else if (begin + duration > Duration)
        {
            Duration -= begin;
            Begining += begin;
        }
        else
        {
            Begining += begin;
            Duration = duration;
        }
    }
}