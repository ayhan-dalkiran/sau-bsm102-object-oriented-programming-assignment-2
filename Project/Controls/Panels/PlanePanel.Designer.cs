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

partial class PlanePanel {
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
		this.CenterInput = new Inputs.Vector3DInput();
		this.SizeInput = new Inputs.Vector2DInput();
		this.FaceAxisInput = new Inputs.FaceAxisInput();
		this.SuspendLayout();
		// 
		// ObjectNameInput
		// 
		this.ObjectNameInput.Location = new System.Drawing.Point(3, 104);
		// 
		// DeleteButton
		// 
		this.DeleteButton.Location = new System.Drawing.Point(3, 139);
		// 
		// ColorButton
		// 
		this.ColorButton.Location = new System.Drawing.Point(84, 139);
		// 
		// SelectedColorPanel
		// 
		this.SelectedColorPanel.Location = new System.Drawing.Point(165, 139);
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
		this.SizeInput.TabIndex = 7;
		this.SizeInput.XLabelText = "En:";
		this.SizeInput.YLabelText = "Boy:";
		// 
		// FaceAxisInput
		// 
		this.FaceAxisInput.AutoSize = true;
		this.FaceAxisInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.FaceAxisInput.InputName = "Yüzey Ekseni:";
		this.FaceAxisInput.Location = new System.Drawing.Point(3, 73);
		this.FaceAxisInput.Name = "FaceAxisInput";
		this.FaceAxisInput.Size = new System.Drawing.Size(197, 25);
		this.FaceAxisInput.TabIndex = 8;
		this.FaceAxisInput.Value = Geometry.FaceAxis.Z;
		// 
		// PlanePanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.CenterInput);
		this.Controls.Add(this.SizeInput);
		this.Controls.Add(this.FaceAxisInput);
		this.Name = "PlanePanel";
		this.Size = new System.Drawing.Size(447, 165);
		this.Controls.SetChildIndex(this.ColorButton, 0);
		this.Controls.SetChildIndex(this.SelectedColorPanel, 0);
		this.Controls.SetChildIndex(this.FaceAxisInput, 0);
		this.Controls.SetChildIndex(this.SizeInput, 0);
		this.Controls.SetChildIndex(this.CenterInput, 0);
		this.Controls.SetChildIndex(this.ObjectNameInput, 0);
		this.Controls.SetChildIndex(this.DeleteButton, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Inputs.Vector3DInput CenterInput;
	private Inputs.Vector2DInput SizeInput;
	private Inputs.FaceAxisInput FaceAxisInput;
}
