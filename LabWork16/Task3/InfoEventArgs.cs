public class InfoEventArgs : EventArgs
{
    public string NameProperty { get; set; }
    public string TextError { get; set; }
    public DateTime ChangedDate { get; set; }

    public InfoEventArgs(string nameProperty, string textError)
    {
        NameProperty = nameProperty;
        TextError = textError;
        ChangedDate = DateTime.Now;
    }
}