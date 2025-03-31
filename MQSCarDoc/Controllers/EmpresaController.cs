using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class EmpresaController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public EmpresaController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
