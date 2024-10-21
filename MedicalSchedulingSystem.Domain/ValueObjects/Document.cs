using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;
using System.Text.RegularExpressions;

namespace MedicalSchedulingSystem.Domain.ValueObjects;

public class Document : ValueObject
{
    public Document(string cpf)
    {
        CPFNumber = cpf;

        var cpfNmb = cpf.Replace(".", "").Replace("-", "");

        AddNotifications(new Contract<Document>()
            .Requires()
            .IsNotNullOrEmpty(CPFNumber, "Document.CPFNumber", "CPF não pode ser vazio")
            .IsTrue(cpfNmb.Length == 11, "Document.CPFNumber", "O CPF deve conter 11 dígitos numéricos")
            .IsTrue(IsValidCPF(cpfNmb), "Document.CPFNumber", "CPF inválido"));
    }

    public string CPFNumber { get; private set; }

    private bool IsValidCPF(string cpf)
    {
        var cpfNmb = cpf.Replace(".", "").Replace("-", "");

        if (cpfNmb.Length != 11 || Regex.IsMatch(cpfNmb, @"(\d)\1{10}"))
            return false;

        int[] multiplier1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int sum = 0;
        for (int i = 0; i < 9; i++)
            sum += (cpfNmb[i] - '0') * multiplier1[i];

        int remainder = sum % 11;
        int firstVerifierDigit = remainder < 2 ? 0 : 11 - remainder;

        int[] multiplier2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += (cpfNmb[i] - '0') * multiplier2[i];

        remainder = sum % 11;
        int secondVerifierDigit = remainder < 2 ? 0 : 11 - remainder;

        return cpfNmb[9] - '0' == firstVerifierDigit && cpfNmb[10] - '0' == secondVerifierDigit;
    }
}