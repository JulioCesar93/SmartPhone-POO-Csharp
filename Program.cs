using DesafioPOO.Models;

Nokia smartphone1 = new(numero: "3491310721", modelo: "nokia1", imei: "d517s006", memoria: 64);
Iphone smartphone2 = new(numero: "34991707070", modelo: "iphone1", imei: "def5678", memoria: 256);

Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Ifood");

Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "Prime Vídeo");