#  *Sintaxe e Tipos de valor em C# - .NET*

---

### O que é sintaxe?
- ***Sintaxe*** é o nome dado ao ambiente em que uma ***linguagem de programação é escrita***, por exemplo, cada linguagem de programação tem sua própria sintaxe.

---

### O que é tipo de dados?
- Tipo de dados são ***tipos de variáveis que ficaram armazenados dentro de uma variável***, como um tipo texto ou tipo número.

---

### O que é .NET?
- .NET é um ***ambiente de desenvolvimento*** para facilitar a vida do desenvolvedor de software, a fim de amplificar e criar produtividade durante o seu dia.

---

### O que é C#?
- C# (CSharp) é uma ***linguagem de programação*** utilizada no ambiente de desenvolvimento .NET, mantido em open source e pela ***Microsoft***.

---

### O que é uma variável?
- Variável é um ***tipo*** que ficará referenciado ou ***armazenado na memória do computador***.
- **Possíveis tipos de dados** - números, letras, palavras, uma letra, etc.
- **Tipos de valor** - Armazenam os dados diretamente!
- **Tipos de referência** - Apontam para o local da memória onde os dados estão armazenados.

---

# Tipos de variáveis
---
- **Var** - Usado para definir uma ***variável sem*** declarar seu **tipo**.

- **Bool** - Declara verdadeiro ou false. (true or false).

- **Byte** - Declara números que irão de 0 até 255, somente.

- **Char** - Define um caractere Unicode que representam uma Letra. (U+0000 a U+FFFF).

- **String** - Utilizado para declarar uma variável ***tipo texto***.

- **Int** - Definido para instancionar uma variável tipo ***número inteiro***.

- **Decimal** - Tipo de dado definido para utilizar ***números com casas decimais***.

- **Double** - Utilizado para definir um tipo de dado número para ***suportar dois grandes números***, seja decimal ou inteiro.

- **Float** - Tipo de dado usado para definir um número de ***ponto flutuante*** para seu **número**.

- **Long** - Define números inteiros que atinge uma quantidade maior de finalidade. (-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 com somente números inteiros).

- **sbyte** - tipo alongado do tipo byte. (-128 a 127).

- **short** - Armazena uma quantidade certa de números inteiros somente. (-32.768 a 32.767).

- **uint** - Armazena um número do tipo int alongado. (0 a 4.294.967.295 - inteiros somente) 

- **ulong** - Variável do tipo long alongado. (0 a 18.446.744.073.709.551.615- inteiros somente)

- **ushort** - Variável do tipo short alongado. (0 a 65.535 - inteiros somente)

- **enum** - Conjunto de constantes nomeados.

- **struct** - Agrupa pequenos grupos de variáveis relacionadas.

--- 

# Boas práticas para criação de nomes de váriaveis

- Não utilizar acentos.
- Não pode conter cedilhas e caracteres especiais.
- Não começar o nome de uma variável com números.

### Exemplos de boas práticas

int numero = 2;
int **(tipo)** numero **(nome da variavel)** **=** (operador de atribuição) e o número **2** (que é o valor atribuido a variavel numero).