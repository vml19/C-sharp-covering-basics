using System.Collections;

namespace ca_basics
{
    internal class MoneyChange
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="money">13</param>
        /// <param name="coins">[1, 3,4,5]</param>
        /// <returns>Combo count</returns>
        public static int CountChange(int money, int[] coins)
        {
            int count = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                int coin = coins[i];
                if (money < coin)
                    continue;
                else
                {
                    int selfMul = coin;
                    while (selfMul <= money)
                    {
                        if (selfMul == money)
                        {
                            count++;
                            Console.WriteLine($"SELF : coin -> {coin}, selfMul -> {selfMul}, Count -> {count}");
                            break;
                        }

                        string strLog = $"coin-> {coin} selfMul -> {selfMul.ToString()}";

                        var subArr = coins.Where(val => val != coin).ToArray();
                        int targetSum = money - selfMul;
                        count += GetCombination(subArr.ToList(), targetSum).FirstOrDefault();


                        selfMul += coin;
                    }
                }
            }
            return count;
        }

        private static IEnumerable<int> GetCombination(List<int> list, int targetSum)
        {
            var s = $"TargetSum -> {targetSum}, Sub Array => {string.Join(" ", list.Select(x => string.Format("{0}", x)).ToArray())}";
            Console.WriteLine(s);
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    int b = i & (1 << j);
                    if (b > 0)
                    {
                        tempCount += list[j];
                        if (tempCount == targetSum)
                        {
                            yield return 1;
                        }
                        Console.Write(list[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
