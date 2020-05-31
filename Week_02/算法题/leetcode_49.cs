public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            IList<IList<string>> list = new List<IList<string>>();
            Dictionary<string,List<string>> dic =new Dictionary<string, List<string>>();
            foreach(string str in strs)
            {
                List<char> ary = str.ToList();
                ary.Sort();
                string tmp = string.Join("",ary);
                if(!dic.ContainsKey(tmp))
                {
                    dic.Add(tmp,new List<string>());
                }
                dic[tmp].Add(str);
            }
            foreach( var item in dic)
            {
                IList<string> tmp = new List<string>();
                foreach( string s in item.Value)
                {
                    tmp.Add(s);
                }
                list.Add(tmp);
            }
            return list;
    }
}