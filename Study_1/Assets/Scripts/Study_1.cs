using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_1 : MonoBehaviour
{
    //int 정수형, float 부동소수점형, double 배정도부동소수점형, bool 불형, char 문자형, string 문자열형

    void Start()
    {
        int age;            //변수 age 선언
        age = 30;           //선언된 변수 age에 나이(30세) 대입
        Debug.Log(age);     //변수 age에 대입된 나이를 Debug.Log로 출력
        //---------------------------------------------------------------------------------------------------------------------------------
        float height1 = 160.5f;     //변수 height1에 160.5f 대입
        float height2;              //변수 height2 선언
        height2 = height1;          //변수 height2에 height1을 대입해 초기화
        Debug.Log(height2);         //출력
        //---------------------------------------------------------------------------------------------------------------------------------
        string name;         //변수 name 선언
        name = "Sera";       //변수 string에 선언된 name에 Sera 라는 이름을 대입(대입연산자"=")
        Debug.Log(name);     //name에 대입된 Sera를 출력
        //---------------------------------------------------------------------------------------------------------------------------------
        int answer;               //변수 answer 선언
        answer = 100 + 22;        //변수 answer에 100과 22를 더한 값을 대입(연산자-> -, +, *, /)
        Debug.Log(answer);        //answer에 대입되어있는 값을 출력
        //---------------------------------------------------------------------------------------------------------------------------------
        int a = 19;             //a 변수 선언과 값을 정함
        int b = 13;             //b 변수 선언과 값을 정함
        int answer1;            //위에서 answer 변수를 사용했기에 answer1 변수를 선언해 위 내용과 충돌이 없게 함
        answer1 = a + b;        //answer1에 a+b 대입
        Debug.Log(answer1);     //answer1의 값을 출력
        //---------------------------------------------------------------------------------------------------------------------------------
        int answer2 = 22;       //answer2 변수를 선언
        answer2 += 11;          //answer2변수의 값을 11만큼 증가(연산자 += 사용)
        Debug.Log(answer2);     //출력
        //---------------------------------------------------------------------------------------------------------------------------------
        int answer3 = 100;         //변수 answer3을 100이라고 선언
        answer3++;                 //변수 answer3이 1 증가하도록 함(증가연산자 ++)
        Debug.Log(answer3);        //출력
        //---------------------------------------------------------------------------------------------------------------------------------
        string str1 = "happy";       //문자를 집어넣는 변수 string, str1에 happy라는 값 대입
        string str2 = "birthday";    //문자를 집어넣는 변수 string, str2에 birthday라는 값 대입
        string message;              //message 변수 선언
        message = str1 + str2;       //message 변수에 str1 + str2 대입(+=연산자를 활용해 message 변수를 사용하지 않을 수도 있다)
        Debug.Log(message);          //대입한 값을 출력
        //---------------------------------------------------------------------------------------------------------------------------------
        string str = "you're";                 //str 변수에 you're이라는 값을 대입(문자열)
        int num = 12;                          //num 변수에 12라는 값을 대입(수)
        string message1 = str + num;           //str + num 의 값을 message 변수에 대입
        Debug.Log(message1);                   //대입된 값을 출력
        //---------------------------------------------------------------------------------------------------------------------------------

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
