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

namespace Project.Controls.Inputs;
public partial class FloatInput : UserControl {
	public string InputName { get => this.InputNameLabel.Text; set => this.InputNameLabel.Text = value; }

	public decimal MinValue { get => this.DecimalNumericUpDown.Minimum; set => this.DecimalNumericUpDown.Minimum = value; }
	public decimal MaxValue { get => this.DecimalNumericUpDown.Maximum; set => this.DecimalNumericUpDown.Maximum = value; }
	public float Value { get => (float)this.DecimalNumericUpDown.Value; set => this.DecimalNumericUpDown.Value = (decimal)value; }

	public event EventHandler ValueChanged { add => this.DecimalNumericUpDown.ValueChanged += value; remove => this.DecimalNumericUpDown.ValueChanged -= value; }

	public FloatInput() {
		InitializeComponent();
	}
}
