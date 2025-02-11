using Xunit;

namespace TestProject
{
    public class ListOfExtensionsTest
    {
        [Theory]
        [InlineData("document.doc", true)]
        [InlineData("presentation.ppt", true)]
        [InlineData("document.pdf", true)]
        [InlineData("document.mp3", false)]
        [InlineData("image.png", false)]

        public void VerifyFileExtension_ShouldReturnExpectedResult(string fileName, bool expected)
        {
            var validExtensions = ListOfExtensions.DoscList();

            bool result = validExtensions.Any(ext => fileName.EndsWith(ext));

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData("document.mp3", true)]
        public void checkIfFileExtensionShouldListMusicExtension(string fileName, bool expected)
        {
            var validExtensions = ListOfExtensions.MusicList();

            bool result = validExtensions.Any(ext => fileName.EndsWith(ext));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("document.png", true)]
        public void checkIfFileExtensionShouldListImagesExtension(string fileName, bool expected)
        {
            var validExtensions = ListOfExtensions.PicturesList();

            bool result = validExtensions.Any(ext => fileName.EndsWith(ext));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("document.exe", true)]
        public void checkIfFileExtensionShouldListProgramExtension(string fileName, bool expected)
        {
            var validExtensions = ListOfExtensions.ProgramList();

            bool result = validExtensions.Any(ext => fileName.EndsWith(ext));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("document.mp4", true)]
        public void checkIfFileExtensionShouldListVideoExtension(string fileName, bool expected)
        {
            var validExtensions = ListOfExtensions.VideoList();

            bool result = validExtensions.Any(ext => fileName.EndsWith(ext));

            Assert.Equal(expected, result);
        }

    }
}