using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public enum PacStudentDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public Tweener tweener;

    private float tweenDuration = 0.5f;
    private PacStudentDirection pacStudentDirection = PacStudentDirection.Right;
    private string lastInput = "D";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastInput = "W";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastInput = "A";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lastInput = "S";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastInput = "D";
        }

        switch (lastInput)
        {
            case "W":
                pacStudentDirection = PacStudentDirection.Up;
                break;
            case "A":
                pacStudentDirection = PacStudentDirection.Left;
                break;
            case "S":
                pacStudentDirection = PacStudentDirection.Down;
                break;
            case "D":
                pacStudentDirection = PacStudentDirection.Right;
                break;
        }
        if (!tweener.TweenExists(transform))
        {
            Vector3 target = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            if (pacStudentDirection == PacStudentDirection.Up)
            {
                target.y += 0.64f;
                tweener.AddTween(transform, transform.position, target, tweenDuration);
            }
            if (pacStudentDirection == PacStudentDirection.Down)
            {
                target.y -= 0.64f;
                tweener.AddTween(transform, transform.position, target, tweenDuration);
            }
            if (pacStudentDirection == PacStudentDirection.Left)
            {
                target.x -= 0.64f;
                tweener.AddTween(transform, transform.position, target, tweenDuration);
            }
            if (pacStudentDirection == PacStudentDirection.Right)
            {
                target.x += 0.64f;
                tweener.AddTween(transform, transform.position, target, tweenDuration);
            }
        }
    }
}
