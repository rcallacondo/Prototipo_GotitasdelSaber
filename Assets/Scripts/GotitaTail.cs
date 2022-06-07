using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotitaTail : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform GotitaTailGfx;
    public float circleDiameter;

    private List<Transform> gotitaTail = new List<Transform>();
    private List<Vector2> positions = new List<Vector2>();

    private void Start()
    {
        positions.Add(GotitaTailGfx.position);
    }

    private void Update()
    {
        float distance = ((Vector2)GotitaTailGfx.position - positions[0]).magnitude;
        if(distance > circleDiameter)
        {
            Vector2 direction = ((Vector2)GotitaTailGfx.position - positions[0]).normalized;

            positions.Insert(0, positions[0] + direction * circleDiameter);
            positions.RemoveAt(positions.Count - 1);

            distance -= circleDiameter;
        }

        for (int i=0; i < gotitaTail.Count; i++)
        {
            gotitaTail[i].position = Vector2.Lerp(positions[i + 1], positions[i], distance / circleDiameter);
        }
    }

    public void AddTail()
    {
        Transform tail = Instantiate(GotitaTailGfx, positions[positions.Count - 1], Quaternion.identity, transform);
        gotitaTail.Add(tail);
        positions.Add(tail.position);
    }
}
