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

namespace Project.Geometry;
public static class CollisionDetectionEngine {

	#region Proxy Objects
	private static readonly Circle _Circle1 = new();
	private static readonly Circle _Circle2 = new();
	private static readonly Rectangle _Rectangle1 = new();
	private static readonly Rectangle _Rectangle2 = new();
	private static readonly RectangularPrism _RectangularPrism = new();
	#endregion

	#region 2D Collisions
	public static bool CheckCollision(Circle c1, Circle c2) {
		//Checking the distance between the centers
		float centerDistance = (c1.Center - c2.Center).Magnitude;
		float maxDistance = c1.Radius + c2.Radius;

		return centerDistance <= maxDistance;
	}
	public static bool CheckCollision(Circle c, Rectangle r) {
		Vector2D circleCenter = r.Center.ToLocalSpace(c.Center).Abs();
		Vector2D topRight = r.Size * 0.5f;
		float radius = c.Radius;
		
		if (circleCenter.X >= topRight.X && circleCenter.Y >= topRight.Y && (circleCenter - topRight).Magnitude <= radius)
			return true;
		else if (circleCenter.X <= topRight.X && circleCenter.Y <= topRight.Y + radius)
			return true;
		else if (circleCenter.Y <= topRight.Y && circleCenter.X <= topRight.X + radius)
			return true;
		else
			return false;
	}
	public static bool CheckCollision(Circle c, Vector2D p) {
		//Checking distance from the center
		float centerDistance = (c.Center - p).Magnitude;
		float maxDistance = c.Radius;
		return centerDistance <= maxDistance;
	}

	public static bool CheckCollision(Rectangle r, Circle c) => CheckCollision(c, r);
	public static bool CheckCollision(Rectangle r1, Rectangle r2) {
		Vector2D r2Center = r1.Center.ToLocalSpace(r2.Center).Abs();
		Vector2D r2BottomLeft = r2Center + r2.Size * -0.5f;
		Vector2D r1TopRight = r1.Size * 0.5f;

		if (r2BottomLeft.X <= r1TopRight.X && r2BottomLeft.Y <= r1TopRight.Y)
			return true;
		else
			return false;
	}
	public static bool CheckCollision(Rectangle r, Vector2D p) {
		Vector2D position = r.Center.ToLocalSpace(p).Abs();
		Vector2D topRight = r.Size * 0.5f;

		if (position.X <= topRight.X && position.Y <= topRight.Y)
			return true;
		else
			return false;
	}

	public static bool CheckCollision(Vector2D p, Circle c) => CheckCollision(c, p);
	public static bool CheckCollision(Vector2D p, Rectangle r) => CheckCollision(r, p);
	#endregion

	#region 3D Collisions
	public static bool CheckCollision(Cylinder c1, Cylinder c2) {
		if (c1.TopCenter.Y < c2.BottomCenter.Y)
			return false;
		else if (c1.BottomCenter.Y > c2.TopCenter.Y)
			return false;

		_Circle1.Center = new(c1.Center.X, c1.Center.Y);
		_Circle1.Radius = c1.Radius;
		_Circle2.Center = new(c2.Center.X, c2.Center.Y);
		_Circle2.Radius = c2.Radius;

		return CheckCollision(c1, c2);
	}
	public static bool CheckCollision(Cylinder c, Plane p) {
		_RectangularPrism.Center = p.Center;
		_RectangularPrism.Size = p.Size;

		return CheckCollision(c, _RectangularPrism);
	}
	public static bool CheckCollision(Cylinder c, RectangularPrism r) {
		if (c.TopCenter.Y < r.BackBottomLeft.Y)
			return false;
		else if (c.BottomCenter.Y > r.FrontTopRight.Y)
			return false;

		_Circle1.Center = new(c.Center.X, c.Center.Z);
		_Circle1.Radius = c.Radius;
		_Rectangle1.Center = new(r.Center.X, r.Center.Z);
		_Rectangle1.Size = new(r.Size.X, r.Size.Z);

		return CheckCollision(_Circle1, _Rectangle1);
	}
	public static bool CheckCollision(Cylinder c, Sphere s) {
		Vector3D sphereCenter = c.Center.ToLocalSpace(s.Center).Abs();
		float topY = c.Height * 0.5f;
		float centerDiff = sphereCenter.Y - topY;
		float realDiff = centerDiff - s.Radius;

		if (realDiff > 0)
			return false;

		_Circle1.Center = new(c.Center.X, c.Center.Z);
		_Circle1.Radius = c.Radius;
		_Circle2.Center = new(s.Center.X, s.Center.Z);
		_Circle2.Radius = sphereCenter.Y <= topY ? s.Radius : float.Sqrt(s.Radius * s.Radius - centerDiff * centerDiff);

		return CheckCollision(_Circle1, _Circle2);
	}
	public static bool CheckCollision(Cylinder c, Vector3D p) {
		if (c.TopCenter.Y < p.Y || c.BottomCenter.Y > p.Y)
			return false;

		_Circle1.Center = new(c.Center.X, c.Center.Z);
		_Circle1.Radius = c.Radius;

		return CheckCollision(_Circle1, new Vector2D(p.X, p.Z));
	}

	public static bool CheckCollision(Plane p, Cylinder c) => CheckCollision(c, p);
	public static bool CheckCollision(Plane p, RectangularPrism r) {
		_RectangularPrism.Center = p.Center;
		_RectangularPrism.Size = p.Size;

		return CheckCollision(_RectangularPrism, r);
	}
	public static bool CheckCollision(Plane p, Sphere s) {
		_RectangularPrism.Center = p.Center;
		_RectangularPrism.Size = p.Size;

		return CheckCollision(_RectangularPrism, s);
	}

	public static bool CheckCollision(RectangularPrism r, Cylinder c) => CheckCollision(c, r);
	public static bool CheckCollision(RectangularPrism r, Plane p) => CheckCollision(p, r);
	public static bool CheckCollision(RectangularPrism r, Sphere s) {
		Vector3D sphereCenter = r.Center.ToLocalSpace(s.Center).Abs();
		Vector3D frontTopRight = r.Size * 0.5f;
		float radius = s.Radius;

		if (sphereCenter.X >= frontTopRight.X && sphereCenter.Y >= frontTopRight.Y && sphereCenter.Z >= frontTopRight.Z && (sphereCenter - frontTopRight).Magnitude <= radius)
			return true;
		else if (sphereCenter.X <= frontTopRight.X && sphereCenter.Y <= frontTopRight.Y && sphereCenter.Z <= frontTopRight.Z + radius)
			return true;
		else if (sphereCenter.X <= frontTopRight.X && sphereCenter.Z <= frontTopRight.Z && sphereCenter.Y <= frontTopRight.Y + radius)
			return true;
		else if (sphereCenter.Y <= frontTopRight.Y && sphereCenter.Z <= frontTopRight.Z && sphereCenter.X <= frontTopRight.X + radius)
			return true;
		else if (sphereCenter.X <= frontTopRight.X && ((sphereCenter - frontTopRight) * (0.0f, 1.0f, 1.0f)).Magnitude <= radius)
			return true;
		else if (sphereCenter.Y <= frontTopRight.Y && ((sphereCenter - frontTopRight) * (1.0f, 0.0f, 1.0f)).Magnitude <= radius)
			return true;
		else if (sphereCenter.Z <= frontTopRight.Z && ((sphereCenter - frontTopRight) * (1.0f, 1.0f, 0.0f)).Magnitude <= radius)
			return true;
		else
			return false;
	}
	public static bool CheckCollision(RectangularPrism r1, RectangularPrism r2) {
		Vector3D r2Center = r1.Center.ToLocalSpace(r2.Center).Abs();
		Vector3D r2BackBottomLeft = r2Center - r2.Size * 0.5f;
		Vector3D r1FrontTopRight = r1.Size * 0.5f;

		if (r2BackBottomLeft.X <= r1FrontTopRight.X && r2BackBottomLeft.Y <= r1FrontTopRight.Y && r2BackBottomLeft.Z <= r1FrontTopRight.Z)
			return true;
		else
			return false;
	}
	public static bool CheckCollision(RectangularPrism r, Vector3D p) {
		Vector3D position = r.Center.ToLocalSpace(p).Abs();
		Vector3D frontTopRight = r.Size * 0.5f;

		if (position.X <= frontTopRight.X && position.Y <= frontTopRight.Y && position.Z <= frontTopRight.Z)
			return true;
		else
			return false;
	}

	public static bool CheckCollision(Sphere s, Cylinder c) => CheckCollision(c, s);
	public static bool CheckCollision(Sphere s, Plane p) => CheckCollision(p, s);
	public static bool CheckCollision(Sphere s, RectangularPrism r) => CheckCollision(r, s);
	public static bool CheckCollision(Sphere s1, Sphere s2) {
		//Checking distance from the center
		float centerDistance = (s1.Center - s2.Center).Magnitude;
		float maxDistance = s1.Radius + s2.Radius;
		return centerDistance <= maxDistance;
	}
	public static bool CheckCollision(Sphere s, Vector3D p) {
		//Checking distance from the center
		float centerDistance = (s.Center - p).Magnitude;
		float maxDistance = s.Radius;
		return centerDistance <= maxDistance;
	}

	public static bool CheckCollision(Vector3D p, Cylinder c) => CheckCollision(c, p);
	public static bool CheckCollision(Vector3D p, RectangularPrism r) => CheckCollision(r, p);
	public static bool CheckCollision(Vector3D p, Sphere s) => CheckCollision(s, p);
	#endregion
}