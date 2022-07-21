using ApiCatalogo.Data;
using ApiCatalogo.Filters;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        //Motivos por usar interface de enumerable ao inves de List<>
        //1° interface somente para leitura,
        //2° enumerable trabalha por demanda,
        //3°não necessito ter toda coleção na memória
        public  ActionResult<IEnumerable<Produto>> Get()
        {
            try
            {
                var produtos =  _context.Produtos.AsNoTracking().ToList();
                if (produtos is null)
                {
                    return NotFound("Produtos não encontrados");
                }
                return produtos;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao tratar a sua solicitação");
            }

        }

        [HttpGet("{id:int:min(1)}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            try
            {
                var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
                if (produto is null)
                {
                    return NotFound("Produto não Encontrado");
                }
                return produto;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao tratar a sua solicitação");
            }
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            try
            {
                if (produto is null)
                    return BadRequest("Não foi possivel adicionar o produto");

                _context.Produtos.Add(produto);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterProduto",
                    new { id = produto.ProdutoId }, produto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao tratar a sua solicitação");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            try
            {
                if (id != produto.ProdutoId)
                {
                    return BadRequest();
                }
                _context.Entry(produto).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(produto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao tratar a sua solicitação");
            }

        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

                if (produto is null)
                {
                    return NotFound("Produto não localizado.");
                }

                _context.Produtos.Remove(produto);
                _context.SaveChanges();

                return Ok("Produto excluido com sucesso.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao tratar a sua solicitação");
            }
        }
    }
}
