//using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; // LINQ에서 제공하는 Contains() 메서드를 사용하기 위해 다음 네임스페이스를 추가
using UnityEngine;
using UnityEngine.UI; // Text 사용을 위해 추가

public class NewLottery : MonoBehaviour
{
    int count = 6;
    int min = 1;
    int max = 45;

    // 배열형으로 만들어서 지저분함을 줄임

    [SerializeField] GameObject paper;
    Transform[] myLine = new Transform[5];
    Text[,] Texts = new Text[5,6];
    //public Text[] text1;
    //public Text[] text2;
    //public Text[] text3;
    //public Text[] text4;
    //public Text[] text5;

    //List<int> emptyBox = new List<int>();

    #region MyRegion
    //void FirstShuffle()
    //{
    //    List<int> firstArray = new List<int>();
    //    string[] firstArrayString = new string[6];

    //    for (int loop = 0; loop < count; loop++) // 루프를 30번 돌려서 5단위로 쪼개 각 단위 당 1~45까지 랜덤함수를 표현하고 싶었으나 잠이오네...
    //    {
    //        // 랜덤 값 생성
    //        int randNumber = UnityEngine.Random.Range(min, max);  //? 추가 랜덤 값을 만들어 넣어서 했으면 더 깔끔하지 않았을까? 
    //                                                              //? System.Random과 UnityEngine.Random은 같지 않은 것인가?

    //        // 랜덤 값이 배열에 존재하면 loop를 1 감소
    //        if (firstArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // 랜덤 값이 배열에 없으면 배열에 추가
    //        else if (!firstArray.Contains(randNumber))
    //        {
    //            firstArray.Add(randNumber);
    //        }

    //    }
    //    firstArray.Sort(); // 배열을 내림차순으로 정렬하고 싶었으나 못찾고 리스트로 변환 후 정렬
    //    for (int i = 0; i < count; i++) // Text로 10아래의 자연수를 두자리 수로 표현하고 싶었으나 불가
    //    {                               // 받은 int 정수를 string 문자열로 받아서 사용
    //        if (firstArray[i] < 10)  // 10보다 작은 자연수에게 문자 "0"을 부여
    //        {
    //            firstArrayString[i] = "0" + firstArray[i].ToString();
    //        }
    //        else
    //        {
    //            firstArrayString[i] = firstArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in firstArrayString) // 잘 돌아가는지 로그테스트
    //    {
    //        Debug.Log(loterry);  // 도대체 유니티는 왜 WriteLine인가
    //    }
    //    text1[0].text = firstArrayString[0]; //GameObject.Find("Canvas").GetComponentInChildren<Text>();
    //    text1[1].text = firstArrayString[1];
    //    text1[2].text = firstArrayString[2];
    //    text1[3].text = firstArrayString[3];
    //    text1[4].text = firstArrayString[4];
    //    text1[5].text = firstArrayString[5];
    //}
    //void SecondShuffle()
    //{
    //    List<int> secondArray = new List<int>();
    //    string[] secondArrayString = new string[6];

    //    for (int loop = 0; loop < count; loop++)
    //    {
    //        // 랜덤 값 생성
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // 랜덤 값이 배열에 존재하면 loop를 1 감소
    //        if (secondArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // 랜덤 값이 배열에 없으면 배열에 추가
    //        else if (!secondArray.Contains(randNumber))
    //        {
    //            secondArray.Add(randNumber);
    //        }

    //    }
    //    secondArray.Sort();
    //    for (int i = 0; i < count; i++)
    //    {
    //        if (secondArray[i] < 10)
    //        {
    //            secondArrayString[i] = "0" + secondArray[i].ToString();
    //        }
    //        else
    //        {
    //            secondArrayString[i] = secondArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in secondArrayString)
    //    {
    //        Debug.Log(loterry);
    //    }
    //    text2[0].text = secondArrayString[0];
    //    text2[1].text = secondArrayString[1];
    //    text2[2].text = secondArrayString[2];
    //    text2[3].text = secondArrayString[3];
    //    text2[4].text = secondArrayString[4];
    //    text2[5].text = secondArrayString[5];
    //}
    //void ThirdShuffle()
    //{
    //    List<int> thirdArray = new List<int>();
    //    string[] thirdArrayString = new string[6];

    //    for (int loop = 0; loop < count; loop++)
    //    {
    //        // 랜덤 값 생성
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // 랜덤 값이 배열에 존재하면 loop를 1 감소
    //        if (thirdArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // 랜덤 값이 배열에 없으면 배열에 추가
    //        else if (!thirdArray.Contains(randNumber))
    //        {
    //            thirdArray.Add(randNumber);
    //        }

    //    }
    //    thirdArray.Sort();
    //    for (int i = 0; i < count; i++)
    //    {
    //        if (thirdArray[i] < 10)
    //        {
    //            thirdArrayString[i] = "0" + thirdArray[i].ToString();
    //        }
    //        else
    //        {
    //            thirdArrayString[i] = thirdArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in thirdArrayString)
    //    {
    //        Debug.Log(loterry);
    //    }
    //    text3[0].text = thirdArrayString[0];
    //    text3[1].text = thirdArrayString[1];
    //    text3[2].text = thirdArrayString[2];
    //    text3[3].text = thirdArrayString[3];
    //    text3[4].text = thirdArrayString[4];
    //    text3[5].text = thirdArrayString[5];
    //}
    //void FourthShuffle()
    //{
    //    List<int> fourthArray = new List<int>();
    //    string[] fourthArrayString = new string[6];

    //    for (int loop = 0; loop < count; loop++)
    //    {
    //        // 랜덤 값 생성
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // 랜덤 값이 배열에 존재하면 loop를 1 감소
    //        if (fourthArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // 랜덤 값이 배열에 없으면 배열에 추가
    //        else if (!fourthArray.Contains(randNumber))
    //        {
    //            fourthArray.Add(randNumber);
    //        }

    //    }
    //    fourthArray.Sort();
    //    for (int i = 0; i < count; i++)
    //    {
    //        if (fourthArray[i] < 10)
    //        {
    //            fourthArrayString[i] = "0" + fourthArray[i].ToString();
    //        }
    //        else
    //        {
    //            fourthArrayString[i] = fourthArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in fourthArrayString)
    //    {
    //        Debug.Log(loterry);
    //    }
    //    text4[0].text = fourthArrayString[0];
    //    text4[1].text = fourthArrayString[1];
    //    text4[2].text = fourthArrayString[2];
    //    text4[3].text = fourthArrayString[3];
    //    text4[4].text = fourthArrayString[4];
    //    text4[5].text = fourthArrayString[5];
    //}
    //void FifthShuffle()
    //{
    //    List<int> fifthArray = new List<int>();
    //    string[] fifthArrayString = new string[6];

    //    for (int loop = 0; loop < count; loop++)
    //    {
    //        // 랜덤 값 생성
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // 랜덤 값이 배열에 존재하면 loop를 1 감소
    //        if (fifthArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // 랜덤 값이 배열에 없으면 배열에 추가
    //        else if (!fifthArray.Contains(randNumber))
    //        {
    //            fifthArray.Add(randNumber);
    //        }

    //    }
    //    fifthArray.Sort();
    //    for (int i = 0; i < count; i++)
    //    {
    //        if (fifthArray[i] < 10)
    //        {
    //            fifthArrayString[i] = "0" + fifthArray[i].ToString();
    //        }
    //        else
    //        {
    //            fifthArrayString[i] = fifthArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in fifthArrayString)
    //    {
    //        Debug.Log(loterry);
    //    }
    //    text5[0].text = fifthArrayString[0];
    //    text5[1].text = fifthArrayString[1];
    //    text5[2].text = fifthArrayString[2];
    //    text5[3].text = fifthArrayString[3];
    //    text5[4].text = fifthArrayString[4];
    //    text5[5].text = fifthArrayString[5];
    //} 
    #endregion

    void RowShuffle(int row)
    {
        List<int> firstArray = new List<int>();
        string[] firstArrayString = new string[6];

        for (int loop = 0; loop < count; loop++) // 루프를 30번 돌려서 5단위로 쪼개 각 단위 당 1~45까지 랜덤함수를 표현하고 싶었으나 잠이오네...
        {
            // 랜덤 값 생성
            int randNumber = UnityEngine.Random.Range(min, max);  //? 추가 랜덤 값을 만들어 넣어서 했으면 더 깔끔하지 않았을까? 
                                                                  //? System.Random과 UnityEngine.Random은 같지 않은 것인가?

            //if (emptyBox.Contains(randNumber))
            //{
            //    loop--;
            //    continue;
            //}

            // 랜덤 값이 배열에 존재하면 loop를 1 감소
            if (firstArray.Contains(randNumber))
            {
                loop--;
                continue;
            }
            // 랜덤 값이 배열에 없으면 배열에 추가
            else if (!firstArray.Contains(randNumber))
            {
                firstArray.Add(randNumber);
                //emptyBox.Add(randNumber);
            }
        }

        firstArray.Sort(); // 배열을 내림차순으로 정렬하고 싶었으나 못찾고 리스트로 변환 후 정렬
        for (int i = 0; i < count; i++) // Text로 10아래의 자연수를 두자리 수로 표현하고 싶었으나 불가
        {                               // 받은 int 정수를 string 문자열로 받아서 사용
            if (firstArray[i] < 10)  // 10보다 작은 자연수에게 문자 "0"을 부여
            {
                firstArrayString[i] = "0" + firstArray[i].ToString();
            }
            else
            {
                firstArrayString[i] = firstArray[i].ToString();
            }
        }
        foreach (string loterry in firstArrayString) // 잘 돌아가는지 로그테스트
        {
            Debug.Log(loterry);  // 도대체 유니티는 왜 WriteLine인가
        }
        
        Texts[row,0].text = firstArrayString[0]; //GameObject.Find("Canvas").GetComponentInChildren<Text>();
        Texts[row,1].text = firstArrayString[1];
        Texts[row,2].text = firstArrayString[2];
        Texts[row,3].text = firstArrayString[3];
        Texts[row,4].text = firstArrayString[4];
        Texts[row,5].text = firstArrayString[5];
    }

    void Start()
    {
        for (int ii = 0; ii < paper.transform.childCount; ii++)
        {
            myLine[ii] = paper.transform.GetChild(ii);
                        
            for (int jj = 0; jj < 6; jj++)
            {
                Texts[ii,jj] = myLine[ii].GetChild(jj).GetComponent<Text>();
            }
        }

        Invoke("GetLotto", 1f);

        

        //emptyBox.Clear();


        //FirstShuffle();
        //SecondShuffle();
        //ThirdShuffle();
        //FourthShuffle();
        //FifthShuffle();
    }

    private void GetLotto()
    {
        for (int ii = 0; ii < paper.transform.childCount; ii++)
        {
            RowShuffle(ii);
        }
    }
}
