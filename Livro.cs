
namespace ListaExPOO
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "Sem título";
            Autor = "Sem Autor";
            NumeroPaginas = 0;
        }
        public Livro(string titulo)
        {
            Titulo = titulo;
        }
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = paginas;
        }
    }
}