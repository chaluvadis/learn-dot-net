using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

using (PdfDocument document = PdfDocument.Open("/Users/hola/Documents/myworks/learn-dot-net/ReadPdfDemo/Pdf/notblank.pdf"))
{
    int pageCount = document.NumberOfPages;

    // Page number starts from 1, not 0.
    Page page = document.GetPage(1);

    double widthInPoints = page.Width;
    double heightInPoints = page.Height;

    string text = page.Text;
    if (string.IsNullOrWhiteSpace(text))
    {
        Console.WriteLine("Pdf is blank");
    }
    else
    {
        Console.WriteLine($"Height:{heightInPoints}, Width:{widthInPoints}, PageText:{text}");
    }
}
