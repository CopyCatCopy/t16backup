 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Animator JunoAni;
    public object Player;
    public GameObject juno;
    public GameObject JunoSprite;
    public float PlayerSpeed;
    public Rigidbody rb;
    public bool isMoving = false;
    public bool CameraRotationOn = false;
    public float horizontalSpeed = 1.0f;
    float v;
    public string colTag;
    public string keyPress;
    public float pushback = 10.0f;
    public float timer = 0.5f;
    public bool moving = false;
    public float Xposition, Yposition, Zposition;
    public int SceneChanged;
    public int ResetDataBool = 0;
    public int MiniGameChange = 0;

    public GameObject North;
    public GameObject South;
    public GameObject West;
    public GameObject East;

    
    

    public bool moveOK = true;

    Quaternion targetRotation;

    private Vector2 moveInput;


    // Start is called before the first frame update
    void Start()
    {
        //Camera Fixed Position
        Cursor.lockState = CursorLockMode.Locked;
        ResetDataBool = PlayerPrefs.GetInt("ResetDataBool");

        Debug.Log(SceneChanged);
        SceneChanged = PlayerPrefs.GetInt("SceneChanged");
        Debug.Log(SceneChanged);
        if (ResetDataBool == 1 && SceneChanged == 0)
        {
            ResetData();
        }
        else if (SceneChanged == 1 && ResetDataBool == 0)
        {
            LoadPos();
        }
        
    }

    void Update()
    {
                
        //Movement Script

        if (Input.GetKey(KeyCode.S))
        {
            keyPress = "S";
        }
        else if (Input.GetKey(KeyCode.W)) {
            keyPress = "W";
        } else if (Input.GetKey(KeyCode.A))
        {
            keyPress = "A";
        }
        else if (Input.GetKey(KeyCode.D)) {
            keyPress = "D";
        } else
        {
            keyPress = "";
        }

        if (moveOK == true)
        {
            MovePlayer();
            KickBack();
        }

        //Camera Stuff

        if (CameraRotationOn == false)
        {
            
        }
        if (CameraRotationOn == true)
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(v, h, 0);
        }

    }


    public void RotationOn()
    {
        if (CameraRotationOn == true)
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(v, h, 0);
            
        }
        if (CameraRotationOn == false)
        {
            
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            colTag = "Wall";
        } else
        {
            colTag = "";
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            colTag = "";
        }
    }

    public void KickBack()
    {

        if (keyPress == "W" && colTag == "Wall" || North.GetComponentInChildren<CollisionDirection>().CTag == "Wall" && colTag == "Wall" ) 
        {
            transform.position -= transform.forward * Time.deltaTime * PlayerSpeed * pushback;
            moveOK = false;
            Invoke("SetMoveOKTrue", timer);
            moving = false;
            JunoAni.SetBool("Moving", false);
        }

        if (keyPress == "S" && colTag == "Wall" || South.GetComponentInChildren<CollisionDirection>().CTag == "Wall" && colTag == "Wall")
        {
            transform.position += transform.forward * Time.deltaTime * PlayerSpeed * pushback;
            moveOK = false;
            Invoke("SetMoveOKTrue", timer);
            moving = false;
            JunoAni.SetBool("Moving", false);
        }

        if (keyPress == "D" && colTag == "Wall" || East.GetComponentInChildren<CollisionDirection>().CTag == "Wall" && colTag == "Wall")
        {
            transform.position -= transform.right * Time.deltaTime * PlayerSpeed * pushback;
            moveOK = false;
            Invoke("SetMoveOKTrue", timer);
            moving = false;
            JunoAni.SetBool("Moving", false);
        }

        if (keyPress == "A" && colTag == "Wall" || West.GetComponentInChildren<CollisionDirection>().CTag == "Wall" && colTag == "Wall")
        {
            transform.position += transform.right * Time.deltaTime * PlayerSpeed * pushback;
            moveOK = false;
            Invoke("SetMoveOKTrue", timer);
            moving = false;
            JunoAni.SetBool("Moving", false);
        }
    }

    public void MovePlayer()
    {

        if (keyPress == "W" && colTag == "")
        {
            transform.position += transform.forward * Time.deltaTime * PlayerSpeed;
            if (moving == false)
            {
                moving = true;
            }
            JunoAni.SetBool("Backward", true);
            JunoAni.SetBool("Moving", true);
            if (moving == true)
            {
                JunoAni.SetBool("Forward", false);
                JunoAni.SetBool("Right", false);
                JunoAni.SetBool("Left", false);
            }
            
        }
        

        if (keyPress == "S" && colTag == "")
        {
            transform.position -= transform.forward * Time.deltaTime * PlayerSpeed;
            if (moving == false)
            {
                moving = true;
            }
            JunoAni.SetBool("Forward", true);
            JunoAni.SetBool("Moving", true);
            if (moving == true)
            {
                JunoAni.SetBool("Backward", false);
                JunoAni.SetBool("Right", false);
                JunoAni.SetBool("Left", false);
            }
        }
        

        if (keyPress == "D" && colTag == "")
        {
            transform.position += transform.right * Time.deltaTime * PlayerSpeed;
            if (moving == false)
            {
                moving = true;
            }
            JunoAni.SetBool("Right", true);
            JunoAni.SetBool("Moving", true);
            if (moving == true)
            {
                JunoAni.SetBool("Forward", false);
                JunoAni.SetBool("Backward", false);
                JunoAni.SetBool("Left", false);
            }
        }
        

        if (keyPress == "A" && colTag == "")
        {
            transform.position -= transform.right * Time.deltaTime * PlayerSpeed;
            if(moving == false)
            {
                moving = true;
            }
            JunoAni.SetBool("Left", true);
            JunoAni.SetBool("Moving", true);
            if (moving == true)
            {
                JunoAni.SetBool("Forward", false);
                JunoAni.SetBool("Right", false);
                JunoAni.SetBool("Backward", false);
            }
        }

        if (keyPress == "" && colTag == "")
        {
            moving = false;
            JunoAni.SetBool("Moving", false);
        }
        

    }

    public void SetMoveOKTrue()
    {
        moveOK = true;
    }
    

                //DATA STORING


    //When Scene is closed, Data Saves Position of Player
    private void OnDestroy()
    {
        MiniGameChange = PlayerPrefs.GetInt("MiniGameChange");
        if (MiniGameChange == 1)
        {
            SavePos();
            PlayerPrefs.SetInt("MiniGameChange", 0);
        }
    }

    //Player Position Saved and SceneChanged is recognized
    public void SavePos()
    {

        Debug.Log("Player Saved");
        Xposition = juno.transform.position.x;
        Yposition = juno.transform.position.y;
        Zposition = juno.transform.position.z;
        PlayerPrefs.SetInt("SceneChanged", 1);
        Debug.Log(PlayerPrefs.GetInt("SceneChanged"));


        PlayerPrefs.SetFloat("X", Xposition);
        PlayerPrefs.SetFloat("Y", Yposition);
        PlayerPrefs.SetFloat("Z", Zposition);

        Debug.Log(PlayerPrefs.GetInt("X"));
        Debug.Log(PlayerPrefs.GetInt("Y"));
        Debug.Log(PlayerPrefs.GetInt("Z"));
    }


    //After Scene is Openned again, Player Position is Loaded And then Resets Function so it can work again
    public void LoadPos()
    {
        Debug.Log("Player Loaded");
        
        Xposition = PlayerPrefs.GetFloat("X");
        Debug.Log(Xposition);
        Yposition = PlayerPrefs.GetFloat("Y");
        Debug.Log(Yposition);
        Zposition = PlayerPrefs.GetFloat("Z");
        Debug.Log(Zposition);


        Vector3 LoadPosition = new Vector3(Xposition, Yposition, Zposition);
        transform.position = LoadPosition;
        
    }


    //When Day is Over or Game is Closed, Reset Data to Original State.
    public void ResetData()
    {

        PlayerPrefs.SetFloat("X", 0);
        PlayerPrefs.SetFloat("Y", 0);
        PlayerPrefs.SetFloat("Z", 0);
        PlayerPrefs.SetInt("ResetDataBool", 0);
        PlayerPrefs.SetInt("SceneChanged", 0);

    }
}
