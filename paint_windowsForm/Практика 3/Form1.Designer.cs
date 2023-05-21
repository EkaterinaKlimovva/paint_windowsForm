
namespace curves
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
            this.btPoint = new System.Windows.Forms.Button();
            this.btParametrs = new System.Windows.Forms.Button();
            this.btMovement = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCurve = new System.Windows.Forms.Button();
            this.btPolyline = new System.Windows.Forms.Button();
            this.btBeziers = new System.Windows.Forms.Button();
            this.btFilled = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btSave = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPoint
            // 
            this.btPoint.Location = new System.Drawing.Point(0, 2);
            this.btPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btPoint.Name = "btPoint";
            this.btPoint.Size = new System.Drawing.Size(103, 35);
            this.btPoint.TabIndex = 0;
            this.btPoint.Text = "Точки";
            this.btPoint.UseVisualStyleBackColor = true;
            // 
            // btParametrs
            // 
            this.btParametrs.Location = new System.Drawing.Point(0, 41);
            this.btParametrs.Margin = new System.Windows.Forms.Padding(2);
            this.btParametrs.Name = "btParametrs";
            this.btParametrs.Size = new System.Drawing.Size(103, 37);
            this.btParametrs.TabIndex = 1;
            this.btParametrs.Text = "Параметры";
            this.btParametrs.UseVisualStyleBackColor = true;
            // 
            // btMovement
            // 
            this.btMovement.Location = new System.Drawing.Point(0, 246);
            this.btMovement.Margin = new System.Windows.Forms.Padding(2);
            this.btMovement.Name = "btMovement";
            this.btMovement.Size = new System.Drawing.Size(103, 38);
            this.btMovement.TabIndex = 2;
            this.btMovement.Text = "Движение";
            this.btMovement.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(0, 288);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(103, 38);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btCurve
            // 
            this.btCurve.Location = new System.Drawing.Point(0, 82);
            this.btCurve.Margin = new System.Windows.Forms.Padding(2);
            this.btCurve.Name = "btCurve";
            this.btCurve.Size = new System.Drawing.Size(103, 38);
            this.btCurve.TabIndex = 4;
            this.btCurve.Text = "Кривая";
            this.btCurve.UseVisualStyleBackColor = true;
            // 
            // btPolyline
            // 
            this.btPolyline.Location = new System.Drawing.Point(0, 124);
            this.btPolyline.Margin = new System.Windows.Forms.Padding(2);
            this.btPolyline.Name = "btPolyline";
            this.btPolyline.Size = new System.Drawing.Size(103, 36);
            this.btPolyline.TabIndex = 5;
            this.btPolyline.Text = "Ломанная";
            this.btPolyline.UseVisualStyleBackColor = true;
            // 
            // btBeziers
            // 
            this.btBeziers.Location = new System.Drawing.Point(0, 164);
            this.btBeziers.Margin = new System.Windows.Forms.Padding(2);
            this.btBeziers.Name = "btBeziers";
            this.btBeziers.Size = new System.Drawing.Size(103, 35);
            this.btBeziers.TabIndex = 6;
            this.btBeziers.Text = "Безье";
            this.btBeziers.UseVisualStyleBackColor = true;
            // 
            // btFilled
            // 
            this.btFilled.Location = new System.Drawing.Point(0, 203);
            this.btFilled.Margin = new System.Windows.Forms.Padding(2);
            this.btFilled.Name = "btFilled";
            this.btFilled.Size = new System.Drawing.Size(103, 39);
            this.btFilled.TabIndex = 7;
            this.btFilled.Text = "Заполненная";
            this.btFilled.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(0, 330);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(103, 38);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Сохранение";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(0, 372);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(103, 38);
            this.Close.TabIndex = 9;
            this.Close.Text = "Выход";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 411);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btFilled);
            this.Controls.Add(this.btBeziers);
            this.Controls.Add(this.btPolyline);
            this.Controls.Add(this.btCurve);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btMovement);
            this.Controls.Add(this.btParametrs);
            this.Controls.Add(this.btPoint);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPoint;
        private System.Windows.Forms.Button btParametrs;
        private System.Windows.Forms.Button btMovement;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCurve;
        private System.Windows.Forms.Button btPolyline;
        private System.Windows.Forms.Button btBeziers;
        private System.Windows.Forms.Button btFilled;
        private System.Windows.Forms.Button btSave;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Close;
    }
}

