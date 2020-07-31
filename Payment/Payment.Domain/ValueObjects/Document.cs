using Flunt.Validations;
using Payment.Domain.Enums;
using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        private const int CnpjLength = 14;
        private const int CpfLength = 11;

        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract().Requires().IsTrue(Validate(), "Document.Number", "Invalid document"));
        }

        public string Number { get; set; }

        public EDocumentType Type { get; set; }

        private bool Validate(){
            if(Type == EDocumentType.Cnpj && Number.Length == CnpjLength)
                return true;

            if(Type == EDocumentType.Cpf && Number.Length == CpfLength)
                return true;

            return false;
        }
    }
}