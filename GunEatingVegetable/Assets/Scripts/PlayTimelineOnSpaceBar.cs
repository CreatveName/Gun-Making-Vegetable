using UnityEngine;
using UnityEngine.Playables;

public class PlayTimelineOnSpacebar : MonoBehaviour
{
    public PlayableDirector director;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (director != null)
            {
                director.Play();
            }
            else
            {
                Debug.LogError("PlayableDirector not assigned!");
            }
        }
    }
}
