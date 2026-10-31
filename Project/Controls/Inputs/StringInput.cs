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
using System.Windows.Forms;

namespace Project.Controls.Inputs;
public partial class StringInput : UserControl {
	public string InputName { get => this.InputNameLabel.Text; set => this.InputNameLabel.Text = value; }

	public string Value { get => this.StringTextBox.Text; set => this.StringTextBox.Text = value; }

	public event CancelEventHandler ValueValidating { add => this.StringTextBox.Validating += value; remove => this.StringTextBox.Validating -= value; }
	public event EventHandler ValueChanged { add => this.StringTextBox.TextChanged += value; remove => this.StringTextBox.TextChanged -= value; }

	public StringInput() {
		InitializeComponent();
	}

	private void StringTextBox_KeyPress(object sender, KeyPressEventArgs e) {
		if (e.KeyChar == (char)Keys.Return && this.ParentForm is not null && this.Validate())
			this.ParentForm.ActiveControl = null;
	}
}
