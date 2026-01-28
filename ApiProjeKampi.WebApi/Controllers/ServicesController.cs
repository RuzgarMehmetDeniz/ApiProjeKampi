using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ApiContext _context;

        public ServicesController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult serviceList()
        {
            var values = _context.Services.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Createservice(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return Ok("kategori Ekleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult Deleteservice(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori Silme İşlemi Başarılı");
        }
        [HttpGet("Getservice")]
        public IActionResult Getservice(int id)
        {
            var value = _context.Services.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Updateservice(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return Ok("Kategori Güncelleme İşlemi Başarılı");
        }
    }
}
