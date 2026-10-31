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

partial class BasePanel {
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
		this.ObjectNameInput = new Inputs.StringInput();
		this.DeleteButton = new System.Windows.Forms.Button();
		this.ColorDialog = new System.Windows.Forms.ColorDialog();
		this.ColorButton = new System.Windows.Forms.Button();
		this.SelectedColorPanel = new System.Windows.Forms.Panel();
		this.SuspendLayout();
		// 
		// ObjectNameInput
		// 
		this.ObjectNameInput.AutoSize = true;
		this.ObjectNameInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.ObjectNameInput.InputName = "Nesne İsmi:";
		this.ObjectNameInput.Location = new System.Drawing.Point(3, 3);
		this.ObjectNameInput.Name = "ObjectNameInput";
		this.ObjectNameInput.Size = new System.Drawing.Size(180, 29);
		this.ObjectNameInput.TabIndex = 6;
		this.ObjectNameInput.Value = "";
		// 
		// DeleteButton
		// 
		this.DeleteButton.Location = new System.Drawing.Point(3, 38);
		this.DeleteButton.Name = "DeleteButton";
		this.DeleteButton.Size = new System.Drawing.Size(75, 23);
		this.DeleteButton.TabIndex = 7;
		this.DeleteButton.Text = "Sil";
		this.DeleteButton.UseVisualStyleBackColor = true;
		// 
		// ColorButton
		// 
		this.ColorButton.Location = new System.Drawing.Point(84, 38);
		this.ColorButton.Name = "ColorButton";
		this.ColorButton.Size = new System.Drawing.Size(75, 23);
		this.ColorButton.TabIndex = 8;
		this.ColorButton.Text = "Renk..";
		this.ColorButton.UseVisualStyleBackColor = true;
		this.ColorButton.Click += this.ColorButton_Click;
		// 
		// SelectedColorPanel
		// 
		this.SelectedColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.SelectedColorPanel.Location = new System.Drawing.Point(165, 38);
		this.SelectedColorPanel.Name = "SelectedColorPanel";
		this.SelectedColorPanel.Size = new System.Drawing.Size(23, 23);
		this.SelectedColorPanel.TabIndex = 9;
		// 
		// BasePanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoScroll = true;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Controls.Add(this.SelectedColorPanel);
		this.Controls.Add(this.ColorButton);
		this.Controls.Add(this.DeleteButton);
		this.Controls.Add(this.ObjectNameInput);
		this.Name = "BasePanel";
		this.Size = new System.Drawing.Size(191, 64);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	protected Inputs.StringInput ObjectNameInput;
	protected System.Windows.Forms.Button DeleteButton;
	private System.Windows.Forms.ColorDialog ColorDialog;
	protected System.Windows.Forms.Button ColorButton;
	protected System.Windows.Forms.Panel SelectedColorPanel;
}
