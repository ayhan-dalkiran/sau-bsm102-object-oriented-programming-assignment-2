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
using Project.Geometry;
using System;

namespace Project.Controls.Inputs;
public partial class Vector3DInput : System.Windows.Forms.UserControl {
	public string InputName { get => this.InputNameLabel.Text; set => this.InputNameLabel.Text = value; }
	public string XLabelText { get => this.XLabel.Text; set => this.XLabel.Text = value; }
	public string YLabelText { get => this.YLabel.Text; set => this.YLabel.Text = value; }
	public string ZLabelText { get => this.ZLabel.Text; set => this.ZLabel.Text = value; }

	public decimal MinimumX { get => this.XNumericUpDown.Minimum; set => this.XNumericUpDown.Minimum = value; }
	public decimal MinimumY { get => this.YNumericUpDown.Minimum; set => this.YNumericUpDown.Minimum = value; }
	public decimal MinimumZ { get => this.ZNumericUpDown.Minimum; set => this.ZNumericUpDown.Minimum = value; }

	public decimal MaximumX { get => this.XNumericUpDown.Maximum; set => this.XNumericUpDown.Maximum = value; }
	public decimal MaximumY { get => this.YNumericUpDown.Maximum; set => this.YNumericUpDown.Maximum = value; }
	public decimal MaximumZ { get => this.ZNumericUpDown.Maximum; set => this.ZNumericUpDown.Maximum = value; }

	public Vector3D Value {
		get => new((float)this.XNumericUpDown.Value, (float)this.YNumericUpDown.Value, (float)this.ZNumericUpDown.Value);
		set {
			this.XNumericUpDown.Value = (decimal)value.X;
			this.YNumericUpDown.Value = (decimal)value.Y;
			this.ZNumericUpDown.Value = (decimal)value.Z;
		}
	}

	public event EventHandler ValueChanged {
		add {
			this.XNumericUpDown.ValueChanged += value;
			this.YNumericUpDown.ValueChanged += value;
			this.ZNumericUpDown.ValueChanged += value;
		}
		remove {
			this.XNumericUpDown.ValueChanged -= value;
			this.YNumericUpDown.ValueChanged -= value;
			this.ZNumericUpDown.ValueChanged -= value;
		}
	}

	public Vector3DInput() {
		InitializeComponent();
	}
}
