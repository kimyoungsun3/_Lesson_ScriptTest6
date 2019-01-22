using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NetworkBase
{
	public enum LOGIN_PROTO : short
	{
		CREATE_ROOM_REQ,
		CREATE_ROOM_OK,
		CREATE_ROOM_FAILED,

		ROOM_LIST_REQ,
		ROOM_LIST_ACK,
		ROOM_EXIT_REQ,

		ROOM_CONNECT_REQ,
		ROOM_CONNECT_OK,
		ROOM_CONNECT_FAILED,

		ROOM_CONNECT_OTHER,
		ROOM_EXIT_OTHER,

		HEART_SEND_REQ,

		LOGIN_REQUEST,
		LOGIN_REPLY,
		FAILD,
		OK,
		MOVE,
		ATTACK,
		USER_CONNECT,
		CHART_MSG_REQ,

		END
	}
}
