using UnityEngine;

public class PointController : MonoBehaviour
{
    public Transform pointA; 
    public Transform pointB; 
    public RectTransform safeZone; 
    public float moveSpeed = 25f; 

    private float direction = 1f;
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
        pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, targetPosition, moveSpeed * Time.deltaTime);

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

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            CheckSuccess();
        }
    }

    void CheckSuccess()
    {
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