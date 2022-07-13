namespace Erantissen_Backend.Domain.Entities
{
    public class Subcategory
    {
        public string Title { get; set; }
        public Subcategory(string title)
        {
            Title = title;
        }
    }
}
