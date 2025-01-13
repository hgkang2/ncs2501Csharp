using System.Formats.Asn1;

class Solution
{
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