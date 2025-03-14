using System.Text;

namespace Task5
{
    public class Configuration
    {
        private static readonly Configuration _instance = new();

        public Dictionary<string, string> settings = new Dictionary<string, string>();

        private Configuration() { }

        public static Configuration GetInstance() => _instance;

        public void RemoveSetting(string index)
            => settings.Remove(index);

        public Configuration? this[string index]
        {
            get => _instance[index];
            set => _instance[index] = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var setting in settings)
            {
                builder.AppendLine($""""""")
            }
        }
    }
}