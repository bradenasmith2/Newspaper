using Newspaper;

namespace Newspaper_Test
{
    public class Reporter_Test
    {
        [Fact]
        public void Reporter_AssignsValues()
        {
            var reporter = new Reporter() { Name = "Name", Speciality = "Speciality", Articles = new List<Article>() };
            var issue = new Issue() { Date = DateTime.Now, Articles = new List<Article>() };
            var article = new Article() { Title = "Title", Content = "Content", Reporter = reporter, Issue = issue };

            Assert.Equal("Name", reporter.Name);
            Assert.Equal("Speciality", reporter.Speciality);
            Assert.Empty(reporter.Articles);

            reporter.Articles.Add(article);
            Assert.NotEmpty(reporter.Articles);
        }
    }
}