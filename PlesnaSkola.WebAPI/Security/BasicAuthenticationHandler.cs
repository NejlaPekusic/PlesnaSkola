using PlesnaSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisniciService _korisniciService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisniciService userService)
            : base(options, logger, encoder, clock)
        {
            _korisniciService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Korisnici PrijavljeniKorisnik = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                PrijavljeniKorisnik = _korisniciService.Autentifikacija(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (PrijavljeniKorisnik == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            _korisniciService.SetPrijavljeniKorisnik(PrijavljeniKorisnik);

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, PrijavljeniKorisnik.Username),
                new Claim(ClaimTypes.Name, PrijavljeniKorisnik.ImePrezime),
            };

            if (PrijavljeniKorisnik.Asistent != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Asistent"));
            }
            if (PrijavljeniKorisnik.Voditelj != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Voditelj"));
            }
            if (PrijavljeniKorisnik.Trener != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Trener"));
            }
            if (PrijavljeniKorisnik.Plesac != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Plesac"));
            }
            if (PrijavljeniKorisnik.Roditelj != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Roditelj"));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
