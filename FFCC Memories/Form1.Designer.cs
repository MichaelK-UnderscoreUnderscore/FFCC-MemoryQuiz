﻿namespace FFCC_Memories
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            this.Kanji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remain = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.KatKa = new System.Windows.Forms.Button();
            this.KatO = new System.Windows.Forms.Button();
            this.KatRu = new System.Windows.Forms.Button();
            this.KatU = new System.Windows.Forms.Button();
            this.HirNa = new System.Windows.Forms.Button();
            this.HirO = new System.Windows.Forms.Button();
            this.HirTo = new System.Windows.Forms.Button();
            this.HirSe = new System.Windows.Forms.Button();
            this.HirSo = new System.Windows.Forms.Button();
            this.HirA = new System.Windows.Forms.Button();
            this.KatShi = new System.Windows.Forms.Button();
            this.KatA = new System.Windows.Forms.Button();
            this.HirI = new System.Windows.Forms.Button();
            this.KatKi = new System.Windows.Forms.Button();
            this.KatSo = new System.Windows.Forms.Button();
            this.KatMa = new System.Windows.Forms.Button();
            this.KatSe = new System.Windows.Forms.Button();
            this.KatTe = new System.Windows.Forms.Button();
            this.KatFu = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.line = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kanji
            // 
            this.Kanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kanji.Location = new System.Drawing.Point(10, 260);
            this.Kanji.Name = "Kanji";
            this.Kanji.Size = new System.Drawing.Size(445, 94);
            this.Kanji.TabIndex = 0;
            this.Kanji.Text = "Kanji";
            this.Kanji.UseVisualStyleBackColor = true;
            this.Kanji.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kanji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label1.Location = new System.Drawing.Point(153, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Katagana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.Location = new System.Drawing.Point(546, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hiragana";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.remain);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(480, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 94);
            this.panel1.TabIndex = 14;
            // 
            // remain
            // 
            this.remain.AutoSize = true;
            this.remain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.remain.Location = new System.Drawing.Point(12, 16);
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(44, 31);
            this.remain.TabIndex = 1;
            this.remain.Text = "25";
            this.remain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "left";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(345, 96);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(98, 108);
            this.answer.TabIndex = 0;
            this.answer.Text = "?";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer.Visible = false;
            // 
            // KatKa
            // 
            this.KatKa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatKa.Image = global::FFCC_Memories.Properties.Resources.Kat_ka;
            this.KatKa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatKa.Location = new System.Drawing.Point(160, 160);
            this.KatKa.Name = "KatKa";
            this.KatKa.Size = new System.Drawing.Size(144, 44);
            this.KatKa.TabIndex = 35;
            this.KatKa.Text = " - Ka";
            this.KatKa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatKa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatKa.UseVisualStyleBackColor = true;
            this.KatKa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatKa_Click);
            // 
            // KatO
            // 
            this.KatO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatO.Image = global::FFCC_Memories.Properties.Resources.Kat_o;
            this.KatO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatO.Location = new System.Drawing.Point(310, 210);
            this.KatO.Name = "KatO";
            this.KatO.Size = new System.Drawing.Size(144, 44);
            this.KatO.TabIndex = 30;
            this.KatO.Text = " - O";
            this.KatO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatO.UseVisualStyleBackColor = true;
            this.KatO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatO_Click);
            // 
            // KatRu
            // 
            this.KatRu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatRu.Image = global::FFCC_Memories.Properties.Resources.Kat_ru;
            this.KatRu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatRu.Location = new System.Drawing.Point(160, 210);
            this.KatRu.Name = "KatRu";
            this.KatRu.Size = new System.Drawing.Size(144, 44);
            this.KatRu.TabIndex = 26;
            this.KatRu.Text = " - Ru";
            this.KatRu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatRu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatRu.UseVisualStyleBackColor = true;
            this.KatRu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatRu_Click);
            // 
            // KatU
            // 
            this.KatU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.KatU.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatU.Image = global::FFCC_Memories.Properties.Resources.Kat_u;
            this.KatU.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatU.Location = new System.Drawing.Point(10, 60);
            this.KatU.Name = "KatU";
            this.KatU.Size = new System.Drawing.Size(144, 44);
            this.KatU.TabIndex = 24;
            this.KatU.Text = " - U";
            this.KatU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatU.UseVisualStyleBackColor = false;
            this.KatU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatU_Click);
            // 
            // HirNa
            // 
            this.HirNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirNa.Image = global::FFCC_Memories.Properties.Resources.Hir_na;
            this.HirNa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirNa.Location = new System.Drawing.Point(630, 160);
            this.HirNa.Name = "HirNa";
            this.HirNa.Size = new System.Drawing.Size(144, 44);
            this.HirNa.TabIndex = 22;
            this.HirNa.Text = " - Na";
            this.HirNa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirNa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirNa.UseVisualStyleBackColor = true;
            this.HirNa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirNa_Click);
            // 
            // HirO
            // 
            this.HirO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirO.Image = global::FFCC_Memories.Properties.Resources.Hir_o;
            this.HirO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirO.Location = new System.Drawing.Point(480, 210);
            this.HirO.Name = "HirO";
            this.HirO.Size = new System.Drawing.Size(144, 44);
            this.HirO.TabIndex = 21;
            this.HirO.Text = " - O";
            this.HirO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirO.UseVisualStyleBackColor = true;
            this.HirO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirO_Click);
            // 
            // HirTo
            // 
            this.HirTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HirTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirTo.Image = global::FFCC_Memories.Properties.Resources.Hir_to;
            this.HirTo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirTo.Location = new System.Drawing.Point(480, 60);
            this.HirTo.Name = "HirTo";
            this.HirTo.Size = new System.Drawing.Size(144, 44);
            this.HirTo.TabIndex = 20;
            this.HirTo.Text = " - To";
            this.HirTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirTo.UseVisualStyleBackColor = false;
            this.HirTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirTo_Click);
            // 
            // HirSe
            // 
            this.HirSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirSe.Image = global::FFCC_Memories.Properties.Resources.Hir_se;
            this.HirSe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirSe.Location = new System.Drawing.Point(630, 110);
            this.HirSe.Name = "HirSe";
            this.HirSe.Size = new System.Drawing.Size(144, 44);
            this.HirSe.TabIndex = 18;
            this.HirSe.Text = " - Se";
            this.HirSe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirSe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirSe.UseVisualStyleBackColor = true;
            this.HirSe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirSe_Click);
            // 
            // HirSo
            // 
            this.HirSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirSo.Image = global::FFCC_Memories.Properties.Resources.Hir_so;
            this.HirSo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirSo.Location = new System.Drawing.Point(480, 110);
            this.HirSo.Name = "HirSo";
            this.HirSo.Size = new System.Drawing.Size(144, 44);
            this.HirSo.TabIndex = 17;
            this.HirSo.Text = " - So";
            this.HirSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirSo.UseVisualStyleBackColor = true;
            this.HirSo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirSo_Click);
            // 
            // HirA
            // 
            this.HirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirA.Image = global::FFCC_Memories.Properties.Resources.Hir_a;
            this.HirA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirA.Location = new System.Drawing.Point(480, 160);
            this.HirA.Name = "HirA";
            this.HirA.Size = new System.Drawing.Size(144, 44);
            this.HirA.TabIndex = 16;
            this.HirA.Text = " - A";
            this.HirA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirA.UseVisualStyleBackColor = true;
            this.HirA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirA_Click);
            // 
            // KatShi
            // 
            this.KatShi.BackColor = System.Drawing.SystemColors.Control;
            this.KatShi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatShi.Image = global::FFCC_Memories.Properties.Resources.Kat_shi;
            this.KatShi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatShi.Location = new System.Drawing.Point(10, 110);
            this.KatShi.Name = "KatShi";
            this.KatShi.Size = new System.Drawing.Size(144, 44);
            this.KatShi.TabIndex = 11;
            this.KatShi.Text = " - Shi";
            this.KatShi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatShi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatShi.UseVisualStyleBackColor = false;
            this.KatShi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatShi_Click);
            // 
            // KatA
            // 
            this.KatA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatA.Image = global::FFCC_Memories.Properties.Resources.Kat_a;
            this.KatA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatA.Location = new System.Drawing.Point(310, 160);
            this.KatA.Name = "KatA";
            this.KatA.Size = new System.Drawing.Size(144, 44);
            this.KatA.TabIndex = 10;
            this.KatA.Text = " - A";
            this.KatA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatA.UseVisualStyleBackColor = true;
            this.KatA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatA_Click);
            // 
            // HirI
            // 
            this.HirI.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirI.Image = global::FFCC_Memories.Properties.Resources.Hir_i;
            this.HirI.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HirI.Location = new System.Drawing.Point(630, 210);
            this.HirI.Name = "HirI";
            this.HirI.Size = new System.Drawing.Size(144, 44);
            this.HirI.TabIndex = 9;
            this.HirI.Text = " - I";
            this.HirI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HirI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HirI.UseVisualStyleBackColor = true;
            this.HirI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HirI_Click);
            // 
            // KatKi
            // 
            this.KatKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KatKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatKi.Image = global::FFCC_Memories.Properties.Resources.Kat_ki;
            this.KatKi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatKi.Location = new System.Drawing.Point(310, 60);
            this.KatKi.Name = "KatKi";
            this.KatKi.Size = new System.Drawing.Size(144, 44);
            this.KatKi.TabIndex = 7;
            this.KatKi.Text = " - Ki";
            this.KatKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatKi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatKi.UseVisualStyleBackColor = false;
            this.KatKi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatKi_Click);
            // 
            // KatSo
            // 
            this.KatSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatSo.Image = global::FFCC_Memories.Properties.Resources.Kat_so;
            this.KatSo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatSo.Location = new System.Drawing.Point(160, 110);
            this.KatSo.Name = "KatSo";
            this.KatSo.Size = new System.Drawing.Size(144, 44);
            this.KatSo.TabIndex = 6;
            this.KatSo.Text = " - So";
            this.KatSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatSo.UseVisualStyleBackColor = true;
            this.KatSo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatSo_Click);
            // 
            // KatMa
            // 
            this.KatMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatMa.Image = global::FFCC_Memories.Properties.Resources.Kat_ma;
            this.KatMa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatMa.Location = new System.Drawing.Point(10, 160);
            this.KatMa.Name = "KatMa";
            this.KatMa.Size = new System.Drawing.Size(144, 44);
            this.KatMa.TabIndex = 4;
            this.KatMa.Text = " - Ma";
            this.KatMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatMa.UseVisualStyleBackColor = true;
            this.KatMa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatMa_Click);
            // 
            // KatSe
            // 
            this.KatSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatSe.Image = global::FFCC_Memories.Properties.Resources.Kat_se;
            this.KatSe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatSe.Location = new System.Drawing.Point(310, 110);
            this.KatSe.Name = "KatSe";
            this.KatSe.Size = new System.Drawing.Size(144, 44);
            this.KatSe.TabIndex = 3;
            this.KatSe.Text = " - Se";
            this.KatSe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatSe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatSe.UseVisualStyleBackColor = true;
            this.KatSe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatSe_Click);
            // 
            // KatTe
            // 
            this.KatTe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KatTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatTe.Image = global::FFCC_Memories.Properties.Resources.Kat_te;
            this.KatTe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatTe.Location = new System.Drawing.Point(160, 60);
            this.KatTe.Name = "KatTe";
            this.KatTe.Size = new System.Drawing.Size(144, 44);
            this.KatTe.TabIndex = 2;
            this.KatTe.Text = " - Te";
            this.KatTe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatTe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatTe.UseVisualStyleBackColor = false;
            this.KatTe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatTe_Click);
            // 
            // KatFu
            // 
            this.KatFu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatFu.Image = global::FFCC_Memories.Properties.Resources.Kat_fu;
            this.KatFu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KatFu.Location = new System.Drawing.Point(10, 210);
            this.KatFu.Name = "KatFu";
            this.KatFu.Size = new System.Drawing.Size(144, 44);
            this.KatFu.TabIndex = 1;
            this.KatFu.Text = " - Fu";
            this.KatFu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KatFu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KatFu.UseVisualStyleBackColor = true;
            this.KatFu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KatFu_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(10, 10);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(66, 29);
            this.reset.TabIndex = 37;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MaximumAutoSize = 1F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.IsMarginVisible = false;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BorderColor = System.Drawing.SystemColors.Control;
            chartArea1.BorderWidth = 0;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(540, 262);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(232, 90);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.line.Location = new System.Drawing.Point(452, 16);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(29, 31);
            this.line.TabIndex = 39;
            this.line.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(382, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Line:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.KatKa);
            this.Controls.Add(this.KatO);
            this.Controls.Add(this.KatRu);
            this.Controls.Add(this.KatU);
            this.Controls.Add(this.HirNa);
            this.Controls.Add(this.HirO);
            this.Controls.Add(this.HirTo);
            this.Controls.Add(this.HirSe);
            this.Controls.Add(this.HirSo);
            this.Controls.Add(this.HirA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KatShi);
            this.Controls.Add(this.KatA);
            this.Controls.Add(this.HirI);
            this.Controls.Add(this.KatKi);
            this.Controls.Add(this.KatSo);
            this.Controls.Add(this.KatMa);
            this.Controls.Add(this.KatSe);
            this.Controls.Add(this.KatTe);
            this.Controls.Add(this.KatFu);
            this.Controls.Add(this.Kanji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Final Fantasy Crystal Chronicles - Memory Cheat Quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kanji;
        private System.Windows.Forms.Button KatFu;
        private System.Windows.Forms.Button KatTe;
        private System.Windows.Forms.Button KatSe;
        private System.Windows.Forms.Button KatMa;
        private System.Windows.Forms.Button KatSo;
        private System.Windows.Forms.Button KatKi;
        private System.Windows.Forms.Button HirI;
        private System.Windows.Forms.Button KatA;
        private System.Windows.Forms.Button KatShi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label remain;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button HirA;
        private System.Windows.Forms.Button HirSo;
        private System.Windows.Forms.Button HirSe;
        private System.Windows.Forms.Button HirTo;
        private System.Windows.Forms.Button HirO;
        private System.Windows.Forms.Button HirNa;
        private System.Windows.Forms.Button KatU;
        private System.Windows.Forms.Button KatRu;
        private System.Windows.Forms.Button KatO;
        private System.Windows.Forms.Button KatKa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label label4;
    }
}

