### Jogo da Forca

**Objetivo:** usando uma aplicação do tipo console do dotnet, criar um jogo da forca que irá ler uma lista de nomes de filmes, nomes de jogos (vídeo game) e países.

## Novos conceitos ou funcionalidades desse exercício

Gravação e leitura de arquivos para armazenar os nomes de filmes, carros e países.

**Estude:**
- Gravação e leitura de arquivos.
- Orientação a objetos (encapsulamento, herança, abstração e polimorfismo).

Caso não conheça os conceitos de orientação a objetos, pause um pouco a execução do exercício, estude esses conceitos e coloque-os em prática em alguns exemplos, pois no próximo exercício apronfundaremos em orientação a objetos.

## Requisitos da aplicação

- Ao abrir a aplicação o sistema deverá sortear aleatóriamente uma das 3 categorias: filmes, carros ou países e, após isso, sortear um dos nomes  da categoria selecionada.

- Após a seleção feita pelo sistema, exiba um placar na tela com a quantidade de tentativas dísponíveis e quantas tentativas já foram realizadas. Nesse mesmo placar crie uma lista com as letras e números já utlizados pelo jogador.

- Mostre na tela também, a categoria sorteada e a quantidade de letras da palavra. Além da quantidade de letras, inicialmente todas as letras da palavra devem ser substituídas por underline (_). Exemplo:
	- Se a palavra for o filme Matrix, deverá ser exibido 6 underline no lugar da palavra.
	- Ao acertar a letra A, deverá ser exibido apenas a letra a na posição correta.

- A cada tentativa atualize o placar com as pontuações.

- Caso o jogador a 0 no número de tentativas exiba a mensagem "Fim de jogo, você perdeu!".

- Caso o jogador acerte todas as letras, exiba a mensagem "Fim de jogo, você venceu!".

**Opcional**
- Fazer o controle de versionamento da sua aplicação usando git;
- Subir a aplicação para um repositório do github.
- Faça o uso de todos os pilares da programação Orientada a Objetos.
- Utilize Enumeradores para a categoria das palavras.

# Desafios

1. Crie mais uma categoria para o jogo dê sua preferência.
2. Antes de iniciar o jogo dê a opção do usuário escolher a dificuldade do jogo: fácil, normal ou difícil:
	- Fácil: 7 tentativas
	- Normal: 6 tentativas
	- Difícil: 5 tentativas