using Microsoft.AspNetCore.Antiforgery;
using WebProject.Controllers;

namespace WebProject.Web.Host.Controllers
{
    public class AntiForgeryController : WebProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
