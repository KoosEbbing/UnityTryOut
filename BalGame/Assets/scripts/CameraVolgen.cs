using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVolgen : MonoBehaviour
{
    public GameObject player;
    public float CameraAfstand = 3.70f;
    public float CameraHoogte = 1.2f;
    

    

    // Update is called once per frame na update
    void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, CameraHoogte, player.gameObject.transform.position.z - CameraAfstand), Time.deltaTime * 100);
    }
}
