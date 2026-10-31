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
using System.ComponentModel;
using System.Windows.Forms;
using Project.Controls.Panels;
using Project.Geometry;

namespace Project;
partial class MainForm {
	private void newCircleButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject2D<Circle>();

		CirclePanel panel = new();
		panel.CenterValue = obj.Center;
		panel.RadiusValue = obj.Radius = 1.0f;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Radius = panel.RadiusValue;
			UpdateHeader(this.CollisionTable2D, Object2DMap, name);
			UpdateViewport2D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport2D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties2DTab.TabPages.Add(page);
		this.Properties2DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object2DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object2DMap.Add(panel.ObjectName, obj);
			Object2DMap.Remove(name);
			RenameHeader(this.CollisionTable2D, name, newName);
			page.Text = newName;
			name = newName;
		};

		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject2D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable2D, Object2DMap, name);
		UpdateViewport2D();
	}

	private void newRectangleButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject2D<Rectangle>();

		RectanglePanel panel = new();
		panel.CenterValue = obj.Center;
		panel.SizeValue = obj.Size = new(1.0f, 1.0f);
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Size = panel.SizeValue;
			UpdateHeader(this.CollisionTable2D, Object2DMap, name);
			UpdateViewport2D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport2D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties2DTab.TabPages.Add(page);
		this.Properties2DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object2DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object2DMap.Add(panel.ObjectName, obj);
			Object2DMap.Remove(name);
			RenameHeader(this.CollisionTable2D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject2D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable2D, Object2DMap, name);
		UpdateViewport2D();
	}

	private void newVector2DButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject2D<Vector2D>();

		Vector2DPanel panel = new();
		panel.CenterValue = obj;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj = panel.CenterValue;
			Object2DMap[name] = panel.CenterValue;
			UpdateHeader(this.CollisionTable2D, Object2DMap, name);
			UpdateViewport2D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties2DTab.TabPages.Add(page);
		this.Properties2DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object2DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object2DMap.Add(panel.ObjectName, obj);
			Object2DMap.Remove(name);
			RenameHeader(this.CollisionTable2D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject2D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable2D, Object2DMap, name);
		UpdateViewport2D();
	}

	private void newCylinderButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject3D<Cylinder>();

		CylinderPanel panel = new();
		panel.CenterValue = obj.Center;
		panel.RadiusValue = obj.Radius = 1.0f;
		panel.HeightValue = obj.Height = 1.0f;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Radius = panel.RadiusValue;
			obj.Height = panel.HeightValue;
			UpdateHeader(this.CollisionTable3D, Object3DMap, name);
			UpdateViewport3D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport3D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties3DTab.TabPages.Add(page);
		this.Properties3DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object3DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object3DMap.Add(panel.ObjectName, obj);
			Object3DMap.Remove(name);
			RenameHeader(this.CollisionTable3D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject3D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable3D, Object3DMap, name);
		UpdateViewport3D();
	}

	private void newPlaneButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject3D<Plane>();

		PlanePanel panel = new();
		panel.CenterValue = obj.Center;
		panel.SizeValue = obj.Size2D = new(1.0f, 1.0f);
		panel.AxisValue = obj.Axis;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Size2D = panel.SizeValue;
			obj.Axis = panel.AxisValue ?? FaceAxis.Z;
			UpdateHeader(this.CollisionTable3D, Object3DMap, name);
			UpdateViewport3D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport3D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties3DTab.TabPages.Add(page);
		this.Properties3DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object3DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object3DMap.Add(panel.ObjectName, obj);
			Object3DMap.Remove(name);
			RenameHeader(this.CollisionTable3D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject3D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable3D, Object3DMap, name);
		UpdateViewport3D();
	}

	private void newRectangularPrismButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject3D<RectangularPrism>();

		RectangularPrismPanel panel = new();
		panel.CenterValue = obj.Center;
		panel.SizeValue = obj.Size = new(1.0f, 1.0f, 1.0f);
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Size = panel.SizeValue;
			UpdateHeader(this.CollisionTable3D, Object3DMap, name);
			UpdateViewport3D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport3D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties3DTab.TabPages.Add(page);
		this.Properties3DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object3DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object3DMap.Add(panel.ObjectName, obj);
			Object3DMap.Remove(name);
			RenameHeader(this.CollisionTable3D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject3D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable3D, Object3DMap, name);
		UpdateViewport3D();
	}

	private void newSphereButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject3D<Sphere>();

		SpherePanel panel = new();
		panel.CenterValue = obj.Center;
		panel.RadiusValue = obj.Radius = 1.0f;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj.Center = panel.CenterValue;
			obj.Radius = panel.RadiusValue;
			UpdateHeader(this.CollisionTable3D, Object3DMap, name);
			UpdateViewport3D();
		};
		panel.ObjectColor = obj.VP_Color;
		panel.ObjectColorChanged += (object? sender, EventArgs e) => {
			obj.VP_Color = panel.ObjectColor;
			UpdateViewport3D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties3DTab.TabPages.Add(page);
		this.Properties3DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object3DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object3DMap.Add(panel.ObjectName, obj);
			Object3DMap.Remove(name);
			RenameHeader(this.CollisionTable3D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject3D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable3D, Object3DMap, name);
		UpdateViewport3D();
	}

	private void newVector3DButton_Click(object sender, EventArgs e) {
		(var name, var obj) = CreateObject3D<Vector3D>();

		Vector3DPanel panel = new();
		panel.CenterValue = obj;
		panel.ObjectName = name;
		panel.ValueChanged += (object? sender, EventArgs e) => {
			obj = panel.CenterValue;
			Object3DMap[name] = panel.CenterValue;
			UpdateHeader(this.CollisionTable3D, Object3DMap, name);
			UpdateViewport3D();
		};
		TabPage page = new(name);
		page.Controls.Add(panel);
		this.Properties3DTab.TabPages.Add(page);
		this.Properties3DTab.SelectTab(page);

		panel.ObjectNameValidating += (object? sender, CancelEventArgs e) => {
			string newName = panel.ObjectName;

			if (newName == name)
				return;

			if (Object3DMap.ContainsKey(newName)) {
				e.Cancel = true;
				MessageBox.Show("Object with this name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Object3DMap.Add(panel.ObjectName, obj);
			Object3DMap.Remove(name);
			RenameHeader(this.CollisionTable3D, name, newName);
			page.Text = newName;
			name = newName;
		};
		panel.DeleteRequested += (object? sender, EventArgs e) => {
			RemoveObject3D(name);
			page.Dispose();
			panel.Dispose();
		};

		AddHeader(this.CollisionTable3D, Object3DMap, name);
		UpdateViewport3D();
	}

	private void MainForm_ResizeEnd(object sender, EventArgs e) {
		UpdateViewport2D();
		UpdateViewport3D();
	}
}
