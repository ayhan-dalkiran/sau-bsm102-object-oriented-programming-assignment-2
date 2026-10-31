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
using System.Drawing;

namespace Project.Geometry;
public readonly struct Vector2D : IGeometry2D {
	public float X { get; } = 0.0f;
	public float Y { get; } = 0.0f;
	public float Magnitude => float.Sqrt(X * X + Y * Y);

	public Vector2D Center => this;
	public PointF VP_Point => new(X, Y);
	public SizeF VP_Size => new(0.0f, 0.0f);
	public float VP_ZIndex => float.MaxValue;
	public Color VP_Color => Color.Black;

	public Vector2D(float x, float y) {
		this.X = x;
		this.Y = y;
	}

	public Vector2D Abs() => new(float.Abs(X), float.Abs(Y));
	public Vector2D Max(Vector2D v) => new(float.Max(X, v.X), float.Max(Y, v.Y));
	public Vector2D Min(Vector2D v) => new(float.Min(X, v.X), float.Min(Y, v.Y));
	public Vector2D ToLocalSpace(Vector2D v) => v - this;

	public static Vector2D operator +(Vector2D v1, Vector2D v2) => new(v1.X + v2.X, v1.Y + v2.Y);

	public static Vector2D operator -(Vector2D v1, Vector2D v2) => new(v1.X - v2.X, v1.Y - v2.Y);

	public static Vector2D operator *(Vector2D v1, Vector2D v2) => new(v1.X * v2.X, v1.Y * v2.Y);
	public static Vector2D operator *(Vector2D v, float n) => new(v.X * n, v.Y * n);

	public static Vector2D operator /(Vector2D v1, Vector2D v2) => new(v1.X / v2.X, v1.Y / v2.Y);
	public static Vector2D operator /(Vector2D v, float n) => new(v.X / n, v.Y / n);

	public static Vector2D operator -(Vector2D v) => new(-v.X, -v.Y);

	public static implicit operator Vector2D((float X, float Y) t) => new(t.X, t.Y); 
}
