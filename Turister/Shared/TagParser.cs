namespace Turister.Shared
{
    public class TagParser
    {
        public string GetTagTitle(string title)
        {
            switch (title.ToLower())
            {
                case "history": return "История";

                default: return title;
            }
        }
    }
}