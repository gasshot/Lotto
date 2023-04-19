//using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Lottery : MonoBehaviour
{
    public Text[] text1;
    //public Text text2;
    //public Text text3;
    //public Text text4;
    //public Text text5;
    //public Text text6;

    // Start is called before the first frame update
    void FirstShuffle()
    { 
    
    }
    void Start()
    {
        int count = 6;
        int min = 1;
        int max = 45;
        List<int> firstArray = new List<int>();
        string[] firstArrayString = new string[6];

        int[] secondArray = new int[count];
        int[] thirdArray = new int[count];
        int[] fourthArray = new int[count];
        int[] fifthArray = new int[count];

        for (int loop = 0; loop < count; loop++)
        {
            // 랜덤 값 생성
            int randNumber = UnityEngine.Random.Range(min, max);

            // 랜덤 값이 배열에 존재하면 loop를 1 감소
            if(firstArray.Contains(randNumber))
            {
                loop--;
            }
            // 랜덤 값이 배열에 없으면 배열에 추가
            else if(!firstArray.Contains(randNumber))
            {
                firstArray.Add(randNumber);
            }

        }
        firstArray.Sort();
        for (int i = 0; i < count; i++)
        {
            if (firstArray[i] < 10)
            {
                firstArrayString[i] = "0" + firstArray[i].ToString();
            }
            else
            {
                firstArrayString[i] = firstArray[i].ToString();
            }
        }
        foreach (string loterry in firstArrayString)
        {
            Debug.Log(loterry);
        }
        text1[0].text = firstArrayString[0];
        text1[1].text = firstArrayString[1];
        text1[2].text = firstArrayString[2];
        text1[3].text = firstArrayString[3];
        text1[4].text = firstArrayString[4];
        text1[5].text = firstArrayString[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
