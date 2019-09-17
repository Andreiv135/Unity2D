using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBot : Monster {

    [SerializeField]
    private float m_MaxSpeed = 10f;

    private bool m_FacingRight = true;

    private Rigidbody2D m_Rigidbody2D;
    private Animator m_Anim;
    float Target = 0.2f;
    int Lives = 2;

    private Transform Check;
    const float CheckRadius = 0.02f;
    [SerializeField]
    private LayerMask m_WhatIsGround;

    Collider2D[] colliders;
    // Use this for initialization
    protected override void Awake() {
        m_Anim = GetComponent<Animator>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        Check = transform.Find("Check");
        // Check = transform.Find("Check");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {


        colliders = Physics2D.OverlapCircleAll(Check.position, CheckRadius);
        if (colliders.Length > 0)
        {
            Flip();
            Target = -Target;
        }
        m_Rigidbody2D.velocity = new Vector2(m_MaxSpeed * Target, m_Rigidbody2D.velocity.y);
    }

   /*protected override void OnTriggerEnter2D(Collider2D Dead)
    {
       Unit unit = Dead.GetComponent<Unit>();
        if (unit && unit is PlatformerCharacter2D)
        {
            if (Mathf.Abs(unit.transform.position.x - transform.position.x) < 0.3F) ReceiveDemage();
            else unit.ReceiveDemage();
        }
    }*/
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
   
}
