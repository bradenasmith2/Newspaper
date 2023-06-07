using Newspaper;
using Newspaper.Models;

namespace Newspaper_Test
{
    public class Issue_Test
    {
        [Fact]
        public void Issue_AssignsValues()
        {
            var reporter = new Reporter() { Name = "Name", Speciality = "Speciality", Articles = new List<Article>() };
            var issue = new Issue() { Date = DateTime.Now, Articles = new List<Article>() };
            var article = new Article() { Title = "Title", Content = "Content", Reporter = reporter, Issue = issue };

            Assert.IsType<DateTime>(issue.Date);
            Assert.Empty(issue.Articles);

            issue.Articles.Add(article);
            Assert.NotEmpty(issue.Articles);
        }
    }
}