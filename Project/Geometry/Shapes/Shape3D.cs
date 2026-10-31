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

public enum FaceAxis { X, Y, Z }

public abstract class Shape3D : Shape, IGeometry3D {
	public abstract Vector3D Center { get; set; }
	public abstract Vector3D Size { get; set; }
}

public class Cylinder : Shape3D {
	public float Height { get => this._Height; set => this._Height = float.Abs(value); }
	public float Radius { get => this._Radius; set => this._Radius = float.Abs(value); }

	public Vector3D TopCenter => Center + (0, Height * 0.5f, 0);
	public Vector3D BottomCenter => Center + (0, -Height * 0.5f, 0);

	public override Vector3D Center { get; set; }
	public override Vector3D Size {
		get => new(Radius, Height, Radius);
		set {
			Height = value.Y;
			Radius = float.MaxMagnitudeNumber(value.X, value.Z);
		}
	}

	public override PointF VP_Point => new(Center.X - Radius, Center.Y + Height * 0.5f);
	public override SizeF VP_Size => new(Radius * 2, Height);
	public override float VP_ZIndex => Center.Z + Radius;

	public Cylinder() { }
	public Cylinder(Vector3D center, float height, float radius) {
		this.Center = center;
		this.Height = height;
		this.Radius = radius;
	}

	protected float _Height = 0.0f;
	protected float _Radius = 0.0f;
}

public class Plane : Shape3D {
	public FaceAxis Axis { get; set; } = FaceAxis.Z;
	public Vector2D Size2D { get => _Size; set => _Size = value.Abs(); }

#pragma warning disable CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
	public Vector3D TopRight {
		get => this.Axis switch {
			FaceAxis.Z => new(Center.X + Size.X * 0.5f, Center.Y + Size.Y * 0.5f, Center.Z),
			FaceAxis.Y => new(Center.X + Size.X * 0.5f, Center.Y, Center.Z + Size.Y * 0.5f),
			FaceAxis.X => new(Center.X, Center.Y + Size.X * 0.5f, Center.Z + Size.Y * 0.5f)
		};
	}
	public Vector3D TopLeft {
		get => Axis switch {
			FaceAxis.Z => new(Center.X - Size.X * 0.5f, Center.Y + Size.Y * 0.5f, Center.Z),
			FaceAxis.Y => new(Center.X - Size.X * 0.5f, Center.Y, Center.Z + Size.Y * 0.5f),
			FaceAxis.X => new(Center.X, Center.Y + Size.X * 0.5f, Center.Z - Size.Y * 0.5f)
		};
	}
	public Vector3D BottomLeft {
		get => this.Axis switch {
			FaceAxis.Z => new(Center.X - Size.X * 0.5f, Center.Y - Size.Y * 0.5f, Center.Z),
			FaceAxis.Y => new(Center.X - Size.X * 0.5f, Center.Y, Center.Z - Size.Y * 0.5f),
			FaceAxis.X => new(Center.X, Center.Y - Size.X * 0.5f, Center.Z - Size.Y * 0.5f)
		};
	}
	public Vector3D BottomRight {
		get => this.Axis switch {
			FaceAxis.Z => new(Center.X - Size.X * 0.5f, Center.Y + Size.Y * 0.5f, Center.Z),
			FaceAxis.Y => new(Center.X - Size.X * 0.5f, Center.Y, Center.Z + Size.Y * 0.5f),
			FaceAxis.X => new(Center.X, Center.Y + Size.X * 0.5f, Center.Z + Size.Y * 0.5f)
		};
	}

	public override Vector3D Center { get; set; }
	public override Vector3D Size {
		get => Axis switch {
			FaceAxis.Z => new(Size2D.X, Size2D.Y, 0.0f),
			FaceAxis.Y => new(Size2D.X, 0.0f, Size2D.Y),
			FaceAxis.X => new(0.0f, Size2D.Y, Size2D.X)
		};
		set => Size2D = Axis switch {
			FaceAxis.Z => new(value.X, value.Y),
			FaceAxis.Y => new(value.X, value.Z),
			FaceAxis.X => new(value.Z, value.Y)
		};
	}
#pragma warning restore CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.

	public override PointF VP_Point => new(Center.X - Size.X * 0.5f, Center.Y - Size.Y * 0.5f);
	public override SizeF VP_Size => new(Size.X, Size.Y);
	public override float VP_ZIndex => Center.Z + Size.Z * 0.5f;

	public Plane() { }
	public Plane(Vector3D center, Vector3D size, FaceAxis axis) {
		this.Center = center;
		this.Size = size;
		this.Axis = axis;
	}

	protected Vector2D _Size = default;
}

public class RectangularPrism : Shape3D {
	public Vector3D FrontTopRight { get => Center + Size * (0.5f, 0.5f, 0.5f); }
	public Vector3D FrontTopLeft { get => Center + Size * (-0.5f, 0.5f, 0.5f); }
	public Vector3D FrontBottomLeft { get => Center + Size * (-0.5f, -0.5f, 0.5f); }
	public Vector3D FrontBottomRight { get => Center + Size * (0.5f, -0.5f, 0.5f); }

	public Vector3D BackTopRight { get => Center + Size * (0.5f, 0.5f, -0.5f); }
	public Vector3D BackTopLeft { get => Center + Size * (-0.5f, 0.5f, -0.5f); }
	public Vector3D BackBottomLeft { get => Center + Size * (-0.5f, -0.5f, -0.5f); }
	public Vector3D BackBottomRight { get => Center + Size * (0.5f, -0.5f, -0.5f); }

	public override Vector3D Center { get; set; }
	public override Vector3D Size { get => _Size; set => _Size = value.Abs(); }

	public override PointF VP_Point => new(Center.X - Size.X * 0.5f, Center.Y - Size.Y * 0.5f);
	public override SizeF VP_Size => new(Size.X, Size.Y);
	public override float VP_ZIndex => Center.Z + Size.Z * 0.5f;

	public RectangularPrism() { }
	public RectangularPrism(Vector3D center, Vector3D size) {
		this.Center = center;
		this.Size = size;
	}

	protected Vector3D _Size = default;
}

public class Sphere : Shape3D {
	public float Radius { get => _Radius; set => _Radius = float.Abs(value); }
	public override Vector3D Center { get; set; }
	public override Vector3D Size { get => new(Radius, Radius, Radius); set => Radius = float.MaxMagnitudeNumber(float.MaxMagnitudeNumber(value.X, value.Y), value.Z); }

	public override PointF VP_Point => new(Center.X - Radius, Center.Y - Radius);
	public override SizeF VP_Size => new(Radius * 2, Radius * 2);
	public override float VP_ZIndex => Center.Z + Radius;

	public Sphere() { }
	public Sphere(Vector3D center, float Radius) {
		this.Center = center;
		this.Radius = Radius;
	}

	protected float _Radius = 0.0f;
}
