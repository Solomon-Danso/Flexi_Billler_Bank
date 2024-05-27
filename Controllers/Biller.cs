using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Flexi_Biller_Back.Data;
using Flexi_Biller_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flexi_Biller_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Biller : ControllerBase
    {
        private readonly DataContext context;
        public Biller(DataContext ctx){
            context = ctx;
        }

[HttpPost("AddUser")]
public async Task<IActionResult> AddUser([FromForm]Authenticate u){

var user = new Authenticate{
    Username = u.Username,
    Password = u.Password,
    ShortName = u.ShortName
};

context.Auth.Add(user);
await context.SaveChangesAsync();

return Ok("User added successfully");

}


[HttpPost("Login")]
public async Task<IActionResult> Login([FromForm]Authenticate u){

var person = context.Auth.FirstOrDefault(a=>a.Username == u.Username && a.Password == u.Password);
if(person == null){
     return BadRequest(new { key = "error", message = "User not found", errorCode = 400 });

}

return Ok(person);

}


[HttpPost("PaymentHistory")]
public async Task<IActionResult> PaymentHistory([FromForm] PaymentHistory p)
{
    if (!p.StartDate.HasValue || !p.EndDate.HasValue)
    {
        return BadRequest("StartDate and EndDate are required.");
    }

    var pay = new PaymentHistory
    {
        InstituitionName = p.InstituitionName,
        ShortName = p.ShortName,
        Country = p.Country,
        Currency = p.Currency,
        InstituitionType = p.InstituitionType,
        CompanyEmail = p.CompanyEmail,
        PackageType = p.PackageType,
        Branches = p.Branches,
        Users = p.Users,
        DatabaseSize = p.DatabaseSize,
        BillingType = p.BillingType,
        AmountPaid = p.AmountPaid,
        PaymentDate = DateTime.Now,
        StartDate = p.StartDate.Value,
        EndDate = p.EndDate.Value
    };

    try
    {
        context.PaymentHis.Add(pay);
        await context.SaveChangesAsync();
        await AddToBillTable(
            pay.InstituitionName,
            pay.ShortName,
            pay.StartDate.Value,
            pay.EndDate.Value,
            pay.CompanyEmail
        );
    }
    catch (Exception e)
    {
        return BadRequest(e);
    }

    return Ok($"{pay.InstituitionName} payment transaction added successfully");
}


[HttpGet("GetPaymentHis")]
public async Task<IActionResult> GetPaymentHis(string ShortName){
var s = context.PaymentHis.Where(a=>a.ShortName == ShortName).ToList();
if (s==null){
    return BadRequest(new { key = "error", message = "No payment history found", errorCode = 400 });
}

return Ok(s);


}



private async Task<IActionResult> AddToBillTable(string InstituitionName, string ShortName, DateTime StartDate, DateTime EndDate, string CompanyEmail)
{
    var addBTable = new InstituitionBillingTable
    {
        InstituitionName = InstituitionName,
        ShortName = ShortName,
        StartDate = StartDate,
        EndDate = EndDate,
        CompanyEmail = CompanyEmail,
        IsInvoiceSent = "0",
        AccessDenied = "false"
    };

    try
    {
        TimeSpan timeDifference = EndDate - DateTime.Today;
        addBTable.DaysLeft = (int)timeDifference.TotalDays;
    }
    catch (Exception e)
    {
        addBTable.DaysLeft = 0;
    }

    var biller = await context.BillingTable.AnyAsync(a => a.ShortName == addBTable.ShortName);

    if (biller)
    {
        var s = context.BillingTable.FirstOrDefault(a => a.ShortName == addBTable.ShortName);

        if (s != null)
        {
            s.InstituitionName = InstituitionName;
            s.ShortName = ShortName;
            s.IsInvoiceSent = "0";
            s.AccessDenied = "false";
            s.StartDate = StartDate;
            s.EndDate = EndDate;
            s.CompanyEmail = CompanyEmail;

            try
            {
                TimeSpan timeDifference = EndDate - DateTime.Today;
                s.DaysLeft = (int)timeDifference.TotalDays;
            }
            catch (Exception e)
            {
                s.DaysLeft = 0;
            }

            await context.SaveChangesAsync();
        }
    }
    else
    {
        context.BillingTable.Add(addBTable);
        await context.SaveChangesAsync();
    }

    return Ok("User added successfully");
}









[HttpGet("ViewBillInst")]
public async Task<IActionResult> ViewBillInst(string ShortName){

var s = context.BillingTable.FirstOrDefault(a=>a.ShortName == ShortName);
if (s==null){
    return BadRequest(new { key = "error", message = "Instituition not found", errorCode = 400 });
}
var theDaysLeft = 0;

//Update The Days  Left
if (s.EndDate.HasValue)
    {
        TimeSpan timeDifference = s.EndDate.Value - DateTime.Today;
        s.DaysLeft = (int)timeDifference.TotalDays;
        theDaysLeft = (int)timeDifference.TotalDays;
    }
else
    {
     s.DaysLeft = 0;
    }



//Send the Invoice if DaysLeft is 14 and Invoice sent is "0"
if(theDaysLeft<15 && s.IsInvoiceSent=="0"){
  // string endDate = s.EndDate?.ToString("dd MMMM, yyyy") ?? "N/A";
   DateTime endDate = s.EndDate.Value;

      await SendInvoice(s.CompanyEmail, s.InstituitionName, endDate);
s.IsInvoiceSent = "1";
 
}


//If Days left is less than 1, set accessDenied to "true" 
if(theDaysLeft<1){
    s.AccessDenied = "true";
}



await context.SaveChangesAsync();
return Ok(s);
}



private async Task SendInvoice(string email, string companyName, DateTime endDate)
{
    
    // Construct the email body with the invoice details
    string body = $@"
    

    <!DOCTYPE html>
    <!--[if lt IE 7]>      <html class='no-js lt-ie9 lt-ie8 lt-ie7'> <![endif]-->
    <!--[if IE 7]>         <html class='no-js lt-ie9 lt-ie8'> <![endif]-->
    <!--[if IE 8]>         <html class='no-js lt-ie9'> <![endif]-->
    <!--[if gt IE 8]>      <html class='no-js'> <!--<![endif]-->
    <html>
        <head>
            <meta charset='utf-8' />
            <meta http-equiv='X-UA-Compatible' content='IE=edge' />
            <title></title>
            <meta name='description' content='' />
            <meta name='viewport' content='width=device-width, initial-scale=1' />
            <link rel='stylesheet' href='' />
            <link rel='preconnect' href='https://fonts.googleapis.com' />
            <link rel='preconnect' href='https://fonts.gstatic.com' crossorigin />
            <link href='https://fonts.googleapis.com/css2?family=Lexend:wght@300;500&display=swap' rel='stylesheet' />
            <!-- <style type='text/css'>
          body {{
            font-family: Lexend;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 200px;
            background-color: #fffff2;
          }}
          .container {{
            border-radius: 5px;
            width: 300px;
            height: max-content;
            background-color: white;
            box-shadow: 0px 20px 40px rgb(10 33 65 / 5%),
              0px 0px 2px rgb(0 0 0 / 13%);
            border: 0.5px solid rgba(0, 0, 0, 0.1);
            padding: 20px;
          }}
          nav {{
            display: flex;
            justify-content: space-between;
            align-items: center;
          }}
          button {{
            border: none;
            border: 30px;
            border-radius: 5px;
            border: none;
            background-color: #8f0408;
            color: white;
            text-align: center;
            padding: 7px 25px;
            cursor: pointer;
            transition: all 0.5s ease-in-out;
            display: flex;
            align-items: center;
            align-content: center;
            justify-content: center;
            height: max-content;
          }}
          .confirm {{
            padding: 15px 40px;
          }}
          h3 {{
            display: flex;
            align-items: center;
            margin: 0;
            font-weight: bolder;
          }}
          h2 {{
            margin-top: 40px;
          }}
          p {{
            font-size: 12px;
            color: grey;
            font-weight: 300;
          }}
          .code {{
            padding: 20px;
            text-align: center;
            color: black;
            font-size: 24px;
            background-color: #eae2b7;
            font-weight: bolder;
          }}
          .option {{
            color: black;
            font-weight: 500;
          }}
        </style> -->
        </head>
        <body style='font-family: Lexend; justify-content: center; align-items: center; min-height: 200px; background-color: #fffff2;'>
            <div style='border-radius: 5px; width: 300px; height: max-content; background-color: white; box-shadow: 0px 20px 40px rgb(10 33 65 / 5%), 0px 0px 2px rgb(0 0 0 / 13%); border: 0.5px solid rgba(0, 0, 0, 0.1); padding: 20px;'>

                <h2 style='margin-top: 40px;'>Invoice</h2>
                <p style='font-size: 16px; color: grey; font-weight: 300;'>
                  Dear {companyName},                
                </p> 

                  <p style='font-size: 16px; color: grey; font-weight: 300;'>
                  Please be noted that your subscription will expire on <b>{endDate}</b> 
                  </p>
                <p style='font-size: 12px; color: grey; font-weight: 300; padding: 20px; text-align: center; color: black; font-size: 24px; background-color: #eae2b7; font-weight: bolder;'>
                    Kindly contact our Financial team to renew your subscription
                </p>

                <p style='font-size: 16px; color: grey; font-weight: 300; color: black; font-weight: 500;'>
                   Best Regards,<br>Glydetek Group Limited
                </p>
                         
         </div>
        </body>

    </html>

    
    ";    // Email subject
    string subject = "Invoice for Services Rendered";

    // Use the current date for the email
    string theDate = DateTime.Today.ToString("dd MMMM, yyyy");

    // Create an instance of EmailRequest
    EmailRequest mail = new EmailRequest();

    // Send the email using SMTP
    using (SmtpClient smtpClient = new SmtpClient(mail.SmtpHost, mail.SmtpPort))
    {
        smtpClient.EnableSsl = true;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(mail.SmtpUserName, mail.SmtpPassword);

        // Create a MailMessage instance
        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress(mail.SmtpUserName);
        mailMessage.To.Add(email);
        mailMessage.Subject = subject;
        mailMessage.Body = body;
        mailMessage.IsBodyHtml = true; // Set the email body format to HTML

        // Send the email asynchronously
        await smtpClient.SendMailAsync(mailMessage);
    }
}






    }
}