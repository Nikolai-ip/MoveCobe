using UnityEngine;

public class GetInputParametrs : MonoBehaviour, IGetSpeed, IGetTime
{
    private UITextBarController uiController;

    private void Start()
    {
        uiController = FindObjectOfType<UITextBarController>();
    }

    public float Speed
    {
        get
        {
            if (float.TryParse(uiController.Speed, out float speed))
            {
                return speed;
            }
            else if (float.TryParse(uiController.Distance, out float distance) && float.TryParse(uiController.Time, out float time))
            {
                return distance / time;
            }
            return 0f;
        }
    }

    public float Time
    {
        get
        {
            if (float.TryParse(uiController.Time, out float time))
            {
                return time;
            }
            else if (float.TryParse(uiController.Distance, out float distance) && float.TryParse(uiController.Speed, out float speed))
            {
                return distance / speed;
            }
            return 0f;
        }
    }
}