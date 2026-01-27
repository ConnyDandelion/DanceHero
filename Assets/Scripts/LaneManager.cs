using UnityEngine;

public class LaneManager : MonoBehaviour
{
    [SerializeField]
    private Line[] lanes;

    public Line GetLane(int index)
    {
        return lanes[index];
    }
}
