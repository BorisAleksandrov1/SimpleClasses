namespace Newspaper
{
    class Newspaper
    {
        private string? title;
        private string? text;
        private string? writer;

        public string Title { get; set; }
        public string Text { get; set; }
        public string Writer { get; set; }

        public Newspaper(string title, string text, string writer)
        {
            this.Title = title;
            this.Text = text;
            this.Writer = writer;
        }

        public void Edit(string newText)
        {
            this.Text = newText;
        }

        public void ChangeWriter(string newWriter)
        {
            this.Writer = newWriter;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Text}:{Writer}";
        }
    }
}