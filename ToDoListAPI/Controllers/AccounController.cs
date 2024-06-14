using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.AccountController;
public class AccountController : Controller
{
    [HttpGet("~/login")]
    public IActionResult Login()
    {
        var properties = new AuthenticationProperties { RedirectUri = "/" };
        return Challenge(properties, GoogleDefaults.AuthenticationScheme);
    }

    [HttpGet("~/logout")]
    public IActionResult Logout()
    {
        return SignOut(new AuthenticationProperties { RedirectUri = "/" },
            CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
