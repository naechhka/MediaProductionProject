using UnityEngine;
using UnityEngine.Formats.Alembic.Importer;

public class AlembicLooper : MonoBehaviour 
{
    public AlembicStreamPlayer streamPlayer;
    public float speed = 1.0f;
    private float startTime = 0.0f;
    private float endTime = 5.0f;


    void Start()
    {
          streamPlayer.CurrentTime = streamPlayer.StartTime;
    }

    void Update()
    {
        if (streamPlayer == null) return;

        endTime = streamPlayer.EndTime;
        startTime = streamPlayer.StartTime;


        float duration = streamPlayer.Duration;
        float halfDuration = duration / 2f;
        float centerTime = startTime + halfDuration;


        // Math explanation:
        // Sin oscillates between -1 and 1. 
        // We multiply by halfDuration to scale the movement.
        float smoothOffset = Mathf.Sin(UnityEngine.Time.time * speed) * halfDuration;

        // Apply the smooth motion centered between your start and end points
        streamPlayer.CurrentTime = centerTime + smoothOffset;
    }
}