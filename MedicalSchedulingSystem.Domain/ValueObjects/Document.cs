using MedicalSchedulingSystem.Domain.Enums;

namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Document
    {
        public Document(EDocumentType documentType)
            =>   DocumentType = documentType;

        public EDocumentType DocumentType { get; private set; }
    }
}