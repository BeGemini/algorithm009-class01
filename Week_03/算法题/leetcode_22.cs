public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> list = new List<string>();
        generate(0,0,n,"",list);
        return list;
    }

    public void generate(int left,int right,int n ,string str,IList<string> list)
    {
        if(left==n&&right==n)
        {
            list.Add(str);
        }
        if(left<n)
            generate(left+1,right,n,str+"(",list);
        if(right<left)
            generate(left,right+1,n,str+")",list);
    }
}