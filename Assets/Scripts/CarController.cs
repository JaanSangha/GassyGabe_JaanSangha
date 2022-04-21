using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    [SerializeField]
    private float steerAngle;
    private bool isBreaking;
    //references
    Vector2 inputVector = Vector2.zero;
    Vector2 moveDirectionRight = Vector2.zero;
    float inputFloat = 0;
    float moveDirection = 0;
    Vector2 moveDirectionLeft = Vector2.zero;
    Vector2 lookInput = Vector2.zero;
    public GameManager gameManager;

    [SerializeField]
    private float motorPower;
    [SerializeField]
    private float breakPower;
    [SerializeField]
    private float maxSteeringAngle;

    [SerializeField]
    private WheelCollider frontRightWheelCollider;
    [SerializeField]
    private WheelCollider frontLeftWheelCollider;
    [SerializeField]
    private WheelCollider backRightWheelCollider;
    [SerializeField]
    private WheelCollider backLeftWheelCollider;

    [SerializeField]
    private Transform frontRightWheelTransform;
    [SerializeField]
    private Transform frontLeftWheelTransform;
    [SerializeField]
    private Transform backRightWheelTransform;
    [SerializeField]
    private Transform backLeftWheelTransform;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (gameManager.isDriving)
        {
            Debug.Log(inputFloat);
            //Debug.Log(moveDirection.x);
            Debug.Log(steerAngle);

            GetInput();
            HandleMotor();
            HandleSteering();
            UpdateWheels();
        }
    }

    private void GetInput()
    {

    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = inputFloat * motorPower;
        frontRightWheelCollider.motorTorque = inputFloat * motorPower;
        breakPower = isBreaking ? breakPower : 0f;
        ApplyBreaking();
        
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = breakPower;
        frontLeftWheelCollider.brakeTorque = breakPower;
        backRightWheelCollider.brakeTorque = breakPower;
        backLeftWheelCollider.brakeTorque = breakPower;

    }

    private void HandleSteering()
    {
        steerAngle = maxSteeringAngle * moveDirection;
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelcollider, Transform wheeltransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelcollider.GetWorldPose(out pos, out rot);
        wheeltransform.rotation = rot;
        wheeltransform.position = pos;
    }
    //public void OnMovement(InputValue value)
    //{
    //    inputVector = value.Get<Vector2>();
    //    verticalInput = value.Get<Vector2>().x;
    //    // playerAnimator.SetFloat(movementXHash, inputVector.x);
    //    // playerAnimator.SetFloat(movementYHash, inputVector.y);
    //}

    //public void OnTurnRight(InputValue value)
    //{
    //    moveDirectionRight = value.Get<Vector2>();
    //}
    //public void OnTurnLeft(InputValue value)
    //{
    //    moveDirectionRight = -(value.Get<Vector2>());
    //}

    public void OnCarThrottle(InputValue value)
    {
        inputFloat = value.Get<float>();
        verticalInput = value.Get<float>();
    }
    public void OnCarTurn(InputValue value)
    {
        moveDirection = value.Get<float>();

    }
}
