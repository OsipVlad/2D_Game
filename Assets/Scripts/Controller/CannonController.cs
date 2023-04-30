using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController
{
    private Transform _muzzleT;
    private Transform _targetT;

    private Vector3 _dir;
    private Vector3 _axis;
    private float _angle;

    public CannonController(Transform muzzle, Transform target)
    {
        _muzzleT = muzzle;
        _targetT = target;
        
    }
    // Update is called once per frame
    public void Update()
    {
        _dir = _targetT.position - _muzzleT.position;
        _angle = Vector3.Angle(Vector3.right, _dir);
        _axis = Vector3.Cross(Vector3.right, _dir);

        _muzzleT.rotation = Quaternion.AngleAxis(_angle, _axis);
    }
}
