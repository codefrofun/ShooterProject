using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Actor
{
    public static Player instance;

    public void Awake() {
        instance = this;
    }

    public override Vector3 GetMovementDirection()
    {
        return new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    }
}
