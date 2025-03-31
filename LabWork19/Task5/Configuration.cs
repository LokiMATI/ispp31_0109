using System.Text;

namespace Task5
{
    public class Configuration
    {
        private static readonly Configuration _instance = new();

        public Dictionary<string, string> settings = new();

        private Configuration() { }

        public static Configuration GetInstance() => _instance;

        public void RemoveSetting(string index)
            => settings.Remove(index);

        public string? this[string index]
        {
            get => settings[index];
            set => settings[index] = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");
            foreach (var setting in settings)
                builder.AppendLine($"  \"{setting.Key}\": \"{setting.Value}\"");

            builder.AppendLine("}");
            return builder.ToString();
        }
    }
}