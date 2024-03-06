namespace Algoritmo.Csharp.TabelaLinear
{
    public  class TestOneArrayAppend
    {
        public void Main()
        {
            int[] array = { 90, 70, 50, 80, 60,85 };
            array = Adicionar(array, 75);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.ReadKey();

        }
        public  int[] Adicionar(int[] arry,int value)
        {
            int[] tempArray = new int[arry.Length + 1]; // Crie um tempArray maior que o array

            for (int i = 0; i < arry.Length; i++)
            {
                tempArray[i] = arry[i]; // Copie o  valor da matriz para um tempArray
                tempArray[arry.Length] = value; // Insira o valor para o utlimo Array 
                
            }

            return tempArray;
        }
    }
}
