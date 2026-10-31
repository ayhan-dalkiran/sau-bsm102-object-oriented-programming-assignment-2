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

public abstract class Shape2D : Shape, IGeometry2D {
	public abstract Vector2D Center { get; set; }
	public abstract Vector2D Size { get; set; }

	public override float VP_ZIndex => 0.0f;
}

public class Circle : Shape2D {
	public float Radius { get => this._Radius; set => this._Radius = float.Abs(value); }

	public override Vector2D Center { get; set; } = default;
	public override Vector2D Size { get => (Radius, Radius); set => Radius = float.MaxMagnitudeNumber(value.X, value.Y); }

	public override PointF VP_Point => new(Center.X - Radius, Center.Y - Radius);
	public override SizeF VP_Size => new(Radius * 2, Radius * 2);

	public Circle() { }
	public Circle(Vector2D center, float radius) {
		this.Center = center;
		this.Radius = radius;
	}

	protected float _Radius = 0.0f;
}

public class Rectangle : Shape2D {
	public Vector2D TopRight => Center + Size * (0.5f, 0.5f);
	public Vector2D TopLeft => Center + Size * (-0.5f, 0.5f);
	public Vector2D BottomLeft => Center + Size * (-0.5f, -0.5f);
	public Vector2D BottomRight => Center + Size * (0.5f, -0.5f);

	public override Vector2D Center { get; set; }
	public override Vector2D Size { get => _Size; set => _Size = value.Abs(); }

	public override PointF VP_Point => new(Center.X - Size.X * 0.5f, Center.Y - Size.Y * 0.5f);
	public override SizeF VP_Size => new(Size.X, Size.Y);

	public Rectangle() { }
	public Rectangle(Vector2D center, Vector2D size) {
		this.Center = center;
		this.Size = size;
	}

	protected Vector2D _Size = default;
}
