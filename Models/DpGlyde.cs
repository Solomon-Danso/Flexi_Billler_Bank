using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpGlyde
{
    public long Id { get; set; }

    public string? Narration { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string? Userid { get; set; } 

    public string? InstCode { get; set; } 

    public string? Statuz { get; set; } 

    public string? TransId { get; set; } 

    public string? TransDate { get; set; } 

    public string? DateModified { get; set; }

    public decimal? Discount { get; set; }

    public string? CategoryId { get; set; }

    public string? ProviderId { get; set; }

    public string? Extras { get; set; }

    public string? CountryCode { get; set; }

    public string? ValueDate { get; set; }

    public string? Recipient { get; set; }

    public string? TransType { get; set; }
    public string? Currency { get; set; }
    public string? InstituitionType { get; set; }
     public string?  CompanyEmail { get; set; }
     public string?  PackageType { get; set; }

    public int Branches {get; set;}
        public int Users {get; set;}
        public double? DatabaseSize {get; set;}

        public double? AmountPaid {get; set;} 

        public DateTime? PaymentDate {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}






}
