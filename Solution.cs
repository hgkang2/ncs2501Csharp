using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Runtime.Serialization;

class Solution
{
    /// <summary>
    /// 짝수 홀수 개수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] solution01172(int[] num_list)
    {
        int[] answer = new int[2];
        foreach(var item in num_list)
        {
            if(item%2==0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }
        return answer;
    }
    /// <summary>
    /// 머쓱이보다 키 큰 사람
    /// </summary>
    /// <param name="array"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public int solution0117 (int[]array, int height)
    {
        int answer = 0;
        for(int i= 0; i < array.Length; i++ )
        if (height < array [i] )
        {
            answer= answer+1;
        }
        return answer;
    }
    /// <summary>
    /// 배열나누기
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int[] solution01162(int[] numbers, int num1, int num2)
    {
        //리턴할 배열의 크기를 먼저 구한다
        int len = num2 - num1 + 1;
        //구한 크기만큼 배열을 선언
        int[] answer = new int[len];
        //크기만큼 반복
        for (int i = 0; i < len; i++)
        {
            //인덱스에 해당하는 값을 배열에 넣는다
           answer[i] = numbers[num1 + i]; 
        }
            //배열 리턴
            return answer;
    }
    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public double solution0116(string message)
    {
        int answer = 0;
        answer = message.Length * 2;
        return answer;
    }
    /// <summary>
    /// 배열의 평균값
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public double solution0115 (int[] numbers)
    {
        int sum = 0;
        double answer = 0;
        //배열의 요소만큼 반복
        for(int i = 0; i<numbers.Length; i++)
        //각 요소를 더한다
        {
            sum = sum += numbers [i];
        }
        //결과값을 배열의 크기로 나눈다
        answer = sum / (double)numbers.Length;
        return answer;
    }
    /// <summary>
    /// 양꼬치
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>

    public int solution01142 (int n, int k)
    {
        int answer=0;
        int ser = n/10;
        answer = n * 12000 + k * 2000 - ser*2000;
        return answer;
    }
    /// <summary>
    /// 짝수의 합
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int solution0114(int n)
    {
        // 계산된 값을 저장할 변수를 준비한다
        int answer = 0;
        //n까지 반복한다
        for(int i =0; i <= n; i++)
        //짝수인가?
        if (i%2==0)
        //짝수일경우 계산
        {
            answer = answer+i;
        }
        //계산된 최종값을 리턴한다
        return answer;  
    }
    /// <summary>
    /// 숫자비교하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0113(int num1, int num2)
    {
        //기본풀이
        int answer = 0;
        if (num1 == num2)
        {
        answer = 1;
        }
        else
        {
            answer = -1;
        }
        return answer;
        //3항 연산자
        //answer = (num1 == num2)? answer = 1 : -1;
        //3항 연산자2
        //return num1 == num2 ? 1 : -1;
        // 단축
        /*if (num1 == num2)
        {
            return 1;
        }
        else
        {
            return -1;
        }*/
        //return answer;
    }
    /// <summary>
    /// 나이출력
    /// </summary>
    /// <param name="age"></param>
    /// <returns></returns>
    public int solution01102(int age)
    {
        //나이출력
        int answer = 0;
        answer = 2022 - age + 1;
        return answer;
    }

    /// <summary>
    /// 나머지구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0110(int num1, int num2)
    {
        //단축2
        return num1 % num2;

        //단축1
        /*int answer = num1 % num2;
        return answer;*/

        //답
        /*int answer = -1; //계산으로 나올 수 없는 값을 기본값으로 해준다.
        answer = num1 % num2;
        return answer;*/
    }
    public int solution0109(int num1, int num2)
    {
        //단축2
        return num1 - num2;

        //단축1
        //int anything = num1 - num2;
        //return anything;

        //답
        //int answer = 0;
        //answer = num1 - num2;
        //return answer;
    }
    public int solution0108(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }
} 