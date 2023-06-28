using System;
using System.Collections.Generic;
using System.Text;

namespace Newspaper
{
    public class News
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Writter { get; set; }

        public News (string title, string text, string writter)
        {
            Title = title;
            Text = text;
            Writter = writter;
        }
        public void Edit(string text)
        {
            Text = text;
        }
        public void Rename(string title)
        {
            Title = title;
            
        }
        public void ChangeWritter(string writter)
        {
            Writter = writter;
        }
        public override string ToString()
        {
            return $"{Title} ‐ {Text}: {Writter}";
        }

    }
}
