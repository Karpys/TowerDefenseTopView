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
            if(ProjStats.TypeMouv==TypeMouvementProj.MOVETOWARDS)
            {

                transform.position = Vector2.MoveTowards(transform.position, Follower.transform.position, speed * Time.deltaTime);

            }
            else if(ProjStats.TypeMouv == TypeMouvementProj.LERP)
            {
                transform.position = Vector2.LerpUnclamped(transform.position, Follower.transform.position, speed * Time.deltaTime);
            }else if(ProjStats.TypeMouv == TypeMouvementProj.ACCELERATION)
            {
                transform.position = Vector2.MoveTowards(transform.position, Follower.transform.position, speed * Time.deltaTime);
                speed += ProjStats.Acc;
            }
        }else
        {
            Destroy(gameObject);
        }
    }

    public void FinisherActivate()
    {
        if(gameObject.GetComponent<Finisher>())
        {
            if(Follower)
            {
            gameObject.GetComponent<Finisher>().ApplyFinish(Follower,this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ennemy"))
        {
            collision.gameObject.GetComponent<Ennemy>().life -= dmg;
            FinisherActivate();
            Destroy(gameObject);
            
        }
    }
}
