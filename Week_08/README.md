学习笔记

## 勤动脑 勤动手

今天在做第 190 题时，虽然是一道简单的题，但是自己在看题解的时候完全没有想法，看了快半小时了，我觉得这样不行，于是开始看他的代码，并自己在 iPad 上画一下， n&1 会得到什么，为什么要用的 n&1，终于明白了题解的意思，有一种醍醐灌顶的感觉。

## 初级排序算法

```csharp
using System;

namespace GeekTime
{
    public class SortFunctions
    {
        // 选择排序
        public void SelectionSort(int[] ary)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                int minValue = int.MaxValue;
                int minIndex = -1;
                for (int j = i; j < ary.Length; j++)
                {
                    if (ary[j] < minValue)
                    {
                        minValue = ary[j];
                        minIndex = j;
                    }
                }
                int tempValue = ary[i];
                ary[i] = minValue;
                ary[minIndex] = tempValue;
            }

            foreach (int val in ary)
            {
                Console.Write(val + " ");
            }
        }

        // 插入排序
        public void InsertionSort(int[] ary)
        {
            for (int i = 1; i < ary.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (ary[j] < ary[j - 1])
                    {
                        int tempValue = ary[j];
                        ary[j] = ary[j - 1];
                        ary[j - 1] = tempValue;
                    }
                }
            }

            foreach (int val in ary)
            {
                Console.Write(val + " ");
            }
        }

        // 冒泡排序
        public void BubbleSort(int[] ary)
        {
            int tag = ary.Length - 1;
            while (true)
            {
                bool isSwaped = false;
                for (int j = 0; j < tag; j++)
                {
                    if (ary[j] > ary[j + 1])
                    {
                        int tempValue = ary[j];
                        ary[j] = ary[j + 1];
                        ary[j + 1] = tempValue;
                        isSwaped = true;
                    }
                }
                tag--;
                if (!isSwaped)
                    break;
            }

            foreach (int val in ary)
            {
                Console.Write(val + " ");
            }
        }
    }
}
```