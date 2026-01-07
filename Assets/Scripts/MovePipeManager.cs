using UnityEngine;

public class MovePipeManager : MonoBehaviour
{

    [SerializeField] private float _speedPipe = 0.5f;

    private void Update()
    {
        transform.position += Vector3.left * _speedPipe * Time.deltaTime;
    }

}
