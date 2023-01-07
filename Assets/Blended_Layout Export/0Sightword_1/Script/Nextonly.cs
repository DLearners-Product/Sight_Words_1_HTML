using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Nextonly : MonoBehaviour
{
    public GameObject[] GA_Questions;
    public AudioSource AS_Empty;
    public AudioClip[] AC_clips;
    public int I_count;
    public GameObject G_final;
    public Text TXT_Max, TXT_Current;

    // Start is called before the first frame update
    void Start()
    {
        G_final.SetActive(false);
        I_count = 0;
        TXT_Max.text = GA_Questions.Length.ToString();
        int i = I_count + 1;
        TXT_Current.text = i.ToString();
        showquestion();
    }
    public void BUT_Clicking()
    {
       // GA_Questions[I_count].GetComponent<TextMeshProUGUI>().enabled = false;
       // GA_Questions[I_count].transform.GetChild(0).gameObject.SetActive(true);
    }
    public void showquestion()
    {
        for(int i=0;i<GA_Questions.Length;i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_count].SetActive(true);
        //GA_Questions[I_count].transform.GetChild(0).gameObject.SetActive(false);
    }
    // Update is called once per frame
    public void BUT_Speaker()
    {
        AS_Empty.clip = AC_clips[I_count];
        AS_Empty.Play();
    }

    public void BUT_next()
    {
        I_count++;
        if(I_count<GA_Questions.Length)
        {
            showquestion();
            int i = I_count + 1;
            TXT_Current.text = i.ToString();
        }
        else
        {
            G_final.SetActive(true);
        }
    }
}
