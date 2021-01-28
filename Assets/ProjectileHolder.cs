using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public Projectile ProjStats;
    public float speed;
    public float dmg;
    public GameObject Follower;
    void Start()
    {
        speed = ProjStats.speed;
        dmg = ProjStats.dmg;
        GetComponent<SpriteRenderer>().sprite = ProjStats.Image;
    }

    // Update is called once per frame
    void Update()
    {
        if(Follower)
        {
            transform.position = Vector2.MoveTowards(transform.position, Follower.transform.position, speed * Time.deltaTime);
        }else
        {
            Destroy(gameObject);
        }
    }
}
