using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      ICalculadora calc = new Calculadora();
      System.Console.WriteLine(calc.Somar(10, 20));
      System.Console.WriteLine(calc.Dividir(10, 2));

      // Corrente c = new Corrente();
      // c.Creditar(100);
      // c.ExibirSaldo();
      // c.Creditar(200);
      // c.ExibirSaldo();

      // Calculadora calc = new Calculadora();
      // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(2, 4));
      // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(2, 4, 9));

      // Aluno a = new Aluno();
      // a.Nome = "Bob";
      // a.Idade = 20;
      // a.Nota = 10;
      // a.Apresentar();

      // Professor p = new Professor();
      // p.Nome = "Rob";
      // p.Idade = 40;
      // p.Salario = 2359.32;
      // p.Apresentar();

      // //valores validos
      // Retangulo r = new Retangulo();
      // r.DefinirMedidas(30, 30);
      // System.Console.WriteLine($"Área: {r.ObterArea()}");

      // //valores invalidos
      // Retangulo r2 = new Retangulo();
      // r2.DefinirMedidas(0, 0);
      // System.Console.WriteLine($"Área: {r2.ObterArea()}");

      // Pessoa p1 = new Pessoa();

      // p1.Nome = "Bob";
      // p1.Idade = 20;

      // p1.Apresentar();

    }
  }
}