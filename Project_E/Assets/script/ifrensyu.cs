using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor.ShaderGraph;


public class ifrensyu : MonoBehaviour
{
    int count;
    int pic;
    public TextMeshProUGUI text_chul;
    public TextMeshProUGUI Ytext_0;
    public TextMeshProUGUI Ytext_1;
    public TextMeshProUGUI Ytext_2;
    public TextMeshProUGUI Ytext_3;
    public TextMeshProUGUI Ytext_4;
    public TextMeshProUGUI Ytext_5;
    public TextMeshProUGUI Ytext_6;
    public TextMeshProUGUI Ytext_7;
    public TextMeshProUGUI Ytext_8;
    public TextMeshProUGUI Ytext_9;
    public Image picA;
    public Image picB;
    public Image picC;
    public Image GC0;
    public Image GC1;
    public Image GC2;
    public Image GC3;
    public Image GC4;
    public Image GC5;
    public Image GC6;
    public Image GC7;
    public Image GC8;
    public Image GC9;
    public Button Dan;
    public Button yun;
    public Image colorimage;
    public Image colorimage1;
    public Image colorimage2;
    public TextMeshProUGUI gcount;

    List<string> Clist = new List<string>();
    List<string> Clist1 = new List<string>();
    List<string> Clist2 = new List<string>();
    private void Awake()
    {
        count = 0;
        pic = 0;
        picA.color = Color.gray;
        gcount.text = $"{count}";
    }

    private void Start()
    {
        Clist.Add("���߿�");
        Clist.Add("������");
        Clist.Add("��μ�");
        Clist.Add("���뿬");
        Clist.Add("�Ѽ���");
        Clist.Add("���ѳ�");
        Clist.Add("�ڽÿ�");
        Clist.Add("����ȣ");
        Clist.Add("����");
        Clist.Add("������");

        Clist1.Add("������ ���߿�");
        Clist1.Add("������ ��μ�");
        Clist1.Add("����");
        Clist1.Add("���");
        Clist1.Add("�׳� ����");

        Clist2.Add("����");
        Clist2.Add("ŷ��Ȳ ���ѳ�");
        Clist2.Add("���� ������");
    }

    public void OnclickPicA()
    {
        pic = 0;
        picA.color = Color.gray;
        picB.color = Color.white;
        picC.color = Color.white;
    }

    public void OnclickPicB()
    {
        pic = 1;
        picA.color = Color.white;
        picB.color = Color.gray;
        picC.color = Color.white;
    }

    public void OnclickPicC()
    {
        pic = 2;
        picA.color = Color.white;
        picB.color = Color.white;
        picC.color = Color.gray;
    }
    /*
public void Onclickgacha()
    {
        int RandomValue = Random.Range(1, 101);
        Debug.Log(RandomValue);
        switch (pic)
        {
            case 0:
                if (10 <= count)
                {
                    text_chul.text = "'ŷ��Ȳ�����۷� ���ѳ�'���� ��̴�!";
                    count = 0;
                }
                else if (RandomValue <= 70)
                {
                    text_chul.text = "'������ ���߿�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 85)
                {
                    text_chul.text = "'������'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 90)
                {
                    text_chul.text = "'����'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 99)
                {
                    text_chul.text = "'������ ��μ�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 101)
                {
                    text_chul.text = "'�׳� ����'�� �����̽��ϴ�";
                }

                count++;
                break;
            case 1:
                if (10 <= count)
                {
                    text_chul.text = "'¯¯�� ������'���� ��̴�!";
                    count = 0;
                }
                else if (RandomValue <= 70)
                {
                    text_chul.text = "'������ ���߿�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 85)
                {
                    text_chul.text = "'�߿�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 90)
                {
                    text_chul.text = "'�뿬'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 99)
                {
                    text_chul.text = "'�׳� ��μ�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 101)
                {
                    text_chul.text = "'���Գ� ����'�� �����̽��ϴ�";
                }
                count++;
                break;

            case 2:
                if (10 <= count)
                {
                    text_chul.text = "'���̹̾� ����'���� ��̴�!";
                    count = 0;
                }
                else if (RandomValue <= 70)
                {
                    text_chul.text = "'����'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 85)
                {
                    text_chul.text = "'����'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 90)
                {
                    text_chul.text = "'���ѳ�'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 99)
                {
                    text_chul.text = "'���'�� �����̽��ϴ�";
                }
                else if (RandomValue <= 101)
                {
                    text_chul.text = "'�丮�� ����'�� �����̽��ϴ�";
                }
                count++;
                break;

        }



    }
    */
    public void Onclickgacha2()
    {
        for (int yuncount = 0; yuncount < 10; yuncount++)
        {
            int RandomValue = Random.Range(1, 100);


            if (count >= 100)
            {
                text_chul.text = $"{Clist2[1]}��/�� ȹ���Ͽ����ϴ�";
                count -= 100;
                count++;
                gcount.text = $"{count}";
                if (yuncount == 0)
                {
                    Ytext_0.text = $"{Clist2[1]}";
                    GC0.color = colorimage2.color;
                }
                else if (yuncount == 1)
                {
                    Ytext_1.text = $"{Clist2[1]}";
                    GC1.color = colorimage2.color;
                }
                else if (yuncount == 2)
                {
                    Ytext_2.text = $"{Clist2[1]}";
                    GC2.color = colorimage2.color;
                }
                else if (yuncount == 3)
                {
                    Ytext_3.text = $"{Clist2[1]}";
                    GC3.color = colorimage2.color;
                }
                else if (yuncount == 4)
                {
                    Ytext_4.text = $"{Clist2[1]}";
                    GC4.color = colorimage2.color;
                }
                else if (yuncount == 5)
                {
                    Ytext_5.text = $"{Clist2[1]}";
                    GC5.color = colorimage2.color;
                }
                else if (yuncount == 6)
                {
                    Ytext_6.text = $"{Clist2[1]}";
                    GC6.color = colorimage2.color;
                }
                else if (yuncount == 7)
                {
                    Ytext_7.text = $"{Clist2[1]}";
                    GC7.color = colorimage2.color;
                }
                else if (yuncount == 8)
                {
                    Ytext_8.text = $"{Clist2[1]}";
                    GC8.color = colorimage2.color;
                }
                else if (yuncount == 9)
                {
                    Ytext_9.text = $"{Clist2[1]}";
                    GC9.color = colorimage2.color;
                }
            }
            else if (RandomValue <= 80)
            {
                int CC = Random.Range(0, 9);
                text_chul.text = $"{Clist[CC]}��/�� ȹ���Ͽ����ϴ�";
                if (yuncount == 0)
                {
                    Ytext_0.text = $"{Clist[CC]}";
                    GC0.color = colorimage.color;
                }
                else if (yuncount == 1)
                {
                    Ytext_1.text = $"{Clist[CC]}";
                    GC1.color = colorimage.color;
                }
                else if (yuncount == 2)
                {
                    Ytext_2.text = $"{Clist[CC]}";
                    GC2.color = colorimage.color;
                }
                else if (yuncount == 3)
                {
                    Ytext_3.text = $"{Clist[CC]}";
                    GC3.color = colorimage.color;
                }
                else if (yuncount == 4)
                {
                    Ytext_4.text = $"{Clist[CC]}";
                    GC4.color = colorimage.color;
                }
                else if (yuncount == 5)
                {
                    Ytext_5.text = $"{Clist[CC]}";
                    GC5.color = colorimage.color;
                }
                else if (yuncount == 6)
                {
                    Ytext_6.text = $"{Clist[CC]}";
                    GC6.color = colorimage.color;
                }
                else if (yuncount == 7)
                {
                    Ytext_7.text = $"{Clist[CC]}";
                    GC7.color = colorimage.color;
                }
                else if (yuncount == 8)
                {
                    Ytext_8.text = $"{Clist[CC]}";
                    GC8.color = colorimage.color;
                }
                else if (yuncount == 9)
                {
                    Ytext_9.text = $"{Clist[CC]}";
                    GC9.color = colorimage.color;
                }
                count++;
                gcount.text = $"{count}";
            }
            else if (RandomValue <= 95)
            {
                int CC = Random.Range(0, 3);
                text_chul.text = $"{Clist1[CC]}��/�� ȹ���Ͽ����ϴ�";
                if (yuncount == 0)
                {
                    Ytext_0.text = $"{Clist1[CC]}";
                    GC0.color = colorimage1.color;
                }
                else if (yuncount == 1)
                {
                    Ytext_1.text = $"{Clist1[CC]}";
                    GC1.color = colorimage1.color;
                }
                else if (yuncount == 2)
                {
                    Ytext_2.text = $"{Clist1[CC]}";
                    GC2.color = colorimage1.color;
                }
                else if (yuncount == 3)
                {
                    Ytext_3.text = $"{Clist1[CC]}";
                    GC3.color = colorimage1.color;
                }
                else if (yuncount == 4)
                {
                    Ytext_4.text = $"{Clist1[CC]}";
                    GC4.color = colorimage1.color;
                }
                else if (yuncount == 5)
                {
                    Ytext_5.text = $"{Clist1[CC]}";
                    GC5.color = colorimage1.color;
                }
                else if (yuncount == 6)
                {
                    Ytext_6.text = $"{Clist1[CC]}";
                    GC6.color = colorimage1.color;
                }
                else if (yuncount == 7)
                {
                    Ytext_7.text = $"{Clist1[CC]}";
                    GC7.color = colorimage1.color;
                }
                else if (yuncount == 8)
                {
                    Ytext_8.text = $"{Clist1[CC]}";
                    GC8.color = colorimage1.color;
                }
                else if (yuncount == 9)
                {
                    Ytext_9.text = $"{Clist1[CC]}";
                    GC9.color = colorimage1.color;
                }
                count++;
                gcount.text = $"{count}";
            }
            else if (RandomValue <= 100)
            {
                int CC = Random.Range(0, 2);
                text_chul.text = $"{Clist2[CC]}��/�� ȹ���Ͽ����ϴ�";
                if (yuncount == 0)
                {
                    Ytext_0.text = $"{Clist2[CC]}";
                    GC0.color = colorimage2.color;
                }
                else if (yuncount == 1)
                {
                    Ytext_1.text = $"{Clist2[CC]}";
                    GC1.color = colorimage2.color;
                }
                else if (yuncount == 2)
                {
                    Ytext_2.text = $"{Clist2[CC]}";
                    GC2.color = colorimage2.color;
                }
                else if (yuncount == 3)
                {
                    Ytext_3.text = $"{Clist2[CC]}";
                    GC3.color = colorimage2.color;
                }
                else if (yuncount == 4)
                {
                    Ytext_4.text = $"{Clist2[CC]}";
                    GC4.color = colorimage2.color;
                }
                else if (yuncount == 5)
                {
                    Ytext_5.text = $"{Clist2[CC]}";
                    GC5.color = colorimage2.color;
                }
                else if (yuncount == 6)
                {
                    Ytext_6.text = $"{Clist2[CC]}";
                    GC6.color = colorimage2.color;
                }
                else if (yuncount == 7)
                {
                    Ytext_7.text = $"{Clist2[CC]}";
                    GC7.color = colorimage2.color;
                }
                else if (yuncount == 8)
                {
                    Ytext_8.text = $"{Clist2[CC]}";
                    GC8.color = colorimage2.color;
                }
                else if (yuncount == 9)
                {
                    Ytext_9.text = $"{Clist2[CC]}";
                    GC9.color = colorimage2.color;
                }
                count++;
                gcount.text = $"{count}";
            }
        }
        
    }
}

