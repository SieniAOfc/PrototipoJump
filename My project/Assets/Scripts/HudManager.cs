using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class HudManager : MonoBehaviour
{

    [SerializeField] TMP_Text textLife;

    public void updateLifes(int value)
    {
        textLife.text = value.ToString();
    }
}
