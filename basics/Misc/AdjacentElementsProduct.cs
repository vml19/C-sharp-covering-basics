namespace ca_basics
{
    internal class AdjacentElementsProduct
    {
        /// <summary>
        /// Given an array of integers, find the pair of adjacent elements that has the 
        /// largest product and return that product.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        static int Solution(int[] inputArray)
        {
            int prod = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int tempProd = inputArray[i] * inputArray[i + 1];
                if (tempProd > prod)
                {
                    prod = tempProd;
                }
            }
            return prod;
        }
    }
}
