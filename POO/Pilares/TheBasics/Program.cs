using System.Net.WebSockets;
using TheBasics;
Console.Clear();

// // array/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();

// // ************EDUARDO*****************
// // Endereço
// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niterói";
// // Pessoa com Endereço
// Pessoa edu = new Pessoa(enderecoEdu);
// edu.Nome = "Eduardo Costa";
// edu.Idade = 43;

// // ************ALÉXIA*****************
// // Endereço
// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua lá de casa";
// // Pessoa Com Endereço
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Santos";
// alexia.Idade = 24;

// // guardando os dados na lista

// peoples.Add(edu);
// peoples.Add(alexia);

// // Percorre a lista people inteira e adiciona cada "pessoa" na variável "p"
// foreach (Pessoa p in peoples)
// {
//     Console.WriteLine($"Nome: {p.Nome}");
// }

// // Aluno
// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;

// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// // Professor
// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da profa. {profAlexia.Nome}");


Carro fusca = new Carro();
fusca.Marca = "Wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";

fusca.Ligar();
fusca.AbrirPortaMala();

dominar400.Ligar();
dominar400.Empinar();


Aviao AirbusA220 = new Aviao();
AirbusA220.Marca = "Bombardier CSeries";
AirbusA220.Modelo = "AirbusA220";

AirbusA220.Ligar();
AirbusA220.Turbinas();






/*

CRIAR UMA CLASSE AVIÃO COM 1 PROPRIEDADE E UM MÉTODO QUE SEJAM ESPECÍFICOS DE UM AVIÃO.

CRIE E UTILIZE UMA VARIÁVEL NA PROBGRAM.CS E ADICIONE A MARCA, MODELO, QUANTIDADE DE RODAS E A PROPRIEDADE ESPECÍFICA DO AVIÃO, ALÉM, DE CHAMAR OS MÉTODOS LIGAR E TAMBÉM O MÉTODO QUE VOCÊ CRIOU NA CLASSE AVIÃO
*/