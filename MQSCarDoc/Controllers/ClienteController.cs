using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class ClienteController : ControllerBase

    {
        private readonly MQSCarDocContext _context;

        public ClienteController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
