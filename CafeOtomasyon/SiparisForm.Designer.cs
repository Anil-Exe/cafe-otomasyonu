
namespace CafeOtomasyon
{
    partial class SiparisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKategoriler = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAdisyon = new System.Windows.Forms.Panel();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.pnlUrunler.SuspendLayout();
            this.pnlAdisyon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ EKRANI";
            // 
            // pnlKategoriler
            // 
            this.pnlKategoriler.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKategoriler.Location = new System.Drawing.Point(0, 76);
            this.pnlKategoriler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKategoriler.Name = "pnlKategoriler";
            this.pnlKategoriler.Size = new System.Drawing.Size(165, 448);
            this.pnlKategoriler.TabIndex = 1;
            // 
            // pnlUrunler
            // 
            this.pnlUrunler.Controls.Add(this.flowLayoutPanel1);
            this.pnlUrunler.Location = new System.Drawing.Point(170, 76);
            this.pnlUrunler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUrunler.Name = "pnlUrunler";
            this.pnlUrunler.Size = new System.Drawing.Size(294, 327);
            this.pnlUrunler.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlAdisyon
            // 
            this.pnlAdisyon.Controls.Add(this.btnSiparisiTamamla);
            this.pnlAdisyon.Controls.Add(this.lblToplam);
            this.pnlAdisyon.Controls.Add(this.lvSiparisler);
            this.pnlAdisyon.Location = new System.Drawing.Point(466, 78);
            this.pnlAdisyon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAdisyon.Name = "pnlAdisyon";
            this.pnlAdisyon.Size = new System.Drawing.Size(181, 428);
            this.pnlAdisyon.TabIndex = 3;
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSiparisiTamamla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(14, 389);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(148, 29);
            this.btnSiparisiTamamla.TabIndex = 2;
            this.btnSiparisiTamamla.Text = "Gönder";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = false;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(11, 361);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(56, 19);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0,00 TL";
            // 
            // lvSiparisler
            // 
            this.lvSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSiparisler.HideSelection = false;
            this.lvSiparisler.Location = new System.Drawing.Point(2, 5);
            this.lvSiparisler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Size = new System.Drawing.Size(177, 354);
            this.lvSiparisler.TabIndex = 0;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fiyat";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 524);
            this.Controls.Add(this.pnlAdisyon);
            this.Controls.Add(this.pnlUrunler);
            this.Controls.Add(this.pnlKategoriler);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SiparisForm_FormClosing);
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUrunler.ResumeLayout(false);
            this.pnlAdisyon.ResumeLayout(false);
            this.pnlAdisyon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlKategoriler;
        private System.Windows.Forms.FlowLayoutPanel pnlUrunler;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlAdisyon;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}