using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum Location {StartArea, Base, ResearchPad, Field};
    public Location CurrentLocation = Location.StartArea;
}
