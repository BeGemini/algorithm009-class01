// 给定一个整数，编写一个函数来判断它是否是 2 的幂次方
public class Solution
{
    // 1. 2 的幂次方的二进制为 10000...
    // 2. x & (x-1) 去掉最后位的 1
    public bool IsPowerOfTwo(int n)
    {
        return (n > 0) && ((n & (n - 1)) == 0);
    }
}