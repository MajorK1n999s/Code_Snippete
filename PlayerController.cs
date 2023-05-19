using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 rotation;
    private Transform Player;
    private Rigidbody playerRb;
    [SerializeField] private float Xspeed;
    [SerializeField] private float Zspeed;
    [SerializeField] private float JumpForce;
    [SerializeField] private float rotationSpeed;
    private float zBound = 23.0f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Transform>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        InvisibleWall();
        PlayerMovement();
        horizontalRotationView();
    }
    private void FixedUpdate()
    {
        playerJump();
    }
    void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * Xspeed * verticalInput, ForceMode.Impulse);

        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * Zspeed * horizontalInput, ForceMode.Impulse);
    }

    void horizontalRotationView()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput);
        
    }

    void InvisibleWall()
    {
        if (transform.position.z < -23f)
        {
            pos = new Vector3(transform.position.x, 0.3f, -zBound);
            Player.transform.position = pos;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Powerup"))
        {
            Debug.Log("collide");
            Destroy(collision.gameObject);
            Xspeed = 5f;
        }
    }

    void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * JumpForce,ForceMode.Impulse);
            Debug.Log("space");
        }
    }
}
