using MedicalSchedulingSystem.Domain.ValueObjects;

namespace MedicalSchedulingSystem.Tests.ValueObjects;

[TestClass]
public class DocumentTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenCpfIsInvalid()
    {
        var cpf = new Document("060");
        Assert.IsFalse(cpf.IsValid);
    }

    [TestMethod]
    public void ShoudReturnSuccessWhenCpfIsValidWithFormat()
    {
        var cpf = new Document("060.628.680-26");
        Assert.IsTrue(cpf.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCpfIsValidWithoutFormat()
    {
        var cpf = new Document("06062868026");
        Assert.IsTrue(cpf.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCpfHasOnlyRepeatedDigits()
    {
        var cpf = new Document("111.111.111-11");
        Assert.IsFalse(cpf.IsValid);
    }
}