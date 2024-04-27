using Bars;
using DZ;
using Project2;
using ProjectTwo;

namespace BarsTests
{
    [TestClass]
    public class Choosing1Tests
    {
        [TestMethod]
        public void TestBackClick()
        {
            // Arrange
            Choosing1 choosingForm = new Choosing1();
            Cafe cafeForm = new Cafe();
            choosingForm.Hide();

            // Act
            choosingForm.back_Click_1(null, null);

            // Assert
            Assert.IsFalse(choosingForm.Visible);
            Assert.IsTrue(cafeForm.Visible);
        }

        [TestMethod]
        public void TestShowClickMethod()
        {
            // Arrange
            Choosing1 form = new Choosing1();

            // Act
            form.show_Click_1(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.Visible);
        }
        [TestMethod]
        public void TestYoursClick1()
        {
            // Arrange
            Choosing1 form = new Choosing1();

            // Act
            form.yours_Click_1(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.Visible);
        }
    }
}