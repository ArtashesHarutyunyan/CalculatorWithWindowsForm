namespace Calculator
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TxtBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            PointBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            ResultBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            MinusOrPlusBtn = new Button();
            DevideBtn = new Button();
            PlusBtn = new Button();
            ClearBtn = new Button();
            MinusBtn = new Button();
            PercentBtn = new Button();
            MultipleBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 15F);
            TxtBox.Location = new Point(34, 22);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(422, 41);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += textBox1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(34, 79);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(75, 61);
            SevenBtn.TabIndex = 2;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += button7_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(34, 146);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(75, 61);
            FourBtn.TabIndex = 3;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += button4_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(34, 213);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(75, 61);
            OneBtn.TabIndex = 4;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += button1_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(34, 280);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(75, 61);
            ZeroBtn.TabIndex = 5;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += button0_Click;
            // 
            // PointBtn
            // 
            PointBtn.Font = new Font("Segoe UI", 12F);
            PointBtn.Location = new Point(115, 280);
            PointBtn.Name = "PointBtn";
            PointBtn.Size = new Size(75, 61);
            PointBtn.TabIndex = 9;
            PointBtn.Text = ".";
            PointBtn.UseVisualStyleBackColor = true;
            PointBtn.Click += buttonPoint;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(115, 213);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(75, 61);
            TwoBtn.TabIndex = 8;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += button2_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(115, 146);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(75, 61);
            FiveBtn.TabIndex = 7;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += button5_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(115, 79);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(75, 61);
            EightBtn.TabIndex = 6;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += button8_Click;
            // 
            // ResultBtn
            // 
            ResultBtn.Font = new Font("Segoe UI", 12F);
            ResultBtn.Location = new Point(196, 280);
            ResultBtn.Name = "ResultBtn";
            ResultBtn.Size = new Size(75, 61);
            ResultBtn.TabIndex = 13;
            ResultBtn.Text = "=";
            ResultBtn.UseVisualStyleBackColor = true;
            ResultBtn.Click += buttonResult_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(196, 213);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(75, 61);
            ThreeBtn.TabIndex = 12;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += button3_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(196, 146);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(75, 61);
            SixBtn.TabIndex = 11;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += button6_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(196, 79);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(75, 61);
            NineBtn.TabIndex = 10;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += button9_Click;
            // 
            // MinusOrPlusBtn
            // 
            MinusOrPlusBtn.Font = new Font("Segoe UI", 12F);
            MinusOrPlusBtn.Location = new Point(302, 280);
            MinusOrPlusBtn.Name = "MinusOrPlusBtn";
            MinusOrPlusBtn.Size = new Size(75, 61);
            MinusOrPlusBtn.TabIndex = 21;
            MinusOrPlusBtn.Text = "-/+";
            MinusOrPlusBtn.UseVisualStyleBackColor = true;
            MinusOrPlusBtn.Click += buttonPlusOrMinus_Click;
            // 
            // DevideBtn
            // 
            DevideBtn.Font = new Font("Segoe UI", 12F);
            DevideBtn.Location = new Point(302, 213);
            DevideBtn.Name = "DevideBtn";
            DevideBtn.Size = new Size(75, 61);
            DevideBtn.TabIndex = 20;
            DevideBtn.Text = "/";
            DevideBtn.UseVisualStyleBackColor = true;
            DevideBtn.Click += buttonDevide_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(302, 146);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(75, 61);
            PlusBtn.TabIndex = 19;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += buttonPlus_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(302, 79);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(155, 61);
            ClearBtn.TabIndex = 18;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += buttonClear_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(383, 146);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(75, 61);
            MinusBtn.TabIndex = 23;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += buttonMinus_Click;
            // 
            // PercentBtn
            // 
            PercentBtn.Font = new Font("Segoe UI", 12F);
            PercentBtn.Location = new Point(383, 280);
            PercentBtn.Name = "PercentBtn";
            PercentBtn.Size = new Size(75, 61);
            PercentBtn.TabIndex = 25;
            PercentBtn.Text = "%";
            PercentBtn.UseVisualStyleBackColor = true;
            PercentBtn.Click += buttonPercent;
            // 
            // MultipleBtn
            // 
            MultipleBtn.Font = new Font("Segoe UI", 12F);
            MultipleBtn.Location = new Point(381, 213);
            MultipleBtn.Name = "MultipleBtn";
            MultipleBtn.Size = new Size(75, 61);
            MultipleBtn.TabIndex = 24;
            MultipleBtn.Text = "*";
            MultipleBtn.UseVisualStyleBackColor = true;
            MultipleBtn.Click += buttonMultiple_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 394);
            Controls.Add(PercentBtn);
            Controls.Add(MultipleBtn);
            Controls.Add(MinusBtn);
            Controls.Add(MinusOrPlusBtn);
            Controls.Add(DevideBtn);
            Controls.Add(PlusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ResultBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(PointBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "FormCalculator";
            Text = "FormCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private ContextMenuStrip contextMenuStrip1;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button PointBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button ResultBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button MinusOrPlusBtn;
        private Button DevideBtn;
        private Button PlusBtn;
        private Button ClearBtn;
        private Button MinusBtn;
        private Button PercentBtn;
        private Button MultipleBtn;
    }
}
