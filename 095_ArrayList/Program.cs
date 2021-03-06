﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * ArrayList
 *  - 컬렉션 중 배열과 가장 유사
 *  - 생성 시 미리 용량을 지정할 필요가 없다
 *  - 자동으로 용량이 줄어들거나 늘어난다
 *  - Add(), RemoveAt(), Insert()
 */
namespace _095_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");       // Add(string name)
            arrList.Add(10f);           // Add(float num)

            for(int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach(object data in arrList)
            {
                Console.WriteLine("arrList data: " + data);
            }

            // 배열데이터로 초기화
            Console.WriteLine("배열테이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach(object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: " + data);
            }
        }
    }
}
