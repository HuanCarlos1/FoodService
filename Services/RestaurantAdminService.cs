using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services.Email;
using Kamall_foods_server_aspNetCore.Services.IServices;

namespace Kamall_foods_server_aspNetCore.Services;

public class RestaurantAdminService : IRestaurantAdminService
{
    private readonly IRestaurantAdminRepository _adminRepository;

    private readonly string[] _emails =
    {
        "abatienon@gmail.com",
        "kamallburkina@gmail.com",
        "karim01870@gmail.com"
    };

    private readonly IEmailService _emailService;

    public RestaurantAdminService(IEmailService emailService, IRestaurantAdminRepository adminRepository)
    {
        _emailService = emailService;
        _adminRepository = adminRepository;
    }

    public async Task SendRegisteringRequestEmail(RestaurantAdminCreateRequest restaurantAdmin)
    {
        string id = (await _adminRepository.FindByEmail(restaurantAdmin.Email)).ID;
        const string subject = "Nouvelle demande de création de compte";
        var body = "<p>Une nouvelle demande création de compte professionnele à été reçue.</p>" +
                   "<div style='color: #545557;background-color: #9ea4ad'>" +
                   $"<p>Nom : {restaurantAdmin.Lastname}</p>" +
                   $"<p>Prénom : {restaurantAdmin.Firstname} </p>" +
                   $"<p>Email : {restaurantAdmin.Email}</p>" +
                   $"<p>Numéro Téléphone : {restaurantAdmin.PhoneNumber}</p>" +
                   "</div>" +
                   $"<a href='https://kamall-foods-server.xyz/restaurants/validate/admin/{id}'><button style='color: #62fc03'>Approuver</button></a>" +
                   $"<a href='https://kamall-foods-server.xyz/restaurants/invalidate/admin/{id}'><button style='color: #fc3d03'>Refuser</button></a><br>" +
                   "<img src=`https://kamall-bf.com/nouveauScripts/images/menu/logo/logo_kamall_grand5.png` alt=`Kamall logo`/>";

        foreach (var mail in _emails)
        {
            var mailRequest = new MailRequest
            {
                Attachments = null,
                Subject = subject,
                Body = body,
                ToEmail = new MailAddress(mail).ToString()
            };
            await _emailService.SendProfessional(mailRequest);
        }
    }

    public async Task Approve(string id)
    {
        try
        {
            var restaurantAdmin = await _adminRepository.Find(id);
            restaurantAdmin.IsVerified = true;
            await _adminRepository.Update(restaurantAdmin.ID, restaurantAdmin);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DisapproveAndDelete(string id)
    {
        try
        {
            var restaurantAdmin = await _adminRepository.Find(id);
            await _adminRepository.Remove(restaurantAdmin.ID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}