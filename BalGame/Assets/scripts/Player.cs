using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sceneManager;
    public float playerSpeed =500;
    public float directionalSpeed = 20;
    public GameObject player;
    public AudioClip scoreUp;
    public AudioClip damage;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITER || UNITY_STANDALONE || UNITY_WEBPLAYER
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Debug.Log(moveHorizontal);
        transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(Mathf.Clamp(gameObject.transform.position.x + moveHorizontal, -2.5f, 2.5f), gameObject.transform.position.y, gameObject.transform.position.z), directionalSpeed * Time.deltaTime);
#endif        
        GetComponent<Rigidbody>().velocity = Vector3.forward * playerSpeed * Time.deltaTime;
        //MOBIELTJE CONTROLLE
        Vector2 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));
        if (Input.touchCount > 0)
        {
            Debug.Log("input door telefoon");
            transform.position = new Vector3(touch.x, transform.position.y, transform.position.z);
        }
        if(player.gameObject.transform.position.y >= 0.05)
        {
            GetComponent<Rigidbody>().velocity = Vector3.down * directionalSpeed * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "scoreup")
        {
            GetComponent<AudioSource>().PlayOneShot(scoreUp, 1.0f);
            Debug.Log("score geluid werkt");
        }

        if (other.gameObject.tag == "driehoek")
        {
            GetComponent<AudioSource>().PlayOneShot(damage, 1.0f);
            Debug.Log("score geluid werkt");
            sceneManager.GetComponent<App_Start>().GameOver();
        }
    }
}




