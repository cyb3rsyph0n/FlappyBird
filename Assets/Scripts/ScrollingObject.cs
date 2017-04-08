using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    #region Fields

    private Rigidbody2D scrollingObject;

    #endregion

    #region Methods

    // Use this for initialization
    private void Start()
    {
        scrollingObject = GetComponent<Rigidbody2D>();
        scrollingObject.velocity = new Vector2(GameController.Instance.ScrollSpeed, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameController.Instance.IsGameOver) scrollingObject.velocity = Vector2.zero;
    }

    #endregion
}