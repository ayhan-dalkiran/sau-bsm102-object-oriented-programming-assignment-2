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
using System.Windows.Forms;

using Project.Geometry;

namespace Project.Controls.Inputs;
public partial class FaceAxisInput : UserControl {
	public string InputName { get => this.InputNameLabel.Text; set => this.InputNameLabel.Text = value; }

	public FaceAxis? Value {
		get {
			if (ZRadioButton.Checked)
				return FaceAxis.Z;
			else if (YRadioButton.Checked)
				return FaceAxis.Y;
			else if (XRadioButton.Checked)
				return FaceAxis.X;
			else
				return null;
		}
		set {
			switch (value) {
				case FaceAxis.Z:
					ZRadioButton.Checked = true;
					break;
				case FaceAxis.Y:
					YRadioButton.Checked = true;
					break;
				case FaceAxis.X:
					XRadioButton.Checked = true;
					break;
				default:
					ZRadioButton.Checked = false;
					YRadioButton.Checked = false;
					XRadioButton.Checked = false;
					break;
			}
		}
	}

	public event EventHandler ValueChanged {
		add {
			this.ZRadioButton.CheckedChanged += value;
			this.YRadioButton.CheckedChanged += value;
			this.XRadioButton.CheckedChanged += value;
		}
		remove {
			this.ZRadioButton.CheckedChanged -= value;
			this.YRadioButton.CheckedChanged -= value;
			this.XRadioButton.CheckedChanged -= value;
		}
	}
	public FaceAxisInput() {
		InitializeComponent();
	}
}
