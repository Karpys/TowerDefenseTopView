using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Object", menuName = "New Projectile")]

public class Projectile : ScriptableObject
{
    // Start is called before the first frame update
    public Sprite Image;
    public new string name;
    public float speed;
    public float dmg;
    public float Acc;
    public TypeMouvementProj TypeMouv;
}


public enum TypeMouvementProj
{
    LERP,
    ACCELERATION,
    MOVETOWARDS,
}
