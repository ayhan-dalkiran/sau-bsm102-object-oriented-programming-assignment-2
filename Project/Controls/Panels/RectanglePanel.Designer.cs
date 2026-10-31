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
namespace Project.Controls.Panels;

partial class RectanglePanel {
	/// <summary> 
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.CenterInput = new Inputs.Vector2DInput();
		this.SizeInput = new Inputs.Vector2DInput();
		this.SuspendLayout();
		// 
		// ObjectNameInput
		// 
		this.ObjectNameInput.Location = new System.Drawing.Point(3, 73);
		// 
		// DeleteButton
		// 
		this.DeleteButton.Location = new System.Drawing.Point(3, 108);
		// 
		// ColorButton
		// 
		this.ColorButton.Location = new System.Drawing.Point(84, 108);
		// 
		// SelectedColorPanel
		// 
		this.SelectedColorPanel.Location = new System.Drawing.Point(165, 108);
		// 
		// CenterInput
		// 
		this.CenterInput.AutoSize = true;
		this.CenterInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.CenterInput.InputName = "Merkez:";
		this.CenterInput.Location = new System.Drawing.Point(3, 3);
		this.CenterInput.MaximumX = new decimal(new int[] { -1, -1, -1, 0 });
		this.CenterInput.MaximumY = new decimal(new int[] { -1, -1, -1, 0 });
		this.CenterInput.MinimumX = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.CenterInput.MinimumY = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.CenterInput.Name = "CenterInput";
		this.CenterInput.Size = new System.Drawing.Size(312, 29);
		this.CenterInput.TabIndex = 2;
		this.CenterInput.XLabelText = "X:";
		this.CenterInput.YLabelText = "Y:";
		// 
		// SizeInput
		// 
		this.SizeInput.AutoSize = true;
		this.SizeInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.SizeInput.InputName = "Boyut:";
		this.SizeInput.Location = new System.Drawing.Point(3, 38);
		this.SizeInput.MaximumX = new decimal(new int[] { -1, -1, -1, 0 });
		this.SizeInput.MaximumY = new decimal(new int[] { -1, -1, -1, 0 });
		this.SizeInput.MinimumX = new decimal(new int[] { 0, 0, 0, 0 });
		this.SizeInput.MinimumY = new decimal(new int[] { 0, 0, 0, 0 });
		this.SizeInput.Name = "SizeInput";
		this.SizeInput.Size = new System.Drawing.Size(324, 29);
		this.SizeInput.TabIndex = 3;
		this.SizeInput.XLabelText = "En:";
		this.SizeInput.YLabelText = "Boy:";
		// 
		// RectanglePanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.CenterInput);
		this.Controls.Add(this.SizeInput);
		this.Name = "RectanglePanel";
		this.Size = new System.Drawing.Size(330, 134);
		this.Controls.SetChildIndex(this.ColorButton, 0);
		this.Controls.SetChildIndex(this.SelectedColorPanel, 0);
		this.Controls.SetChildIndex(this.SizeInput, 0);
		this.Controls.SetChildIndex(this.CenterInput, 0);
		this.Controls.SetChildIndex(this.ObjectNameInput, 0);
		this.Controls.SetChildIndex(this.DeleteButton, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Inputs.Vector2DInput CenterInput;
	private Inputs.Vector2DInput SizeInput;
}
