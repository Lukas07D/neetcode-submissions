public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> nome = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++) {
        int diff = target - nums[i];
        if (nome.ContainsKey(diff)) {
            return new int[] {nome[diff], i};
        }
        nome.Add(nums[i], i);
    }
    return new int[] {0, 0};
    }
}