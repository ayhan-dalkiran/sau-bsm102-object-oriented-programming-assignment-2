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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controls.Panels;
public partial class BasePanel : UserControl {
	public string ObjectName { get => this.ObjectNameInput.Value; set => this.ObjectNameInput.Value = value; }
	public Color ObjectColor { get => SelectedColorPanel.BackColor; set => SelectedColorPanel.BackColor = value; }

	public event CancelEventHandler ObjectNameValidating { add => this.ObjectNameInput.ValueValidating += value; remove => this.ObjectNameInput.ValueValidating -= value; }
	public virtual event EventHandler? ValueChanged;
	public event EventHandler DeleteRequested { add => this.DeleteButton.Click += value; remove => this.DeleteButton.Click -= value; }
	public event EventHandler ObjectColorChanged { add => this.SelectedColorPanel.BackColorChanged += value; remove => this.SelectedColorPanel.BackColorChanged -= value; }

	public BasePanel() {
		InitializeComponent();
	}

	private void ColorButton_Click(object sender, EventArgs e) {
		if (this.ColorDialog.ShowDialog() == DialogResult.OK)
			ObjectColor = this.ColorDialog.Color;
	}
}
