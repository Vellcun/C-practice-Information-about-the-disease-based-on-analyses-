using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace pract
{
    public partial class Form1 : Form
    {

        public List<string> Analyses = new List<string>();
        //public string[][] Diseases = new string[1000][];
        public List<List<string>> Diseases = new List<List<string>>();

        public List<string> ResultMax = new List<string>();
        public List<string> ResultMin = new List<string>();

        string _analyse;
        string _analyseValue;


        public Form1()
        {
            InitializeComponent();
        }


        // получаем данные
        private void GetDatatxt_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;

            getData(path);
        }


        // вывод результата
        private void GetResult_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            GetDictionary();

            foreach (string _dictionary in ResultMax)
            {
                DictionaryMax.Items.Add(_dictionary);
            }

            foreach (string _dictionary in ResultMin)
            {
                DictionaryMin.Items.Add(_dictionary);
            }
        }


        // заполнение входных данных
        private void AddAnalysis_Click(object sender, EventArgs e)
        {
            if (_analyse == null | _analyseValue == null)
            {
                label3.Text = "Данные не введены!";
                return;
            }
            Analyses.Add(_analyse + " " + _analyseValue);
            AnalysisResult.Items.Add((string)_analyse + " : " + (string)_analyseValue);
        }


        // чистка входных данных
        private void ClearAnalysis_Click(object sender, EventArgs e)
        {
            Analyses.Clear();
            AnalysisResult.Items.Clear();
        }


        // получаем данные о виде анализа
        private void AnalysisDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            _analyse = AnalysisDictionary.Text;
        }


        // получаем данные о результате анализа
        private void ResultDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            _analyseValue = ResultDictionary.Text;
        }


        // функция для получения данных
        private void getData(string path)
        {
            AnalysisDictionary.Items.Clear();
            ResultDictionary.Items.Clear();

            try
            {
                //-----------------------------------------------------------
                // Вид анализа
                // Считываем строки из файла
                string[] _Lines = File.ReadAllLines(path + "\\Analysis.txt");

                // Заполняем comboBox анализами
                foreach (string _line in _Lines)
                {
                    AnalysisDictionary.Items.Add(_line);
                }

                //------------------------------------------------------------
                // Значение анализа
                // Считываем строки из файла
                _Lines = File.ReadAllLines(path + "\\AnalysisValue.txt");

                // Заполняем comboBox результатами анализов
                foreach (string _line in _Lines)
                {
                    ResultDictionary.Items.Add(_line);
                }

                //--------------------------------------------------------------
                //загрузка данных о болезнях
                LoadDiseasesFromFile(path);
                //--------------------------------------------------------------
            }
            catch (Exception ex)
            {
                label3.Text = $"Ошибка при чтении файла: {ex.Message}";
            }
        }


        // получаем список болезней связанных с входными данными
        void GetDictionary ()
        {
            ResultMax.Clear();
            ResultMin.Clear();

            ProgressBar.Value = 0;
            ProgressBar.Maximum = Diseases.Count;
            ProgressBar.Step = 1;
            ProgressBar.Visible = true;

            int res = 0;
            for (int i = 0; i < Diseases.Count; i++)
            {
                for (int j = 1; j < Diseases[i].Count; j++)
                {
                    
                    foreach (string _analyse in Analyses)
                    {
                        if (_analyse == Diseases[i][j])
                        {
                            res += 1;
                        }
                    }
                    if (j == (Diseases[i].Count - 1) & res >= Diseases[i].Count * 0.5)
                    {
                        ResultMax.Add(Diseases[i][0]);
                    }
                    else
                    {
                        if (j == (Diseases[i].Count-1) & res < Diseases[i].Count * 0.5 & res > Diseases[i].Count * 0.25)
                        {
                            ResultMin.Add(Diseases[i][0]);
                        }
                    }
                }
                ProgressBar.Value = i + 1;
                Application.DoEvents();
                res = 0;
            }

            ProgressBar.Visible = false;
        }


        // Загрузка информации о болезнях из текстового файла
        void LoadDiseasesFromFile(string filePath)
        {
            
            try
            {
                string[] _Lines = File.ReadAllLines(filePath + "\\desiases.txt");
                int i = 0;
                foreach (string _line in _Lines)
                {
                    string[] _parts = _line.Split(',');
                    List<string> row = new List<string>(_parts);
                    Diseases.Add(row);
                    i++;
                }
            }
            catch (Exception ex)
            {
                label3.Text=($"Ошибка при загрузке информации о болезнях: {ex.Message}");
            }
        }

        private void ClearResults_Click(object sender, EventArgs e)
        {
            DictionaryMax.Items.Clear();
            DictionaryMin.Items.Clear();
        }
    }
}
