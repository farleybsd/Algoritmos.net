namespace Algoritmo.Csharp.TabelaLinear
{
    public class TestOneArrayDelete
    {
        public void Main()
        {
            int[] array = { 90, 70, 50, 80, 60,85 };
            array = Remove(array, 2);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.ReadKey();
        }
        public int[] Remove(int[] array,int index)
        {
            int[] tempArray = new int[array.Length -1];

            for (int i = 0; i < array.Length; i++)
            {
                if(i < index)
                {
                    // Copie os dados anteriores a i = index para temarray
                    tempArray[i] = array[i];    

                }
                if(i > index)
                {
                    // Copie a matriz apos i = index para o final de temArray
                    tempArray[i -1] = array[i];
                }
            }

            return tempArray;
        }
    }
}
