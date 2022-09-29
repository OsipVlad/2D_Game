using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Vector3 _vectorA;
    [SerializeField] Vector3 _vectorB;

    private void Start()
    {
        var dot = Vector3.Dot(_vectorB, _vectorA);
        Debug.Log(dot);
        //var directionNormalize = (_vectorA - _vectorB).normalized;
        //Debug.Log(directionNormalize);

        //var distance2 = Vector3.Distance(_vectorA, _vectorB);
        //Debug.Log(distance2);
    }
}
