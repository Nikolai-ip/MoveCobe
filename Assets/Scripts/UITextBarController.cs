using TMPro;
using UnityEngine;

public class UITextBarController : MonoBehaviour
{
    [SerializeField] private TMP_InputField _timeTextBar;
    [SerializeField] private TMP_InputField _speedTextBar;
    [SerializeField] private TMP_InputField _distanceTextBar;
    [HideInInspector] public string Speed { get; private set; }
    [HideInInspector] public string Time { get; private set; }
    [HideInInspector] public string Distance { get; private set; }

    public void TakeSpeed()
    {
        Speed = _speedTextBar.text;
    }

    public void TakeTime()
    {
        Time = _timeTextBar.text;
    }

    public void TakeDistance()
    {
        Distance = _distanceTextBar.text;
    }
}