using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Dash : MonoBehaviour
{
    private Rigidbody2D rb;
 
    public DashState dashState;
    public float dashForce;
    public float dashTimer = 3f;
    public float dashStartTimer = 3f;
    public float maxDash = 2000f;
    public AudioSource AudioDash;
 
    public Vector2 savedVelocity;
    public enum DashState
    {
        Ready,
        Dashing,
        Cooldown
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.PlayerId == 1)
            {
                dashTimer = 1.5f;
            }
            else if (MainManager.Instance.PlayerId == 2)
            {
                dashTimer = 5f;
            }
            else if (MainManager.Instance.PlayerId == 3)
            {
                dashTimer = 0.75f;
            }
        }
        
        
        
       
    }
 
    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready:
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = rb.velocity;
                    rb.AddForce(new Vector2(rb.velocity.x * dashForce, rb.velocity.y));
                    dashState = DashState.Dashing;
                    
                    //Dash Audio
                    if(MainManager.Instance.SoundEffectsEnabled ==true)
                    {
                        AudioDash.Play();
                    }
                }
                break;
            case DashState.Dashing:
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    rb.velocity = savedVelocity;
                    dashState = DashState.Cooldown;

                }
                else
                {
                    dashState = DashState.Cooldown;
                }
                break;
            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 3;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}
