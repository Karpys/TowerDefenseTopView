using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> PathingEnnemy;
    public List<GameObject> ListEnnemy;
    public static MapManager map;
    void Start()
    {
        map = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
