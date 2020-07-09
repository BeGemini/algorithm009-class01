// 颠倒给定二进制的 32 位无符号证书的二进制位
public class Solution
{
    public uint reverseBits(unint n)
    {
        uint res = 0;
        int power = 31;
        while(n != 0)
        {
            res += (n&1)<<power;
            n = n>>1;
            power--;
        }
        return res;
    }
}

// 这道题真的是让我想了快半个小时，最后在 iPad 上画了一下，终于理通了
// 跟官方题解说的一样，关键思想是，对于位于索引 i 处的位，在反转之后，其位置应位于 31-i
// 所以我们需要将该二进制数从后往前，将其放到反转后的位置
// 而获取该二进制数最后一位的办法，就是 n&1，获取下一位，只需将当前数右移 1 位，再求 n&1 即可