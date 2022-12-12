using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [Header("Player Stats")]
    public float moveSpeed;                   // Movement speed in units per second
    public float jumpForce;                   // Force applied upwards

    public int curHp;
    public int maxHp;

    [Header("Camera Info")]
    public float lookSensitivity;             // Mouse look sensitivity
    public float maxLookX;                    // Lowest we can look down
    public float minLookX;                    // Highest we can look up
    private float rotX;                       // Current x rotation of the camera

    private Camera camera;
    private Rigidbody rb;
    //private Weapon weapon;

    void Awake()
    {
        //weapon = GetComponent<Weapon>();
        curHp = maxHp;
    }
    // Start is called before the first frame update
    void Start()
    {
       //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        
        /* Initiate the UI
        GameUI.instance.UpdateHealthBar(curHp, maxHp);
        GameUI.instance.UpdateScoreText(0);
        GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo); */
    }
    // Applies Damage to player
    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
            Die();
        
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
    }
    // If players health is reduced to zero or below then run Die()
    void Die()
    {
        //GameManager.instance.LoseGame();
        Debug.Log("Player has died! Game Over !");
        Time.timeScale = 0;
    }
     public void GiveHealth(int amountToGive)
    {
        //curHp = Mathf.Clamp(curHp + amountToGive, 0, maxHp);
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
        Debug.Log("Player has been healed!");
    }

    public void GiveAmmo(int amountToGive)
    {
        //weapon.curAmmo = Mathf.Clamp(weapon.curAmmo + amountToGive, 0, weapon.maxAmmo);
        //GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo);
        Debug.Log("Player has collected ammo!");
    }

    public void GivepowerUp(int amountToGive)
    {
        Debug.Log("Player has collected powerUp!");
    }
    
    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;      // Getting input for left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed;       // Getting input for forward and back movement
        
        // Walk in the direction we are looking/facing
        Vector3 dir = transform.right * x + transform.forward * z;
        
        dir.y = rb.velocity.y;
        rb.velocity = dir;                                   // Drives player movement relative to the camera look direction
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X")* lookSensitivity; //Look Up and Down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // Look Left and Right
        
        
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            // Add force to jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    
    }

   
// Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();

        /* Fire button
        if(Input.GetButton("Fire1"))
        {
            if(weapon.CanShoot())
              weapon.Shoot();
        }*/
        
        
        
        // Jump Button
       if(Input.GetButtonDown("Jump"))
         PlayerJump();

       /* Don't do anything is the game pause
       if(GameManager.instance.gamePaused == true)
           return;  */
    }
}
