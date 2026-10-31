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
using System.ComponentModel;
using Project.Geometry;

namespace Project.Controls.Panels;
public partial class CylinderPanel : BasePanel {
	public Vector3D CenterValue { get => this.CenterInput.Value; set => this.CenterInput.Value = value; }
	public float HeightValue { get => this.HeightInput.Value; set => this.HeightInput.Value = value; }
	public float RadiusValue { get => this.RadiusInput.Value; set => this.RadiusInput.Value = value; }

	public override event EventHandler? ValueChanged {
		add {
			this.CenterInput.ValueChanged += value;
			this.HeightInput.ValueChanged += value;
			this.RadiusInput.ValueChanged += value;
		}
		remove {
			this.CenterInput.ValueChanged -= value;
			this.HeightInput.ValueChanged -= value;
			this.RadiusInput.ValueChanged -= value;
		}
	}

	public CylinderPanel() {
		InitializeComponent();
	}
}
