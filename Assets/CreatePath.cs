using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MathsUti.MathUtilities;

public class CreatePath : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> ListTransform;
    public CreateGridMap grid;
    public float speed;
    void Start()
    {
        transform.position = ListTransform[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(ListTransform.Count>0)
        {
        if(ListTransform[0].transform.position!=transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, ListTransform[0].transform.position,speed);
        }else
        {
            ListTransform.Remove(ListTransform[0]);
        }
        }
        GetClosest().GetComponent<SpriteRenderer>().color = GetClosest().GetComponent<GridScript>().PathColor;
        GetClosest().GetComponent<GridScript>().Occup = true;
    }

    public GameObject GetClosest()
    {
        float lastdist = 100;
        GameObject Closest = null;
        foreach (var i in grid.ListGrid)
        {
            float dist = GetDistance2D(this.gameObject, i);
            if (dist < lastdist)
            {
                lastdist = dist;
                Closest = i;
            }
        }
        return Closest;
    }
}
