using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    [SerializeField] private Transform _target;
    [SerializeField] private ConfigurableJoint _joint;
    [SerializeField] private Transform _pelvisTransform;

    void FixedUpdate() {

        Vector3 toTaget = _target.position - _pelvisTransform.position;
        Vector3 toTagetXZ = new Vector3(toTaget.x, 0f, toTaget.z);
        Quaternion rotation = Quaternion.LookRotation(toTagetXZ);

        _joint.targetRotation = Quaternion.Inverse(rotation);


    }
}
