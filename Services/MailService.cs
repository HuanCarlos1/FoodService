using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Services.Email;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Kamall_foods_server_aspNetCore.Services;

public class EmailService : IEmailService
{
    private readonly MailSettings _mailPersonalSettings;
    private readonly MailSettings _mailProfessionalSettings;

    public EmailService(IOptions<MailTypes> mailSettings)
    {
        _mailProfessionalSettings = mailSettings.Value.Professional;
        _mailPersonalSettings = mailSettings.Value.Personal;
    }

    public async Task SendProfessional(MailRequest mailRequest)
    {
        var email = new MimeMessage();

        email.From.Add(new MailboxAddress(_mailProfessionalSettings.DisplayName, _mailProfessionalSettings.Mail));
        email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
        email.Subject = mailRequest.Subject;
        email.Body = new TextPart(TextFormat.Html) { Text = mailRequest.Body };

        using var smtp = new SmtpClient();
        await smtp.ConnectAsync(_mailProfessionalSettings.Host, _mailProfessionalSettings.Port);
        await smtp.AuthenticateAsync(_mailProfessionalSettings.Mail,
            Environment.GetEnvironmentVariable("EMAILPASSWORD"));
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);
    }

    public async Task SendPersonal(MailRequest mailRequest)
    {
        var email = new MimeMessage();

        email.From.Add(new MailboxAddress(_mailPersonalSettings.DisplayName, _mailPersonalSettings.Mail));
        email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
        email.Subject = mailRequest.Subject;
        email.Body = new TextPart(TextFormat.Html) { Text = mailRequest.Body };

        using var smtp = new SmtpClient();
        await smtp.ConnectAsync(_mailPersonalSettings.Host, _mailPersonalSettings.Port);
        await smtp.AuthenticateAsync(_mailPersonalSettings.Mail,
            Environment.GetEnvironmentVariable("EMAILPASSWORD"));
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);
    }

    public async Task RestaurantManagerCreationValidation(RestaurantAdminCreateRequest request)
    {
        var mailRequest = new MailRequest
        {
            Attachments = null,
            Subject = "En attente de validation de création de compte",
            Body =
                $"<p>Bonjour Mr/Mme {request.Firstname} {request.Lastname},</p>" +
                "" +
                "<p>Votre demande de création de compte pour votre restaurant sur Kamall Foods à été bien prise en compte.</p>" +
                "<p>Nous vous recontacterons bientôt sur votre numéro de téléphone pour vous confirmer la création de votre profile restaurant.</p>" +
                "" +
                "<p>Cordialement,</p>" +
                "<p>L'équipe Kamall Foods</p>" +
                "<img src=`https://kamall-bf.com/nouveauScripts/images/menu/logo/logo_kamall_grand5.png` alt=`Kamall logo` />",
            ToEmail = new MailAddress(request.Email).ToString()
        };
        await SendProfessional(mailRequest);
    }

    public async Task UserLinkValidationEmail(User user)
    {
        var url =
            $"https://www.kamall-foods.com/Users/account_verification/email/{user.ID}/{user.AccountValidationToken}";
        var mailRequest = new MailRequest
        {
            Attachments = null,
            Subject = "Confirmer votre compte Kamall Foods",
            Body =
                "<p>Pour terminer la création de votre compte, confirmez votre adresse email en cliquant sur ce lien:</p>" +
                $"<p><a href={url}>{url}</a></p>" +
                "" +
                "<img src=`https://kamall-bf.com/nouveauScripts/images/menu/logo/logo_kamall_grand5.png` alt=`Kamall logo`/>",
            ToEmail = new MailAddress(user.Email).ToString()
        };

        await SendPersonal(mailRequest);
    }
}