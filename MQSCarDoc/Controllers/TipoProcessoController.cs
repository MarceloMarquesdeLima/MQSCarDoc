using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class TipoProcessoController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public TipoProcessoController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
