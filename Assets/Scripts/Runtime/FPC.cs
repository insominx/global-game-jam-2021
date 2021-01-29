using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//https://www.youtube.com/watch?v=vbILVirFV3A
// Fird Person Controller
public class FPC : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] float speed = 10f;
    [SerializeField] float angularSpeed;

    CharacterController Controller;
    Vector2 Move;
    float MouseX;
    float MouseY;

    void Awake()
    {
        Controller = GetComponent<CharacterController>();

        Transform cameraXform = this.gameObject.transform.GetChild(0); // camera
        cameraXform.position += Vector3.forward * -5.0f;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Move = context.ReadValue<Vector2>();
        //Debug.Log(Move);
    }

    public void OnRotationX(InputAction.CallbackContext context)
    {
        MouseX = context.ReadValue<float>();
    }

    public void OnRotationY(InputAction.CallbackContext context)
    {
        MouseY = context.ReadValue<float>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        Vector3 newMove = new Vector3(Move.x * speed * deltaTime, 0f, Move.y * speed * deltaTime);
        Controller.Move(newMove);
        //cam.transform.Rotate(MouseX, MouseY, 0); // this doesnt work
    }
}
