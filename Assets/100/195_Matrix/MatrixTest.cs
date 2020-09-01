using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _195_MatrixTest
{
	public enum eMatrixType {  Local, World}
	public class MatrixTest : MonoBehaviour
	{


		[SerializeField] float rotationSpeed = 50.0f;
		[Range(0.01f, 0.2f), SerializeField] float gizmosSize = 0.01f;
		[SerializeField] eMatrixType type = eMatrixType.Local;


		void OnDrawGizmos()
		{
			Gizmos.color = Color.red;


			var _meshFilter = GetComponent<MeshFilter>();
			if (_meshFilter && _meshFilter.sharedMesh)
			{
				if(type == eMatrixType.Local)
				{
					//Gizmos.matrix = transform.localToWorldMatrix;
					Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.localScale);
					var _vertices = _meshFilter.sharedMesh.vertices;
					for (int i = 0; i < _vertices.Length; i++)
					{
						//자신의 공간으로 생각하고 연산하면 된다.
						Gizmos.color = Color.red;
						Gizmos.DrawSphere(_vertices[i], gizmosSize);
					}
				}
				else if (type == eMatrixType.World)
				{
					Gizmos.matrix = Matrix4x4.TRS(Vector3.zero, transform.rotation, transform.localScale);
					var _vertices = _meshFilter.sharedMesh.vertices;
					for (int i = 0; i < _vertices.Length; i++)
					{
						//글로벌 공간에서 연산을 해줘야함...
						//위치 - 회전 - 스케일...
						Gizmos.color = Color.red;
						Gizmos.DrawSphere(_vertices[i] + transform.position, gizmosSize);
					}

				}
			}
		}

		// Rotate the cylinder.
		void Update()
		{
			float zRot = rotationSpeed * Time.deltaTime;
			transform.Rotate(0.0f, 0.0f, zRot);
		}
	}
}
