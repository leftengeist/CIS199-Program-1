namespace Prog1
{
    partial class CarpetEstimatorForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.maxWidthLbl = new System.Windows.Forms.Label();
            this.maxLengthLbl = new System.Windows.Forms.Label();
            this.carpetPriceLbl = new System.Windows.Forms.Label();
            this.paddingUsedLbl = new System.Windows.Forms.Label();
            this.roomNumberLbl = new System.Windows.Forms.Label();
            this.squareYardsLbl = new System.Windows.Forms.Label();
            this.carpetCostLbl = new System.Windows.Forms.Label();
            this.paddingCostLbl = new System.Windows.Forms.Label();
            this.laborCostLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.outSquareYardsLbl = new System.Windows.Forms.Label();
            this.outCarpetCostLbl = new System.Windows.Forms.Label();
            this.outPaddingCostLbl = new System.Windows.Forms.Label();
            this.outLaborCostLbl = new System.Windows.Forms.Label();
            this.outTotalCostLbl = new System.Windows.Forms.Label();
            this.paddingLayersTxt = new System.Windows.Forms.TextBox();
            this.firstRoomTxt = new System.Windows.Forms.TextBox();
            this.maxWidthTxt = new System.Windows.Forms.TextBox();
            this.maxLengthTxt = new System.Windows.Forms.TextBox();
            this.carpetPriceTxt = new System.Windows.Forms.TextBox();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Location = new System.Drawing.Point(403, 255);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 46);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maxWidthLbl
            // 
            this.maxWidthLbl.AutoSize = true;
            this.maxWidthLbl.Location = new System.Drawing.Point(34, 15);
            this.maxWidthLbl.Name = "maxWidthLbl";
            this.maxWidthLbl.Size = new System.Drawing.Size(328, 25);
            this.maxWidthLbl.TabIndex = 1;
            this.maxWidthLbl.Text = "Enter max width of room (in feet):";
            this.maxWidthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxLengthLbl
            // 
            this.maxLengthLbl.AutoSize = true;
            this.maxLengthLbl.Location = new System.Drawing.Point(34, 52);
            this.maxLengthLbl.Name = "maxLengthLbl";
            this.maxLengthLbl.Size = new System.Drawing.Size(337, 25);
            this.maxLengthLbl.TabIndex = 2;
            this.maxLengthLbl.Text = "Enter max length of room (in feet):";
            this.maxLengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carpetPriceLbl
            // 
            this.carpetPriceLbl.AutoSize = true;
            this.carpetPriceLbl.Location = new System.Drawing.Point(34, 89);
            this.carpetPriceLbl.Name = "carpetPriceLbl";
            this.carpetPriceLbl.Size = new System.Drawing.Size(358, 25);
            this.carpetPriceLbl.TabIndex = 3;
            this.carpetPriceLbl.Text = "Enter the carpet price (per sq. yard):";
            this.carpetPriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingUsedLbl
            // 
            this.paddingUsedLbl.AutoSize = true;
            this.paddingUsedLbl.Location = new System.Drawing.Point(34, 126);
            this.paddingUsedLbl.Name = "paddingUsedLbl";
            this.paddingUsedLbl.Size = new System.Drawing.Size(380, 25);
            this.paddingUsedLbl.TabIndex = 4;
            this.paddingUsedLbl.Text = "Enter layers of padding to use (1 or 2):";
            this.paddingUsedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomNumberLbl
            // 
            this.roomNumberLbl.AutoSize = true;
            this.roomNumberLbl.Location = new System.Drawing.Point(34, 163);
            this.roomNumberLbl.Name = "roomNumberLbl";
            this.roomNumberLbl.Size = new System.Drawing.Size(395, 25);
            this.roomNumberLbl.TabIndex = 5;
            this.roomNumberLbl.Text = "Is this the first room? (0 = NO, 1 = YES):";
            this.roomNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // squareYardsLbl
            // 
            this.squareYardsLbl.AutoSize = true;
            this.squareYardsLbl.Location = new System.Drawing.Point(34, 266);
            this.squareYardsLbl.Name = "squareYardsLbl";
            this.squareYardsLbl.Size = new System.Drawing.Size(194, 25);
            this.squareYardsLbl.TabIndex = 6;
            this.squareYardsLbl.Text = "Sq. Yards Needed:";
            this.squareYardsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carpetCostLbl
            // 
            this.carpetCostLbl.AutoSize = true;
            this.carpetCostLbl.Location = new System.Drawing.Point(34, 303);
            this.carpetCostLbl.Name = "carpetCostLbl";
            this.carpetCostLbl.Size = new System.Drawing.Size(132, 25);
            this.carpetCostLbl.TabIndex = 7;
            this.carpetCostLbl.Text = "Carpet Cost:";
            this.carpetCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingCostLbl
            // 
            this.paddingCostLbl.AutoSize = true;
            this.paddingCostLbl.Location = new System.Drawing.Point(34, 340);
            this.paddingCostLbl.Name = "paddingCostLbl";
            this.paddingCostLbl.Size = new System.Drawing.Size(147, 25);
            this.paddingCostLbl.TabIndex = 8;
            this.paddingCostLbl.Text = "Padding Cost:";
            this.paddingCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laborCostLbl
            // 
            this.laborCostLbl.AutoSize = true;
            this.laborCostLbl.Location = new System.Drawing.Point(34, 377);
            this.laborCostLbl.Name = "laborCostLbl";
            this.laborCostLbl.Size = new System.Drawing.Size(123, 25);
            this.laborCostLbl.TabIndex = 9;
            this.laborCostLbl.Text = "Labor Cost:";
            this.laborCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(34, 414);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(116, 25);
            this.totalCostLbl.TabIndex = 10;
            this.totalCostLbl.Text = "Total Cost:";
            this.totalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outSquareYardsLbl
            // 
            this.outSquareYardsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outSquareYardsLbl.Location = new System.Drawing.Point(234, 266);
            this.outSquareYardsLbl.Name = "outSquareYardsLbl";
            this.outSquareYardsLbl.Size = new System.Drawing.Size(128, 25);
            this.outSquareYardsLbl.TabIndex = 11;
            this.outSquareYardsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outCarpetCostLbl
            // 
            this.outCarpetCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outCarpetCostLbl.Location = new System.Drawing.Point(234, 303);
            this.outCarpetCostLbl.Name = "outCarpetCostLbl";
            this.outCarpetCostLbl.Size = new System.Drawing.Size(128, 25);
            this.outCarpetCostLbl.TabIndex = 12;
            this.outCarpetCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outPaddingCostLbl
            // 
            this.outPaddingCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPaddingCostLbl.Location = new System.Drawing.Point(234, 340);
            this.outPaddingCostLbl.Name = "outPaddingCostLbl";
            this.outPaddingCostLbl.Size = new System.Drawing.Size(128, 25);
            this.outPaddingCostLbl.TabIndex = 13;
            this.outPaddingCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outLaborCostLbl
            // 
            this.outLaborCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outLaborCostLbl.Location = new System.Drawing.Point(234, 377);
            this.outLaborCostLbl.Name = "outLaborCostLbl";
            this.outLaborCostLbl.Size = new System.Drawing.Size(128, 25);
            this.outLaborCostLbl.TabIndex = 14;
            this.outLaborCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outTotalCostLbl
            // 
            this.outTotalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outTotalCostLbl.Location = new System.Drawing.Point(234, 414);
            this.outTotalCostLbl.Name = "outTotalCostLbl";
            this.outTotalCostLbl.Size = new System.Drawing.Size(128, 25);
            this.outTotalCostLbl.TabIndex = 15;
            this.outTotalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingLayersTxt
            // 
            this.paddingLayersTxt.Location = new System.Drawing.Point(435, 123);
            this.paddingLayersTxt.Name = "paddingLayersTxt";
            this.paddingLayersTxt.Size = new System.Drawing.Size(100, 31);
            this.paddingLayersTxt.TabIndex = 16;
            // 
            // firstRoomTxt
            // 
            this.firstRoomTxt.Location = new System.Drawing.Point(435, 160);
            this.firstRoomTxt.Name = "firstRoomTxt";
            this.firstRoomTxt.Size = new System.Drawing.Size(100, 31);
            this.firstRoomTxt.TabIndex = 17;
            // 
            // maxWidthTxt
            // 
            this.maxWidthTxt.Location = new System.Drawing.Point(435, 12);
            this.maxWidthTxt.Name = "maxWidthTxt";
            this.maxWidthTxt.Size = new System.Drawing.Size(100, 31);
            this.maxWidthTxt.TabIndex = 18;
            // 
            // maxLengthTxt
            // 
            this.maxLengthTxt.Location = new System.Drawing.Point(435, 49);
            this.maxLengthTxt.Name = "maxLengthTxt";
            this.maxLengthTxt.Size = new System.Drawing.Size(100, 31);
            this.maxLengthTxt.TabIndex = 19;
            // 
            // carpetPriceTxt
            // 
            this.carpetPriceTxt.Location = new System.Drawing.Point(435, 86);
            this.carpetPriceTxt.Name = "carpetPriceTxt";
            this.carpetPriceTxt.Size = new System.Drawing.Size(100, 31);
            this.carpetPriceTxt.TabIndex = 20;
            // 
            // clearFormButton
            // 
            this.clearFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearFormButton.Location = new System.Drawing.Point(403, 319);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(150, 46);
            this.clearFormButton.TabIndex = 21;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(385, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 29);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CarpetEstimatorForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.clearFormButton;
            this.ClientSize = new System.Drawing.Size(577, 472);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.carpetPriceTxt);
            this.Controls.Add(this.maxLengthTxt);
            this.Controls.Add(this.maxWidthTxt);
            this.Controls.Add(this.firstRoomTxt);
            this.Controls.Add(this.paddingLayersTxt);
            this.Controls.Add(this.outTotalCostLbl);
            this.Controls.Add(this.outLaborCostLbl);
            this.Controls.Add(this.outPaddingCostLbl);
            this.Controls.Add(this.outCarpetCostLbl);
            this.Controls.Add(this.outSquareYardsLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.laborCostLbl);
            this.Controls.Add(this.paddingCostLbl);
            this.Controls.Add(this.carpetCostLbl);
            this.Controls.Add(this.squareYardsLbl);
            this.Controls.Add(this.roomNumberLbl);
            this.Controls.Add(this.paddingUsedLbl);
            this.Controls.Add(this.carpetPriceLbl);
            this.Controls.Add(this.maxLengthLbl);
            this.Controls.Add(this.maxWidthLbl);
            this.Controls.Add(this.calculateButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarpetEstimatorForm";
            this.Text = "Carpet Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label maxWidthLbl;
        private System.Windows.Forms.Label maxLengthLbl;
        private System.Windows.Forms.Label carpetPriceLbl;
        private System.Windows.Forms.Label paddingUsedLbl;
        private System.Windows.Forms.Label roomNumberLbl;
        private System.Windows.Forms.Label squareYardsLbl;
        private System.Windows.Forms.Label carpetCostLbl;
        private System.Windows.Forms.Label paddingCostLbl;
        private System.Windows.Forms.Label laborCostLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label outSquareYardsLbl;
        private System.Windows.Forms.Label outCarpetCostLbl;
        private System.Windows.Forms.Label outPaddingCostLbl;
        private System.Windows.Forms.Label outLaborCostLbl;
        private System.Windows.Forms.Label outTotalCostLbl;
        private System.Windows.Forms.TextBox paddingLayersTxt;
        private System.Windows.Forms.TextBox firstRoomTxt;
        private System.Windows.Forms.TextBox maxWidthTxt;
        private System.Windows.Forms.TextBox maxLengthTxt;
        private System.Windows.Forms.TextBox carpetPriceTxt;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

