using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Load scene
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // variable that can be edited in the Inspector to easily modify the Player‘s speed
    public float speed = 300f;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    public GameObject winLose;
    public Image winLoseImg;
    public Text winLoseText;
    public Joystick joystick;
    Vector3 translateObj;
    Vector3 rotateObj;

    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0); //load the main menu
        }

        if (health == 0)
        {
            // Debug.Log("Game Over!");
            winLose.SetActive(true);
            winLoseText.text = "Game Over!";
            winLoseText.color = new Color(1, 1, 1, 1);
            winLoseImg.color = new Color(1, 0, 0, 1);
            //SceneManager.LoadScene("maze"); //load scene
            StartCoroutine(LoadScene(3)); //the scene waits 3 seconds to reload
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchSupported)
        {
            joystick.gameObject.SetActive(true); // Active the Touch option for device
            //horizontal
            translateObj.x = joystick.Horizontal;
            //vertical
            translateObj.z = joystick.Vertical;
            rotateObj.x = joystick.Vertical;// Vertical
            rotateObj.z = joystick.Horizontal;// Horizontal    
        }
        else
        {
            joystick.gameObject.SetActive(false);
            translateObj.x = Input.GetAxis("Horizontal");
            translateObj.z = Input.GetAxis("Vertical");
            rotateObj.x = Input.GetAxis("Vertical");
            rotateObj.z = Input.GetAxis("Horizontal");
        }
        // Add speed force
        rb.AddForce(translateObj * speed * Time.deltaTime) ; 
        // Apply rotate
        rb.transform.Rotate(rotateObj * speed * Time.deltaTime) ;
    }

void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            // Debug.Log($"Score: {score}");
            SetScoreText();
            other.gameObject.SetActive(false);
        }
        
        if (other.tag == "Trap")
        {
            health -= 1;
            // Debug.Log($"Health: {health}");
            SetHealthText();
        }

        if (other.tag == "Goal")
        {
            // Debug.Log("You Win!");
            winLose.SetActive(true);
            winLoseText.text = "You Win!";
            winLoseText.color = new Color(0, 0, 0, 1);
            winLoseImg.color = new Color(0, 1, 0);
            StartCoroutine(LoadScene(3)); // the scene waits 3 seconds to reload        
        }        
    }

void SetScoreText()
    {
        scoreText.text = $"Score: {score.ToString()}";
    }

void SetHealthText()
    {
        healthText.text = $"Health: {health.ToString()}";
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("maze");      
    }
}    
