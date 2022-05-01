using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponScript : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerController playerController;
    private Animator playerAnimator;
    private bool isPlayerStrapped = false;
    private GameObject spawnedWeapon;
    public Transform weaponSocket;
    public GameObject pistol;
    public readonly int isStrappedHash = Animator.StringToHash("IsStrapped");

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
        gameManager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEquipWeapon(InputValue value)
    {
        if(isPlayerStrapped)
        {
            playerController.isStrapped = false;
            Destroy(spawnedWeapon.gameObject);
            spawnedWeapon = null;
            isPlayerStrapped = false;
        }
        else
        {
            playerController.isStrapped = true;
            spawnedWeapon = Instantiate(pistol, weaponSocket.position, weaponSocket.transform.rotation);
            spawnedWeapon.transform.parent = weaponSocket.transform;
            isPlayerStrapped = true;
        }
        playerAnimator.SetBool(isStrappedHash, playerController.isStrapped);

    }
}
