using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 MousePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
        MousePosition.z = 0;
    }
}
