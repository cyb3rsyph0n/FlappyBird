using UnityEngine;

public class BirdController : MonoBehaviour
{
    #region Fields

    public float UpwardVelocity;

    private Animator animator;

    private Rigidbody2D bird;

    private bool isDead;

    #endregion

    #region Methods

    private void Flap()
    {
        bird.velocity = Vector2.zero;
        bird.AddForce(new Vector2(0, UpwardVelocity), ForceMode2D.Impulse);
        animator.SetTrigger("Flap");
    }

    private void OnCollisionEnter2D(Collision2D collision2d)
    {
        bird.velocity = Vector2.zero;
        isDead = true;
        animator.SetTrigger("Dead");

        GameController.Instance.GameOver();
    }

    // Use this for initialization
    private void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Flap();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isDead && Input.GetMouseButtonDown(0)) Flap();
    }

    #endregion
}