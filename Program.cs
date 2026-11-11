
using ExercicioPOOCS;
using ListaExPOO;

// // 1. Apresentação de pessoas

// Pessoa p1 = new Pessoa();

// p1.Nome = "Guilherme";

// p1.Idade = 17;

// p1.Cidade = "São Paulo";

// Pessoa p2 = new Pessoa();

// p2.Nome = "Sofia";

// p2.Idade = 16;

// p2.Cidade = "Rio de Janeiro";

// p1.Apresentar();
// p2.Apresentar();


// // 2. Métodos de instância e métodos estáticos

// Calculadora conta = new Calculadora(); 

// Console.WriteLine(conta.Somar(2, 3));

// Console.WriteLine(conta.Subtrair(4, 8));

// Console.WriteLine(conta.Multiplicar(7, 19));

// Console.WriteLine(Calculadora.Dividir(27, 3));

// Console.WriteLine(Calculadora.Dividir(3, 0));


// //3. Propriedades com validação

// Veiculo camaro = new Veiculo();

// camaro.medidorVelocidade(45);

// Console.WriteLine(camaro.Velocidade);

// camaro.medidorVelocidade(456);

// Console.WriteLine(camaro.Velocidade);

// camaro.medidorVelocidade(198);

// Console.WriteLine(camaro.Velocidade);


//4. Propriedades e controle de acesso

// Funcionario f1 = new Funcionario();

// f1.Nome = "Sofia";
// f1.Cargo = "Gerente";

// f1.DefinirSalario(5000.00m);

// f1.AumentarSalario(0.5m);

// f1.ConsultarSalario();

//f1.Salario = 4300; Não é possível realizar está ação, pois o setter dessa propriedade está privado, isso é útil para encapsulamneto das propriedades utilizando de métodos



//5. Construtores e sobrecarga

// Livro book1 = new Livro();
// Livro book2 = new Livro("O Triste fim de Policarpo Qaresma");
// Livro book3 = new Livro("São Bernardo", "Graciliano Ramos");
// Livro book4 = new Livro("Capitães da Areia", "Jorge Amado", 280);

// Console.WriteLine($"Título: {book1.Titulo}\nAutor: {book1.Autor}\nNúmero de páginas: {book1.NumeroPaginas}");
// Console.WriteLine($"Título: {book2.Titulo}\nAutor: {book2.Autor}\nNúmero de páginas: {book2.NumeroPaginas}");
// Console.WriteLine($"Título: {book3.Titulo}\nAutor: {book3.Autor}\nNúmero de páginas: {book3.NumeroPaginas}");
// Console.WriteLine($"Título: {book4.Titulo}\nAutor: {book4.Autor}\nNúmero de páginas: {book4.NumeroPaginas}");

