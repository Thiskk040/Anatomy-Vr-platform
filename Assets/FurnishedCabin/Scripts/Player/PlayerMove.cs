using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName = "Horizontal";
    [SerializeField] private string verticalInputName = "Vertical";
    [SerializeField] public float jumpforce;
    bool isground;
    public Rigidbody rig;

    [SerializeField] private float movementSpeed = 2f;

    private CharacterController charController;


    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;     //CharacterController.SimpleMove() applies deltaTime
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        //simple move applies delta time automatically
        charController.SimpleMove(forwardMovement + rightMovement);

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(2);
        }

        else if (Input.GetKey(KeyCode.LeftShift)) // Press left shit to make a speed * 2
        {
            float fontinput = Input.GetAxis(verticalInputName) * movementSpeed * 2;     
            float backinput = Input.GetAxis(horizontalInputName) * movementSpeed * 2;

            Vector3 movementForward = transform.forward * fontinput;
            Vector3 movementright = transform.right * backinput;

            charController.SimpleMove(movementForward + movementright);
        }
       
        else if (Input.GetKeyDown(KeyCode.Space) && isground)
        {
            isground = false;
            rig.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }

    }
 

}
