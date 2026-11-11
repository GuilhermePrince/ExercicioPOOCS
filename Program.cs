
using ExercicioPOOCS;

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

Funcionario f1 = new Funcionario();

f1.Nome = "Sofia";
f1.Cargo = "Gerente";

f1.AumentarSalario(0.25);