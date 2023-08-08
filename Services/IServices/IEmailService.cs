using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Services.Email;

namespace Kamall_foods_server_aspNetCore.Services.IServices;

public interface IEmailService
{
    public Task RestaurantManagerCreationValidation(RestaurantAdminCreateRequest request);
    public Task UserLinkValidationEmail(User user);
    public Task SendPersonal(MailRequest mailRequest);
    public Task SendProfessional(MailRequest mailRequest);
}