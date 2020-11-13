using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement() 
    {
        Vector3 sidewaysMovement = transform.right * Input.GetAxis("Horizontal");

        GetComponent<CharacterController>().Move(sidewaysMovement * _moveSpeed * Time.deltaTime);
    }
}
