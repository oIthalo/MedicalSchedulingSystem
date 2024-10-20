using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;
using System.Text.RegularExpressions;

namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string document)
        {
            CPFNumber = document;

            AddNotifications(new Contract<Document>()
                .Requires()
                .IsNotNullOrEmpty(CPFNumber, "Document.DocumentCPF", "CPF não pode ser vazio")
                .Matches(CPFNumber, @"^\d{11}$", "CPF.CPFNumber", "O CPF deve conter 11 dígitos numéricos")
                .IsTrue(IsValidCPF(CPFNumber), "CPF.CPFNumber", "CPF inválido"));
        }

        public string CPFNumber { get; private set; }

        private bool IsValidCPF(string cpf)
        {
            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"(\d)\1{10}"))
                return false;

            // first verifier digit
            int[] multiplier1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (cpf[i] - '0') * multiplier1[i];

            int remainder = sum % 11;
            int firstVerifierDigit = remainder < 2 ? 0 : 11 - remainder;

            // last verifier digit
            int[] multiplier2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += (cpf[i] - '0') * multiplier2[i];

            remainder = sum % 11;
            int secondVerifierDigit = remainder < 2 ? 0 : 11 - remainder;

            
            return cpf[9] - '0' == firstVerifierDigit && cpf[10] - '0' == secondVerifierDigit;
        }
    }
}