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
    public float currentGas = 0;

    Vector2 moveDirectionLeft = Vector2.zero;
    Vector2 lookInput = Vector2.zero;
    public GameManager gameManager;
    public Transform respawnPoint;

    private Rigidbody rigidbody;
    //checkpoint stuff
    public int currentCheckpoint = 0;
    private bool reachedCheckpointOne, reachedCheckpointTwo, reachedCheckpointThree, reachedCheckpointFour, reachedCheckpointFive, reachedCheckpointSix = false;

    [SerializeField]
    private float motorPower;
    [SerializeField]
    private float breakPower;
    [SerializeField]
    private float maxSteeringAngle;

    public float speed;

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
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!gameManager.isDriving)
        {
            steerAngle = 0;
            inputFloat = 0;
            moveDirection = 0;
            rigidbody.velocity = Vector3.zero;

        }
        else
        {
            if(currentGas >0)
            {
                HandleMotor();
                HandleSteering();
                UpdateWheels();
                currentGas -= Time.deltaTime;
                speed = rigidbody.velocity.magnitude * 1;
            }
            else
            {
                rigidbody.velocity = Vector3.zero;
            }
            speed = rigidbody.velocity.sqrMagnitude;
        }
        if(currentGas>100)
        {
            currentGas = 100;
        }

        //if (rigidbody.velocity.x > 10)
        //{
        //    rigidbody.velocity = new Vector3(10, rigidbody.velocity.y, rigidbody.velocity.z);
        //}
        ////if (rigidbody.velocity.z > 10)
        ////{
        ////    rigidbody.velocity = new Vector3(10, rigidbody.velocity.y, rigidbody.velocity.z);
        ////}
        //if (rigidbody.velocity.magnitude > 10)
        //{
        // //   rigidbody.velocity.magnitude = new Vector3(10,0,0);
        //}
    }

    private void HandleMotor()
    {
        if (rigidbody.velocity.x < 10 && rigidbody.velocity.z <10)
        {
            frontLeftWheelCollider.motorTorque = inputFloat * motorPower;
            frontRightWheelCollider.motorTorque = inputFloat * motorPower;
        }

        breakPower = isBreaking ? breakPower : 0f;
        //ApplyBreaking();        
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
        //UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        //UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        //UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        //UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelcollider, Transform wheeltransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelcollider.GetWorldPose(out pos, out rot);
        wheeltransform.rotation = rot;
        wheeltransform.position = pos;
    }

    public void FillGasTank(float amount)
    {
        if(currentGas<100)
        {
            currentGas += amount;
        }
    }
    public void OnCarThrottle(InputValue value)
    {
        if (gameManager.isDriving)
        {
            inputFloat = value.Get<float>();
        }
    }
    public void OnCarTurn(InputValue value)
    {
        if (gameManager.isDriving)
        {
            moveDirection = value.Get<float>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckpointOne"))
        {
            if (!reachedCheckpointOne)
            {
                currentCheckpoint++;
                reachedCheckpointOne = true;
                gameManager.isRacing = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("CheckpointTwo"))
        {
            if (!reachedCheckpointTwo && reachedCheckpointOne)
            {
                currentCheckpoint++;
                reachedCheckpointTwo = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("CheckpointThree"))
        {
            if (!reachedCheckpointThree && reachedCheckpointTwo)
            {
                currentCheckpoint++;
                reachedCheckpointThree = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("CheckpointFour"))
        {
            if (!reachedCheckpointFour && reachedCheckpointThree)
            {
                currentCheckpoint++;
                reachedCheckpointFour = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("CheckpointFive"))
        {
            if (!reachedCheckpointFive&& reachedCheckpointFour)
            {
                currentCheckpoint++;
                reachedCheckpointFive = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("CheckpointSix"))
        {
            if (!reachedCheckpointSix && reachedCheckpointFive)
            {
                currentCheckpoint++;
                reachedCheckpointSix = true;
                gameManager.HitCheckpoint();
            }
        }
        if (other.CompareTag("Goal"))
        {
            if (!gameManager.wonRace && reachedCheckpointSix)
            {
                currentCheckpoint++;
                gameManager.WinRace();
            }
        }
    }
}
