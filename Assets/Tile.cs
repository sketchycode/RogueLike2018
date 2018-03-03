using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileTypes {
	Wall
}

[RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour {
	public TileTypes tileType;

	public SpriteRenderer spriteRenderer { get; private set; }

	private void Start() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
}
