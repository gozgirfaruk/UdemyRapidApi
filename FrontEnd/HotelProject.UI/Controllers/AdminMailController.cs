using HotelProject.UI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.UI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminmailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddress = new MailboxAddress("HotelierAdmin", "gozegir127@gmail.com");
            mimeMessage.From.Add(mailboxAddress);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Subject=model.Subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody=model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("gozegir127@gmail.com", "pfbldjuxjiah skec");
            client.Send(mimeMessage);
            client.Disconnect(true);


            return RedirectToAction("Sendbox", "AdminContract");
        }
    }
}
