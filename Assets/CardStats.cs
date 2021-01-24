﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Object", menuName = "CardStats")]

public class CardStats : ScriptableObject
{
    // Start is called before the first frame update
    public Sprite Image;
    public new string name;
    public string description;
    public int cost;
}