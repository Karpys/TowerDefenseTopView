using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerUp
{

public class TowerUpgrade
{
    public static void ApplyUp(Tower Tow,PowerUp type)
    {
            if(type == PowerUp.ATKSPEEDUP)
            {
                if (Tow.gameObject.GetComponent<Bonus>())
                {
                    if(Tow.gameObject.GetComponent<Bonus>().bonus==Bonus.BonusType.AtkSpeedx2)
                    {
                    Tow.CdShootSet -= 0.20f;
                    }
                }
                Tow.CdShootSet -= 0.20f;
            }
            else if(type == PowerUp.LIFEUP)
            {
                
            }else if(type == PowerUp.RANGEUP)
            {
                Tow.range += 1;
            }
    }

    public static void DeApplyUp(Tower Tow,PowerUp type)
    {
            if (type == PowerUp.ATKSPEEDUP)
            {
                Tow.CdShootSet += 0.20f;
            }
            else if (type == PowerUp.LIFEUP)
            {

            }
            else if (type == PowerUp.RANGEUP)
            {
                Tow.range -= 1;
            }
        }
}
}


public enum PowerUp
{
    ATKSPEEDUP,
    LIFEUP,
    RANGEUP
}
