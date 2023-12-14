using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private Animator myAnim;
    public float move_sp = 0.1f;
    Vector2 movement = new Vector2();

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement == new Vector2(0, 1))
        {
            transform.Translate(0, move_sp, 0);
            myAnim.SetFloat("MoveY", move_sp);
            myAnim.SetFloat("MoveX", 0);
        }
        if (movement == new Vector2(0, -1))
        {
            transform.Translate(0, -move_sp, 0);
            myAnim.SetFloat("MoveY", -move_sp);
            myAnim.SetFloat("MoveX", 0);
        }
        if (movement == new Vector2(1, 0))
        {
            transform.Translate(move_sp, 0, 0);
            myAnim.SetFloat("MoveX", move_sp);
            myAnim.SetFloat("MoveY", 0);
        }
        if (movement == new Vector2(-1, 0))
        {
            transform.Translate(-move_sp, 0, 0);
            myAnim.SetFloat("MoveX", -move_sp);
            myAnim.SetFloat("MoveY", 0);
        }

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }

        playerRb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * move_sp * Time.deltaTime;
    }
}
