using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementComponent : MonoBehaviour
{
    public GameObject FloorOneSwitches;
    public GameObject FloorTwoSwitches;
    public GameObject FloorThreeSwitches;
    public GameObject FloorFourSwitches;
    public Transform SpawnPoint;
    public GameObject waveController;
    public GameManager gameManager;

    [SerializeField]
    float walkSpeed = 5;
    [SerializeField]
    float runSpeed = 10;
    [SerializeField]
    float jumpForce = 5;
    [SerializeField]
    float rollForce = 5;

    //components
    private PlayerController playerController;
    private AudioSource audioSource;
    Rigidbody rigidbody;
    Animator playerAnimator;
    public GameObject followTarget;

    //references
    Vector2 inputVector = Vector2.zero;
    Vector3 moveDirection = Vector3.zero;
    Vector2 lookInput = Vector2.zero;
    PlayerInputActions playerControls;

    public float aimSensitivity = 0.2f;
    private bool InSwitchZone;
    private bool InSwitchZoneTwo;
    private bool InSwitchZoneThree;
    private bool InSwitchZoneFour;
    private bool waterIsRising;


    //animator hashes
    public readonly int movementXHash = Animator.StringToHash("MovementX");
    public readonly int movementYHash = Animator.StringToHash("MovementY");
    public readonly int isJumpingHash = Animator.StringToHash("IsJumping");
    public readonly int isRunningHash = Animator.StringToHash("IsRunning");
    public readonly int isRollingHash = Animator.StringToHash("IsRolling");
    public readonly int isInteractingHash = Animator.StringToHash("IsInteracting");


    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        playerController = GetComponent<PlayerController>();
        if (!GameManager.instance.cursorActive)
        {
            AppEvents.InvokeMouseCursorEnable(false);
        }

        //UnityEngine.Cursor.visible = false;

        playerControls = new PlayerInputActions();
        transform.position = SpawnPoint.position;
        waveController = GameObject.FindGameObjectWithTag("Water");
        gameManager = FindObjectOfType<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //aiming/looking
        followTarget.transform.rotation *= Quaternion.AngleAxis(lookInput.x * aimSensitivity, Vector3.up);
        followTarget.transform.rotation *= Quaternion.AngleAxis(lookInput.y * aimSensitivity, Vector3.left);

        var angles = followTarget.transform.localEulerAngles;
        angles.z = 0;

        var angle = followTarget.transform.localEulerAngles.x;

        if (angle > 180 && angle < 300)
        {
            angles.x = 300;
        }
        else if (angle < 180 && angle > 70)
        {
            angles.x = 70;
        }

        followTarget.transform.localEulerAngles = angles;

        //rotate player rotation based on look
        transform.rotation = Quaternion.Euler(0, followTarget.transform.rotation.eulerAngles.y, 0);

        followTarget.transform.localEulerAngles = new Vector3(angles.x, 0, 0);

        //movement
        if (playerController.isJumping) return;
        if (!(inputVector.magnitude > 0)) moveDirection = Vector3.zero;

        moveDirection = transform.forward * inputVector.y + transform.right * inputVector.x;
        float currentSpeed = playerController.isRunning ? runSpeed : walkSpeed;

        Vector3 movementDirection = moveDirection * (currentSpeed * Time.deltaTime);

        transform.position += movementDirection;
    }

    public void LateUpdate()
    {
        //playerController.isRolling = false;
        //playerAnimator.SetBool(isRollingHash, playerController.isRolling);

        //playerController.isInteracting = false;
        //playerAnimator.SetBool(isInteractingHash, playerController.isInteracting);
    }
    public void OnMovement(InputValue value)
    {
        inputVector = value.Get<Vector2>();
        playerAnimator.SetFloat(movementXHash, inputVector.x);
        playerAnimator.SetFloat(movementYHash, inputVector.y);
    }

    public void SetInteractFalse()
    {
        playerController.isInteracting = false;
        playerAnimator.SetBool(isInteractingHash, playerController.isInteracting);
        print("Set interact false");
    }

    public void SetRollingFalse()
    {
        playerController.isRolling = false;
        playerAnimator.SetBool(isRollingHash, playerController.isRolling);
        print("Set rolling false");
    }
    public void OnRun(InputValue value)
    {
        playerController.isRunning = value.isPressed;
        playerAnimator.SetBool(isRunningHash, playerController.isRunning);
    }

    public void OnJump(InputValue value)
    {
        //if(playerController.isJumping)
        //{
        //    return;
        //}

        //playerController.isJumping = value.isPressed;
        //playerAnimator.SetBool(isJumpingHash, playerController.isJumping);
        //rigidbody.AddForce((transform.up + moveDirection) * jumpForce, ForceMode.Impulse);
    }

    public void OnRoll(InputValue value)
    {
        if (playerController.isRolling)
        {
            return;
        }

        playerController.isRolling = value.isPressed;
        playerAnimator.SetBool(isRollingHash, playerController.isRolling);
        rigidbody.AddForce((transform.forward + moveDirection) * rollForce, ForceMode.Impulse);
    }

    public void OnInteract(InputValue value)
    {
        if (playerController.isInteracting)
        {
            return;
        }

        playerController.isInteracting = value.isPressed;
        playerAnimator.SetBool(isInteractingHash, playerController.isInteracting);

        if(InSwitchZone)
        {
            FloorOneSwitches.SetActive(false);
            audioSource.Play();
        }
        else if (InSwitchZoneTwo)
        {
            FloorTwoSwitches.SetActive(false);
            audioSource.Play();
        }
        else if (InSwitchZoneThree)
        {
            FloorThreeSwitches.SetActive(false);
            audioSource.Play();
        }
        else if (InSwitchZoneFour)
        {
            FloorFourSwitches.SetActive(false);
            audioSource.Play();
        }
    }
    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
        // if we aim up,down, adjust anims to have mask that properly animates aim
    }

    public void OnPause(InputValue value)
    {
        if (gameManager.IsPaused)
        {
            return;
        }
        else
        {
            gameManager.PauseGame();
        }
    }
        private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Switch"))
        {
            InSwitchZone = true;
        }
        else if (other.gameObject.CompareTag("Switch2"))
        {
            InSwitchZoneTwo = true;
        }
        else if (other.gameObject.CompareTag("Switch3"))
        {
            InSwitchZoneThree = true;
        }
        else if (other.gameObject.CompareTag("Switch4"))
        {
            InSwitchZoneFour = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Switch"))
        {
            InSwitchZone = false;
        }
        else if (other.gameObject.CompareTag("Switch2"))
        {
            InSwitchZoneTwo = false;
        }
        else if (other.gameObject.CompareTag("Switch3"))
        {
            InSwitchZoneThree = false;
        }
        else if (other.gameObject.CompareTag("Switch4"))
        {
            InSwitchZoneFour = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !playerController.isJumping) return;
        
        playerController.isJumping = false;
        playerAnimator.SetBool(isJumpingHash, false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!waterIsRising)
        {
            if (other.CompareTag("WaterTrigger"))
            {
                waveController.GetComponent<WaterMovement>().StartRising();
                waterIsRising = true;
                gameManager.SetHintBar("Water Level Rising! Unlock Doors To Find A Way To The Roof!");
                gameManager.SetRunMusic();
            }
        }

        if(other.CompareTag("Goal"))
        {
            gameManager.GameOver("You Made It To The Helicopter, You Escaped!");
        }

        if (other.CompareTag("Water"))
        {
            gameManager.GameOver("You Weren't Fast Enough, Try Again!");
        }
        if (other.CompareTag("RoofTrigger"))
        {
            gameManager.SetHintBar("Make It To The Helicopter To Escape!");
        }

    }
}
