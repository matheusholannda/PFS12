using ChapterAPI.Models;

namespace ChapterAPI.Interfaces
{
    /// <summary>
    /// Interface ILivroRepository
    /// </summary>
    public interface ILivroRepository
    {
        List<Livro> Ler(); //método que deverá ser implementado pela classe que herdar desta interface
    }
}
