namespace FigureForm
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
            cbCircles = new ComboBox();
            pnMain = new Panel();
            pnTools = new Panel();
            btnCollapse = new Button();
            btnExpand = new Button();
            btnRightFar = new Button();
            btnRight = new Button();
            btnLeftFar = new Button();
            btnLeft = new Button();
            btnDownFar = new Button();
            btnDown = new Button();
            btnUp = new Button();
            btnUpFar = new Button();
            btnShow = new Button();
            btnHide = new Button();
            btnCreateNew = new Button();
            label1 = new Label();
            pnTools.SuspendLayout();
            SuspendLayout();
            // 
            // cbCircles
            // 
            cbCircles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Location = new Point(6, 43);
            cbCircles.Name = "cbCircles";
            cbCircles.Size = new Size(335, 28);
            cbCircles.TabIndex = 0;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(627, 657);
            pnMain.TabIndex = 1;
            pnMain.Paint += panel1_Paint;
            // 
            // pnTools
            // 
            pnTools.Controls.Add(btnCollapse);
            pnTools.Controls.Add(btnExpand);
            pnTools.Controls.Add(btnRightFar);
            pnTools.Controls.Add(btnRight);
            pnTools.Controls.Add(btnLeftFar);
            pnTools.Controls.Add(btnLeft);
            pnTools.Controls.Add(btnDownFar);
            pnTools.Controls.Add(btnDown);
            pnTools.Controls.Add(btnUp);
            pnTools.Controls.Add(btnUpFar);
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(label1);
            pnTools.Controls.Add(cbCircles);
            pnTools.Location = new Point(627, 0);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(355, 657);
            pnTools.TabIndex = 2;
            pnTools.Paint += panel1_Paint_1;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(121, 412);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(94, 29);
            btnCollapse.TabIndex = 14;
            btnCollapse.Text = "-";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(121, 383);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(94, 29);
            btnExpand.TabIndex = 13;
            btnExpand.Text = "+";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnRightFar
            // 
            btnRightFar.Location = new Point(280, 397);
            btnRightFar.Name = "btnRightFar";
            btnRightFar.Size = new Size(44, 35);
            btnRightFar.TabIndex = 12;
            btnRightFar.Text = "-->";
            btnRightFar.UseVisualStyleBackColor = true;
            btnRightFar.Click += btnRightFar_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(230, 397);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(44, 35);
            btnRight.TabIndex = 11;
            btnRight.Text = "-->";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeftFar
            // 
            btnLeftFar.Location = new Point(18, 395);
            btnLeftFar.Name = "btnLeftFar";
            btnLeftFar.Size = new Size(44, 37);
            btnLeftFar.TabIndex = 10;
            btnLeftFar.Text = "<--";
            btnLeftFar.UseVisualStyleBackColor = true;
            btnLeftFar.Click += btnLeftFar_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(68, 397);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(44, 35);
            btnLeft.TabIndex = 9;
            btnLeft.Text = "<--";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnDownFar
            // 
            btnDownFar.Location = new Point(121, 482);
            btnDownFar.Name = "btnDownFar";
            btnDownFar.Size = new Size(94, 29);
            btnDownFar.TabIndex = 8;
            btnDownFar.Text = "Down+";
            btnDownFar.UseVisualStyleBackColor = true;
            btnDownFar.Click += btnDownFar_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(121, 447);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(94, 29);
            btnDown.TabIndex = 7;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(121, 348);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(94, 29);
            btnUp.TabIndex = 6;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnUpFar
            // 
            btnUpFar.Location = new Point(121, 313);
            btnUpFar.Name = "btnUpFar";
            btnUpFar.Size = new Size(94, 29);
            btnUpFar.TabIndex = 5;
            btnUpFar.Text = "Up+";
            btnUpFar.UseVisualStyleBackColor = true;
            btnUpFar.Click += btnUpFar_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(6, 205);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(335, 52);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати об'єкт";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(6, 141);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(335, 58);
            btnHide.TabIndex = 3;
            btnHide.Text = "Приховати об'єкт";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(6, 77);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(335, 58);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "Створити новий об'єкт";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Перелік об'єктів";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 655);
            Controls.Add(pnTools);
            Controls.Add(pnMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCircles;
        private Panel pnMain;
        private Panel pnTools;
        private Button btnShow;
        private Button btnHide;
        private Button btnCreateNew;
        private Label label1;
        private Button btnCollapse;
        private Button btnExpand;
        private Button btnRightFar;
        private Button btnRight;
        private Button btnLeftFar;
        private Button btnLeft;
        private Button btnDownFar;
        private Button btnDown;
        private Button btnUp;
        private Button btnUpFar;
    }
}