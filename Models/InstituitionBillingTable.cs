using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexi_Biller_Back.Models
{
    public class InstituitionBillingTable
    {
        public int Id {get; set;}
        public string? InstituitionName {get; set;}
        public string? ShortName {get; set;}
        public string? IsInvoiceSent {get; set;}
        public string? AccessDenied {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}
        public int DaysLeft {get; set;}
        public string? CompanyEmail {get; set;}

    }

    public class BillTableDTO{
       public string? InstituitionName {get; set;}
        public string? ShortName {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}
      
        public string? CompanyEmail {get; set;}
  
    }

    public class PaymentHistory{
        public int Id {get; set;}
        public string? InstituitionName {get; set;}
        public string? ShortName {get; set;}
        public string? Country {get; set;}
        public string? Currency {get; set;}
        public string? InstituitionType {get; set;}
        public string? CompanyEmail {get; set;}
        public string? PackageType {get; set;}
        public int Branches {get; set;}
        public int Users {get; set;}
        public double? DatabaseSize {get; set;}
        public string? BillingType {get; set;} 

        public double? AmountPaid {get; set;} 

        public DateTime? PaymentDate {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}





    }

    public class Authenticate{
         public int Id {get; set;}
         public string? Username{get; set;}
         public string? Password{get; set;}
         public string? ShortName{get; set;}
    }



}