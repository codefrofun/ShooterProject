using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask projectileHitsType;
    public float speed = 10.0f;
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        if (Physics.OverlapSphere(transform.position, 0.2f, projectileHitsType.value).Length > 0)
        {
            Destroy(gameObject);
        }
    }
}
