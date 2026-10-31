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

partial class Vector2DInput {
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
		this.XNumericUpDown = new System.Windows.Forms.NumericUpDown();
		this.XLabel = new System.Windows.Forms.Label();
		this.InputNameLabel = new System.Windows.Forms.Label();
		this.YLabel = new System.Windows.Forms.Label();
		this.YNumericUpDown = new System.Windows.Forms.NumericUpDown();
		tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		tableLayoutPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.XNumericUpDown).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.YNumericUpDown).BeginInit();
		this.SuspendLayout();
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.AutoSize = true;
		tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		tableLayoutPanel1.ColumnCount = 5;
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		tableLayoutPanel1.Controls.Add(this.XNumericUpDown, 2, 0);
		tableLayoutPanel1.Controls.Add(this.XLabel, 1, 0);
		tableLayoutPanel1.Controls.Add(this.InputNameLabel, 0, 0);
		tableLayoutPanel1.Controls.Add(this.YLabel, 3, 0);
		tableLayoutPanel1.Controls.Add(this.YNumericUpDown, 4, 0);
		tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 1;
		tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
		tableLayoutPanel1.Size = new System.Drawing.Size(349, 29);
		tableLayoutPanel1.TabIndex = 0;
		// 
		// XNumericUpDown
		// 
		this.XNumericUpDown.DecimalPlaces = 2;
		this.XNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
		this.XNumericUpDown.Location = new System.Drawing.Point(117, 3);
		this.XNumericUpDown.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
		this.XNumericUpDown.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.XNumericUpDown.Name = "XNumericUpDown";
		this.XNumericUpDown.Size = new System.Drawing.Size(100, 23);
		this.XNumericUpDown.TabIndex = 1;
		// 
		// XLabel
		// 
		this.XLabel.AutoSize = true;
		this.XLabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.XLabel.Location = new System.Drawing.Point(94, 0);
		this.XLabel.Name = "XLabel";
		this.XLabel.Size = new System.Drawing.Size(17, 29);
		this.XLabel.TabIndex = 2;
		this.XLabel.Text = "X:";
		this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// InputNameLabel
		// 
		this.InputNameLabel.AutoSize = true;
		this.InputNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.InputNameLabel.Location = new System.Drawing.Point(3, 0);
		this.InputNameLabel.Name = "InputNameLabel";
		this.InputNameLabel.Size = new System.Drawing.Size(85, 29);
		this.InputNameLabel.TabIndex = 0;
		this.InputNameLabel.Text = "Vector2DInput:";
		this.InputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// YLabel
		// 
		this.YLabel.AutoSize = true;
		this.YLabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.YLabel.Location = new System.Drawing.Point(223, 0);
		this.YLabel.Name = "YLabel";
		this.YLabel.Size = new System.Drawing.Size(17, 29);
		this.YLabel.TabIndex = 3;
		this.YLabel.Text = "Y:";
		this.YLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// YNumericUpDown
		// 
		this.YNumericUpDown.DecimalPlaces = 2;
		this.YNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
		this.YNumericUpDown.Location = new System.Drawing.Point(246, 3);
		this.YNumericUpDown.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
		this.YNumericUpDown.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
		this.YNumericUpDown.Name = "YNumericUpDown";
		this.YNumericUpDown.Size = new System.Drawing.Size(100, 23);
		this.YNumericUpDown.TabIndex = 4;
		// 
		// Vector2DInput
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.Controls.Add(tableLayoutPanel1);
		this.Name = "Vector2DInput";
		this.Size = new System.Drawing.Size(349, 29);
		tableLayoutPanel1.ResumeLayout(false);
		tableLayoutPanel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.XNumericUpDown).EndInit();
		((System.ComponentModel.ISupportInitialize)this.YNumericUpDown).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.Label InputNameLabel;
	private System.Windows.Forms.NumericUpDown XNumericUpDown;
	private System.Windows.Forms.Label XLabel;
	private System.Windows.Forms.Label YLabel;
	private System.Windows.Forms.NumericUpDown YNumericUpDown;
}
