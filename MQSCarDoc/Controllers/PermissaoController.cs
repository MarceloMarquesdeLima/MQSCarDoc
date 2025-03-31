using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class PermissaoController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public PermissaoController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
