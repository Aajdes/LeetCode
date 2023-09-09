public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] result = new int[2]{0, 1};

        for(int i = 0; i < nums.Length; i++){

            int missing = target - nums[i];

            if(nums.Contains(missing)){

                int index = Array.IndexOf(nums, missing);

                if(index != i){
                    result[0] = i;
                    result[1] = index;
                    return result;
                }
            }
        }

        return result;
    }
}
