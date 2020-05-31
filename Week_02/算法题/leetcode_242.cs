public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        int[] ary = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int index1 = (int)s[i] - (int)'a';
            int index2 = (int)t[i] - (int)'a';
            ary[index1]++;
            ary[index2]--;
        }
        if (ary.All(x => x == 0))
            return true;
        else
            return false;
    }
}