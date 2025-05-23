﻿namespace SistemaFinanceiro
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            graficoGeral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlSessaoGeral = new Panel();
            pnlSessaoGeralDireito = new Panel();
            pnlSessaoGeralEsquerdo = new Panel();
            lblSessaoGeralEsquerda = new Label();
            panel1 = new Panel();
            graficoDespesas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            lblDespesas = new Label();
            ((System.ComponentModel.ISupportInitialize)graficoGeral).BeginInit();
            pnlSessaoGeral.SuspendLayout();
            pnlSessaoGeralDireito.SuspendLayout();
            pnlSessaoGeralEsquerdo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)graficoDespesas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 2;
            label1.Text = "TELA DASHBOARD";
            // 
            // graficoGeral
            // 
            chartArea1.Name = "ChartArea1";
            graficoGeral.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            graficoGeral.Legends.Add(legend1);
            graficoGeral.Location = new Point(438, 17);
            graficoGeral.Name = "graficoGeral";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            graficoGeral.Series.Add(series1);
            graficoGeral.Size = new Size(288, 220);
            graficoGeral.TabIndex = 3;
            graficoGeral.Text = "chart1";
            // 
            // pnlSessaoGeral
            // 
            pnlSessaoGeral.Controls.Add(pnlSessaoGeralDireito);
            pnlSessaoGeral.Controls.Add(pnlSessaoGeralEsquerdo);
            pnlSessaoGeral.Location = new Point(1, 61);
            pnlSessaoGeral.Name = "pnlSessaoGeral";
            pnlSessaoGeral.Size = new Size(1378, 251);
            pnlSessaoGeral.TabIndex = 4;
            // 
            // pnlSessaoGeralDireito
            // 
            pnlSessaoGeralDireito.Controls.Add(graficoGeral);
            pnlSessaoGeralDireito.Dock = DockStyle.Right;
            pnlSessaoGeralDireito.Location = new Point(493, 0);
            pnlSessaoGeralDireito.Name = "pnlSessaoGeralDireito";
            pnlSessaoGeralDireito.Size = new Size(885, 251);
            pnlSessaoGeralDireito.TabIndex = 1;
            // 
            // pnlSessaoGeralEsquerdo
            // 
            pnlSessaoGeralEsquerdo.Controls.Add(lblSessaoGeralEsquerda);
            pnlSessaoGeralEsquerdo.Dock = DockStyle.Left;
            pnlSessaoGeralEsquerdo.Location = new Point(0, 0);
            pnlSessaoGeralEsquerdo.Name = "pnlSessaoGeralEsquerdo";
            pnlSessaoGeralEsquerdo.Size = new Size(493, 251);
            pnlSessaoGeralEsquerdo.TabIndex = 0;
            // 
            // lblSessaoGeralEsquerda
            // 
            lblSessaoGeralEsquerda.AutoSize = true;
            lblSessaoGeralEsquerda.Location = new Point(111, 125);
            lblSessaoGeralEsquerda.Name = "lblSessaoGeralEsquerda";
            lblSessaoGeralEsquerda.Size = new Size(111, 15);
            lblSessaoGeralEsquerda.TabIndex = 0;
            lblSessaoGeralEsquerda.Text = "Receitas X Despesas";
            // 
            // panel1
            // 
            panel1.Controls.Add(graficoDespesas);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 251);
            panel1.TabIndex = 5;
            // 
            // graficoDespesas
            // 
            chartArea2.Name = "ChartArea1";
            graficoDespesas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            graficoDespesas.Legends.Add(legend2);
            graficoDespesas.Location = new Point(278, 14);
            graficoDespesas.Name = "graficoDespesas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            graficoDespesas.Series.Add(series2);
            graficoDespesas.Size = new Size(288, 220);
            graficoDespesas.TabIndex = 4;
            graficoDespesas.Text = "chart1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDespesas);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(885, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 251);
            panel2.TabIndex = 0;
            // 
            // lblDespesas
            // 
            lblDespesas.AutoSize = true;
            lblDespesas.Font = new Font("Segoe UI", 15F);
            lblDespesas.Location = new Point(228, 116);
            lblDespesas.Name = "lblDespesas";
            lblDespesas.Size = new Size(92, 28);
            lblDespesas.TabIndex = 1;
            lblDespesas.Text = "Despesas";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1379, 685);
            Controls.Add(panel1);
            Controls.Add(pnlSessaoGeral);
            Controls.Add(label1);
            Name = "FormDashboard";
            Text = "Form1";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)graficoGeral).EndInit();
            pnlSessaoGeral.ResumeLayout(false);
            pnlSessaoGeralDireito.ResumeLayout(false);
            pnlSessaoGeralEsquerdo.ResumeLayout(false);
            pnlSessaoGeralEsquerdo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)graficoDespesas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoGeral;
        private Panel pnlSessaoGeral;
        private Panel pnlSessaoGeralEsquerdo;
        private Panel pnlSessaoGeralDireito;
        private Label lblSessaoGeralEsquerda;
        private Panel panel1;
        private Panel panel2;
        private Label lblDespesas;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoDespesas;
    }
}