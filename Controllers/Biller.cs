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



[HttpPost("AddToBillTable")]
public async Task<IActionResult> AddToBillTable([FromForm] BillTableDTO bTable){

var addBTable = new InstituitionBillingTable{
InstituitionName = bTable.InstituitionName,
ShortName = bTable.ShortName,

StartDate = bTable.StartDate,
EndDate = bTable.EndDate,
CompanyEmail = bTable.CompanyEmail,

};

addBTable.IsInvoiceSent = "0";
addBTable.AccessDenied = "false";


 if (bTable.EndDate.HasValue)
    {
        TimeSpan timeDifference = bTable.EndDate.Value - DateTime.Today;
        addBTable.DaysLeft = (int)timeDifference.TotalDays;
    }
else
    {
     addBTable.DaysLeft = 0;
    }

var biller = await context.BillingTable.AnyAsync(a=>a.ShortName == addBTable.ShortName);

if(biller==true){

var s = context.BillingTable.FirstOrDefault(a=>a.ShortName == addBTable.ShortName);

if(s!=null){

s.InstituitionName = bTable.InstituitionName;
s.ShortName = bTable.ShortName;
s.IsInvoiceSent = "0";
s.AccessDenied = "false";
s.StartDate = bTable.StartDate;
s.EndDate = bTable.EndDate;
s.CompanyEmail = bTable.CompanyEmail;

if (bTable.EndDate.HasValue)
    {
        TimeSpan timeDifference = bTable.EndDate.Value - DateTime.Today;
        s.DaysLeft = (int)timeDifference.TotalDays;
    }
else
    {
     s.DaysLeft = 0;
    }


await context.SaveChangesAsync();


}


}
else{

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
   string endDate = s.EndDate?.ToString("dd MMMM, yyyy") ?? "N/A";
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



private async Task SendInvoice(string email, string companyName, string endDate)
{
    // Construct the email body with the invoice details
    string body = $@"
        <p>Dear {companyName},</p>
        <p>Please find attached the invoice for the services provided.</p>
        <p>Invoice Details:</p>
        <ul>
            <li>Company Name: {companyName}</li>
            <li>End Date: {endDate}</li>
            <!-- Add more invoice details here as needed -->
        </ul>
        <p>If you have any questions or concerns, please don't hesitate to contact us.</p>
        <p>Thank you for your business!</p>
        <p>Best Regards,<br>Glydetek Group Limited</p>";

    // Email subject
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