using System;

namespace DIO.Livros
{
    public class Livros : EntidadeBase
    {
        //Atributos
        private Genero Genero{get;set;}
        private String Titulo{get;set;}
        private String Descricao{get;set;}
        private int Ano{get;set;}
        private bool Excluido{get;set;}

        public Livros(int Id, Genero Genero, string Titulo, string Descricao, int Ano){
            this.Id = Id;
			this.Genero = Genero;
			this.Titulo = Titulo;
			this.Descricao = Descricao;
			this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaId(){
            return this.Id;
        }

         public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void Excluir() {
            this.Excluido = true;
        }


    }
}