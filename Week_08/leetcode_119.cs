public class Solution
{
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