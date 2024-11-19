using InternshipTestDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternshipTestDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoClassController : ControllerBase
    {
        private readonly ProdutoClassContext _produtoClassContext ;
        public ProdutoClassController(ProdutoClassContext produtoClassContext)
        {
            _produtoClassContext = produtoClassContext;        
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoClass>>> GetProdutos()
        {
            if(_produtoClassContext.Produtos == null)
            {
                return NotFound();
            }
            return await _produtoClassContext.Produtos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoClass>> GetProduto(int id)
        {
            if (_produtoClassContext.Produtos == null)
            {
                return NotFound();
            }
            var produto = await _produtoClassContext.Produtos.FindAsync(id);
            if(produto == null)
            {
                return NotFound();
            }
            return produto;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoClass>> PostProduto(ProdutoClass produto)
        {
            produto.ID = 0;
            _produtoClassContext.Produtos.Add(produto);
            await _produtoClassContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduto), new { id = produto.ID }, produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduto(int id, ProdutoClass produto)
        {
            if (id != produto.ID)
            {
                return BadRequest();
            }

            _produtoClassContext.Entry(produto).State = EntityState.Modified;
            try
            {
                await _produtoClassContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(int id)
        {
            if (_produtoClassContext.Produtos == null)
            {
                return NotFound();
            }
            var produto = await _produtoClassContext.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            _produtoClassContext.Produtos.Remove(produto);
            await _produtoClassContext.SaveChangesAsync();
            return Ok();
        }
    }
}
