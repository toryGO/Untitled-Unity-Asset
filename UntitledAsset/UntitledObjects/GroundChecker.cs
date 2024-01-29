using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable All

public class GroundChecker : MonoBehaviour
{
	[SerializeField, ColorUsage(true)] private Color gizmosColor;
	[SerializeField] private Vector2 groundCheckSize;
	[SerializeField] private LayerMask whatIsGround;

	public Vector2 GroundCheckSize
	{
		get => groundCheckSize;
		private set => groundCheckSize = value;
	}
	
	/// <returns> True if touching "whatIsGround" layer. </returns>
	///
	/// <returns>False if not touching "whatIsGround" layer.</returns>
	public bool IsGrounded()
	{
		return Physics2D.OverlapBox(transform.position, GroundCheckSize, 0, whatIsGround);
	}
	
	private void OnDrawGizmos()
	{
		Gizmos.color = gizmosColor;
		
		Gizmos.DrawWireCube(transform.position, GroundCheckSize);
	}
}
