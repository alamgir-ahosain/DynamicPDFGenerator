namespace pdfDesign
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            unit = new TextBox();
            roll = new TextBox();
            cname = new TextBox();
            bill = new TextBox();
            fname = new TextBox();
            mname = new TextBox();
            amount = new TextBox();
            comStatus = new ComboBox();
            comboICT = new ComboBox();
            comboCSE = new ComboBox();
            pdf = new Button();
            comboTextile = new ComboBox();
            label8 = new Label();
            add = new Button();
            searchRoll = new TextBox();
            SearchByRoll = new Button();
            pictureBox = new PictureBox();
            loadImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "UNIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 101);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Candidate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 221);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "ICT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 159);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Bill No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 45);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "GST ROLL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 101);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Father";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 159);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(531, 156);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 8;
            label9.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 226);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 9;
            label10.Text = "CSE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(531, 91);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 10;
            label11.Text = "Mother";
            // 
            // unit
            // 
            unit.Location = new Point(129, 45);
            unit.Name = "unit";
            unit.Size = new Size(125, 27);
            unit.TabIndex = 11;
            // 
            // roll
            // 
            roll.Location = new Point(351, 36);
            roll.Name = "roll";
            roll.Size = new Size(125, 27);
            roll.TabIndex = 12;
            // 
            // cname
            // 
            cname.Location = new Point(129, 98);
            cname.Name = "cname";
            cname.Size = new Size(125, 27);
            cname.TabIndex = 13;
            // 
            // bill
            // 
            bill.Location = new Point(129, 156);
            bill.Name = "bill";
            bill.Size = new Size(125, 27);
            bill.TabIndex = 14;
            // 
            // fname
            // 
            fname.Location = new Point(351, 98);
            fname.Name = "fname";
            fname.Size = new Size(125, 27);
            fname.TabIndex = 15;
            // 
            // mname
            // 
            mname.Location = new Point(616, 94);
            mname.Name = "mname";
            mname.Size = new Size(151, 27);
            mname.TabIndex = 16;
            // 
            // amount
            // 
            amount.Location = new Point(351, 148);
            amount.Name = "amount";
            amount.Size = new Size(125, 27);
            amount.TabIndex = 17;
            // 
            // comStatus
            // 
            comStatus.FormattingEnabled = true;
            comStatus.Items.AddRange(new object[] { "Pending", "Paid" });
            comStatus.Location = new Point(616, 148);
            comStatus.Name = "comStatus";
            comStatus.Size = new Size(151, 28);
            comStatus.TabIndex = 19;
            // 
            // comboICT
            // 
            comboICT.FormattingEnabled = true;
            comboICT.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboICT.Location = new Point(351, 221);
            comboICT.Name = "comboICT";
            comboICT.Size = new Size(137, 28);
            comboICT.TabIndex = 20;
            // 
            // comboCSE
            // 
            comboCSE.FormattingEnabled = true;
            comboCSE.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboCSE.Location = new Point(129, 218);
            comboCSE.Name = "comboCSE";
            comboCSE.Size = new Size(128, 28);
            comboCSE.TabIndex = 21;
            // 
            // pdf
            // 
            pdf.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdf.Location = new Point(233, 375);
            pdf.Name = "pdf";
            pdf.Size = new Size(154, 42);
            pdf.TabIndex = 22;
            pdf.Text = "Generate PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // comboTextile
            // 
            comboTextile.FormattingEnabled = true;
            comboTextile.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboTextile.Location = new Point(626, 226);
            comboTextile.Name = "comboTextile";
            comboTextile.Size = new Size(151, 28);
            comboTextile.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 224);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 24;
            label8.Text = "Textile";
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(393, 375);
            add.Name = "add";
            add.Size = new Size(151, 42);
            add.TabIndex = 25;
            add.Text = "ADD to DB";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // searchRoll
            // 
            searchRoll.Location = new Point(393, 337);
            searchRoll.Name = "searchRoll";
            searchRoll.Size = new Size(125, 27);
            searchRoll.TabIndex = 27;
            // 
            // SearchByRoll
            // 
            SearchByRoll.Location = new Point(233, 328);
            SearchByRoll.Name = "SearchByRoll";
            SearchByRoll.Size = new Size(154, 41);
            SearchByRoll.TabIndex = 28;
            SearchByRoll.Text = "Search By Roll";
            SearchByRoll.UseVisualStyleBackColor = true;
            SearchByRoll.Click += SearchByRoll_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(41, 274);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(125, 164);
            pictureBox.TabIndex = 29;
            pictureBox.TabStop = false;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(188, 274);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(94, 29);
            loadImageButton.TabIndex = 30;
            loadImageButton.Text = "Image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadImageButton);
            Controls.Add(pictureBox);
            Controls.Add(SearchByRoll);
            Controls.Add(searchRoll);
            Controls.Add(add);
            Controls.Add(label8);
            Controls.Add(comboTextile);
            Controls.Add(pdf);
            Controls.Add(comboCSE);
            Controls.Add(comboICT);
            Controls.Add(comStatus);
            Controls.Add(amount);
            Controls.Add(mname);
            Controls.Add(fname);
            Controls.Add(bill);
            Controls.Add(cname);
            Controls.Add(roll);
            Controls.Add(unit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox unit;
        private TextBox roll;
        private TextBox cname;
        private TextBox bill;
        private TextBox fname;
        private TextBox mname;
        private TextBox amount;
        private TextBox textBox8;
        private ComboBox comStatus;
        private ComboBox comboICT;
        private ComboBox comboCSE;
        private Button pdf;
        private ComboBox comboTextile;
        private Label label8;
        private Button button2;
        private Button add;
        private TextBox searchRoll;
        private Button SearchByRoll;
        private PictureBox pictureBox;
        private Button loadImageButton;
    }
}
