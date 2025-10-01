using UnityEngine;

public class MovementOptions : MonoBehaviour
{
    [SerializeField] GameManager.Location _location = GameManager.Location.StartArea;
    GameManager GM;

    [SerializeField] GameObject[] _visuals;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (_location == GM.CurrentLocation) VisualSwich(true);
        else VisualSwich(false);
    }

    public void Move(string locationName)
    {
        if (locationName == "StartArea") GM.CurrentLocation = GameManager.Location.StartArea;
        if (locationName == "Base") GM.CurrentLocation = GameManager.Location.Base;
    }

    void VisualSwich(bool active)
    {
        if (active)
        {
            foreach(GameObject G in _visuals)
            {
                G.SetActive(true);
            }
        }

        if (!active)
        {
            foreach(GameObject G in _visuals)
            {
                G.SetActive(false);
            }
        }
    }
}
