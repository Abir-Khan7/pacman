using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }
    private float elapsedTime;

    public Tween(Transform target, Vector3 startPos, Vector3 endPos, float startTime, float duration) {
        Target = target;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = startTime;
        Duration = duration;
        elapsedTime = 0f;
    }

    private void Update() {
        elapsedTime = Time.deltaTime - StartTime;
        float interpolationFactor = elapsedTime / Duration;
        Target.transform.position = Vector3.Lerp(StartPos, EndPos, interpolationFactor);
    }
}