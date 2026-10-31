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

partial class CylinderPanel {
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
		this.RadiusInput = new Inputs.FloatInput();
		this.HeightInput = new Inputs.FloatInput();
		this.CenterInput = new Inputs.Vector3DInput();
		this.SuspendLayout();
		// 
		// ObjectNameInput
		// 
		this.ObjectNameInput.Location = new System.Drawing.Point(3, 108);
		// 
		// DeleteButton
		// 
		this.DeleteButton.Location = new System.Drawing.Point(3, 140);
		// 
		// ColorButton
		// 
		this.ColorButton.Location = new System.Drawing.Point(84, 140);
		// 
		// SelectedColorPanel
		// 
		this.SelectedColorPanel.Location = new System.Drawing.Point(165, 140);
		// 
		// RadiusInput
		// 
		this.RadiusInput.AutoSize = true;
		this.RadiusInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.RadiusInput.InputName = "Yarıçap:";
		this.RadiusInput.Location = new System.Drawing.Point(3, 73);
		this.RadiusInput.MaxValue = new decimal(new int[] { -1, -1, -1, 0 });
		this.RadiusInput.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
		this.RadiusInput.Name = "RadiusInput";
		this.RadiusInput.Size = new System.Drawing.Size(160, 29);
		this.RadiusInput.TabIndex = 3;
		this.RadiusInput.Value = 0F;
		// 
		// HeightInput
		// 
		this.HeightInput.AutoSize = true;
		this.HeightInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.HeightInput.InputName = "Yükseklik:";
		this.HeightInput.Location = new System.Drawing.Point(3, 38);
		this.HeightInput.MaxValue = new decimal(new int[] { -1, -1, -1, 0 });
		this.HeightInput.MinValue = new decimal(new int[] { 0, 0, 0, 0 });
		this.HeightInput.Name = "HeightInput";
		this.HeightInput.Size = new System.Drawing.Size(171, 29);
		this.HeightInput.TabIndex = 4;
		this.HeightInput.Value = 0F;
		// 
		// CenterInput
		// 
		this.CenterInput.AutoSize = true;
		this.CenterInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.CenterInput.InputName = "Merkez:";
		this.CenterInput.Location = new System.Drawing.Point(3, 3);
		this.CenterInput.MaximumX = new decimal(new int[] { -1, -1, -1, 0 });
		this.CenterInput.MaximumY = new decimal(new int[] { -1, -1, -1, 0 });
		this.CenterInput.MaximumZ = new decimal(new int[] { -1, -1, -1, 0 });
		this.CenterInput.MinimumX = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.CenterInput.MinimumY = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.CenterInput.MinimumZ = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.CenterInput.Name = "CenterInput";
		this.CenterInput.Size = new System.Drawing.Size(441, 29);
		this.CenterInput.TabIndex = 5;
		this.CenterInput.XLabelText = "X:";
		this.CenterInput.YLabelText = "Y:";
		this.CenterInput.ZLabelText = "Z:";
		// 
		// CylinderPanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.CenterInput);
		this.Controls.Add(this.RadiusInput);
		this.Controls.Add(this.HeightInput);
		this.Name = "CylinderPanel";
		this.Size = new System.Drawing.Size(447, 166);
		this.Controls.SetChildIndex(this.ColorButton, 0);
		this.Controls.SetChildIndex(this.SelectedColorPanel, 0);
		this.Controls.SetChildIndex(this.HeightInput, 0);
		this.Controls.SetChildIndex(this.RadiusInput, 0);
		this.Controls.SetChildIndex(this.CenterInput, 0);
		this.Controls.SetChildIndex(this.ObjectNameInput, 0);
		this.Controls.SetChildIndex(this.DeleteButton, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Inputs.FloatInput RadiusInput;
	private Inputs.FloatInput HeightInput;
	private Inputs.Vector3DInput CenterInput;
}
