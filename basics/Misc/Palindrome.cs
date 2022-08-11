namespace ca_basics
{
    internal class Palindrome
    {
        /// <summary>
        /// Given the string, check if it is a palindrome.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        internal static bool Solution(string inputString)
        {
            int len = inputString.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (inputString[i] != inputString[len - (i+1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
