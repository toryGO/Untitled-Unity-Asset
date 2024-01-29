using UnityEngine;
// ReSharper disable All

public class WallChecker : MonoBehaviour
{
    [SerializeField, ColorUsage(true)] private Color gizmosColor;
    [SerializeField, Min(0)] private float wallCheckDistance;
    [SerializeField] private LayerMask whatIsWall;

    public float WallCheckDistance
    {
        get => wallCheckDistance;
        private set => wallCheckDistance = value;
    }

    /// <returns> True if touching "whatIsWall" layer. </returns>
    ///
    /// <returns>False if not touching "whatIsWall" layer.</returns>
    public bool IsOnWall()
    {
        return Physics2D.Raycast(transform.position, transform.right, WallCheckDistance, whatIsWall);
    }
	
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmosColor;
		
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x + WallCheckDistance, transform.position.y, transform.position.z));
    }
}
