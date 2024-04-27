using Bars;
using DZ;
using Project2;
using ProjectTwo;
using System.Windows.Forms;
namespace BarsTests
{
    [TestClass]
    public class YourRecomendationsTests
    {
        [TestMethod]
        public void TestBackClick()
        {
            // Arrange
            YourRecomendations form = new YourRecomendations();

            // Act
            System.Windows.Forms.Button back4 = new System.Windows.Forms.Button();
            EventArgs args = new EventArgs();
            form.back4_Click(back4, args);
            Choosing1 choose1Form = Application.OpenForms["Choosing1"] as Choosing1;

            // Assert
            Assert.IsNotNull(choose1Form);
            Assert.IsFalse(form.Visible);
            form.Dispose();
            choose1Form.Dispose();

        }
    }
}