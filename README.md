# Smartphone - Trilha .NET (DIO) - Programação orientada a objetos
By dio.me

## Descrição
Aprimoramento de conhecimentos de módulos de orientação a objetos, da trilha .NET da DIO.

## Contexto
Sistema que trabalha com celulares, onde diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos. No sistema em .NET, é mapeado uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Estabelecido conforme o diagrama:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** classe abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** classes filhas de Smartphone.
3. O método **InstalarAplicativo** será obrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.