// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// tipos de variaveis
int idade = 19;
string nome = "Valdinei";
double salario = 12500.00;
bool estudante = true;
char sexo = 'M';

//constante
const double pi = 3.14;

//como exibibir as variaveis
Console.WriteLine(salario);

Console.WriteLine("Meu nome é: " + nome + " || " + "Minha idade é: " + idade);

//escopo das variaveis


    int idade2 = 20;
    Console.WriteLine(idade2);

Console.Write("Digite seu nome: ");
string nome2 = Console.ReadLine();

Console.WriteLine(nome2);

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Digite outro número: ");
int numero2 = int.Parse(Console.ReadLine());

int resultado = numero + numero2;
Console.WriteLine("O resultado da soma é: " + resultado);