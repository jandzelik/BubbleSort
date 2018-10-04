namespace BubbleSortApplication
{
    public class BubbleSort
    {
        private int[] array = new int[10];

        public BubbleSort(int[] array)
        {
            this.array = array;
        }

        private void Swap(int index)
        {
            int temp = array[index + 1];
            array[index + 1] = array[index];
            array[index] = temp;
        }

        private void SortAsc()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j);
                    }
                }
            }
        }

        private void SortDesc()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        Swap(j);
                    }
                }
            }
        }

        public int[] Sort(SortDirection direction)
        {
            if (direction == SortDirection.Asc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
            return array;
        }
    }
}
