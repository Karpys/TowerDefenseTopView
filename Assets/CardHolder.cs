using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public CardStats stats;
    public Image Image;
    void Start()
    {
        Image.sprite = stats.Image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
