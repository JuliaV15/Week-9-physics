using UnityEngine;

public class CannonballController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Target")) // you can tag gameobjects in editor, and this line of code is checking if the object hit has the tag "Target"
        {
            ScoreboardController.Instance.Score += 1;
        }

        Destroy(gameObject);
    }
}
