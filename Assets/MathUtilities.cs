using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathsUti
{
    public class MathUtilities
    {
        public static float GetDistance2D(GameObject obj1, GameObject obj2)
        {
            float dist = Vector2.Distance(obj1.transform.position, obj2.transform.position);
            return dist;
        }

        public static float GetDistance2D(Vector3 obj1, GameObject obj2)
        {
            float dist = Vector2.Distance(obj1, obj2.transform.position);
            return dist;
        }
    }
}
