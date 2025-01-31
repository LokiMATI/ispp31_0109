using System.Text;

public class PowerfullRandom : Random
{
    public string RandomString(int n)
    {
        StringBuilder str = new StringBuilder();
        char ch;

        for (int i = 0; i < n; i++)
        {
            ch = Convert.ToChar(Random.Shared.Next(65, 90));
            str.Append(ch);
        }

        return str.ToString();
    }
}

