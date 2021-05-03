using System;
using System.Collections.Generic;
using DIO.Livros.Interfaces;

namespace DIO.Livros
{
    public class LivroRepositorio : IRepositorios<Livros>
    {
         private List<Livros> listaLivro = new List<Livros>();
		public void Atualiza(int id, Livros objeto)
		{
			listaLivro[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaLivro[id].Excluir();
		}

		public void Insere(Livros objeto)
		{
			listaLivro.Add(objeto);
		}

		public List<Livros> Lista()
		{
			return listaLivro;
		}

		public int ProximoId()
		{
			return listaLivro.Count;
		}

		public Livros RetornaPorId(int id)
		{
			return listaLivro[id];
		}
    }
}