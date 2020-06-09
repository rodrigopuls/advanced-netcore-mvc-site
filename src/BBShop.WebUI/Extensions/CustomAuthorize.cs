using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BBShop.App.Extensions
{
    /// <summary>
    /// Autorização customizada:
    /// - Validação de Claims
    /// - Atributo para ser usado nos controllers
    /// - Filtro de Autorização que checa as actions que contém o atributo customizado
    /// </summary>
    public class CustomAuthorization
    {
        // Validar as Claims do Usuário 
        public static bool ValidarClaimsUsuario(HttpContext context, string claimName, string claimValue)
        {
            // e o usuário possui a autenticação e se possui o valor da Claim
            return context.User.Identity.IsAuthenticated &&
                   context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }

    }

    // Atributo que fará uso do RequisitoClaimFilter
    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitoClaimFilter))
        {

            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }

    // Filtro de Autorização
    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public RequisitoClaimFilter(Claim claim)
        {
            // Recebe a Claim como parâmetro
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Validar a Claim

            // Se está autenticado
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                // Se não estiver, redireciona para o LOGIN
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { area = "Identity", page = "/Account/Login", ReturnUrl = context.HttpContext.Request.Path.ToString() }));
                return;
            }

            // Se possui as Claims esperadas
            if (!CustomAuthorization.ValidarClaimsUsuario(context.HttpContext, _claim.Type, _claim.Value))
            {
                // Se não tiver, retorna ACESSO NEGADO
                context.Result = new StatusCodeResult(403);
            }
        }
    }
}
