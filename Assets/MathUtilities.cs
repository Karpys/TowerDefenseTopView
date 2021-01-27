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

        public static float GetDistance2D(Vector3 obj1, Vector3 obj2)
        {
            float dist = Vector2.Distance(obj1, obj2);
            return dist;
        }

        public static GameObject GetClose(List<GameObject> List,Vector3 Pos)
        {

            float lastdist = 100;
            GameObject Closest = null;
            foreach (var i in List)
            {
                float dist = GetDistance2D(Pos, i);
                if (dist < lastdist)
                {
                    lastdist = dist;
                    Closest = i;
                }
            }
            return Closest;
        }
    }
}
