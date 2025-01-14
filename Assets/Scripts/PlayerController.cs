using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    [SerializeField] private float moveSpeed;
    private GameEndController gameEndController;
    private Animator animator;
    private bool canMove;

    private Rigidbody2D rb;

    void Awake() {
        canMove = true;
    }

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        gameEndController = FindFirstObjectByType<GameEndController>();
        animator = GetComponent<Animator>();
    }

    void Update(){
        HandleMovement();
    }

    private void HandleMovement(){
        if(!canMove)
            return;

        Vector2 moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rb.velocity = moveDirection * moveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Portal")){
            gameEndController.ChangeScene();
        }
    }
}