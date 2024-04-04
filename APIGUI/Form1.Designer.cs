namespace APIGUI {
    partial class Form1 {
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
        private void InitializeComponent()
        {
            button1 = new Button();
            deserializedTextBox = new TextBox();
            QueryTypeBox = new ComboBox();
            FirstParameter = new TextBox();
            SecondParameter = new TextBox();
            label1 = new Label();
            formatText = new Label();
            addButton = new Button();
            dbListBox = new ListBox();
            clearButton = new Button();
            imageBox = new PictureBox();
            showButton = new Button();
            titleText = new Label();
            dateText = new Label();
            explanationText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 178);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 4;
            button1.Text = "Receive!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += requestButtonOnClick;
            // 
            // deserializedTextBox
            // 
            deserializedTextBox.Location = new Point(12, 266);
            deserializedTextBox.Multiline = true;
            deserializedTextBox.Name = "deserializedTextBox";
            deserializedTextBox.ScrollBars = ScrollBars.Vertical;
            deserializedTextBox.Size = new Size(368, 99);
            deserializedTextBox.TabIndex = 6;
            // 
            // QueryTypeBox
            // 
            QueryTypeBox.FormattingEnabled = true;
            QueryTypeBox.Items.AddRange(new object[] { "Date", "Date Range", "Count" });
            QueryTypeBox.Location = new Point(12, 81);
            QueryTypeBox.Name = "QueryTypeBox";
            QueryTypeBox.Size = new Size(121, 23);
            QueryTypeBox.TabIndex = 7;
            // 
            // FirstParameter
            // 
            FirstParameter.Location = new Point(12, 110);
            FirstParameter.Name = "FirstParameter";
            FirstParameter.Size = new Size(121, 23);
            FirstParameter.TabIndex = 8;
            // 
            // SecondParameter
            // 
            SecondParameter.Location = new Point(139, 110);
            SecondParameter.Name = "SecondParameter";
            SecondParameter.Size = new Size(121, 23);
            SecondParameter.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 10;
            label1.Text = "Data Type";
            // 
            // formatText
            // 
            formatText.AutoSize = true;
            formatText.Location = new Point(12, 136);
            formatText.Name = "formatText";
            formatText.Size = new Size(154, 15);
            formatText.TabIndex = 11;
            formatText.Text = "Date Format: YYYY-MM-DD";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 223);
            addButton.Name = "addButton";
            addButton.Size = new Size(121, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Add to Database";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButtonOnClikc;
            // 
            // dbListBox
            // 
            dbListBox.FormattingEnabled = true;
            dbListBox.ItemHeight = 15;
            dbListBox.Location = new Point(12, 392);
            dbListBox.Name = "dbListBox";
            dbListBox.Size = new Size(368, 259);
            dbListBox.TabIndex = 13;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(139, 223);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(121, 23);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear Database";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // imageBox
            // 
            imageBox.Location = new Point(401, 12);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(633, 451);
            imageBox.TabIndex = 15;
            imageBox.TabStop = false;
            // 
            // showButton
            // 
            showButton.BackgroundImageLayout = ImageLayout.Zoom;
            showButton.Location = new Point(139, 178);
            showButton.Name = "showButton";
            showButton.Size = new Size(121, 23);
            showButton.TabIndex = 16;
            showButton.Text = "Show Image";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Location = new Point(401, 466);
            titleText.Name = "titleText";
            titleText.Size = new Size(32, 15);
            titleText.TabIndex = 17;
            titleText.Text = "Title:";
            // 
            // dateText
            // 
            dateText.AutoSize = true;
            dateText.Location = new Point(401, 481);
            dateText.Name = "dateText";
            dateText.Size = new Size(37, 15);
            dateText.TabIndex = 18;
            dateText.Text = "Date: ";
            // 
            // explanationText
            // 
            explanationText.Location = new Point(401, 499);
            explanationText.Multiline = true;
            explanationText.Name = "explanationText";
            explanationText.ScrollBars = ScrollBars.Vertical;
            explanationText.Size = new Size(633, 152);
            explanationText.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 685);
            Controls.Add(explanationText);
            Controls.Add(dateText);
            Controls.Add(titleText);
            Controls.Add(showButton);
            Controls.Add(imageBox);
            Controls.Add(clearButton);
            Controls.Add(dbListBox);
            Controls.Add(addButton);
            Controls.Add(formatText);
            Controls.Add(label1);
            Controls.Add(SecondParameter);
            Controls.Add(FirstParameter);
            Controls.Add(QueryTypeBox);
            Controls.Add(deserializedTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button button1;
        public TextBox deserializedTextBox;
        public ComboBox QueryTypeBox;
        public TextBox FirstParameter;
        public TextBox SecondParameter;
        public Label label1;
        public Label formatText;
        private Button addButton;
        private ListBox dbListBox;
        private Button clearButton;
        private PictureBox imageBox;
        private Button showButton;
        private Label titleText;
        private Label dateText;
        private TextBox explanationText;
    }
}
