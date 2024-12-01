using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animated : MonoBehaviour {


    Animator anim;
    Animator Anim
    {
        get
        {
            if(anim == null)
            {
                anim = GetComponent<Animator>();
            }
            return anim;
        }
    }



    [SerializeField] private PhysicMaterial _defaultFriction;
    [SerializeField] private PhysicMaterial _zeroFriction;

    [SerializeField] private Collider _leftCollider;
    [SerializeField] private Collider _rightCollider;

    public void SetLeftFriction() {
        _leftCollider.material = _defaultFriction;
        _rightCollider.material = _zeroFriction;
    }

    public void SetRightFriction() {
        _leftCollider.material = _zeroFriction;
        _rightCollider.material = _defaultFriction;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Anim.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Anim.enabled = false;
        }
    }
}
