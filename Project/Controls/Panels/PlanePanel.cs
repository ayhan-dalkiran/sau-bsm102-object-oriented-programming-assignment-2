using System;
using System.ComponentModel;
using Project.Geometry;

namespace Project.Controls.Panels;
public partial class PlanePanel : BasePanel {
	public Vector3D CenterValue { get => this.CenterInput.Value; set => this.CenterInput.Value = value; }
	public Vector2D SizeValue { get => this.SizeInput.Value; set => this.SizeInput.Value = value; }
	public FaceAxis? AxisValue { get => this.FaceAxisInput.Value; set => this.FaceAxisInput.Value = value; }

	public override event EventHandler? ValueChanged {
		add {
			this.CenterInput.ValueChanged += value;
			this.SizeInput.ValueChanged += value;
			this.FaceAxisInput.ValueChanged += value;
		}
		remove {
			this.CenterInput.ValueChanged -= value;
			this.SizeInput.ValueChanged -= value;
			this.FaceAxisInput.ValueChanged -= value;
		}
	}

	public PlanePanel() {
		InitializeComponent();
	}
}
