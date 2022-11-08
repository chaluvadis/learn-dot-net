
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace BlankPdf;
public static class Utility
{
    public static bool IsBlankPdf(MemoryStream stream)
    {
        stream.Position = 0;
        using PdfDocument document = PdfDocument.Open(stream);
        int pageCount = document.NumberOfPages;
        Page page = document.GetPage(1);
        return string.IsNullOrWhiteSpace(page.Text);
    }
}