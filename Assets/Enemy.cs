using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor
{


    public override Vector3 GetMovementDirection()
    {
        Vector3 directionToPlayer = ((Player.instance.transform.position - transform.position));
        directionToPlayer.y = 0.0f;
        return directionToPlayer.normalized;
    }
}
