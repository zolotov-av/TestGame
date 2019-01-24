using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript: GameScriptAPI
{
	
	/**
	 * Обработчик клика по ячейке
	 */
	protected override void HandleClick(int row, int col)
	{
		int value = GetValue(row, col);
		SetValue(row, col, value == 0 ? 1 : 0);
	}
	
	/**
	 * Заполнить поле нулями
	 */
	public void FillZero()
	{
		for(int row = 0; row < rowCount; row++)
		{
			for(int col = 0; col < colCount; col++)
			{
				SetValue(row, col, 0);
				SetColor(row, col, colorTwo);
			}
		}
	}
	
	/**
	 * Пронумеровать ячейки
	 */
	public void FillNumber()
	{
	}
	
	/**
	 * Произвольное заполнение
	 */
	public void FillCustom()
	{
	}
	
	void Start()
	{
		ResetErrors();
		Rebuild();
		FillZero();
	}
	
}
