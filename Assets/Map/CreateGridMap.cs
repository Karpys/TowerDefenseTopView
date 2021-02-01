using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MathsUti.MathUtilities;




public class CreateGridMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Grid;
    public List<GameObject> ListGrid;
    public float GridWidth;
    public float GridHeigh;
    public float ScreensizeWidth;
    public float ScreenHeigh;
    public Transform StartTransform;
    public static GameObject ClosestGrid;
    
    void Start()
    {
        for(int i=0;i<ScreensizeWidth/GridWidth;i++)
        {
            for(int j=0; j<ScreenHeigh/GridHeigh;j++)
            {
            GameObject gri = Instantiate(Grid, new Vector3(StartTransform.position.x + i * GridWidth / 100, StartTransform.position.y-j*GridHeigh/100, StartTransform.transform.position.z), transform.rotation);
            gri.transform.parent = this.gameObject.transform;
            ListGrid.Add(gri);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ClosestGrid=GetClosest();
    }

    public GameObject GetClosest()
    {
        float lastdist = 100;
        GameObject Closest=null;
        foreach (var i in ListGrid)
        {
            float dist = GetDistance2D(Mouse.MousePosition, i);
            if (dist<lastdist)
            {
                lastdist = dist;
                Closest = i;
            }
        }
        return Closest;
    }
}

