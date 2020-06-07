学习笔记

1. 先在这里默写一下递归模板

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