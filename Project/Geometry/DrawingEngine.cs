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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Geometry;
public static class DrawingEngine {
	#region 2D Drawings
	public static void Draw(Graphics graphics, Circle c, PointF offset, float scale) {
		PointF point = c.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = c.VP_Size;
		size.Width *= scale;
		size.Height *= scale;

		graphics.FillEllipse(_SolidBrush, new RectangleF(point, size));
	}
	public static void Draw(Graphics graphics, Rectangle r, PointF offset, float scale) {
		PointF point = r.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = r.VP_Size;
		size.Width *= scale;
		size.Height *= scale;

		graphics.FillRectangle(_SolidBrush, new RectangleF(point, size));
	}
	public static void Draw(Graphics graphics, Vector2D p, PointF offset, float scale) {
		PointF point = p.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = p.VP_Size;
		size.Width = 5.0f;
		size.Height = 5.0f;

		graphics.FillRectangle(_SolidBrush, new RectangleF(point, size));
	}
	#endregion

	#region 3D Drawings
	public static void Draw(Graphics graphics, Cylinder c, PointF offset, float scale) {
		PointF point = c.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = c.VP_Size;
		size.Width *= scale;
		size.Height *= scale;

		graphics.DrawEllipse(_Pen, point.X, point.Y - 25.0f, size.Width, 50.0f);
		graphics.DrawEllipse(_Pen, point.X , point.Y + size.Height - 25.0f, size.Width, 50.0f);
		graphics.DrawLine(_Pen, point.X, point.Y, point.X, point.Y + size.Height);
		graphics.DrawLine(_Pen, point.X + size.Width, point.Y, point.X + size.Width, point.Y + size.Height);
	}
	public static void Draw(Graphics graphics, Plane p, PointF offset, float scale) {
		PointF point = p.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = p.VP_Size;
		if (p.Axis == FaceAxis.Z) {
			size.Width *= scale;
			size.Height *= scale;
		}
		else if (p.Axis == FaceAxis.Y) {
			size.Width *= scale;
			size.Height = 5.0f;
		}
		else {
			size.Width = 5.0f;
			size.Height *= scale;
		}

		graphics.FillRectangle(_SolidBrush, new RectangleF(point, size));
	}
	public static void Draw(Graphics graphics, RectangularPrism r, PointF offset, float scale) {
		SizeF size = r.VP_Size;
		size.Width *= scale;
		size.Height *= scale;

		PointF point = r.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		//25, -25
		PointF backBegin = new(point.X + 25.0f, point.Y - 25.0f);
		PointF frontBegin = point;

		graphics.DrawRectangle(_Pen, new RectangleF(backBegin, size));
		graphics.DrawRectangle(_Pen, new RectangleF(frontBegin, size));
		graphics.DrawLine(_Pen, backBegin, frontBegin);
		graphics.DrawLine(_Pen, frontBegin.X, frontBegin.Y + size.Height, backBegin.X, backBegin.Y + size.Height);
		graphics.DrawLine(_Pen, frontBegin.X + size.Width, frontBegin.Y + size.Height, backBegin.X + size.Width, backBegin.Y + size.Height);
		graphics.DrawLine(_Pen, frontBegin.X + size.Width, frontBegin.Y, backBegin.X + size.Width, backBegin.Y);
	}
	public static void Draw(Graphics graphics, Sphere s, PointF offset, float scale) {
		PointF point = s.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = s.VP_Size;
		size.Width *= scale;
		size.Height *= scale;

		graphics.FillEllipse(_SolidBrush, new RectangleF(point, size));
	}
	public static void Draw(Graphics graphics, Vector3D p, PointF offset, float scale) {
		PointF point = p.VP_Point;
		point.X = (point.X - offset.X) * scale;
		point.Y = (point.Y - offset.Y) * scale;

		SizeF size = p.VP_Size;
		size.Width = 5.0f;
		size.Height = 5.0f;

		graphics.FillRectangle(_SolidBrush, new RectangleF(point, size));
	}
	#endregion

	public static void Draw(Graphics graphics, IEnumerable<IDrawable> objects) {
		List<IDrawable> sortedList = new(objects);
		sortedList.Sort((IDrawable obj1, IDrawable obj2) => {
			float z1 = obj1.VP_ZIndex;
			float z2 = obj2.VP_ZIndex;

			if (z1 < z2)
				return -1;
			else if (z2 < z1)
				return 1;

			SizeF s1 = obj1.VP_Size;
			SizeF s2 = obj2.VP_Size;
			float s1Magnitude = float.Sqrt(s1.Width * s1.Width + s1.Height * s1.Height);
			float s2Magnitude = float.Sqrt(s2.Width * s2.Width + s2.Height * s2.Height);

			if (s1Magnitude < s2Magnitude)
				return -1;
			else if (s2Magnitude < s1Magnitude)
				return 1;
			else
				return 0;
		});

		PointF min = new(0.0f, 0.0f);
		PointF max = new(0.0f, 0.0f);

		foreach (IDrawable obj in objects) {
			PointF p = obj.VP_Point;
			SizeF s = obj.VP_Size;
			min.X = float.Min(min.X, p.X);
			min.Y = float.Min(min.Y, p.Y);
			max.X = float.Max(max.X, p.X + s.Width);
			max.Y = float.Max(max.Y, p.Y + s.Height);
		}

		min.X -= 1.0f;
		min.Y -= 1.0f;
		max.X += 1.0f;
		max.Y += 1.0f;

		SizeF requiredSize = new(max.X - min.X, max.Y - min.Y);
		SizeF viewportSize = graphics.VisibleClipBounds.Size;
		float scale = float.Min(viewportSize.Width / requiredSize.Width, viewportSize.Height / requiredSize.Height);

		foreach (IDrawable obj in objects) {
			_SolidBrush.Color = obj.VP_Color;
			_Pen.Color = obj.VP_Color;
			Draw(graphics, obj as dynamic, min, scale);
		}
	}

	private static SolidBrush _SolidBrush = new(Color.Black);
	private static Pen _Pen = new Pen(Color.Black, 10);

}
