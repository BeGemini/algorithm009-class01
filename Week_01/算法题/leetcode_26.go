package leetcode

// 26. 删除排序数组中的重复项
// 给定一个排序数组，你需要在 原地 删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
// 不要使用额外的数组空间，你必须在 原地 修改输入数组 并在使用 O(1) 额外空间的条件下完成。

// 题目与之前 “移动零” 是同一题目，只是将之前的定值 0 改为了一个变量
func removeDuplicates(nums []int) int {
	//[0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 4]
	j := 0
	for i := 1; i < len(nums); i++ {
		if nums[i] != nums[j] {
			j++
			if j < len(nums) {
				nums[j] = nums[i]
			}
		}
	}
	return j + 1
}
