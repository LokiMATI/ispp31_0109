public class PowerfullRandom : Random
{
    public string NextString(int lenght)
    {
        string text = string.Empty;

        for (int i = 0; i < lenght; i++)
            text += Convert.ToChar(Random.Shared.Next(65, 90));

        return text;
    }
}

