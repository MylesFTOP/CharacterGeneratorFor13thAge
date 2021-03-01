using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using Xunit;
using ToolkitLibrary.DataAccess.TextHelpers;

namespace ToolkitLibrary.Tests
{
    public class FileTests
    {
        private const string file = "CharacterModels.csv";
        private readonly ContentType contentType = new ContentType();

        [Fact]
        public void TextConnectorProcessor_FullFilePath_ShouldIncludeFileName() {
            var expected = "\\" + file;
            var actual = file
                .FullFilePath();
            Assert.Equal(expected, actual);
        }
    }
}
