using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;
using System.Linq;

namespace MQSCarDocFrontend.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public UsuarioController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
