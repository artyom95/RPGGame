using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private MovementController _target;
    
    [SerializeField] 
    private Vector3 _offset = new(0, 5, -7);

    private void LateUpdate()
    {
        var targetPosition = _target.transform.position;
        var cameraPosition = new Vector3(targetPosition.x + _offset.x, transform.position.y, targetPosition.z + _offset.z);

        transform.position = cameraPosition;
    }
}