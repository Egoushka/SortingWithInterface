namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sortType = new System.Windows.Forms.GroupBox();
            this.wordsCount = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.signsCount = new System.Windows.Forms.RadioButton();
            this.lineLength = new System.Windows.Forms.RadioButton();
            this.lettersCount = new System.Windows.Forms.RadioButton();
            this.sortMethod = new System.Windows.Forms.GroupBox();
            this.shell = new System.Windows.Forms.RadioButton();
            this.insertion = new System.Windows.Forms.RadioButton();
            this.selection = new System.Windows.Forms.RadioButton();
            this.bubble = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.sortType.SuspendLayout();
            this.sortMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            chartArea1.Name = "ChartArea1";
            this.Result.ChartAreas.Add(chartArea1);
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Result.Legends.Add(legend1);
            this.Result.Location = new System.Drawing.Point(0, 0);
            this.Result.Name = "Result";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Result.Series.Add(series1);
            this.Result.Size = new System.Drawing.Size(800, 450);
            this.Result.TabIndex = 0;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // sortType
            // 
            this.sortType.Controls.Add(this.wordsCount);
            this.sortType.Controls.Add(this.radioButton6);
            this.sortType.Controls.Add(this.signsCount);
            this.sortType.Controls.Add(this.lineLength);
            this.sortType.Controls.Add(this.lettersCount);
            this.sortType.Location = new System.Drawing.Point(694, 112);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(106, 135);
            this.sortType.TabIndex = 4;
            this.sortType.TabStop = false;
            this.sortType.Text = "Sort type";
            // 
            // wordsCount
            // 
            this.wordsCount.AutoSize = true;
            this.wordsCount.Location = new System.Drawing.Point(7, 66);
            this.wordsCount.Name = "wordsCount";
            this.wordsCount.Size = new System.Drawing.Size(101, 17);
            this.wordsCount.TabIndex = 4;
            this.wordsCount.Text = "Counts of words";
            this.wordsCount.UseVisualStyleBackColor = true;
            this.wordsCount.CheckedChanged += new System.EventHandler(this.SortType_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 112);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.SortType_CheckedChanged);
            // 
            // signsCount
            // 
            this.signsCount.AutoSize = true;
            this.signsCount.Location = new System.Drawing.Point(7, 89);
            this.signsCount.Name = "signsCount";
            this.signsCount.Size = new System.Drawing.Size(77, 17);
            this.signsCount.TabIndex = 3;
            this.signsCount.Text = "Punc signs";
            this.signsCount.UseVisualStyleBackColor = true;
            this.signsCount.CheckedChanged += new System.EventHandler(this.SortType_CheckedChanged);
            // 
            // lineLength
            // 
            this.lineLength.AutoSize = true;
            this.lineLength.Location = new System.Drawing.Point(7, 43);
            this.lineLength.Name = "lineLength";
            this.lineLength.Size = new System.Drawing.Size(89, 17);
            this.lineLength.TabIndex = 1;
            this.lineLength.Text = "Length of line";
            this.lineLength.UseVisualStyleBackColor = true;
            this.lineLength.CheckedChanged += new System.EventHandler(this.SortType_CheckedChanged);
            // 
            // lettersCount
            // 
            this.lettersCount.AutoSize = true;
            this.lettersCount.Checked = true;
            this.lettersCount.Location = new System.Drawing.Point(7, 20);
            this.lettersCount.Name = "lettersCount";
            this.lettersCount.Size = new System.Drawing.Size(96, 17);
            this.lettersCount.TabIndex = 0;
            this.lettersCount.TabStop = true;
            this.lettersCount.Text = "Count of letters";
            this.lettersCount.UseVisualStyleBackColor = true;
            this.lettersCount.CheckedChanged += new System.EventHandler(this.SortType_CheckedChanged);
            // 
            // sortMethod
            // 
            this.sortMethod.Controls.Add(this.shell);
            this.sortMethod.Controls.Add(this.insertion);
            this.sortMethod.Controls.Add(this.selection);
            this.sortMethod.Controls.Add(this.bubble);
            this.sortMethod.Location = new System.Drawing.Point(694, 0);
            this.sortMethod.Name = "sortMethod";
            this.sortMethod.Size = new System.Drawing.Size(106, 114);
            this.sortMethod.TabIndex = 0;
            this.sortMethod.TabStop = false;
            this.sortMethod.Text = "Sort method";
            // 
            // shell
            // 
            this.shell.AutoSize = true;
            this.shell.Location = new System.Drawing.Point(6, 89);
            this.shell.Name = "shell";
            this.shell.Size = new System.Drawing.Size(48, 17);
            this.shell.TabIndex = 3;
            this.shell.Text = "Shell";
            this.shell.UseVisualStyleBackColor = true;
            this.shell.CheckedChanged += new System.EventHandler(this.SortMethod_CheckedChanged);
            // 
            // insertion
            // 
            this.insertion.AutoSize = true;
            this.insertion.Location = new System.Drawing.Point(7, 66);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(65, 17);
            this.insertion.TabIndex = 2;
            this.insertion.Text = "Insertion";
            this.insertion.UseVisualStyleBackColor = true;
            this.insertion.CheckedChanged += new System.EventHandler(this.SortMethod_CheckedChanged);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(7, 43);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(69, 17);
            this.selection.TabIndex = 1;
            this.selection.Text = "Selection";
            this.selection.UseVisualStyleBackColor = true;
            this.selection.CheckedChanged += new System.EventHandler(this.SortMethod_CheckedChanged);
            // 
            // bubble
            // 
            this.bubble.AutoSize = true;
            this.bubble.Checked = true;
            this.bubble.Location = new System.Drawing.Point(7, 20);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(58, 17);
            this.bubble.TabIndex = 0;
            this.bubble.TabStop = true;
            this.bubble.Text = "Bubble";
            this.bubble.UseVisualStyleBackColor = true;
            this.bubble.CheckedChanged += new System.EventHandler(this.SortMethod_CheckedChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(705, 412);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(97, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Сортировать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sortMethod);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.sortType.ResumeLayout(false);
            this.sortType.PerformLayout();
            this.sortMethod.ResumeLayout(false);
            this.sortMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Result;
        private System.Windows.Forms.GroupBox sortType;
        private System.Windows.Forms.RadioButton wordsCount;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton signsCount;
        private System.Windows.Forms.RadioButton lineLength;
        private System.Windows.Forms.RadioButton lettersCount;
        private System.Windows.Forms.GroupBox sortMethod;
        private System.Windows.Forms.RadioButton shell;
        private System.Windows.Forms.RadioButton insertion;
        private System.Windows.Forms.RadioButton selection;
        private System.Windows.Forms.RadioButton bubble;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

