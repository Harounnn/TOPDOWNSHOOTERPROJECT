using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightwhendeath : MonoBehaviour
{
    public Image healthbar;
    public Behaviour[] forlight;
    public new GameObject light;
    void Update()
    {
        if (healthbar.fillAmount <= 0) 
        {
            healthbar.fillAmount = 0;
            foreach(Behaviour behaviour in forlight) 
            {
                behaviour.enabled = false;
            }
            light.SetActive(true);
        }
    }
}