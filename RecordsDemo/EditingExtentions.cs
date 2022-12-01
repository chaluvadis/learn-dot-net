namespace VideoExtentions;

using Types;

static class EditingExtentions
{
    public static Video CutOut(this Video video, TimeSpan begin, TimeSpan duration) =>
        begin >= video.Duration ? video with { Begining = begin, Duration = TimeSpan.Zero }
        : begin + duration > video.Duration ? video with
        {
            Duration = video.Duration - begin,
            Begining = video.Begining + begin
        }
        : video with
        {
            Begining = video.Begining + begin,
            Duration = video.Duration
        };
}