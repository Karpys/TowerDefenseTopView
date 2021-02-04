using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static bool CardInHand;
    public static GameObject CardHand;
    public static GameObject TowerOnMouse;
    public bool Cardh;
    public GameObject Car;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Car = CardHand;
        Cardh = CardInHand;
    }
}
