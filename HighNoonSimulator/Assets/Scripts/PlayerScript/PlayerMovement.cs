﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementspeed;

    [SerializeField] private AnimationCurve jumpFallOff;
    [SerializeField] private float jumpMulti;
    [SerializeField] private KeyCode jumpKey;
    private Animator Player;

    private bool isJumping;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        Player = GetComponent<Animator>();
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        _PlayerMovement();
        JumpInput();
    }

    private void _PlayerMovement()

    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementspeed;

        float vertInput = Input.GetAxis(verticalInputName) * movementspeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
        if (horizInput == 0 && vertInput == 0)
        {
            Player.SetBool("Running", false);
            Player.SetBool("Idle", true);
        }
        else
        {
            Player.SetBool("Running", true);
            Player.SetBool("Idle", false);
        }
    }

    private void JumpInput()
    {
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(JumpEvent());
        }
    }

    private IEnumerator JumpEvent()
    {
        float timeInAir = 0.0f;

            do
        {

            float jumpforce = jumpFallOff.Evaluate(timeInAir);
            charController.Move(Vector3.up * jumpforce * jumpMulti * Time.deltaTime);
            timeInAir += Time.deltaTime;

            yield return null;
        } while (!charController.isGrounded && charController.collisionFlags != CollisionFlags.Above);

        isJumping = false;
       
    }
}
