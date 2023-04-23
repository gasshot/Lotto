//using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; // LINQ���� �����ϴ� Contains() �޼��带 ����ϱ� ���� ���� ���ӽ����̽��� �߰�
using UnityEngine;
using UnityEngine.UI; // Text ����� ���� �߰�

public class NewLottery : MonoBehaviour
{
    int count = 6;
    int min = 1;
    int max = 45;

    // �迭������ ���� ���������� ����

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

    //    for (int loop = 0; loop < count; loop++) // ������ 30�� ������ 5������ �ɰ� �� ���� �� 1~45���� �����Լ��� ǥ���ϰ� �;����� ���̿���...
    //    {
    //        // ���� �� ����
    //        int randNumber = UnityEngine.Random.Range(min, max);  //? �߰� ���� ���� ����� �־ ������ �� ������� �ʾ�����? 
    //                                                              //? System.Random�� UnityEngine.Random�� ���� ���� ���ΰ�?

    //        // ���� ���� �迭�� �����ϸ� loop�� 1 ����
    //        if (firstArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // ���� ���� �迭�� ������ �迭�� �߰�
    //        else if (!firstArray.Contains(randNumber))
    //        {
    //            firstArray.Add(randNumber);
    //        }

    //    }
    //    firstArray.Sort(); // �迭�� ������������ �����ϰ� �;����� ��ã�� ����Ʈ�� ��ȯ �� ����
    //    for (int i = 0; i < count; i++) // Text�� 10�Ʒ��� �ڿ����� ���ڸ� ���� ǥ���ϰ� �;����� �Ұ�
    //    {                               // ���� int ������ string ���ڿ��� �޾Ƽ� ���
    //        if (firstArray[i] < 10)  // 10���� ���� �ڿ������� ���� "0"�� �ο�
    //        {
    //            firstArrayString[i] = "0" + firstArray[i].ToString();
    //        }
    //        else
    //        {
    //            firstArrayString[i] = firstArray[i].ToString();
    //        }
    //    }
    //    foreach (string loterry in firstArrayString) // �� ���ư����� �α��׽�Ʈ
    //    {
    //        Debug.Log(loterry);  // ����ü ����Ƽ�� �� WriteLine�ΰ�
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
    //        // ���� �� ����
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // ���� ���� �迭�� �����ϸ� loop�� 1 ����
    //        if (secondArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // ���� ���� �迭�� ������ �迭�� �߰�
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
    //        // ���� �� ����
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // ���� ���� �迭�� �����ϸ� loop�� 1 ����
    //        if (thirdArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // ���� ���� �迭�� ������ �迭�� �߰�
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
    //        // ���� �� ����
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // ���� ���� �迭�� �����ϸ� loop�� 1 ����
    //        if (fourthArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // ���� ���� �迭�� ������ �迭�� �߰�
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
    //        // ���� �� ����
    //        int randNumber = UnityEngine.Random.Range(min, max);

    //        // ���� ���� �迭�� �����ϸ� loop�� 1 ����
    //        if (fifthArray.Contains(randNumber))
    //        {
    //            loop--;
    //        }
    //        // ���� ���� �迭�� ������ �迭�� �߰�
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

        for (int loop = 0; loop < count; loop++) // ������ 30�� ������ 5������ �ɰ� �� ���� �� 1~45���� �����Լ��� ǥ���ϰ� �;����� ���̿���...
        {
            // ���� �� ����
            int randNumber = UnityEngine.Random.Range(min, max);  //? �߰� ���� ���� ����� �־ ������ �� ������� �ʾ�����? 
                                                                  //? System.Random�� UnityEngine.Random�� ���� ���� ���ΰ�?

            //if (emptyBox.Contains(randNumber))
            //{
            //    loop--;
            //    continue;
            //}

            // ���� ���� �迭�� �����ϸ� loop�� 1 ����
            if (firstArray.Contains(randNumber))
            {
                loop--;
                continue;
            }
            // ���� ���� �迭�� ������ �迭�� �߰�
            else if (!firstArray.Contains(randNumber))
            {
                firstArray.Add(randNumber);
                //emptyBox.Add(randNumber);
            }
        }

        firstArray.Sort(); // �迭�� ������������ �����ϰ� �;����� ��ã�� ����Ʈ�� ��ȯ �� ����
        for (int i = 0; i < count; i++) // Text�� 10�Ʒ��� �ڿ����� ���ڸ� ���� ǥ���ϰ� �;����� �Ұ�
        {                               // ���� int ������ string ���ڿ��� �޾Ƽ� ���
            if (firstArray[i] < 10)  // 10���� ���� �ڿ������� ���� "0"�� �ο�
            {
                firstArrayString[i] = "0" + firstArray[i].ToString();
            }
            else
            {
                firstArrayString[i] = firstArray[i].ToString();
            }
        }
        foreach (string loterry in firstArrayString) // �� ���ư����� �α��׽�Ʈ
        {
            Debug.Log(loterry);  // ����ü ����Ƽ�� �� WriteLine�ΰ�
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
