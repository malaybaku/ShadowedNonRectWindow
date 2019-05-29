using UnityEngine;

public class RotateQube : MonoBehaviour
{
    private Quaternion _initRot = Quaternion.identity;

    private void Start()
    {
        _initRot = transform.rotation;
    }

    private void Update()
    {
        //Rotate by yaw angle
        transform.rotation = Quaternion.AngleAxis(Time.time * 90, Vector3.up) * _initRot;        
    }
}
