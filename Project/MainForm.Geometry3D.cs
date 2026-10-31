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
	private Dictionary<string, IGeometry3D> Object3DMap = new();

	private (string Name, T Object) CreateObject3D<T>() where T : IGeometry3D, new() {
		int index = 0;
		string prefix = typeof(T).Name;
		string name;
		do {
			name = prefix + index;
			index++;
		} while (Object3DMap.ContainsKey(name));

		T obj = new T();
		Object3DMap.Add(name, obj);
		return (name, obj);
	}

	private void RemoveObject3D(string name) {
		RemoveHeader(this.CollisionTable3D, name);
		Object3DMap.Remove(name);
		UpdateViewport3D();
	}

	private void UpdateViewport3D() {
		Graphics graphics = this.Viewport3D.CreateGraphics();
		graphics.Clear(Color.White);
		DrawingEngine.Draw(graphics, Object3DMap.Values);
	}
}
