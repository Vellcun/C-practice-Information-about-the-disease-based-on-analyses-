namespace pract
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnalysisDictionary = new System.Windows.Forms.ComboBox();
            this.ResultDictionary = new System.Windows.Forms.ComboBox();
            this.DictionaryMax = new System.Windows.Forms.ListBox();
            this.AddAnalysis = new System.Windows.Forms.Button();
            this.ClearAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetDatatxt = new System.Windows.Forms.Button();
            this.AnalysisResult = new System.Windows.Forms.ListBox();
            this.GetResult = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DictionaryMin = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnalysisDictionary
            // 
            this.AnalysisDictionary.FormattingEnabled = true;
            this.AnalysisDictionary.Location = new System.Drawing.Point(265, 71);
            this.AnalysisDictionary.Name = "AnalysisDictionary";
            this.AnalysisDictionary.Size = new System.Drawing.Size(282, 21);
            this.AnalysisDictionary.TabIndex = 0;
            this.AnalysisDictionary.SelectedIndexChanged += new System.EventHandler(this.AnalysisDictionary_SelectedIndexChanged);
            // 
            // ResultDictionary
            // 
            this.ResultDictionary.FormattingEnabled = true;
            this.ResultDictionary.Location = new System.Drawing.Point(553, 71);
            this.ResultDictionary.Name = "ResultDictionary";
            this.ResultDictionary.Size = new System.Drawing.Size(137, 21);
            this.ResultDictionary.TabIndex = 1;
            this.ResultDictionary.SelectedIndexChanged += new System.EventHandler(this.ResultDictionary_SelectedIndexChanged);
            // 
            // DictionaryMax
            // 
            this.DictionaryMax.FormattingEnabled = true;
            this.DictionaryMax.HorizontalScrollbar = true;
            this.DictionaryMax.Location = new System.Drawing.Point(369, 128);
            this.DictionaryMax.Name = "DictionaryMax";
            this.DictionaryMax.ScrollAlwaysVisible = true;
            this.DictionaryMax.Size = new System.Drawing.Size(336, 355);
            this.DictionaryMax.TabIndex = 2;
            // 
            // AddAnalysis
            // 
            this.AddAnalysis.Location = new System.Drawing.Point(718, 55);
            this.AddAnalysis.Name = "AddAnalysis";
            this.AddAnalysis.Size = new System.Drawing.Size(128, 38);
            this.AddAnalysis.TabIndex = 3;
            this.AddAnalysis.Text = "Добавить анализ";
            this.AddAnalysis.UseVisualStyleBackColor = true;
            this.AddAnalysis.Click += new System.EventHandler(this.AddAnalysis_Click);
            // 
            // ClearAnalysis
            // 
            this.ClearAnalysis.Location = new System.Drawing.Point(48, 486);
            this.ClearAnalysis.Name = "ClearAnalysis";
            this.ClearAnalysis.Size = new System.Drawing.Size(200, 42);
            this.ClearAnalysis.TabIndex = 4;
            this.ClearAnalysis.Text = "Очистить анализы";
            this.ClearAnalysis.UseVisualStyleBackColor = true;
            this.ClearAnalysis.Click += new System.EventHandler(this.ClearAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Анализ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Errors";
            // 
            // GetDatatxt
            // 
            this.GetDatatxt.Location = new System.Drawing.Point(128, 57);
            this.GetDatatxt.Name = "GetDatatxt";
            this.GetDatatxt.Size = new System.Drawing.Size(117, 35);
            this.GetDatatxt.TabIndex = 9;
            this.GetDatatxt.Text = "Загрузить данные";
            this.GetDatatxt.UseVisualStyleBackColor = true;
            this.GetDatatxt.Click += new System.EventHandler(this.GetDatatxt_Click);
            // 
            // AnalysisResult
            // 
            this.AnalysisResult.FormattingEnabled = true;
            this.AnalysisResult.HorizontalScrollbar = true;
            this.AnalysisResult.Location = new System.Drawing.Point(48, 125);
            this.AnalysisResult.Name = "AnalysisResult";
            this.AnalysisResult.ScrollAlwaysVisible = true;
            this.AnalysisResult.Size = new System.Drawing.Size(305, 355);
            this.AnalysisResult.TabIndex = 10;
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(497, 493);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(208, 42);
            this.GetResult.TabIndex = 11;
            this.GetResult.Text = "Узнать варианты болезней";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 541);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1113, 23);
            this.ProgressBar.TabIndex = 12;
            this.ProgressBar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результаты анализов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Болезни с большей вероятностью";
            // 
            // DictionaryMin
            // 
            this.DictionaryMin.FormattingEnabled = true;
            this.DictionaryMin.HorizontalScrollbar = true;
            this.DictionaryMin.Location = new System.Drawing.Point(718, 129);
            this.DictionaryMin.Name = "DictionaryMin";
            this.DictionaryMin.ScrollAlwaysVisible = true;
            this.DictionaryMin.Size = new System.Drawing.Size(353, 355);
            this.DictionaryMin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Болезни с меньшей вероятностью";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Очистить результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DictionaryMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.AnalysisResult);
            this.Controls.Add(this.GetDatatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAnalysis);
            this.Controls.Add(this.AddAnalysis);
            this.Controls.Add(this.DictionaryMax);
            this.Controls.Add(this.ResultDictionary);
            this.Controls.Add(this.AnalysisDictionary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AnalysisDictionary;
        private System.Windows.Forms.ComboBox ResultDictionary;
        private System.Windows.Forms.ListBox DictionaryMax;
        private System.Windows.Forms.Button AddAnalysis;
        private System.Windows.Forms.Button ClearAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetDatatxt;
        private System.Windows.Forms.ListBox AnalysisResult;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox DictionaryMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

