public interface IDocument
{
    void Open();
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("pdf opened");
}

public class DocxDocument : IDocument
{
    public void Open() => Console.WriteLine("docx opened");
}

public class Application
{
    public IDocument? Create(string type) // Фабричный метод
     => type switch
     {
         "pdf" => new PdfDocument(),
         "docx" => new DocxDocument(),
         _ => throw new AggregateException()
     };
}

//public abstract class Application
//{
//    public abstract IDocument Create(); // Фабричный метод
//    public void NewDocument() => Create().Open();
//}

//public class PdfApplication : Application
//{
//    public override IDocument Create() => new PdfDocument();
//}

class Document : ICloneable
{
    public string Text { get; set; }
    public object Clone() => new Document() { Text = Text };
}