using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public static CharacterAnimationController Instance { get; private set; }

    private Animator animator;
    public static event EventHandler OnMousePress;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (GetComponent<BoxCollider2D>().bounds.Contains(new Vector3(mousePosition.x, mousePosition.y, transform.position.z)))
            {
                animator.SetTrigger("Clicked_trigger");
                OnMousePress?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
