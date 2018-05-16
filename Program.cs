using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 希尔排序
{
    class Program
    {
      static  int[] a = new int[9] { 1, 5, 3, 4, 9, 7, 8, 6, 2 };
        static void Main(string[] args)//核心是每次比较的数字距离为K(增量),比较一轮完成后,k/2，k初始为数组长/2
        {
            int k = a.Length / 2;
            while (k >= 1)
            {
                int i = 0;
                while (i +k<a.Length)
                {
                    if(a[i]>a[i+k])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[i + k];
                        a[i + k] = temp;
                    }
                    i++;
                }
                if(k/2<1)
                {
                    break;
                }
                k = k / 2;
            }
        }
    }
}
