using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class FornecedorController : ControllerBase
    {
        private readonly MQSCarDocContext _context;
        public FornecedorController(MQSCarDocContext context)
        {
            _context = context;
        }
    }
}
