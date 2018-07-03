using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    void Start () 
    {
        offset = transform.position - player.transform.position;
    }
    
    // 各フレームで、Update の後に LateUpdate が呼び出されます。
    void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
    }
}