using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MathsUti.MathUtilities;
public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
    public float multi;

    public GameObject Circle;
    public GameObject Closest;
    public GameObject ProjBase;
    public Projectile Proj;
   
    public MapManager Map;
   
    public Color DebugCol;

    public float CdShoot;
    private float CdShootSet;
    void Start()
    {
        CdShootSet = CdShoot;
    }

    // Update is called once per frame
    void Update()
    {
        //Circle Range
        multi=2/Circle.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        Circle.transform.localScale = new Vector3(range*multi, range * multi, 1);
        if(Map.ListEnnemy.Count!=0)
        {
        Closest=GetClose(Map.ListEnnemy,transform.position);
            if(range>GetDistance2D(transform.position, Closest))
            {
                Debug.DrawLine(transform.position, Closest.transform.position, DebugCol);
                //Shoot
                if(CdShoot<=0)
                {
                    CdShoot = CdShootSet;
                    GameObject Shot = Instantiate(ProjBase, transform.position, transform.rotation);
                    Shot.GetComponent<ProjectileHolder>().ProjStats = Proj;
                    Shot.GetComponent<ProjectileHolder>().Follower = Closest;
                    Debug.Log("Shoot");
                }
            }
        }
        if(CdShoot>0)
        {
        CdShoot -= Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            Circle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            Circle.SetActive(false);
        }
    }
}
