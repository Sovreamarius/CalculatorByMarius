namespace CalculatorByMarius
{
    partial class Calculator
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
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.NullButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.LbResult = new System.Windows.Forms.Label();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.ColumnCount = 4;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.Controls.Add(this.UndoButton, 0, 4);
            this.Panel.Controls.Add(this.CButton, 1, 0);
            this.Panel.Controls.Add(this.EqualButton, 3, 4);
            this.Panel.Controls.Add(this.DotButton, 2, 4);
            this.Panel.Controls.Add(this.NullButton, 1, 4);
            this.Panel.Controls.Add(this.PlusButton, 3, 3);
            this.Panel.Controls.Add(this.ThreeButton, 2, 3);
            this.Panel.Controls.Add(this.TwoButton, 1, 3);
            this.Panel.Controls.Add(this.OneButton, 0, 3);
            this.Panel.Controls.Add(this.MinusButton, 3, 2);
            this.Panel.Controls.Add(this.SixButton, 2, 2);
            this.Panel.Controls.Add(this.FiveButton, 1, 2);
            this.Panel.Controls.Add(this.FourButton, 0, 2);
            this.Panel.Controls.Add(this.MultiplyButton, 3, 1);
            this.Panel.Controls.Add(this.NineButton, 2, 1);
            this.Panel.Controls.Add(this.EightButton, 1, 1);
            this.Panel.Controls.Add(this.SevenButton, 0, 1);
            this.Panel.Controls.Add(this.DivisionButton, 3, 0);
            this.Panel.Controls.Add(this.BackspaceButton, 2, 0);
            this.Panel.Controls.Add(this.CEButton, 0, 0);
            this.Panel.Location = new System.Drawing.Point(12, 105);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 5;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.Size = new System.Drawing.Size(368, 280);
            this.Panel.TabIndex = 2;
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.PaleGreen;
            this.UndoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.Location = new System.Drawing.Point(3, 227);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(86, 50);
            this.UndoButton.TabIndex = 21;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.LightGreen;
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.CButton.Location = new System.Drawing.Point(95, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(86, 50);
            this.CButton.TabIndex = 20;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.DarkGreen;
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.EqualButton.Location = new System.Drawing.Point(279, 227);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(86, 50);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.SlateGray;
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(187, 227);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(86, 50);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // NullButton
            // 
            this.NullButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NullButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NullButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.NullButton.Location = new System.Drawing.Point(95, 227);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(86, 50);
            this.NullButton.TabIndex = 17;
            this.NullButton.Text = "0";
            this.NullButton.UseVisualStyleBackColor = false;
            this.NullButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.PlusButton.Location = new System.Drawing.Point(279, 171);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(86, 50);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.ThreeButton.Location = new System.Drawing.Point(187, 171);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(86, 50);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.TwoButton.Location = new System.Drawing.Point(95, 171);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(86, 50);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.OneButton.Location = new System.Drawing.Point(3, 171);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(86, 50);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MinusButton.Location = new System.Drawing.Point(279, 115);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(86, 50);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.SixButton.Location = new System.Drawing.Point(187, 115);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(86, 50);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.FiveButton.Location = new System.Drawing.Point(95, 115);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(86, 50);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.FourButton.Location = new System.Drawing.Point(3, 115);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(86, 50);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MultiplyButton.Location = new System.Drawing.Point(279, 59);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(86, 50);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.NineButton.Location = new System.Drawing.Point(187, 59);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(86, 50);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.EightButton.Location = new System.Drawing.Point(95, 59);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(86, 50);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.SevenButton.Location = new System.Drawing.Point(3, 59);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(86, 50);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DivisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.DivisionButton.Location = new System.Drawing.Point(279, 3);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(86, 50);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.OperatorsEvent);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.Color.LightGreen;
            this.BackspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.BackspaceButton.Location = new System.Drawing.Point(187, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(86, 50);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "<-";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.LightGreen;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(86, 50);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResult.Location = new System.Drawing.Point(12, 9);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(0, 15);
            this.LbResult.TabIndex = 5;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(15, 54);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(362, 45);
            this.TxtDisplay.TabIndex = 6;
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AcceptButton = this.EqualButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(392, 397);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

