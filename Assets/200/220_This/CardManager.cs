using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassThisTest
{
	public class CardManager : MonoBehaviour
	{
		public static CardManager ins;

		[Header("클릭시 선택됨")]
		[SerializeField] Card firstCard;
		[SerializeField] Card secondCard;

		private void Awake()
		{
			ins = this;
		}

		public bool isCardSelecting { get{	return secondCard == null;}}

		public void CheckCard(Card _card)
		{
			if(firstCard == null)
			{
				firstCard = _card;
			}
			else
			{
				secondCard = _card;
				StartCoroutine(Co_CheckCard());
			}
		}

		IEnumerator Co_CheckCard()
		{
			if(firstCard.number == secondCard.number)
			{
				Debug.Log("Same Card");
			}
			else
			{
				Debug.Log("Not Same Card");
				yield return new WaitForSeconds(2f);
				firstCard.Blind();
				secondCard.Blind();
				Debug.Log("Card is reblind");
			}
			firstCard	= null;
			secondCard	= null;
		}
	}
}
