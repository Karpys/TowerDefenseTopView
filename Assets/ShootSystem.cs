using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> EmmiterToAdd;
    public List<GameObject> Finish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(GameObject Bullet)
    {
        Bullet.GetComponent<Finisher>().Finish = new List<GameObject>(Finish);
    }
}
