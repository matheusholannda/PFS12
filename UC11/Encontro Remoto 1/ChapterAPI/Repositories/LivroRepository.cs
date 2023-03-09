﻿using ChapterAPI.Contexts;
using ChapterAPI.Interfaces;
using ChapterAPI.Models;

namespace ChapterAPI.Repositories
{
    /// <summary>
    /// repositório para classe Livro, deverá se comunicar com o contexto
    /// vai pegar a solicitação do controller e vai acessar as informações no banco via context 
    /// herda da interface ILivroRepository
    /// </summary>
    public class LivroRepository : ILivroRepository
    {
        //variável privada criada para armazenar os dados do context
        private readonly ChapterContext _chapterContext;

        //injeção de dependência: o repository depende do context
        public LivroRepository(ChapterContext context)
        {
            _chapterContext = context; //armazenamento das informações do context dentro da variável privada
        }

        //método implementado da interface
        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList(); //o contexto acesso a tabela Livros e lista os itens dentro dela
        }
    }
}
