using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WorldTileTypes {
	Wall
}

[RequireComponent(typeof(SpriteRenderer))]
public class WorldTile : MonoBehaviour {
	public WorldTileTypes tileType;

	public SpriteRenderer spriteRenderer { get; private set; }

	private void Start() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
}
