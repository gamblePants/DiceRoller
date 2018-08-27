namespace DiceRoller
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
            this.pbD6 = new System.Windows.Forms.PictureBox();
            this.pbD4 = new System.Windows.Forms.PictureBox();
            this.pbD8 = new System.Windows.Forms.PictureBox();
            this.pbD12 = new System.Windows.Forms.PictureBox();
            this.pbD10 = new System.Windows.Forms.PictureBox();
            this.pbD20 = new System.Windows.Forms.PictureBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblModifier = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.nudMultiplier = new System.Windows.Forms.NumericUpDown();
            this.nudModifier = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // pbD6
            // 
            this.pbD6.Image = global::DiceRoller.Properties.Resources.d6;
            this.pbD6.Location = new System.Drawing.Point(221, 60);
            this.pbD6.Name = "pbD6";
            this.pbD6.Size = new System.Drawing.Size(77, 78);
            this.pbD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD6.TabIndex = 1;
            this.pbD6.TabStop = false;
            this.pbD6.Click += new System.EventHandler(this.pbD6_Click);
            // 
            // pbD4
            // 
            this.pbD4.Image = ((System.Drawing.Image)(resources.GetObject("pbD4.Image")));
            this.pbD4.Location = new System.Drawing.Point(95, 60);
            this.pbD4.Name = "pbD4";
            this.pbD4.Size = new System.Drawing.Size(77, 78);
            this.pbD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD4.TabIndex = 0;
            this.pbD4.TabStop = false;
            this.pbD4.Click += new System.EventHandler(this.pbD4_Click);
            // 
            // pbD8
            // 
            this.pbD8.Image = global::DiceRoller.Properties.Resources.d8;
            this.pbD8.Location = new System.Drawing.Point(351, 60);
            this.pbD8.Name = "pbD8";
            this.pbD8.Size = new System.Drawing.Size(77, 78);
            this.pbD8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD8.TabIndex = 2;
            this.pbD8.TabStop = false;
            this.pbD8.Click += new System.EventHandler(this.pbD8_Click);
            // 
            // pbD12
            // 
            this.pbD12.Image = global::DiceRoller.Properties.Resources.d12;
            this.pbD12.Location = new System.Drawing.Point(221, 197);
            this.pbD12.Name = "pbD12";
            this.pbD12.Size = new System.Drawing.Size(77, 78);
            this.pbD12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD12.TabIndex = 3;
            this.pbD12.TabStop = false;
            this.pbD12.Click += new System.EventHandler(this.pbD12_Click);
            // 
            // pbD10
            // 
            this.pbD10.Image = global::DiceRoller.Properties.Resources.d10;
            this.pbD10.Location = new System.Drawing.Point(95, 197);
            this.pbD10.Name = "pbD10";
            this.pbD10.Size = new System.Drawing.Size(77, 78);
            this.pbD10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD10.TabIndex = 4;
            this.pbD10.TabStop = false;
            this.pbD10.Click += new System.EventHandler(this.pbD10_Click);
            // 
            // pbD20
            // 
            this.pbD20.Image = global::DiceRoller.Properties.Resources.d20;
            this.pbD20.Location = new System.Drawing.Point(351, 197);
            this.pbD20.Name = "pbD20";
            this.pbD20.Size = new System.Drawing.Size(77, 78);
            this.pbD20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD20.TabIndex = 5;
            this.pbD20.TabStop = false;
            this.pbD20.Click += new System.EventHandler(this.pbD20_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(502, 60);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(208, 34);
            this.lblSelected.TabIndex = 6;
            this.lblSelected.Text = "Die Selected: d20";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(502, 111);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(158, 34);
            this.lblMultiplier.TabIndex = 7;
            this.lblMultiplier.Text = "No. of Dice:";
            // 
            // lblModifier
            // 
            this.lblModifier.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier.Location = new System.Drawing.Point(502, 173);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(128, 34);
            this.lblModifier.TabIndex = 8;
            this.lblModifier.Text = "Modifier:";
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRoll.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(500, 234);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(139, 41);
            this.btnRoll.TabIndex = 9;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // nudMultiplier
            // 
            this.nudMultiplier.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMultiplier.Location = new System.Drawing.Point(687, 109);
            this.nudMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMultiplier.Name = "nudMultiplier";
            this.nudMultiplier.Size = new System.Drawing.Size(64, 38);
            this.nudMultiplier.TabIndex = 10;
            this.nudMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMultiplier.ValueChanged += new System.EventHandler(this.nudMultiplier_ValueChanged);
            // 
            // nudModifier
            // 
            this.nudModifier.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudModifier.Location = new System.Drawing.Point(687, 169);
            this.nudModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudModifier.Name = "nudModifier";
            this.nudModifier.Size = new System.Drawing.Size(64, 38);
            this.nudModifier.TabIndex = 11;
            this.nudModifier.ValueChanged += new System.EventHandler(this.nudModifier_ValueChanged);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(672, 234);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 41);
            this.lblResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.nudModifier);
            this.Controls.Add(this.nudMultiplier);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblModifier);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.pbD20);
            this.Controls.Add(this.pbD10);
            this.Controls.Add(this.pbD12);
            this.Controls.Add(this.pbD8);
            this.Controls.Add(this.pbD6);
            this.Controls.Add(this.pbD4);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.pbD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbD4;
        private System.Windows.Forms.PictureBox pbD6;
        private System.Windows.Forms.PictureBox pbD8;
        private System.Windows.Forms.PictureBox pbD12;
        private System.Windows.Forms.PictureBox pbD10;
        private System.Windows.Forms.PictureBox pbD20;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.NumericUpDown nudMultiplier;
        private System.Windows.Forms.NumericUpDown nudModifier;
        private System.Windows.Forms.Label lblResult;
    }
}

