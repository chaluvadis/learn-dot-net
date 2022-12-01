using Types;
using VideoExtentions;

Video video = Video.Create("Simple Video", TimeSpan.FromMinutes(10));

var cuts = Enumerable.Range(1, 10)
                     .Select(s => TimeSpan.FromSeconds(10 * s))
                     .Select(begining => video.CutOut(begining, TimeSpan.FromMinutes(200)));

Console.WriteLine(string.Join(Environment.NewLine, cuts));