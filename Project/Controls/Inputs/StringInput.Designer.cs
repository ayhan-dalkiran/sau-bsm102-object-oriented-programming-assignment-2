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
namespace Project.Controls.Inputs;

partial class StringInput {
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
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		this.InputNameLabel = new System.Windows.Forms.Label();
		this.StringTextBox = new System.Windows.Forms.TextBox();
		tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		tableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.AutoSize = true;
		tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		tableLayoutPanel1.ColumnCount = 2;
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.Controls.Add(this.InputNameLabel, 0, 0);
		tableLayoutPanel1.Controls.Add(this.StringTextBox, 1, 0);
		tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 1;
		tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
		tableLayoutPanel1.Size = new System.Drawing.Size(181, 29);
		tableLayoutPanel1.TabIndex = 0;
		// 
		// InputNameLabel
		// 
		this.InputNameLabel.AutoSize = true;
		this.InputNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.InputNameLabel.Location = new System.Drawing.Point(3, 0);
		this.InputNameLabel.Name = "InputNameLabel";
		this.InputNameLabel.Size = new System.Drawing.Size(69, 29);
		this.InputNameLabel.TabIndex = 0;
		this.InputNameLabel.Text = "StringInput:";
		this.InputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// StringTextBox
		// 
		this.StringTextBox.Location = new System.Drawing.Point(78, 3);
		this.StringTextBox.Name = "StringTextBox";
		this.StringTextBox.Size = new System.Drawing.Size(100, 23);
		this.StringTextBox.TabIndex = 1;
		this.StringTextBox.KeyPress += this.StringTextBox_KeyPress;
		// 
		// StringInput
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Controls.Add(tableLayoutPanel1);
		this.Name = "StringInput";
		this.Size = new System.Drawing.Size(181, 29);
		tableLayoutPanel1.ResumeLayout(false);
		tableLayoutPanel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.Label InputNameLabel;
	private System.Windows.Forms.TextBox StringTextBox;
}
