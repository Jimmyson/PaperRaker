using System;
using Nager.ArticleNumber;
using PaperRaker.Core.Identity;
using Xunit;

namespace PaperRaker.Core.Test
{
    public class ArticleNumberTest
    {
        [Fact]
        public void ArticleNumberValidISSN()
        {
            // Arrange

            // Act
            PaperArticle pa = new PaperArticle("2049-3630");

            // Assert
            Assert.Equal("2049-3630", pa.Code);
            Assert.Equal(ArticleNumberType.ISSN, pa.Type);
        }

        [Fact]
        public void ArticleNumberInValidDashISSN()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<Exception>(() => { PaperArticle pa = new PaperArticle("1732-532X"); } );
            
            // Assert
            Assert.Equal("Invalid Article Number", ex.Message);
        }
        

        [Fact]
        public void ArticleNumberInValidISSN()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<Exception>(() => { PaperArticle pa = new PaperArticle("1732532X"); } );
            
            // Assert
            Assert.Equal("Invalid Article Number", ex.Message);
        }
    }
}
