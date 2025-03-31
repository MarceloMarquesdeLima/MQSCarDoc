using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;

namespace MQSCarDocFrontend.Controllers
{
    public class MarcaController : ControllerBase
    {
        private readonly MQSCarDocContext _context;

        public MarcaController(MQSCarDocContext context)
        {
            _context = context;
        }
    {
    }
}
