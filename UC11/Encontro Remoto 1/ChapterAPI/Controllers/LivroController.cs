using ChapterAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterAPI.Controllers
{
    [Produces("application/json")] //formato de reposta da api : json
    [Route("api/[controller]")] //rota para acesso do controller : api/livro
    [ApiController] //identificação que é uma classe controladora
    public class LivroController : ControllerBase //herança da classe ControllerBase
    {
        private readonly ILivroRepository _iLivroRepository; //variável privada criada para armazenar os dados da interface

        public LivroController(ILivroRepository iLivroRepository) //injeção de dependência: o controller depende da interface
        {
            _iLivroRepository = iLivroRepository; //armazenamento das informações da interface dentro da variável privada
        }

        [HttpGet] //verbo Get: de obter
        //IActionResult : https://learn.microsoft.com/pt-br/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0
        public IActionResult Listar() //nome do controller para listar os livros 
        {
            try //caso dê certo
            {
                return Ok(_iLivroRepository.Ler()); //retorna um status code 200 e os itens da lista
            }
            catch (Exception e) //caso dê errado
            {
                throw new Exception(e.Message); //retorna uma mensagem de erro
            }
        }
    }
}
