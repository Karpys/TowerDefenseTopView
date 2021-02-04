using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PosToGo;
    public SlotManager SlotManager;
    public float speed;
    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosToGo = SlotManager.ListSlotTrans[index].transform;
        transform.position = Vector2.Lerp(transform.position, SlotManager.ListSlotTrans[index].transform.position, speed);
    }
}
