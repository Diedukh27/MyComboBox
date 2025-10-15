// See https://aka.ms/new-console-template for more information

using MyCalculator;
using Privat24;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт, Козаки ");

// Calculator calc= new Calculator();
// calc.PrintInfo();

PrivatService ps = new PrivatService();
ps.PrintInfo();

ps.GetJsonValuta();
Console.WriteLine(ps.GetJsonValuta());  

// string json = '[{"ccy":"EUR","base_ccy":"UAH","buy":"48.20000","sale":"49.20000"},{ "ccy":"USD","base_ccy":"UAH","buy":"40.98000","sale":"41.58000"}]';
