using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class AmmoUI : MonoBehaviour
{
    public static AmmoUI Instance;
    public TextMeshProUGUI ammoText;

    public GameObject pistol;
    // Start is called before the first frame update
    void Awake()
    {
        pistol = GameObject.FindWithTag("Weapon");
    }

    void Update()
    {
        int clip = Variables.Object(pistol).Get<int>("Clip Ammo");
        int reserve = Variables.Object(pistol).Get<int>("Reserved Ammo");

        ammoText.text = clip + " / " + reserve;
    }
}
