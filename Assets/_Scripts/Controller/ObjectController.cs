using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public Collider _objCollider;

    private OVRGrabbable _grabbable;

    private void Awake()
    {
        _grabbable = this.GetComponent<OVRGrabbable>();
    }

    private void Update()
    {
        if (_grabbable != null)
        {
            _objCollider.isTrigger = _grabbable.isGrabbed;
        }
    }

}
