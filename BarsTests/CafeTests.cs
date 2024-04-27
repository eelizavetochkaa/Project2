using Bars;
using DZ;
using Project2;
using ProjectTwo;


namespace BarsTests
{
    [TestClass]
    public class CafeTests
    {
        [TestMethod]
        public void StartButtonClick_ShouldCreateChoosing1Form()
        {
            // Arrange
            Cafe cafeForm = new Cafe();

            Choosing1 choose1Form = null;

            cafeForm.FormClosed += (sender, e) =>
            {
                choose1Form = cafeForm.OwnedForms.Length > 0 ? cafeForm.OwnedForms[0] as Choosing1 : null;
            };

            // Act
            cafeForm.start_Click(cafeForm, EventArgs.Empty);

            // Assert
            Assert.IsNotNull(choose1Form, "Форма Choosing1 не была создана");
        }
    }
}