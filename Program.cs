using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "81818181", modelo: "4545", imei: "5151", memoria: 454);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo(nomeApp: "gitHub");

Console.WriteLine("\n");

Iphone I1 = new Iphone(numero: "81818181", modelo: "4545", imei: "5151", memoria: 454);
I1.Ligar();
I1.ReceberLigacao();
I1.InstalarAplicativo(nomeApp: "Linkedin");