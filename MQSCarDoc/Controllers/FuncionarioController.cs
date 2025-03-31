using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public FuncionarioController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
