
namespace BubbleSorting
{
    public class TestBubbleSort
    {
        public void Main()
        {
            int[] scores = { 90, 70, 50, 80,60,85 };
            sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
        }

        public void sort(int[] arrays)
        {
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                bool trocar = false;

                for (int j = 0; j  < arrays.Length - 1; j++)
                {
                    if (arrays[j] > arrays[j + 1]) // Faz a Troca
                    {
                        int flag = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = flag;
                        trocar = true;
                        if (!trocar) // Nao faz a troca e encerra a ordenacao
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
