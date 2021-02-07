using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TowerUp.TowerUpgrade;

public class SlotScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PosToGo;
    public SlotManager SlotManager;
    public float speed;
    public int index;
    public int life;
    public PowerUp Power;
    void Start()
    {
        ApplyUp(SlotManager.TowerRef, Power);
    }

    // Update is called once per frame
    void Update()
    {
        PosToGo = SlotManager.ListSlotTrans[index].transform;
        transform.position = Vector2.Lerp(transform.position, SlotManager.ListSlotTrans[index].transform.position, speed*Time.deltaTime);

        if(life<=0)
        {
            Debug.Log("bava");
            DeApplyUp(SlotManager.TowerRef, Power);
            SlotManager.Replace(index);
            SlotManager.DeleteSlot(this.gameObject);
        }
    }
}
