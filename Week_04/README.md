# 第十一课 二分查找

Date: Jun 14, 2020

## 二分查找的前提

1. 目标函数单调性（单调递增或者单调递减）
2. 存在上下界（bounded）
3. 能通过索引访问（index accessible）

## 代码模板

```csharp
int left = 0;
int right = ary.Length - 1
while(left <= right)
{
	int mid = (left + right) / 2;
	if (ary[mid] == target)
	{
		// find the target
		break or return result;
	}
	else if(ary[mid] < target)
	{
		left = mid + 1;
	}
	else
	{
		right = mid - 1;
	}
}
```