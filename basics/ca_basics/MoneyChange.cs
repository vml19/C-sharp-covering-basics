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

                        // find all permutations
                        var subArr = coins.Where(val => val != coin).ToArray();
                        var permutations = Permute(subArr);

                        // check each permutation for the sum
                        foreach (var item in permutations)
                        {
                            int TargetSum = money - selfMul;
                            var itemStr = string.Join(" + ", item.Select(n => n.ToString()).ToArray());

                            if (item.Sum() > TargetSum)
                                continue;

                            if (item.Sum() == TargetSum)
                            {
                                count++;
                                Console.WriteLine($"INTER : {strLog}, sub total -> {TargetSum}, itemStr {itemStr} = item.Sum -> {item.Sum()}, count -> {count}");
                            }
                            else
                            {
                                Console.WriteLine($"INTER : {strLog}, sub total -> {TargetSum}, itemStr {itemStr} = item.Sum -> {item.Sum()}, count -> {count} NO LUCK");
                            }
                        }

                        selfMul += coin;
                    }
                }
            }
            return count;
        }

        static IEnumerable<int[]> Permute(int[] data)
        {
            return Permute(data, 0);
        }

        static IEnumerable<int[]> Permute(int[] data, int level)
        {
            // reached the edge yet? backtrack one step if so.
            if (level >= data.Length) yield break;

            // yield the first #level elements
            yield return data.Take(level + 1).ToArray();

            // permute the remaining elements
            for (int i = level + 1; i < data.Length; i++)
            {
                var temp = data[level];
                data[level] = data[i];
                data[i] = temp;

                foreach (var item in Permute(data, level + 1))
                    yield return item;

                temp = data[i];
                data[i] = data[level];
                data[level] = temp;
            }

        }
    }
}
