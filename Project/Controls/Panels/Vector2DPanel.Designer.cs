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

partial class Vector2DPanel {
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
		this.Vector2DInput = new Inputs.Vector2DInput();
		this.SuspendLayout();
		// 
		// ObjectNameInput
		// 
		this.ObjectNameInput.Location = new System.Drawing.Point(3, 38);
		// 
		// DeleteButton
		// 
		this.DeleteButton.Location = new System.Drawing.Point(3, 73);
		// 
		// ColorButton
		// 
		this.ColorButton.Enabled = false;
		this.ColorButton.Location = new System.Drawing.Point(84, 73);
		// 
		// SelectedColorPanel
		// 
		this.SelectedColorPanel.Location = new System.Drawing.Point(165, 73);
		// 
		// Vector2DInput
		// 
		this.Vector2DInput.AutoSize = true;
		this.Vector2DInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Vector2DInput.InputName = "Nokta:";
		this.Vector2DInput.Location = new System.Drawing.Point(3, 3);
		this.Vector2DInput.MaximumX = new decimal(new int[] { -1, -1, -1, 0 });
		this.Vector2DInput.MaximumY = new decimal(new int[] { -1, -1, -1, 0 });
		this.Vector2DInput.MinimumX = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.Vector2DInput.MinimumY = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.Vector2DInput.Name = "Vector2DInput";
		this.Vector2DInput.Size = new System.Drawing.Size(306, 29);
		this.Vector2DInput.TabIndex = 8;
		this.Vector2DInput.XLabelText = "X:";
		this.Vector2DInput.YLabelText = "Y:";
		// 
		// Vector2DPanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.Vector2DInput);
		this.Name = "Vector2DPanel";
		this.Size = new System.Drawing.Size(312, 99);
		this.Controls.SetChildIndex(this.ColorButton, 0);
		this.Controls.SetChildIndex(this.SelectedColorPanel, 0);
		this.Controls.SetChildIndex(this.ObjectNameInput, 0);
		this.Controls.SetChildIndex(this.DeleteButton, 0);
		this.Controls.SetChildIndex(this.Vector2DInput, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Inputs.Vector2DInput Vector2DInput;
}
