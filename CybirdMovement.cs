using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use for the Bird Test

public class CybirdMovement : MonoBehaviour
{
    GameObject player;

    //HandleThrowing
    [Range(-1f, 1f)]
    public float horizontalSpeed;
    [Range(0, 5)]
    public float verticalSpeed;
    [Range(0, 2)]
    public float amplitude;
    public Collider EntranceArea;
    public GameObject waitPosition;
    public float speed = 3.0f;
    bool EntranceRange = false;

    private Vector3 originalPos;
    private Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        EntranceRange = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("DreamerNew_Desktop");
            if (player == null)
            {
                player = GameObject.Find("XR Rig v2");
                if (player == null)
                {
                    player = GameObject.Find("FirstPersonPlayer");
                }
            }

        }
        else
        {
            if (EntranceRange) //Location of WaitPosition
            {
                transform.position = Vector3.MoveTowards(this.transform.position, waitPosition.transform.position, Time.deltaTime * speed);
            }
            else //Location of Player
            {
                Vector3 placement = new Vector3(player.transform.position.x - 5 , player.transform.position.y + 1, player.transform.position.z + 5);
                this.transform.position = placement;
                tempPosition = placement;
                tempPosition.x += horizontalSpeed * Time.fixedDeltaTime;
                tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
                transform.position = tempPosition;

            }
        }
    }

    public void SetEntranceRangeToTrue()
    {
        EntranceRange = true;   
    }
    public void SetEntranceRangeToFalse()
    {
        EntranceRange = false;
    }


}
