using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button_text : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    
    public string start = "Start";

    // �{�^���������ꂽ�Ƃ��ɃV�[�������[�h
    public void OnClicked()
    {
        SceneManager.LoadScene(start);
    }

    // �{�^���������ꂽ�Ƃ��� text1 ���\���Atext2 ��\��
    public void OnClicked2()
    {
        text.SetActive(false);
        text1.SetActive(true);
    }
    public void OnClicked3()
    {
        text1.SetActive(false);
        text2.SetActive(true);

    }
    public void OnClicked4()
    {
        text2.SetActive(false);
        text3.SetActive(true);

    }

    // �{�^���������ꂽ�Ƃ��ɃG���h���[�����J�n
    public void OnClicked5()
    {
        UnityEngine.Debug.Log("OnClicked3 ���Ăяo����܂���");
        text3.SetActive(false);
        text4.SetActive(true);


        StartText starttext = FindObjectOfType<StartText>();

        if (starttext != null)
        {
            UnityEngine.Debug.Log("StartText ��������܂����B�G���h���[�����J�n���܂�");
            starttext.StartEndRoll();
        }
        else
        {
            UnityEngine.Debug.LogError("StartText �R���|�[�l���g��������܂���");
        }
    }

}
