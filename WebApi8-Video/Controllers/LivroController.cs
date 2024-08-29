using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi8_Video.Dto.Autor;
using WebApi8_Video.Dto.Livro;
using WebApi8_Video.Models;
using WebApi8_Video.Services.Autor;
using WebApi8_Video.Services.Livro;

namespace WebApi8_Video.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivro()
        {
            var livros = await _livroInterface.ListarLivro();
            return Ok(livros);
        }

        [HttpGet("BuscarLivrosPorId/{idLivros}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorId(int idLivros)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivros);
            return Ok(livro);
        }
        [HttpGet("BuscarLivroPorIdAutor/{idLivros}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorIdAutor(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(idAutor);
            return Ok(livro);
        }
        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livros);
        }


        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var livros = await _livroInterface.EditarLivro(livroEdicaoDto);
            return Ok(livros);
        }
        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ExcluirLivro(int idLivros)
        {
            var livros = await _livroInterface.ExcluirLivro(idLivros);
            return Ok(livros);
        }
    }
}
