using Newspaper;
using Newspaper.Models;

namespace Newspaper_Test
{
    public class Article_Test
    {
        [Fact]
        public void Article_AssignsValues()
        {
            
            var reporter = new Reporter() { Name = "Name", Speciality = "Speciality", Articles = new List<Article>()};
            var issue = new Issue() { Date = DateTime.Now, Articles = new List<Article>()};
            var article = new Article() { Title = "Title", Content = "Content", Reporter = reporter, Issue = issue};

            Assert.Equal("Title", article.Title);
            Assert.Equal("Content", article.Content);
            Assert.Equal(issue, article.Issue);
            Assert.Equal(reporter, article.Reporter);
        }
    }
}