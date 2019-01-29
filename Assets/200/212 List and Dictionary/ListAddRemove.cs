using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary
{
	[System.Serializable]
	public class CRoom
	{
		public string name = "name";
		public int number = 0;
	}


	public class ListAddRemove : MonoBehaviour
	{
		public List<CRoom> listRoom = new List<CRoom>();
		int idx = 1;

		private void Start()
		{
			Debug.Log("1(Add), 2(SearchAdd), 5(First Remove), 6(Last Remove)");
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				CRoom _room = new CRoom();
				_room.name = "name" + (idx++);
				listRoom.Add(_room);
				_room.number = listRoom.Count;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				CRoom _room = new CRoom();
				_room.name = "name" + (idx++);
				listRoom.Add(_room);

				int _number = CalNumber2();
				Debug.Log(_number);
				_room.number = _number;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				Debug.Log(CalNumber5());
			}
			else if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				CalNumber4();
			}
			else if (Input.GetKeyDown(KeyCode.Alpha5))
			{
				if (listRoom.Count > 0)
					listRoom.Remove(listRoom[0]);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				if(listRoom.Count > 0)
					listRoom.Remove(listRoom[listRoom.Count - 1]);
			}
		}

		public byte[] _numberBool;
		int CalNumber5()
		{
			//int[] _number = { 4, 5, 7, 9, 10, 11, 12 };	// 1
			//int[] _number = { 4, 1, 2, 3, 5, 7, 9, 10, 11, 12 };//6
			//int[] _number = { 4, 1, 2, 3, 5, 7, 6, 9, 10, 11, 12 };//8
			int[] _number = { 4, 1, 2, 3, 5, 7, 6, 9, 10, 11, 12, 8 };//13
			int _max = 13;
			//int[] _number = { 4, 1, 2, 3, 5, 7, 6, 9, 10, 11, 12, 8, 13 };
			//int _max = 13+1;
			_numberBool = new byte[_max];

			int _rtn = 1;

			for (int i = 0, iMax = _number.Length; i < iMax; i++)
			{
				_numberBool[_number[i]] = 9;
			}

			bool _bFind = false;
			for (int i = 1, iMax = _numberBool.Length; i < iMax; i++)
			{
				if (_numberBool[i] != 9)
				{
					_rtn = i;
					_bFind = true;
					break;
				}
			}

			if(!_bFind)
			{
				_rtn = _max;
				_max++;
			}

			return _rtn;
		}

		void CalNumber4()
		{
			int[] number = { 4, 5, 7, 9, 10, 11, 12 };
			int lastIndex = number.Length - 1;
			int size = number[lastIndex] - number[0] + 1;
			int sumTotal = (number[0] + number[lastIndex]) * size / 2;
			int mulTotal = 1;
			for (int i = number[0]; i <= number[number.Length - 1]; i++)
			{
				mulTotal *= i;
			}

			int partialSum = 0;
			int partialMul = 1;

			for (int i = 0; i < number.Length; i++)
			{
				partialSum += number[i];
				partialMul *= number[i];
			}

			int A = sumTotal - partialSum;
			int B = mulTotal / partialMul;

			int X = (int)((A + (Mathf.Sqrt(A * A - 4 * B))) / 2);
			if (X < 0)
				X = (int)((A + (Mathf.Sqrt(A * A - 4 * B))) / 2);
			int Y = A - X;

			Debug.Log(X);
			Debug.Log(Y);
		}

		int CalNumber3()
		{
			int _number = 1;
			int[] xx = { 1, 2, 3,   5 };	// -> 4
			int _max = 5;
			//int[] xx = { 1, 2, 3, 4, 5 };	// -> 0
			//int _max = 5;
			//int[] xx = { 2, 3, 5 };
			//int _max = 4;//0
			//int _max = 3;//-4
			int _sum = 0;
			int _sum2 = 0;
			{
				for (int i = 0, iMax = xx.Length; i < iMax; i++)
				{
					_sum += xx[i];
				}
				_sum2 = (1 + _max) * _max / 2;
				_number = _sum2 - _sum;

			}
			return _number;
		}

		int CalNumber2()
		{

			int _number = 1;
			if (listRoom.Count > 0)
			{
				int _sum2 = 0;
				for (int i = 0, iMax = listRoom.Count; i < iMax; i++)
				{
					_sum2 += listRoom[i].number;
				}
				int _sum = (1 + listRoom.Count) * listRoom.Count / 2;
				_number = _sum - _sum2;

			}
			return _number;
		}

		int CalNumber()
		{
			int _number = 1;
			if (listRoom.Count > 0)
			{
				CRoom _room;
				int _sum = 0;
				int _sum2 = 0;
				for(int i = 0, iMax = listRoom.Count; i < iMax; i++)
				{
					_room = listRoom[i];
					_sum  += (i + 1);
					_sum2 += _room.number;
					if(_sum != _sum2)
					{
						_number = i + 1;
					}
				}
			}
			return _number;
		}
	}
}