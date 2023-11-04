using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snappo : MonoBehaviour
{
    public Vector3 pos;
    public Quaternion angle;
    // Start is called before the first frame update
    void Start()
    {
        pos= transform.position;
        angle= transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(!transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            transform.position= pos;
            transform.rotation= angle;
        }
    }
}
