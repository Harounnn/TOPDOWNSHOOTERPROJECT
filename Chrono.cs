using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chrono : MonoBehaviour
{
    float timer;
    public Text scoretext;
    public Image healthbar;
    public Behaviour[] chronoo;
    public void Update()
    {
        timer += Time.deltaTime;
        scoretext.text = Mathf.Floor(timer).ToString();
        if (healthbar.fillAmount <= 0) 
        {
            healthbar.fillAmount=0;
            foreach(Behaviour behaviour in chronoo) 
            {
                behaviour.enabled = false;
            }
        }
    }
}