using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Api_Calculadora.Models;
using Api_Calculadora.Data;

namespace Api_Calculadora.Controllers
{
    public class CalculosController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Calculos
        public async Task<IHttpActionResult> GetCalculos()
        {
            var calculos = await db.Calculos.ToListAsync();
            return Ok(calculos);
        }

        // GET: api/Calculos/Sumas
        [Route("api/Calculos/Sumas")]
        public async Task<IHttpActionResult> GetSumas()
        {
            var sumas = await db.Calculos.Where(c => c.Operacion == "Suma").ToListAsync();
            return Ok(sumas);
        }

        // GET: api/Calculos/Restas
        [Route("api/Calculos/Restas")]
        public async Task<IHttpActionResult> GetRestas()
        {
            var restas = await db.Calculos.Where(c => c.Operacion == "Resta").ToListAsync();
            return Ok(restas);
        }

        // GET: api/Calculos/Multiplicaciones
        [Route("api/Calculos/Multiplicaciones")]
        public async Task<IHttpActionResult> GetMultiplicaciones()
        {
            var multiplicaciones = await db.Calculos.Where(c => c.Operacion == "Multiplicacion").ToListAsync();
            return Ok(multiplicaciones);
        }

        // GET: api/Calculos/Divisiones
        [Route("api/Calculos/Divisiones")]
        public async Task<IHttpActionResult> GetDivisiones()
        {
            var divisiones = await db.Calculos.Where(c => c.Operacion == "Division").ToListAsync();
            return Ok(divisiones);
        }

        // GET: api/Calculos/UltimosDiez
        [Route("api/Calculos/UltimosDiez")]
        public async Task<IHttpActionResult> GetUltimosDiez()
        {
            var ultimosDiez = await db.Calculos.OrderByDescending(c => c.FechaCalculo).Take(10).ToListAsync();
            return Ok(ultimosDiez);
        }

        // POST: api/Calculos
        public async Task<IHttpActionResult> PostCalculo(Calculo calculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Calculos.Add(calculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = calculo.Id }, calculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}