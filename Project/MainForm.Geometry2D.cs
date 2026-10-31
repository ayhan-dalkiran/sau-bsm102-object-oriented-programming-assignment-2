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
	private Dictionary<string, IGeometry2D> Object2DMap = new();

	private (string Name, T Object) CreateObject2D<T>() where T : IGeometry2D, new() {
		int index = 0;
		string prefix = typeof(T).Name;
		string name;
		do {
			name = prefix + index;
			index++;
		} while (Object2DMap.ContainsKey(name));

		T obj = new T();
		Object2DMap.Add(name, obj);
		return (name, obj);
	}

	private void RemoveObject2D(string name) {
		RemoveHeader(this.CollisionTable2D, name);
		Object2DMap.Remove(name);
		UpdateViewport2D();
	}

	private void UpdateViewport2D() {
		Graphics graphics = this.Viewport2D.CreateGraphics();
		graphics.Clear(Color.White);
		DrawingEngine.Draw(graphics, Object2DMap.Values);
	}
}
