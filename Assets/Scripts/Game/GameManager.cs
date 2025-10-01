using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum Location {StartArea, Base};
    public Location CurrentLocation = Location.StartArea;
}
