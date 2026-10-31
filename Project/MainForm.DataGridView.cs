/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Ayhan Dalkıran
**				ÖĞRENCİ NUMARASI.......: G221210020
**				DERSİN ALINDIĞI GRUP...: II. Öğretim C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Project.Geometry;

namespace Project;
partial class MainForm {
	private void AddHeader<TValue>(DataGridView dgv, IDictionary<string, TValue> objects, string headerName) where TValue : class, IDrawable {
		var column = new DataGridViewColumn(new DataGridViewTextBoxCell());
		column.Name = headerName;
		column.HeaderText = headerName;
		column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		dgv.Columns.Add(column);

		var row = new DataGridViewRow();
		row.HeaderCell.Value = headerName;
		dgv.Rows.Add(row);
		UpdateHeader(dgv, objects, headerName);
	}

	private void UpdateHeader<TValue>(DataGridView dgv, IDictionary<string, TValue> objects, string headerName) where TValue : class, IDrawable {
		foreach (DataGridViewRow row in dgv.Rows) {
			string rowName = (string)row.HeaderCell.Value;

			if (rowName != headerName)
				row.Cells[headerName].Style.BackColor = GetBackColor(objects, headerName, rowName);
			else
				foreach (DataGridViewCell cell in row.Cells)
					cell.Style.BackColor = GetBackColor(objects, cell.OwningColumn.HeaderText, rowName);
		}
	}

	private void RemoveHeader(DataGridView dgv, string headerName) {
		dgv.Columns.RemoveAt(FindColumn(dgv, headerName).Index);
		dgv.Rows.RemoveAt(FindRow(dgv, headerName).Index);
	}

	private void RenameHeader(DataGridView dgv, string oldName, string newName) {
		var column = FindColumn(dgv, oldName);
		column.Name = newName;
		column.HeaderText = newName;
		FindRow(dgv, oldName).HeaderCell.Value = newName;
	}

	private DataGridViewColumn FindColumn(DataGridView dgv, string columnName) => dgv.Columns[columnName];
	private DataGridViewRow FindRow(DataGridView dgv, object rowName) {
		foreach (DataGridViewRow row in dgv.Rows)
			if (row.HeaderCell.Value == rowName)
				return row;

		throw new ArgumentException();
	}

	private Color GetBackColor<TValue>(IDictionary<string, TValue> objects, string columnName, string rowName) where TValue : class, IDrawable {
		var columnObject = objects[columnName];
		var rowObject = objects[rowName];

		if (columnObject == rowObject)
			return Color.Gray;

		try {
			return CollisionDetectionEngine.CheckCollision(columnObject as dynamic, rowObject as dynamic) ? Color.Green : Color.Maroon;
		}
		catch {
			return Color.Gray;
		}
	}
}
