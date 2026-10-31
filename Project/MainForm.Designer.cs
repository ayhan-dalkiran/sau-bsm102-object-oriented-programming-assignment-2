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
using System.Windows.Forms;

namespace Project;

partial class MainForm {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		this.tabControl1 = new TabControl();
		this.tabPage1 = new TabPage();
		this.splitContainer1 = new SplitContainer();
		this.splitContainer2 = new SplitContainer();
		this.groupBox1 = new GroupBox();
		this.tableLayoutPanel1 = new TableLayoutPanel();
		this.toolStrip2 = new ToolStrip();
		this.toolStripDropDownButton2 = new ToolStripDropDownButton();
		this.newCircleButton = new ToolStripMenuItem();
		this.newRectangleButton = new ToolStripMenuItem();
		this.newVector2DButton = new ToolStripMenuItem();
		this.Properties2DTab = new TabControl();
		this.groupBox2 = new GroupBox();
		this.CollisionTable2D = new DataGridView();
		this.tableLayoutPanel4 = new TableLayoutPanel();
		this.label1 = new Label();
		this.pictureBox3 = new PictureBox();
		this.label3 = new Label();
		this.pictureBox4 = new PictureBox();
		this.pictureBox5 = new PictureBox();
		this.label2 = new Label();
		this.groupBox3 = new GroupBox();
		this.Viewport2D = new PictureBox();
		this.tabPage2 = new TabPage();
		this.splitContainer3 = new SplitContainer();
		this.splitContainer4 = new SplitContainer();
		this.groupBox4 = new GroupBox();
		this.tableLayoutPanel2 = new TableLayoutPanel();
		this.toolStrip1 = new ToolStrip();
		this.toolStripDropDownButton1 = new ToolStripDropDownButton();
		this.newCylinderButton = new ToolStripMenuItem();
		this.newPlaneButton = new ToolStripMenuItem();
		this.newRectangularPrismButton = new ToolStripMenuItem();
		this.newSphereButton = new ToolStripMenuItem();
		this.newVector3DButton = new ToolStripMenuItem();
		this.Properties3DTab = new TabControl();
		this.groupBox5 = new GroupBox();
		this.CollisionTable3D = new DataGridView();
		this.tableLayoutPanel3 = new TableLayoutPanel();
		this.label4 = new Label();
		this.pictureBox6 = new PictureBox();
		this.label5 = new Label();
		this.pictureBox7 = new PictureBox();
		this.pictureBox8 = new PictureBox();
		this.label6 = new Label();
		this.groupBox6 = new GroupBox();
		this.Viewport3D = new PictureBox();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
		this.splitContainer2.Panel1.SuspendLayout();
		this.splitContainer2.Panel2.SuspendLayout();
		this.splitContainer2.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tableLayoutPanel1.SuspendLayout();
		this.toolStrip2.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CollisionTable2D).BeginInit();
		this.tableLayoutPanel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Viewport2D).BeginInit();
		this.tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
		this.splitContainer3.Panel1.SuspendLayout();
		this.splitContainer3.Panel2.SuspendLayout();
		this.splitContainer3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer4).BeginInit();
		this.splitContainer4.Panel1.SuspendLayout();
		this.splitContainer4.Panel2.SuspendLayout();
		this.splitContainer4.SuspendLayout();
		this.groupBox4.SuspendLayout();
		this.tableLayoutPanel2.SuspendLayout();
		this.toolStrip1.SuspendLayout();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CollisionTable3D).BeginInit();
		this.tableLayoutPanel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox8).BeginInit();
		this.groupBox6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Viewport3D).BeginInit();
		this.SuspendLayout();
		// 
		// tabControl1
		// 
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Dock = DockStyle.Fill;
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(1161, 545);
		this.tabControl1.TabIndex = 2;
		// 
		// tabPage1
		// 
		this.tabPage1.Controls.Add(this.splitContainer1);
		this.tabPage1.Location = new System.Drawing.Point(4, 24);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(1153, 517);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "2 Boyutlu Çarpışmalar";
		this.tabPage1.UseVisualStyleBackColor = true;
		// 
		// splitContainer1
		// 
		this.splitContainer1.Dock = DockStyle.Fill;
		this.splitContainer1.Location = new System.Drawing.Point(3, 3);
		this.splitContainer1.Name = "splitContainer1";
		// 
		// splitContainer1.Panel1
		// 
		this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
		// 
		// splitContainer1.Panel2
		// 
		this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
		this.splitContainer1.Size = new System.Drawing.Size(1147, 511);
		this.splitContainer1.SplitterDistance = 544;
		this.splitContainer1.TabIndex = 0;
		// 
		// splitContainer2
		// 
		this.splitContainer2.Dock = DockStyle.Fill;
		this.splitContainer2.Location = new System.Drawing.Point(0, 0);
		this.splitContainer2.Name = "splitContainer2";
		this.splitContainer2.Orientation = Orientation.Horizontal;
		// 
		// splitContainer2.Panel1
		// 
		this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
		// 
		// splitContainer2.Panel2
		// 
		this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
		this.splitContainer2.Size = new System.Drawing.Size(544, 511);
		this.splitContainer2.SplitterDistance = 290;
		this.splitContainer2.TabIndex = 0;
		// 
		// groupBox1
		// 
		this.groupBox1.Controls.Add(this.tableLayoutPanel1);
		this.groupBox1.Dock = DockStyle.Fill;
		this.groupBox1.Location = new System.Drawing.Point(0, 0);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(544, 290);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Nesneler";
		// 
		// tableLayoutPanel1
		// 
		this.tableLayoutPanel1.ColumnCount = 1;
		this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.Properties2DTab, 0, 0);
		this.tableLayoutPanel1.Dock = DockStyle.Fill;
		this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 2;
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 268);
		this.tableLayoutPanel1.TabIndex = 0;
		// 
		// toolStrip2
		// 
		this.toolStrip2.Items.AddRange(new ToolStripItem[] { this.toolStripDropDownButton2 });
		this.toolStrip2.Location = new System.Drawing.Point(0, 243);
		this.toolStrip2.Name = "toolStrip2";
		this.toolStrip2.Size = new System.Drawing.Size(538, 25);
		this.toolStrip2.TabIndex = 0;
		this.toolStrip2.Text = "toolStrip2";
		// 
		// toolStripDropDownButton2
		// 
		this.toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
		this.toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { this.newCircleButton, this.newRectangleButton, this.newVector2DButton });
		this.toolStripDropDownButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton2.Image");
		this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
		this.toolStripDropDownButton2.Size = new System.Drawing.Size(48, 22);
		this.toolStripDropDownButton2.Text = "Yeni..";
		// 
		// newCircleButton
		// 
		this.newCircleButton.Name = "newCircleButton";
		this.newCircleButton.Size = new System.Drawing.Size(133, 22);
		this.newCircleButton.Text = "Daire";
		this.newCircleButton.Click += this.newCircleButton_Click;
		// 
		// newRectangleButton
		// 
		this.newRectangleButton.Name = "newRectangleButton";
		this.newRectangleButton.Size = new System.Drawing.Size(133, 22);
		this.newRectangleButton.Text = "Dikdörtgen";
		this.newRectangleButton.Click += this.newRectangleButton_Click;
		// 
		// newVector2DButton
		// 
		this.newVector2DButton.Name = "newVector2DButton";
		this.newVector2DButton.Size = new System.Drawing.Size(133, 22);
		this.newVector2DButton.Text = "Nokta";
		this.newVector2DButton.Click += this.newVector2DButton_Click;
		// 
		// Properties2DTab
		// 
		this.Properties2DTab.Dock = DockStyle.Fill;
		this.Properties2DTab.Location = new System.Drawing.Point(3, 3);
		this.Properties2DTab.Name = "Properties2DTab";
		this.Properties2DTab.SelectedIndex = 0;
		this.Properties2DTab.Size = new System.Drawing.Size(532, 237);
		this.Properties2DTab.TabIndex = 1;
		// 
		// groupBox2
		// 
		this.groupBox2.Controls.Add(this.CollisionTable2D);
		this.groupBox2.Controls.Add(this.tableLayoutPanel4);
		this.groupBox2.Dock = DockStyle.Fill;
		this.groupBox2.Location = new System.Drawing.Point(0, 0);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(544, 217);
		this.groupBox2.TabIndex = 0;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Çarpışma Tablosu";
		// 
		// CollisionTable2D
		// 
		this.CollisionTable2D.AllowUserToAddRows = false;
		this.CollisionTable2D.AllowUserToDeleteRows = false;
		this.CollisionTable2D.AllowUserToOrderColumns = true;
		this.CollisionTable2D.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.CollisionTable2D.Dock = DockStyle.Fill;
		this.CollisionTable2D.Location = new System.Drawing.Point(3, 19);
		this.CollisionTable2D.Name = "CollisionTable2D";
		this.CollisionTable2D.ReadOnly = true;
		this.CollisionTable2D.Size = new System.Drawing.Size(538, 176);
		this.CollisionTable2D.TabIndex = 0;
		// 
		// tableLayoutPanel4
		// 
		this.tableLayoutPanel4.ColumnCount = 6;
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
		this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 1, 0);
		this.tableLayoutPanel4.Controls.Add(this.label3, 4, 0);
		this.tableLayoutPanel4.Controls.Add(this.pictureBox4, 3, 0);
		this.tableLayoutPanel4.Controls.Add(this.pictureBox5, 5, 0);
		this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
		this.tableLayoutPanel4.Dock = DockStyle.Bottom;
		this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 195);
		this.tableLayoutPanel4.Name = "tableLayoutPanel4";
		this.tableLayoutPanel4.RowCount = 1;
		this.tableLayoutPanel4.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 19);
		this.tableLayoutPanel4.TabIndex = 1;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(79, 15);
		this.label1.TabIndex = 0;
		this.label1.Text = "Çarpışma Var:";
		// 
		// pictureBox3
		// 
		this.pictureBox3.BackColor = System.Drawing.Color.Green;
		this.pictureBox3.Location = new System.Drawing.Point(88, 3);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new System.Drawing.Size(24, 12);
		this.pictureBox3.TabIndex = 1;
		this.pictureBox3.TabStop = false;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(236, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(32, 15);
		this.label3.TabIndex = 3;
		this.label3.Text = "N/A:";
		// 
		// pictureBox4
		// 
		this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
		this.pictureBox4.Location = new System.Drawing.Point(206, 3);
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.Size = new System.Drawing.Size(24, 12);
		this.pictureBox4.TabIndex = 4;
		this.pictureBox4.TabStop = false;
		// 
		// pictureBox5
		// 
		this.pictureBox5.BackColor = System.Drawing.Color.Gray;
		this.pictureBox5.Location = new System.Drawing.Point(274, 3);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new System.Drawing.Size(24, 12);
		this.pictureBox5.TabIndex = 5;
		this.pictureBox5.TabStop = false;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(118, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(82, 15);
		this.label2.TabIndex = 2;
		this.label2.Text = "Çarpışma Yok:";
		// 
		// groupBox3
		// 
		this.groupBox3.Controls.Add(this.Viewport2D);
		this.groupBox3.Dock = DockStyle.Fill;
		this.groupBox3.Location = new System.Drawing.Point(0, 0);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(599, 511);
		this.groupBox3.TabIndex = 0;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Viewport";
		// 
		// Viewport2D
		// 
		this.Viewport2D.BorderStyle = BorderStyle.FixedSingle;
		this.Viewport2D.Dock = DockStyle.Fill;
		this.Viewport2D.Location = new System.Drawing.Point(3, 19);
		this.Viewport2D.Name = "Viewport2D";
		this.Viewport2D.Size = new System.Drawing.Size(593, 489);
		this.Viewport2D.TabIndex = 0;
		this.Viewport2D.TabStop = false;
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.Add(this.splitContainer3);
		this.tabPage2.Location = new System.Drawing.Point(4, 24);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(1153, 517);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "3 Boyutlu Çarpışmalar";
		this.tabPage2.UseVisualStyleBackColor = true;
		// 
		// splitContainer3
		// 
		this.splitContainer3.Dock = DockStyle.Fill;
		this.splitContainer3.Location = new System.Drawing.Point(3, 3);
		this.splitContainer3.Name = "splitContainer3";
		// 
		// splitContainer3.Panel1
		// 
		this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
		// 
		// splitContainer3.Panel2
		// 
		this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
		this.splitContainer3.Size = new System.Drawing.Size(1147, 511);
		this.splitContainer3.SplitterDistance = 497;
		this.splitContainer3.TabIndex = 0;
		// 
		// splitContainer4
		// 
		this.splitContainer4.Dock = DockStyle.Fill;
		this.splitContainer4.Location = new System.Drawing.Point(0, 0);
		this.splitContainer4.Name = "splitContainer4";
		this.splitContainer4.Orientation = Orientation.Horizontal;
		// 
		// splitContainer4.Panel1
		// 
		this.splitContainer4.Panel1.Controls.Add(this.groupBox4);
		// 
		// splitContainer4.Panel2
		// 
		this.splitContainer4.Panel2.Controls.Add(this.groupBox5);
		this.splitContainer4.Size = new System.Drawing.Size(497, 511);
		this.splitContainer4.SplitterDistance = 309;
		this.splitContainer4.TabIndex = 0;
		// 
		// groupBox4
		// 
		this.groupBox4.Controls.Add(this.tableLayoutPanel2);
		this.groupBox4.Dock = DockStyle.Fill;
		this.groupBox4.Location = new System.Drawing.Point(0, 0);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(497, 309);
		this.groupBox4.TabIndex = 0;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Nesneler";
		// 
		// tableLayoutPanel2
		// 
		this.tableLayoutPanel2.ColumnCount = 1;
		this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 1);
		this.tableLayoutPanel2.Controls.Add(this.Properties3DTab, 0, 0);
		this.tableLayoutPanel2.Dock = DockStyle.Fill;
		this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
		this.tableLayoutPanel2.Name = "tableLayoutPanel2";
		this.tableLayoutPanel2.RowCount = 2;
		this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		this.tableLayoutPanel2.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel2.Size = new System.Drawing.Size(491, 287);
		this.tableLayoutPanel2.TabIndex = 1;
		// 
		// toolStrip1
		// 
		this.toolStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripDropDownButton1 });
		this.toolStrip1.Location = new System.Drawing.Point(0, 262);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(491, 25);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		// 
		// toolStripDropDownButton1
		// 
		this.toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
		this.toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { this.newCylinderButton, this.newPlaneButton, this.newRectangularPrismButton, this.newSphereButton, this.newVector3DButton });
		this.toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
		this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
		this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
		this.toolStripDropDownButton1.Text = "Yeni..";
		// 
		// newCylinderButton
		// 
		this.newCylinderButton.Name = "newCylinderButton";
		this.newCylinderButton.Size = new System.Drawing.Size(180, 22);
		this.newCylinderButton.Text = "Silindir";
		this.newCylinderButton.Click += this.newCylinderButton_Click;
		// 
		// newPlaneButton
		// 
		this.newPlaneButton.Name = "newPlaneButton";
		this.newPlaneButton.Size = new System.Drawing.Size(180, 22);
		this.newPlaneButton.Text = "Yüzey";
		this.newPlaneButton.Click += this.newPlaneButton_Click;
		// 
		// newRectangularPrismButton
		// 
		this.newRectangularPrismButton.Name = "newRectangularPrismButton";
		this.newRectangularPrismButton.Size = new System.Drawing.Size(180, 22);
		this.newRectangularPrismButton.Text = "Dikdörtgen Prizması";
		this.newRectangularPrismButton.Click += this.newRectangularPrismButton_Click;
		// 
		// newSphereButton
		// 
		this.newSphereButton.Name = "newSphereButton";
		this.newSphereButton.Size = new System.Drawing.Size(180, 22);
		this.newSphereButton.Text = "Küre";
		this.newSphereButton.Click += this.newSphereButton_Click;
		// 
		// newVector3DButton
		// 
		this.newVector3DButton.Name = "newVector3DButton";
		this.newVector3DButton.Size = new System.Drawing.Size(180, 22);
		this.newVector3DButton.Text = "Nokta";
		this.newVector3DButton.Click += this.newVector3DButton_Click;
		// 
		// Properties3DTab
		// 
		this.Properties3DTab.Dock = DockStyle.Fill;
		this.Properties3DTab.Location = new System.Drawing.Point(3, 3);
		this.Properties3DTab.Name = "Properties3DTab";
		this.Properties3DTab.SelectedIndex = 0;
		this.Properties3DTab.Size = new System.Drawing.Size(485, 256);
		this.Properties3DTab.TabIndex = 1;
		// 
		// groupBox5
		// 
		this.groupBox5.Controls.Add(this.CollisionTable3D);
		this.groupBox5.Controls.Add(this.tableLayoutPanel3);
		this.groupBox5.Dock = DockStyle.Fill;
		this.groupBox5.Location = new System.Drawing.Point(0, 0);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(497, 198);
		this.groupBox5.TabIndex = 1;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Çarpışma Tablosu";
		// 
		// CollisionTable3D
		// 
		this.CollisionTable3D.AllowUserToAddRows = false;
		this.CollisionTable3D.AllowUserToDeleteRows = false;
		this.CollisionTable3D.AllowUserToOrderColumns = true;
		this.CollisionTable3D.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.CollisionTable3D.Dock = DockStyle.Fill;
		this.CollisionTable3D.Location = new System.Drawing.Point(3, 19);
		this.CollisionTable3D.Name = "CollisionTable3D";
		this.CollisionTable3D.ReadOnly = true;
		this.CollisionTable3D.Size = new System.Drawing.Size(491, 157);
		this.CollisionTable3D.TabIndex = 0;
		// 
		// tableLayoutPanel3
		// 
		this.tableLayoutPanel3.ColumnCount = 6;
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
		this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
		this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 1, 0);
		this.tableLayoutPanel3.Controls.Add(this.label5, 4, 0);
		this.tableLayoutPanel3.Controls.Add(this.pictureBox7, 3, 0);
		this.tableLayoutPanel3.Controls.Add(this.pictureBox8, 5, 0);
		this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
		this.tableLayoutPanel3.Dock = DockStyle.Bottom;
		this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 176);
		this.tableLayoutPanel3.Name = "tableLayoutPanel3";
		this.tableLayoutPanel3.RowCount = 1;
		this.tableLayoutPanel3.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel3.Size = new System.Drawing.Size(491, 19);
		this.tableLayoutPanel3.TabIndex = 1;
		// 
		// label4
		// 
		this.label4.AutoSize = true;
		this.label4.Dock = DockStyle.Fill;
		this.label4.Location = new System.Drawing.Point(3, 0);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(79, 19);
		this.label4.TabIndex = 0;
		this.label4.Text = "Çarpışma Var:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// pictureBox6
		// 
		this.pictureBox6.BackColor = System.Drawing.Color.Green;
		this.pictureBox6.Location = new System.Drawing.Point(88, 3);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new System.Drawing.Size(24, 12);
		this.pictureBox6.TabIndex = 1;
		this.pictureBox6.TabStop = false;
		// 
		// label5
		// 
		this.label5.AutoSize = true;
		this.label5.Dock = DockStyle.Fill;
		this.label5.Location = new System.Drawing.Point(236, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(32, 19);
		this.label5.TabIndex = 3;
		this.label5.Text = "N/A:";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// pictureBox7
		// 
		this.pictureBox7.BackColor = System.Drawing.Color.Maroon;
		this.pictureBox7.Location = new System.Drawing.Point(206, 3);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new System.Drawing.Size(24, 12);
		this.pictureBox7.TabIndex = 4;
		this.pictureBox7.TabStop = false;
		// 
		// pictureBox8
		// 
		this.pictureBox8.BackColor = System.Drawing.Color.Gray;
		this.pictureBox8.Location = new System.Drawing.Point(274, 3);
		this.pictureBox8.Name = "pictureBox8";
		this.pictureBox8.Size = new System.Drawing.Size(24, 12);
		this.pictureBox8.TabIndex = 5;
		this.pictureBox8.TabStop = false;
		// 
		// label6
		// 
		this.label6.AutoSize = true;
		this.label6.Dock = DockStyle.Fill;
		this.label6.Location = new System.Drawing.Point(118, 0);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(82, 19);
		this.label6.TabIndex = 2;
		this.label6.Text = "Çarpışma Yok:";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// groupBox6
		// 
		this.groupBox6.Controls.Add(this.Viewport3D);
		this.groupBox6.Dock = DockStyle.Fill;
		this.groupBox6.Location = new System.Drawing.Point(0, 0);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(646, 511);
		this.groupBox6.TabIndex = 0;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Viewport";
		// 
		// Viewport3D
		// 
		this.Viewport3D.BorderStyle = BorderStyle.FixedSingle;
		this.Viewport3D.Dock = DockStyle.Fill;
		this.Viewport3D.Location = new System.Drawing.Point(3, 19);
		this.Viewport3D.Name = "Viewport3D";
		this.Viewport3D.Size = new System.Drawing.Size(640, 489);
		this.Viewport3D.TabIndex = 0;
		this.Viewport3D.TabStop = false;
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(1161, 545);
		this.Controls.Add(this.tabControl1);
		this.Name = "MainForm";
		this.Text = "Çarpışma Kontrol Programı";
		this.ResizeEnd += this.MainForm_ResizeEnd;
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.splitContainer2.Panel1.ResumeLayout(false);
		this.splitContainer2.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
		this.splitContainer2.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.toolStrip2.ResumeLayout(false);
		this.toolStrip2.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.CollisionTable2D).EndInit();
		this.tableLayoutPanel4.ResumeLayout(false);
		this.tableLayoutPanel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
		this.groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.Viewport2D).EndInit();
		this.tabPage2.ResumeLayout(false);
		this.splitContainer3.Panel1.ResumeLayout(false);
		this.splitContainer3.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
		this.splitContainer3.ResumeLayout(false);
		this.splitContainer4.Panel1.ResumeLayout(false);
		this.splitContainer4.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer4).EndInit();
		this.splitContainer4.ResumeLayout(false);
		this.groupBox4.ResumeLayout(false);
		this.tableLayoutPanel2.ResumeLayout(false);
		this.tableLayoutPanel2.PerformLayout();
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		this.groupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.CollisionTable3D).EndInit();
		this.tableLayoutPanel3.ResumeLayout(false);
		this.tableLayoutPanel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox8).EndInit();
		this.groupBox6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.Viewport3D).EndInit();
		this.ResumeLayout(false);
	}

	#endregion
	private TabControl tabControl1;
	private TabPage tabPage1;
	private TabPage tabPage2;
	private SplitContainer splitContainer1;
	private SplitContainer splitContainer2;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private GroupBox groupBox3;
	private SplitContainer splitContainer3;
	private SplitContainer splitContainer4;
	private GroupBox groupBox4;
	private GroupBox groupBox6;
	private PictureBox Viewport2D;
	private PictureBox Viewport3D;
	private TableLayoutPanel tableLayoutPanel1;
	private ToolStrip toolStrip2;
	private TabControl Properties2DTab;
	private DataGridView CollisionTable2D;
	private TableLayoutPanel tableLayoutPanel4;
	private Label label1;
	private PictureBox pictureBox3;
	private TableLayoutPanel tableLayoutPanel2;
	private ToolStrip toolStrip1;
	private TabControl Properties3DTab;
	private Label label2;
	private Label label3;
	private PictureBox pictureBox4;
	private PictureBox pictureBox5;
	private GroupBox groupBox5;
	private DataGridView CollisionTable3D;
	private TableLayoutPanel tableLayoutPanel3;
	private Label label4;
	private PictureBox pictureBox6;
	private Label label5;
	private PictureBox pictureBox7;
	private PictureBox pictureBox8;
	private Label label6;
	private ToolStripDropDownButton toolStripDropDownButton2;
	private ToolStripMenuItem newCircleButton;
	private ToolStripMenuItem newRectangleButton;
	private ToolStripDropDownButton toolStripDropDownButton1;
	private ToolStripMenuItem newCylinderButton;
	private ToolStripMenuItem newPlaneButton;
	private ToolStripMenuItem newRectangularPrismButton;
	private ToolStripMenuItem newSphereButton;
	private ToolStripMenuItem newVector2DButton;
	private ToolStripMenuItem newVector3DButton;
}
