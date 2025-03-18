# Classificador De Triângulos

## Demonstração

![](https://i.imgur.com/tCcWSPO.gif)

## Introdução

Um jogo onde você digita os três lados de um triângulo e descobre qual tipo ele é.

## Como funciona

- Você informa o **lado X**, **lado Y** e **lado Z**.
- O jogo verifica se esses lados podem formar um triângulo.
- Se for válido, ele mostra o tipo:
  - **Equilátero**: todos os lados iguais.
  - **Isósceles**: dois lados iguais.
  - **Escaleno**: todos os lados diferentes.
- Caso contrário, o jogo vai avisar que o **Triângulo é inválido**.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project ClassificacaoDeTriangulos.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./ClassificacaoDeTriangulos.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
ClassificacaoDeTriangulos.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.