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

  public class EmailRequest
    {
        //string compayName = "OSSIA";
        //string compayLogo = "OSSIA";
        //string companyUrl = "https://oguntoye.github.io/KTU-INL-P/";
        //string loginUrl = "https://oguntoye.github.io/KTU-INL-P/";
        //string smtpHost = "smtp.gmail.com";
        //int  smtpPort = 587;
        //bool smtpEnableSsl = true;//ConfigurationManager.AppSettings["ENABLE_SSL"].ToString().ToUpper() == "TRUE" ? true : false
        //string smtpUserName = "JohnAmoahKobla@gmail.com";
        //string smtpPassword = "ubjyusrtsygallyx";

        string compayName = "OSSIA";
        string compayLogo = "OSSIA";
        string companyUrl = "https://glydetek.com/";
        string smtpHost = "smtp.gmail.com";
        int smtpPort = 587;
       
        
        bool smtpEnableSsl = false;//ConfigurationManager.AppSettings["ENABLE_SSL"].ToString().ToUpper() == "TRUE" ? true : false
        string smtpUserName = "glydetekgroup@gmail.com";
        string smtpPassword = "xtjbezbejqtyauqu";
        int clientTimeout = 10000;

        public int ClientTimeout
        {
            get { return clientTimeout; }
            set { clientTimeout = value; }
        }
        public string CompanyName
        {
            get { return compayName; }
            set { compayName = value; }
        }

        public string CompanyLogo
        {
            get { return compayLogo; }
            set { compayLogo = value; }
        }
        public string CompanyURL
        {
            get { return companyUrl; }
            set { companyUrl = value; }
        }

        public string SmtpHost
        {
            get { return smtpHost; }
            set { smtpHost = value; }
        }
        public int SmtpPort
        {
            get { return smtpPort; }
            set { smtpPort = value; }
        }
        public bool SmtpEnableSsl
        {
            get { return smtpEnableSsl; }
            set { smtpEnableSsl = value; }
        }

        public string SmtpUserName
        {
            get { return smtpUserName; }
            set { smtpUserName = value; }
        }
        public string SmtpPassword
        {
            get { return smtpPassword; }
            set { smtpPassword = value; }
        }

    }


}