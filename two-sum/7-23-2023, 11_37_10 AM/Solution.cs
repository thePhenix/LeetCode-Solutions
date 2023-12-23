// https://leetcode.com/problems/two-sum

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];
            int i = 0;
            int j = nums.Length - 1;
            var itemsWithOrder = nums.Select((item, i) => new { Item = item, Order = i }).OrderBy(i => i.Item).ToArray();

            while (i < j)
            {
                var item1 = itemsWithOrder[i];
                var item2 = itemsWithOrder[j];
                var sum = item1.Item + item2.Item;

                if (sum > target)
                {
                    j--;
                }
                else if (sum < target)
                {
                    i++;
                }
                else
                {
                    result[0] = item1.Order;
                    result[1] = item2.Order;
                    return result;
                }
            }


        return result;
    }
}