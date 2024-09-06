using UnityEngine;

public class PointController : MonoBehaviour
{
    public Transform pointA; // Reference to the starting point
    public Transform pointB; // Reference to the ending point
    public RectTransform safeZone; // Reference to the safe zone RectTransform
    public float moveSpeed = 100f; // Speed of the pointer movement

    private float direction = 1f; // 1 for moving towards B, -1 for moving towards A
    private RectTransform pointerTransform;
    private Vector3 targetPosition;
    public GameObject LoadOpenGame;
    public Animator animator;

    void Start()
    {
        pointerTransform = GetComponent<RectTransform>();
        targetPosition = pointB.position;
    }

    void Update()
    {
        // Move the pointer towards the target position
        pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Change direction if the pointer reaches one of the points
        if (Vector3.Distance(pointerTransform.position, pointA.position) < 0.1f)
        {
            targetPosition = pointB.position;
            direction = 1f;
        }
        else if (Vector3.Distance(pointerTransform.position, pointB.position) < 0.1f)
        {
            targetPosition = pointA.position;
            direction = -1f;
        }

        // Check for input
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            CheckSuccess();
        }
    }

    void CheckSuccess()
    {
        // Check if the pointer is within the safe zone
        if (RectTransformUtility.RectangleContainsScreenPoint(safeZone, pointerTransform.position, null))
        {
            RandomizeSafeZone.instance.OnPlayerHitsSafeZone();
            Debug.Log("Success!");
            ScoreMiniGameIII.score += 500;
            animator.SetTrigger("Hit");
            FindObjectOfType<AudioManager>().Play("HitSucess");
            FindObjectOfType<AudioManager>().Play("PunchSucess");
        }
        else
        {
            //LoadOpenGame.SetActive(true);
            Debug.Log("Fail!");
            ScoreMiniGameIII.score -= 1000;
            animator.SetTrigger("Miss");
            FindObjectOfType<AudioManager>().Play("HitFailure");
        }
    }
}