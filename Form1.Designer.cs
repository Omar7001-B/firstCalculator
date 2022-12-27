namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.numClear = new Guna.UI2.WinForms.Guna2Button();
            this.numSeven = new Guna.UI2.WinForms.Guna2Button();
            this.numEight = new Guna.UI2.WinForms.Guna2Button();
            this.numOne = new Guna.UI2.WinForms.Guna2Button();
            this.numTwo = new Guna.UI2.WinForms.Guna2Button();
            this.numFour = new Guna.UI2.WinForms.Guna2Button();
            this.numFive = new Guna.UI2.WinForms.Guna2Button();
            this.numThree = new Guna.UI2.WinForms.Guna2Button();
            this.numMinus = new Guna.UI2.WinForms.Guna2Button();
            this.numSix = new Guna.UI2.WinForms.Guna2Button();
            this.numPlus = new Guna.UI2.WinForms.Guna2Button();
            this.numNine = new Guna.UI2.WinForms.Guna2Button();
            this.numMul = new Guna.UI2.WinForms.Guna2Button();
            this.numMod = new Guna.UI2.WinForms.Guna2Button();
            this.numDiv = new Guna.UI2.WinForms.Guna2Button();
            this.numEqual = new Guna.UI2.WinForms.Guna2Button();
            this.numZero = new Guna.UI2.WinForms.Guna2Button();
            this.numDot = new Guna.UI2.WinForms.Guna2Button();
            this.textStore = new Guna.UI2.WinForms.Guna2TextBox();
            this.textResult = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageRotate = 0F;
            this.buttonExit.Location = new System.Drawing.Point(326, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonExit.Size = new System.Drawing.Size(46, 47);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(276, 28);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Shallculator OmarAbbas";
            // 
            // numClear
            // 
            this.numClear.BorderRadius = 15;
            this.numClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numClear.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClear.ForeColor = System.Drawing.Color.Black;
            this.numClear.Location = new System.Drawing.Point(33, 311);
            this.numClear.Name = "numClear";
            this.numClear.Size = new System.Drawing.Size(144, 45);
            this.numClear.TabIndex = 3;
            this.numClear.Text = "C";
            this.numClear.Click += new System.EventHandler(this.numClear_Click);
            // 
            // numSeven
            // 
            this.numSeven.BorderRadius = 15;
            this.numSeven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numSeven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numSeven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numSeven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numSeven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numSeven.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeven.ForeColor = System.Drawing.Color.Black;
            this.numSeven.Location = new System.Drawing.Point(33, 362);
            this.numSeven.Name = "numSeven";
            this.numSeven.Size = new System.Drawing.Size(69, 45);
            this.numSeven.TabIndex = 5;
            this.numSeven.Text = "7";
            this.numSeven.Click += new System.EventHandler(this.numSeven_Click);
            // 
            // numEight
            // 
            this.numEight.BorderRadius = 15;
            this.numEight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numEight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numEight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numEight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numEight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEight.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEight.ForeColor = System.Drawing.Color.Black;
            this.numEight.Location = new System.Drawing.Point(108, 362);
            this.numEight.Name = "numEight";
            this.numEight.Size = new System.Drawing.Size(69, 45);
            this.numEight.TabIndex = 4;
            this.numEight.Text = "8";
            this.numEight.Click += new System.EventHandler(this.numEight_Click);
            // 
            // numOne
            // 
            this.numOne.BorderRadius = 15;
            this.numOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numOne.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOne.ForeColor = System.Drawing.Color.Black;
            this.numOne.Location = new System.Drawing.Point(33, 467);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(69, 45);
            this.numOne.TabIndex = 9;
            this.numOne.Text = "1";
            this.numOne.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numTwo
            // 
            this.numTwo.BorderRadius = 15;
            this.numTwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numTwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numTwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numTwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numTwo.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwo.ForeColor = System.Drawing.Color.Black;
            this.numTwo.Location = new System.Drawing.Point(108, 467);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(69, 45);
            this.numTwo.TabIndex = 8;
            this.numTwo.Text = "2";
            this.numTwo.Click += new System.EventHandler(this.numTwo_Click);
            // 
            // numFour
            // 
            this.numFour.BorderRadius = 15;
            this.numFour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numFour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numFour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numFour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numFour.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFour.ForeColor = System.Drawing.Color.Black;
            this.numFour.Location = new System.Drawing.Point(33, 416);
            this.numFour.Name = "numFour";
            this.numFour.Size = new System.Drawing.Size(69, 45);
            this.numFour.TabIndex = 7;
            this.numFour.Text = "4";
            this.numFour.Click += new System.EventHandler(this.numFour_Click);
            // 
            // numFive
            // 
            this.numFive.BorderRadius = 15;
            this.numFive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numFive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numFive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numFive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numFive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numFive.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFive.ForeColor = System.Drawing.Color.Black;
            this.numFive.Location = new System.Drawing.Point(108, 416);
            this.numFive.Name = "numFive";
            this.numFive.Size = new System.Drawing.Size(69, 45);
            this.numFive.TabIndex = 6;
            this.numFive.Text = "5";
            this.numFive.Click += new System.EventHandler(this.numFive_Click);
            // 
            // numThree
            // 
            this.numThree.BorderRadius = 15;
            this.numThree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numThree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numThree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numThree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numThree.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThree.ForeColor = System.Drawing.Color.Black;
            this.numThree.Location = new System.Drawing.Point(183, 467);
            this.numThree.Name = "numThree";
            this.numThree.Size = new System.Drawing.Size(69, 45);
            this.numThree.TabIndex = 17;
            this.numThree.Text = "3";
            this.numThree.Click += new System.EventHandler(this.numThree_Click);
            // 
            // numMinus
            // 
            this.numMinus.BorderRadius = 15;
            this.numMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinus.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinus.ForeColor = System.Drawing.Color.Black;
            this.numMinus.Location = new System.Drawing.Point(258, 467);
            this.numMinus.Name = "numMinus";
            this.numMinus.Size = new System.Drawing.Size(69, 45);
            this.numMinus.TabIndex = 16;
            this.numMinus.Text = "-";
            this.numMinus.Click += new System.EventHandler(this.numMinus_Click);
            // 
            // numSix
            // 
            this.numSix.BorderRadius = 15;
            this.numSix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numSix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numSix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numSix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numSix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numSix.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSix.ForeColor = System.Drawing.Color.Black;
            this.numSix.Location = new System.Drawing.Point(183, 416);
            this.numSix.Name = "numSix";
            this.numSix.Size = new System.Drawing.Size(69, 45);
            this.numSix.TabIndex = 15;
            this.numSix.Text = "6";
            this.numSix.Click += new System.EventHandler(this.numSix_Click);
            // 
            // numPlus
            // 
            this.numPlus.BorderRadius = 15;
            this.numPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numPlus.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlus.ForeColor = System.Drawing.Color.Black;
            this.numPlus.Location = new System.Drawing.Point(258, 416);
            this.numPlus.Name = "numPlus";
            this.numPlus.Size = new System.Drawing.Size(69, 45);
            this.numPlus.TabIndex = 14;
            this.numPlus.Text = "+";
            this.numPlus.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // numNine
            // 
            this.numNine.BorderRadius = 15;
            this.numNine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numNine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numNine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numNine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numNine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numNine.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNine.ForeColor = System.Drawing.Color.Black;
            this.numNine.Location = new System.Drawing.Point(183, 362);
            this.numNine.Name = "numNine";
            this.numNine.Size = new System.Drawing.Size(69, 45);
            this.numNine.TabIndex = 13;
            this.numNine.Text = "9";
            this.numNine.Click += new System.EventHandler(this.numNine_Click);
            // 
            // numMul
            // 
            this.numMul.BorderRadius = 15;
            this.numMul.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numMul.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numMul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numMul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numMul.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMul.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMul.ForeColor = System.Drawing.Color.Black;
            this.numMul.Location = new System.Drawing.Point(258, 362);
            this.numMul.Name = "numMul";
            this.numMul.Size = new System.Drawing.Size(69, 45);
            this.numMul.TabIndex = 12;
            this.numMul.Text = "x";
            this.numMul.Click += new System.EventHandler(this.numMul_Click);
            // 
            // numMod
            // 
            this.numMod.BorderRadius = 15;
            this.numMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numMod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMod.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMod.ForeColor = System.Drawing.Color.Black;
            this.numMod.Location = new System.Drawing.Point(183, 311);
            this.numMod.Name = "numMod";
            this.numMod.Size = new System.Drawing.Size(69, 45);
            this.numMod.TabIndex = 11;
            this.numMod.Text = "%";
            this.numMod.Click += new System.EventHandler(this.numMod_Click);
            // 
            // numDiv
            // 
            this.numDiv.BorderRadius = 15;
            this.numDiv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numDiv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numDiv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numDiv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numDiv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDiv.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiv.ForeColor = System.Drawing.Color.Black;
            this.numDiv.Location = new System.Drawing.Point(258, 311);
            this.numDiv.Name = "numDiv";
            this.numDiv.Size = new System.Drawing.Size(69, 45);
            this.numDiv.TabIndex = 10;
            this.numDiv.Text = "/";
            this.numDiv.Click += new System.EventHandler(this.numDiv_Click);
            // 
            // numEqual
            // 
            this.numEqual.BorderRadius = 15;
            this.numEqual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numEqual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numEqual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEqual.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEqual.ForeColor = System.Drawing.Color.Black;
            this.numEqual.Location = new System.Drawing.Point(183, 518);
            this.numEqual.Name = "numEqual";
            this.numEqual.Size = new System.Drawing.Size(144, 45);
            this.numEqual.TabIndex = 20;
            this.numEqual.Text = "=";
            this.numEqual.Click += new System.EventHandler(this.numEqual_Click);
            // 
            // numZero
            // 
            this.numZero.BorderRadius = 15;
            this.numZero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numZero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numZero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numZero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numZero.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numZero.ForeColor = System.Drawing.Color.Black;
            this.numZero.Location = new System.Drawing.Point(33, 518);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(69, 45);
            this.numZero.TabIndex = 19;
            this.numZero.Text = "0";
            this.numZero.Click += new System.EventHandler(this.numZero_Click);
            // 
            // numDot
            // 
            this.numDot.BorderRadius = 15;
            this.numDot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.numDot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.numDot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.numDot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.numDot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDot.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDot.ForeColor = System.Drawing.Color.Black;
            this.numDot.Location = new System.Drawing.Point(108, 518);
            this.numDot.Name = "numDot";
            this.numDot.Size = new System.Drawing.Size(69, 45);
            this.numDot.TabIndex = 18;
            this.numDot.Text = ".";
            this.numDot.Click += new System.EventHandler(this.numDot_Click);
            // 
            // textStore
            // 
            this.textStore.BorderRadius = 5;
            this.textStore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textStore.DefaultText = "";
            this.textStore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textStore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textStore.FillColor = System.Drawing.Color.Black;
            this.textStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textStore.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStore.ForeColor = System.Drawing.Color.White;
            this.textStore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textStore.Location = new System.Drawing.Point(33, 219);
            this.textStore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textStore.Name = "textStore";
            this.textStore.PasswordChar = '\0';
            this.textStore.PlaceholderText = "0";
            this.textStore.SelectedText = "";
            this.textStore.Size = new System.Drawing.Size(294, 59);
            this.textStore.TabIndex = 21;
            this.textStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStore.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // textResult
            // 
            this.textResult.BorderColor = System.Drawing.Color.White;
            this.textResult.BorderRadius = 1;
            this.textResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textResult.DefaultText = "";
            this.textResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textResult.FillColor = System.Drawing.Color.Black;
            this.textResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textResult.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.Color.White;
            this.textResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textResult.Location = new System.Drawing.Point(33, 134);
            this.textResult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textResult.Name = "textResult";
            this.textResult.PasswordChar = '\0';
            this.textResult.PlaceholderText = "0";
            this.textResult.SelectedText = "";
            this.textResult.Size = new System.Drawing.Size(294, 59);
            this.textResult.TabIndex = 21;
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textResult.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textStore);
            this.Controls.Add(this.numEqual);
            this.Controls.Add(this.numZero);
            this.Controls.Add(this.numDot);
            this.Controls.Add(this.numThree);
            this.Controls.Add(this.numMinus);
            this.Controls.Add(this.numSix);
            this.Controls.Add(this.numPlus);
            this.Controls.Add(this.numNine);
            this.Controls.Add(this.numMul);
            this.Controls.Add(this.numMod);
            this.Controls.Add(this.numDiv);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numFour);
            this.Controls.Add(this.numFive);
            this.Controls.Add(this.numSeven);
            this.Controls.Add(this.numEight);
            this.Controls.Add(this.numClear);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonExit;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button numClear;
        private Guna.UI2.WinForms.Guna2Button numSeven;
        private Guna.UI2.WinForms.Guna2Button numEight;
        private Guna.UI2.WinForms.Guna2Button numOne;
        private Guna.UI2.WinForms.Guna2Button numTwo;
        private Guna.UI2.WinForms.Guna2Button numFour;
        private Guna.UI2.WinForms.Guna2Button numFive;
        private Guna.UI2.WinForms.Guna2Button numThree;
        private Guna.UI2.WinForms.Guna2Button numMinus;
        private Guna.UI2.WinForms.Guna2Button numSix;
        private Guna.UI2.WinForms.Guna2Button numPlus;
        private Guna.UI2.WinForms.Guna2Button numNine;
        private Guna.UI2.WinForms.Guna2Button numMul;
        private Guna.UI2.WinForms.Guna2Button numMod;
        private Guna.UI2.WinForms.Guna2Button numDiv;
        private Guna.UI2.WinForms.Guna2Button numEqual;
        private Guna.UI2.WinForms.Guna2Button numZero;
        private Guna.UI2.WinForms.Guna2Button numDot;
        private Guna.UI2.WinForms.Guna2TextBox textStore;
        private Guna.UI2.WinForms.Guna2TextBox textResult;
    }
}

