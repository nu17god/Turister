namespace Turister.Shared
{
    public class TagParser
    {
        public string GetTagTitle(string title)
        {
            switch (title.ToLower())
            {
                case "history": return "История";
                case "hotels": return "Отель";

                default: return title;
            }
        }
    }
}