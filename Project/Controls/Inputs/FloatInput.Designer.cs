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

partial class FloatInput {
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
		this.DecimalNumericUpDown = new System.Windows.Forms.NumericUpDown();
		tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		tableLayoutPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DecimalNumericUpDown).BeginInit();
		this.SuspendLayout();
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.AutoSize = true;
		tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		tableLayoutPanel1.ColumnCount = 2;
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
		tableLayoutPanel1.Controls.Add(this.InputNameLabel, 0, 0);
		tableLayoutPanel1.Controls.Add(this.DecimalNumericUpDown, 1, 0);
		tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 1;
		tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
		tableLayoutPanel1.Size = new System.Drawing.Size(176, 29);
		tableLayoutPanel1.TabIndex = 0;
		// 
		// InputNameLabel
		// 
		this.InputNameLabel.AutoSize = true;
		this.InputNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.InputNameLabel.Location = new System.Drawing.Point(3, 0);
		this.InputNameLabel.Name = "InputNameLabel";
		this.InputNameLabel.Size = new System.Drawing.Size(64, 29);
		this.InputNameLabel.TabIndex = 0;
		this.InputNameLabel.Text = "FloatInput:";
		this.InputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// DecimalNumericUpDown
		// 
		this.DecimalNumericUpDown.DecimalPlaces = 2;
		this.DecimalNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
		this.DecimalNumericUpDown.Location = new System.Drawing.Point(73, 3);
		this.DecimalNumericUpDown.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
		this.DecimalNumericUpDown.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.DecimalNumericUpDown.Name = "DecimalNumericUpDown";
		this.DecimalNumericUpDown.Size = new System.Drawing.Size(100, 23);
		this.DecimalNumericUpDown.TabIndex = 4;
		// 
		// FloatInput
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Controls.Add(tableLayoutPanel1);
		this.Name = "FloatInput";
		this.Size = new System.Drawing.Size(176, 29);
		tableLayoutPanel1.ResumeLayout(false);
		tableLayoutPanel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DecimalNumericUpDown).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.Label InputNameLabel;
	private System.Windows.Forms.NumericUpDown DecimalNumericUpDown;
}
