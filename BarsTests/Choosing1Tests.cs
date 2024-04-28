using Bars;
using DZ;
using Project2;
using Moq;
using ProjectTwo;
using Microsoft.EntityFrameworkCore;

namespace BarsTests
{
    public class DataLoader
    {
        private readonly CafesContext _context;

        public DataLoader(CafesContext context)
        {
            _context = context;
        }

        public List<Bar> LoadDataFromDatabase()
        {
            try
            {
                return _context.Bars.Where(b => b.Type == "для выбора").ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ошибка при подключении к базе данных: " + ex.Message);
            }
        }
    }
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
        [TestMethod]
        public void UpdateMark_TestAllScenarios()
        {
            // Arrange
            using (var context = new CafesContext())
            {
                var choosingForm = new Choosing1();
                int existingRestaurantId = 1;
                int nonExistingRestaurantId = -1;
                choosingForm.UpdateMark(existingRestaurantId, 2);
                var updatedBar = context.Bars.FirstOrDefault(b => b.Id == existingRestaurantId);
                Assert.IsNotNull(updatedBar);
                Assert.AreEqual(2, updatedBar.Mark);
                choosingForm.UpdateMark(existingRestaurantId, 1);
                choosingForm.UpdateMark(existingRestaurantId, 2);
                choosingForm.UpdateMark(nonExistingRestaurantId, 1);
            }
        }
        [TestMethod]
        public void LoadDataFromDatabase_SuccessfulRequest_ReturnsListOfBars()
        {
            // Arrange
            var mockContext = new Mock<CafesContext>();
            var expectedBars = new List<Bar>
            {
                new Bar { Id = 1, Name = "Bar 1", Type = "для выбора" },
                new Bar { Id = 2, Name = "Bar 2", Type = "для выбора" }
            };
            mockContext.Setup(m => m.Bars).Returns((DbSet<Bar>)expectedBars.AsQueryable());

            var sut = new DataLoader(mockContext.Object);

            // Act
            var actualBars = sut.LoadDataFromDatabase();

            // Assert
            CollectionAssert.AreEqual(expectedBars, actualBars);
        }
        [TestMethod]
        public void LoadDataFromDatabase_ErrorConnectingToDatabase_ShowsMessageBoxWithError()
        {
            // Arrange
            var mockContext = new Mock<CafesContext>();
            mockContext.Setup(m => m.Bars).Throws<InvalidOperationException>();

            var sut = new DataLoader(mockContext.Object);

            // Act and assert
            Assert.ThrowsException<InvalidOperationException>(() => sut.LoadDataFromDatabase());
        }
    }
}