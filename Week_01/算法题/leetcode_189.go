package leetcode

// 189. 旋转数组
// 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。

// 暴力
func rotate(nums []int, k int) {
	for i := 0; i < k; i++ {
		end := nums[len(nums)-1]
		for j := len(nums) - 1; j > 0; j-- {
			nums[j] = nums[j-1]
		}
		nums[0] = end
	}

	for _, v := range nums {
		println(v)
	}
}

// 按规律执行，有缺陷，调试环节整了我好长时间，应该按五毒掌来的
func rotate2(nums []int, k int) {
	k = k % len(nums)
	if nums == nil || len(nums) < 2 || k == 0 {
		return
	}
	end := nums[len(nums)-1]
	for i := 0; i < len(nums)/2; i++ {
		if i < k {
			index := i - 1
			if index == -1 {
				index = len(nums) - 1
			}
			tmp := nums[(i+k)%len(nums)]
			nums[(i+k)%len(nums)] = nums[i]
			if index == (i+k)%len(nums) {
				continue
			}
			nums[index] = tmp
		}
	}
	nums[k-1] = end

	for _, v := range nums {
		println(v)
	}
}
