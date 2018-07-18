using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    private Vector3 offset;
    private GameObject player;

    void Start () 
    {
        this.player = GameObject.Find("PlayerPrefab");
        transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y, -20.0f);
        offset = transform.position - this.player.transform.position;
    }
    
    // 各フレームで、Update の後に LateUpdate が呼び出されます。
    void LateUpdate () 
    {
        transform.position = this.player.transform.position + offset;
    }
}