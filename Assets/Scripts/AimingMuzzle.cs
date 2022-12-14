using UnityEngine;

public class AimingMuzzle : MonoBehaviour
{
    [SerializeField] Transform _muzzleTransform;
    [SerializeField] Transform _aimTransform;

    public AimingMuzzle(Transform muzzleTransform, Transform aimTransform)
    {
        _muzzleTransform = muzzleTransform;
        _aimTransform = aimTransform;
    }

    private void Update()
    {
        var dir = _aimTransform.position - _muzzleTransform.position;
        var angle = Vector3.Angle(Vector3.right, dir);
        var axis = Vector3.Cross(Vector3.right, dir);
        _muzzleTransform.rotation = Quaternion.AngleAxis(angle, axis);
    }

}
