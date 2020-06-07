# 思维要点

1. 不要人肉进行递归（最大误区）
2. 找到最近最简方法，将其拆解成可重复解决的问题（重复子问题）
3. 数学归纳法思维

# 递归模板

```csharp
public void recursion(int level,p1,p2...)
{
    // recursion terminator
    if (level > max_level)
    {
        process_result;
        return;
    }

    // process logic in current level
    process(level,data...);

    // drill down
    recursion(level+1,p1,...);

    // reverse the current level status if needed    
}
```