using System.Net;

Download();
Console.Read();

static void Download()
{
    var client = new WebClient();
    Console.WriteLine("Ожидание менее 5 минут");
    for (int i = 0; i < 5; i++)
    {
        client.DownloadFile(new Uri(LinkBilder.LinkBillder()), $"{LinkBilder.JournalBilding()}");
        Console.WriteLine($"Файл номер {i + 1} загружен");
    }
    Console.WriteLine("Готово");
}
class LinkBilder
{
    private static string link =  "";
    private static int numberJurnalStart = 246;
    private static int mouthStart = 9;
    private static int yearStart  = 2019;
    public LinkBilder(){ }

    public static string LinkBillder()
    {
        link = $"http://nozdr.ru/data/media/biblio/j/xak/{yearStart}/xa-{yearStart}-{String.Format("{0:00}", mouthStart)}-{numberJurnalStart}.pdf";
        IteratorFunctionLink();
        return link;
    }

    private static void IteratorFunctionLink()
    {
        mouthStart++;

        if (mouthStart > 12)
        {
            yearStart++;
            mouthStart = 1;
        }
    }

    public static string JournalBilding()
    {
        var numberJournal = $"{numberJurnalStart}.pdf";
        IteratorCountJournal();
        return numberJournal;
    }
    private static void IteratorCountJournal() => numberJurnalStart++;
}
