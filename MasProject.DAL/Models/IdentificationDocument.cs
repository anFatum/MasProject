using System;
using System.ComponentModel.DataAnnotations;

namespace MasProject.DAL.Models
{
    public enum DocumentType
    {
        InternalPassport,
        IdentificationId,
        ExternalPassport
    }

    public class IdentificationDocument
    {
        [Key] public int IdentificationDocumentId { get; set; }
        [Required] public string CountryOfIssuance { get; set; }
        [Required] public DocumentType DocumentType { get; set; }
        [Required] public DateTime ExpirationDate { get; set; }
        public string PassportSeries { get; set; }
        [Required][MaxLength(16)] public string DocumentNumber { get; set; }
    }
}