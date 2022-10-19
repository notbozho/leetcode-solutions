public class Solution {
    public int MaxProductDifference(int[] nums) {
        quickSort(nums, 0, nums.Length - 1);


        return getDifference(nums[0], nums[1], nums[nums.Length - 1], nums[nums.Length - 2]);
    }

    public static int getDifference(int n1, int n2, int n3, int n4)
    {
        return ((n1 * n2) - (n3 * n4)) * -1;
    }

    static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);

                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

}