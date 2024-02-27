using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void TestEmployeeSalaryOperations()
    {
        // Arrange
        Employee emp1 = new Employee();
        emp1.Salary = 1000;

        Employee emp2 = new Employee();
        emp2.Salary = 1500;

        // Act
        double increasedSalary = emp1 + 200;
        double decreasedSalary = emp2 - 300;

        // Assert
        Assert.AreEqual(1200, increasedSalary);
        Assert.AreEqual(1200, decreasedSalary);
    }
}

[TestClass]
public class MatrixTests
{
    [TestMethod]
    public void TestMatrixOperations()
    {
        // Arrange
        Matrix mat1 = new Matrix(2, 2);
        mat1[0, 0] = 1;
        mat1[0, 1] = 2;
        mat1[1, 0] = 3;
        mat1[1, 1] = 4;

        Matrix mat2 = new Matrix(2, 2);
        mat2[0, 0] = 2;
        mat2[0, 1] = 3;
        mat2[1, 0] = 4;
        mat2[1, 1] = 5;

        // Act
        Matrix addedMatrix = mat1 + mat2;
        Matrix multipliedMatrix = mat1 * mat2;

        // Assert
        Assert.AreEqual(3, addedMatrix[0, 0]);
        Assert.AreEqual(5, multipliedMatrix[0, 0]);
    }
}

[TestClass]
public class CityTests
{
    [TestMethod]
    public void TestCityPopulationOperations()
    {
        // Arrange
        City city1 = new City(1000);
        City city2 = new City(1500);

        // Act
        City resultCityAdd = city1 + 200;
        City resultCitySubtract = city2 - 300;

        // Assert
        Assert.AreEqual(1200, resultCityAdd.Population);
        Assert.AreEqual(1200, resultCitySubtract.Population);
    }
}

[TestClass]
public class CreditCardTests
{
    [TestMethod]
    public void TestCreditCardOperations()
    {
        // Arrange
        CreditCard card1 = new CreditCard();
        card1.Balance = 100;

        CreditCard card2 = new CreditCard();
        card2.Balance = 200;

        // Act
        CreditCard resultCardAdd = card1 + 50;
        CreditCard resultCardSubtract = card2 - 100;

        // Assert
        Assert.AreEqual(150, resultCardAdd.Balance);
        Assert.AreEqual(100, resultCardSubtract.Balance);
    }
}
