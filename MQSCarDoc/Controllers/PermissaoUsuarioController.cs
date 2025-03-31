using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class PermissaoUsuarioController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public PermissaoUsuarioController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
