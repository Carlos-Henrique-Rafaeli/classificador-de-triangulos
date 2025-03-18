# Classificador De Tri�ngulos

## Demonstra��o

![](https://i.imgur.com/tCcWSPO.gif)

## Introdu��o

Um jogo onde voc� digita os tr�s lados de um tri�ngulo e descobre qual tipo ele �.

## Como funciona

- Voc� informa o **lado X**, **lado Y** e **lado Z**.
- O jogo verifica se esses lados podem formar um tri�ngulo.
- Se for v�lido, ele mostra o tipo:
  - **Equil�tero**: todos os lados iguais.
  - **Is�sceles**: dois lados iguais.
  - **Escaleno**: todos os lados diferentes.
- Caso contr�rio, o jogo vai avisar que o **Tri�ngulo � inv�lido**.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project ClassificacaoDeTriangulos.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./ClassificacaoDeTriangulos.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
ClassificacaoDeTriangulos.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.