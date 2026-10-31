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
public readonly record struct Vector3D : IGeometry3D {
	public float X { get; } = 0.0f;
	public float Y { get; } = 0.0f;
	public float Z { get; } = 0.0f;
	public float Magnitude => float.Sqrt(X * X + Y * Y + Z * Z);

	public Vector3D Center => this;
	public PointF VP_Point => new(X, Y);
	public SizeF VP_Size => new(0.0f, 0.0f);
	public float VP_ZIndex => float.MaxValue;
	public Color VP_Color => Color.Black;

	public Vector3D(float x, float y, float z) {
		this.X = x;
		this.Y = y;
		this.Z = z;
	}

	public Vector3D Abs() => new(float.Abs(X), float.Abs(Y), float.Abs(Z));
	public Vector3D Max(Vector3D v) => new(float.Max(X, v.X), float.Max(Y, v.Y), float.Max(Z, v.Z));
	public Vector3D Min(Vector3D v) => new(float.Min(X, v.X), float.Min(Y, v.Y), float.Min(Z, v.Z));
	public Vector3D ToLocalSpace(Vector3D v) => v - this;

	public static Vector3D operator +(Vector3D v1, Vector3D v2) => new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);

	public static Vector3D operator -(Vector3D v1, Vector3D v2) => new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

	public static Vector3D operator *(Vector3D v1, Vector3D v2) => new(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
	public static Vector3D operator *(Vector3D v, float n) => new(v.X * n, v.Y * n, v.Z * n);

	public static Vector3D operator /(Vector3D v1, Vector3D v2) => new(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
	public static Vector3D operator /(Vector3D v, float n) => new(v.X / n, v.Y / n, v.Z / n);

	public static Vector3D operator -(Vector3D v) => new(-v.X, -v.Y, -v.Z);

	public static implicit operator Vector3D((float X, float Y, float Z) t) => new(t.X, t.Y, t.Z);
}
