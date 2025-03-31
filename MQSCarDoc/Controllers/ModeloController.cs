using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class ModeloController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public ModeloController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
