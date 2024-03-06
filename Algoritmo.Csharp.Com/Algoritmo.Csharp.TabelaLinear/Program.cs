
/*
 *  Tabela Linear -> E uma sequencia de zero ou mais elementos de dados.Alem do primeiro elemento,cada elemento possui apenas um elemento precursor,
 *  direto e cada elemento elemento possui apenas um elemento sucessor direto, exceto o ultimo. A relacao entre os elementos de dados e de um para um.
 *  As tabelas lineares pode ser representadas por matriz unidimensionais.
 */







using Algoritmo.Csharp.TabelaLinear;

// Tabela Linear Adicione: Adicionar  o numero 75 ao final da matriz unidimensional

/*
 *  1. Primeiro, crie uma matriz temporaria (tempArray) maior que o comprimento da matriz original
 *  2. Copie cada valor da matriz para tempArrau
 *  3. Atribua o 75 no ultimo indice de tempArray
 *  4. Finalmente, atribua a referencia do ponteiro temArray a matriz original
 */

//var testOneArrayAppend = new TestOneArrayAppend();
//testOneArrayAppend.Main();


// Tabela Linear Excluir: Eclua o valor do indice = 2 da matriz

/*
 *  1. Crie uma matriz temporaria (tempArray) com o tamanho menor que a matriz original.
 *  2. Copie os dados na frente de i = 2 para a frente de tempArray
 *  3.  Copie a matriz apos i - 2  para tempArray
 *  4. Atribua a referencia do ponteiro tempArray a matriz original
 */

var testOneArrayDelete = new TestOneArrayDelete();
testOneArrayDelete.Main();