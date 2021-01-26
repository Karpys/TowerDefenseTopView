using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MathsUti.MathUtilities;
public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
    public GameObject Circle;
    public float multi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Circle Range
        multi=2/Circle.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        Circle.transform.localScale = new Vector3(range*multi, range * multi, 1);
    }
}
