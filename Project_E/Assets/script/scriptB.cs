using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scriptB : MonoBehaviour
{
    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_text;
    public Image img_HPbar;
    public int maxHP;
    float nowHP;

    public int Damage;
    public int HealPoint;
    void Awake()
    {
        AUIg();
    }

    void AUIg()
    {
        nowHP = maxHP;
        RefreshUI();
    }

    public void OnClickDamage()
    {
        nowHP -= Damage;
        if (nowHP <0)
        {
            nowHP = 0;
        }

        img_HPbar.fillAmount = nowHP / maxHP;
        RefreshUI();
    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }

        img_HPbar.fillAmount = nowHP / maxHP;
        RefreshUI();

    }

    void RefreshUI()
    {
        img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}";
    }

}
