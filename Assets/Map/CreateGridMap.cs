using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGridMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Grid;
    public float GridWidth;
    public float GridHeigh;
    public float ScreensizeWidth;
    public float ScreenHeigh;
    public Transform StartTransform;
    void Start()
    {
        for(int i=0;i<ScreensizeWidth/GridWidth;i++)
        {
            for(int j=0; j<ScreenHeigh/GridHeigh;j++)
            {
            GameObject gri = Instantiate(Grid, new Vector3(StartTransform.position.x + i * GridWidth / 100, StartTransform.position.y-j*GridHeigh/100, StartTransform.transform.position.z), transform.rotation);
            gri.transform.parent = this.gameObject.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetClosest();
    }

    public void GetClosest()
    {

        /*float dist = Vector3.Distance(t.position, currentPos);*/
    }
}
