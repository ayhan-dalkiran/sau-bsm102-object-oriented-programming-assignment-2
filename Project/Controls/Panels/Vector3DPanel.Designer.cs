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

partial class Vector3DPanel {
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
		this.Vector3DInput = new Inputs.Vector3DInput();
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
		// Vector3DInput
		// 
		this.Vector3DInput.AutoSize = true;
		this.Vector3DInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Vector3DInput.InputName = "Nokta:";
		this.Vector3DInput.Location = new System.Drawing.Point(3, 3);
		this.Vector3DInput.MaximumX = new decimal(new int[] { -1, -1, -1, 0 });
		this.Vector3DInput.MaximumY = new decimal(new int[] { -1, -1, -1, 0 });
		this.Vector3DInput.MaximumZ = new decimal(new int[] { -1, -1, -1, 0 });
		this.Vector3DInput.MinimumX = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.Vector3DInput.MinimumY = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.Vector3DInput.MinimumZ = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.Vector3DInput.Name = "Vector3DInput";
		this.Vector3DInput.Size = new System.Drawing.Size(435, 29);
		this.Vector3DInput.TabIndex = 8;
		this.Vector3DInput.XLabelText = "X:";
		this.Vector3DInput.YLabelText = "Y:";
		this.Vector3DInput.ZLabelText = "Z:";
		// 
		// Vector3DPanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.Vector3DInput);
		this.Name = "Vector3DPanel";
		this.Size = new System.Drawing.Size(441, 99);
		this.Controls.SetChildIndex(this.ColorButton, 0);
		this.Controls.SetChildIndex(this.SelectedColorPanel, 0);
		this.Controls.SetChildIndex(this.ObjectNameInput, 0);
		this.Controls.SetChildIndex(this.DeleteButton, 0);
		this.Controls.SetChildIndex(this.Vector3DInput, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private Inputs.Vector3DInput Vector3DInput;

	#endregion
}
