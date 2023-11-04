using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Grab;
using Oculus.Interaction.GrabAPI;
using Oculus.Interaction.Input;
using Oculus.Interaction.Throw;
using UnityEngine;

public class RigidAssign : MonoBehaviour
{
    public GameObject obj;
    public Vector3 pos;
    public Quaternion angle;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        angle = transform.rotation;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Longboard") 
        Debug.Log("collisison detected");
        return;
    }
    void FixedUpdate()
    {



        HandGrabAPI.print("Object grabbed");
    }
}
