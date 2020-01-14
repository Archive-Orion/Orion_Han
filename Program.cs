using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;



namespace Balancing
{
    class Program
    {
        static void Main(string[] args)
        {
            char close = new char();
            Stack<char> stack = new Stack<char>();
          
            Console.Write(""); 
            int n = Convert.ToInt32(Console.ReadLine()); // 케이스 n 입력

            int[] checkCount = new int[n];

            for (int i=0; i<n; i++)
            {   
                checkCount[i] = 0; //변수 초기화
                    Console.Write("");
                string s = Console.ReadLine();
             
                char[] arr = s.ToCharArray(); //문자열을 문자배열로 치환

                int number = arr.Length;

                    for (int j = 0; j < number; j++)
                { if(number % 2 != 0) // 괄호가 홀수면 닫기
                    {
                        checkCount[i] = 1;
                        break;
                    }
                    if(arr[0]==')' || arr[0] == ']' || arr[0] == '}') // 닫는 괄호가 먼저 나오면 닫기
                    {
                        checkCount[i] = 1;
                        break;
                    }
                    if(arr.Last() == '(' ||  // 마지막 괄호가 여는 괄호라면 닫기
                       arr.Last() == '[' || 
                       arr.Last() == '{' )
                    {
                        checkCount[i] = 1;
                        break;
                    }

                    // 여는 괄호면 스택에 푸쉬
                    if (arr[j] == '(' || arr[j] == '[' || arr[j] == '{')
                    {
                        stack.Push(arr[j]);
                    }

                    // 닫는 괄호면 스택에서 팝을 하여 close 변수에 넣고 비교하기.
                    else
                    {   
                        close = stack.Pop(); //close 변수안에 스택 pop을 하여 값을 넣어준다

                        if (close == '(' && arr[j] != ')' ||  //만약 pop(여는괄호)과 arr[j] 괄호값이 불일치 할 경우 닫기
                           close == '[' && arr[j] != ']' ||
                           close == '{' && arr[j] != '}')
                        {
                            checkCount[i] = 1;
                            break;
                        }
                        else  continue;
                    }
                } 
            } 
            for(int i=0; i<n; i++)
            {
                if (checkCount[i] == 1) 
                    Console.WriteLine("No");
                else Console.WriteLine("Yes");
                
            }
        }
    }
}



