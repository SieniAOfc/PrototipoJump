using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class HudManager : MonoBehaviour
{

    [SerializeField] TMP_Text textLife;
    
    public void updateLifes(int value)
    {
        
        textLife.text = value.ToString();

    }
}
