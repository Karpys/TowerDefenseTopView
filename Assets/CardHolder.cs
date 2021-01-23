﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class CardHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public CardStats stats;
    public Image Image;
    public TextMeshProUGUI Nom;
    public TextMeshProUGUI Description;
   
    void Start()
    {
        Image.sprite = stats.Image;
        Nom.text = stats.name;
        Description.text = stats.description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
