using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DpsCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public Ennemy Ennemy;
    public float DivideDps;
    public float lifestart;
    public float Dps;
    public TextMeshProUGUI Text;
    void Start()
    {
        lifestart = Ennemy.life;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifestart!=Ennemy.life)
        {
            DivideDps += Time.deltaTime;
            Dps = (lifestart - Ennemy.life) / DivideDps;
            Text.text = Dps.ToString();
        }
    }
}
