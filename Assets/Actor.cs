using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    CharacterController charControl;
    public float speed = 10.0f;
    public Transform visual;

    // Start is called before the first frame update
    void Start()
    {
        charControl = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Vector3 desiredMovement = GetMovementDirection();

        charControl.Move(desiredMovement.normalized * speed * Time.deltaTime);

        if (Mathf.Abs(desiredMovement.magnitude) > 0.1f)
        {
            visual.transform.forward = Vector3.Lerp(visual.transform.forward, desiredMovement, Time.deltaTime * 24.0f);
        }
    }

    public virtual Vector3 GetMovementDirection()
    {
        return Vector3.zero;
    }
}
