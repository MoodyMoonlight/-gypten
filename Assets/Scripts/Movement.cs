using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;

    public Animator animator;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);

        AnimateMovement(direction);

        transform.position += direction * speed * Time.deltaTime;
    }

    void AnimateMovement(Vector3 direction)
    {
        if(animator != null)
        {
            if(direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);

                animator.SetFloat("horizontal", direction.y);
                animator.SetFloat("horizontal", direction.x);
            }
            else
            {
                animator.SetBool("isMoving", false);

            }
        }
    }
    

}
