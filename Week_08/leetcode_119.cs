public class Solution
{
    // x&(x-1) 清零最低位的 1
    public int HammingWeight(unint n)
    {
        int num = 0;
        while(num!=0)
        {
            n &= (n-1);
            num++;
        }
        return num;
    }
}