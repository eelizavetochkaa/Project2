using Bars;
using DZ;
using Project2;
using ProjectTwo;

namespace BarsTests
{
    [TestClass]
    public class YourCollectionsTests
    {
        [TestMethod]
        public void BackButtonShouldOpenChoosing1Form()
        {
            // Arrange
            YourCollections form = new YourCollections();
            Choosing1 choose1Form = new Choosing1();

            // Act
            form.back5_Click(this, null);

            // Assert
            Assert.IsFalse(form.Visible);
            Assert.IsTrue(choose1Form.Visible);
        }
    }
}