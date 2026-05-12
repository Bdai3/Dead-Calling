using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class RoundCountUI : MonoBehaviour
{
    public static RoundCountUI Instance;
    public TextMeshProUGUI roundText;

    // Update is called once per frame
    void Update()
    {
        int round = Variables.Scene(gameObject.scene).Get<int>("Round");
        roundText.text = round.ToString();
    }
}
