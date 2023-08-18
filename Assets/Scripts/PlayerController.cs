using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This Class controls the player object itself and its color. UPDATE THIS FURTHER
 */

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body; //MIGHT NOT NEED THIS ANYMORE

    public GameController GameController;

    //GameObject for the Player game object. This is so I can manipulate the position in Fixed Update Below
    public GameObject Player;

    //public bool GameOver = false;//var for checking if the game is over
    // Start is called before the first frame update
    void Start()
    {
        //Initialize Player Game object
        Player = GameObject.Find("Player");
        body = GetComponent<Rigidbody2D>(); //MIGHT NOT NEED THIS ANYMORE
    }

    // Update is called once per frame. Handles the controls for the player. 
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))//on w
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + .1f, Player.transform.position.z);
        }
        if (Input.GetKey(KeyCode.S)) //on s
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - .1f, Player.transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetMouseButton(0)) //on shift Changes color
        {
           
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(1))//on space changes color 
        {
            
        }


    }

    //Handles what happens when the player collides with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerSettings.Instance.GameOver = true;
        body.isKinematic = true;
        SceneManager.LoadScene(4);
    }
}
