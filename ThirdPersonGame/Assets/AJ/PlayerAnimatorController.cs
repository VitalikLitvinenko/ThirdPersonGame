using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        bool isRunning = horizontal != 0 || vertical != 0;
        _animator.SetBool("IsRunning", isRunning);
    }

    public void TriggerJump()
    {
        _animator.SetTrigger("Jump");
    }
}