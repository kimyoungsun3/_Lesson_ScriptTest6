using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace LayerMaskTest
{
	public class LayerMaskTest: MonoBehaviour
	{
		[SerializeField] UILabel uiLabel;
		[SerializeField] UILabel uiLabel2;
		[SerializeField] UILabel uiLabel3;
		[SerializeField] List<GameObject> list = new List<GameObject>();
		void Start()
		{
			int _num	= 0;
			int _layer	= 1;
			_num = _num | 1 << (_layer & 31);

			Debug.Log((_layer & 31));
			Debug.Log((1 << 0) + ":" + Math.Pow(2, 0));
			Debug.Log(_num + ":" + _layer);

			Fun1();
			Fun2();

			Fun3();
		}

		void Fun1()
		{
			string _msg;
			uiLabel.text = "";
			for (int i = 0; i < 10; i++)
			{
				_msg = "(1 << " + i + "):" + (1 << i) + " Math.Pow(2, " + i + "):" + Math.Pow(2, i);
				//_msg = i + " => " + (1 << i) + ":" + Math.Pow(2, i);
				Debug.Log(_msg);

				uiLabel.text += _msg + "\n";
			}
		}

		void Fun2()
		{
			string _msg;
			uiLabel2.text = "";
			for (int i = 0; i < 10; i++)
			{

				int _num = 0;
				_num = _num | 1 << (i & 31);


				_msg = "(1 << " + (i&31) + "):" + (1 << (i & 31));
				//_msg = i + " => " + (1 << i) + ":" + Math.Pow(2, i);
				Debug.Log(_msg);

				uiLabel2.text += _msg + "\n";
			}
		}

		void Fun3()
		{
			GameObject _go;
			string _str;
			uiLabel3.text = "";
			for (int i = 0; i < list.Count; i++)
			{
				_go = list[i];
				_str = _go.name + " -> " + _go.layer + " -> " + GetMaskValue(_go.layer);
				uiLabel3.text += _str + "\n";
				//Debug.Log();
			}
		}

		int GetMaskValue(int _layer)
		{
			return 1 << (_layer & 31);
		}

		public static int GetMask(params string[] layerNames)
		{
			if (layerNames == null)
			{
				throw new ArgumentNullException("layerNames");
			}
			int num = 0;
			string[] strArrays = layerNames;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				int layer = LayerMask.NameToLayer(strArrays[i]);
				if (layer != -1)
				{
					num = num | 1 << (layer & 31);
				}
			}
			return num;
		}
	}


	/// <summary>
	///   <para>Specifies Layers to use in a Physics.Raycast.</para>
	/// </summary>
	//[UsedByNativeCode]
	//public struct LayerMask
	//{
	//	private int m_Mask;

	//	/// <summary>
	//	///   <para>Converts a layer mask value to an integer value.</para>
	//	/// </summary>
	//	//public int @value
	//	//{
	//	//	get
	//	//	{
	//	//		return this.m_Mask;
	//	//	}
	//	//	set
	//	//	{
	//	//		this.m_Mask = value;
	//	//	}
	//	//}

	//	/// <summary>
	//	///   <para>Given a set of layer names as defined by either a Builtin or a User Layer in the, returns the equivalent layer mask for all of them.</para>
	//	/// </summary>
	//	/// <param name="layerNames">List of layer names to convert to a layer mask.</param>
	//	/// <returns>
	//	///   <para>The layer mask created from the layerNames.</para>
	//	/// </returns>
	//	public static int GetMask(params string[] layerNames)
	//	{
	//		if (layerNames == null)
	//		{
	//			throw new ArgumentNullException("layerNames");
	//		}
	//		int num = 0;
	//		string[] strArrays = layerNames;
	//		for (int i = 0; i < (int)strArrays.Length; i++)
	//		{
	//			int layer = LayerMask.NameToLayer(strArrays[i]);
	//			if (layer != -1)
	//			{
	//				num = num | 1 << (layer & 31);
	//			}
	//		}
	//		return num;
	//	}

	//	/// <summary>
	//	///   <para>Given a layer number, returns the name of the layer as defined in either a Builtin or a User Layer in the.</para>
	//	/// </summary>
	//	/// <param name="layer"></param>
	//	//[GeneratedByOldBindingsGenerator]
	//	//[MethodImpl(MethodImplOptions.InternalCall)]
	//	//public static extern string LayerToName(int layer);

	//	///// <summary>
	//	/////   <para>Given a layer name, returns the layer index as defined by either a Builtin or a User Layer in the.</para>
	//	///// </summary>
	//	///// <param name="layerName"></param>
	//	////[GeneratedByOldBindingsGenerator]
	//	//[MethodImpl(MethodImplOptions.InternalCall)]
	//	//public static extern int NameToLayer(string layerName);

	//	//public static implicit operator Int32(LayerMask mask)
	//	//{
	//	//	return mask.m_Mask;
	//	//}

	//	//public static implicit operator LayerMask(int intVal)
	//	//{
	//	//	LayerMask layerMask = new LayerMask();
	//	//	layerMask.m_Mask = intVal;
	//	//	return layerMask;
	//	//}
	//}
}
