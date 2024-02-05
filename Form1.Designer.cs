
namespace _8_Lumberjacks_Eat_Flapjacks
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lumberjackName = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.breakfastLineText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.numberFlapjacks = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFlapjacks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack Name";
            // 
            // lumberjackName
            // 
            this.lumberjackName.Location = new System.Drawing.Point(122, 6);
            this.lumberjackName.Name = "lumberjackName";
            this.lumberjackName.Size = new System.Drawing.Size(159, 20);
            this.lumberjackName.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(15, 25);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(97, 28);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Add Lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast Line";
            // 
            // breakfastLineText
            // 
            this.breakfastLineText.Location = new System.Drawing.Point(15, 80);
            this.breakfastLineText.Multiline = true;
            this.breakfastLineText.Name = "breakfastLineText";
            this.breakfastLineText.Size = new System.Drawing.Size(99, 243);
            this.breakfastLineText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.numberFlapjacks);
            this.groupBox1.Location = new System.Drawing.Point(122, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 291);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(21, 251);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(99, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Next Lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(20, 184);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(109, 52);
            this.nextInLine.TabIndex = 6;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(19, 136);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(101, 36);
            this.addFlapjacks.TabIndex = 5;
            this.addFlapjacks.Text = "Add Flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // numberFlapjacks
            // 
            this.numberFlapjacks.Location = new System.Drawing.Point(6, 19);
            this.numberFlapjacks.Name = "numberFlapjacks";
            this.numberFlapjacks.Size = new System.Drawing.Size(76, 20);
            this.numberFlapjacks.TabIndex = 0;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Cursor = System.Windows.Forms.Cursors.Default;
            this.crispy.Location = new System.Drawing.Point(29, 49);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 8;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(29, 72);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 9;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(29, 95);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 10;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Checked = true;
            this.banana.Location = new System.Drawing.Point(29, 118);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 11;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.breakfastLineText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.lumberjackName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFlapjacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lumberjackName;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breakfastLineText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.TextBox nextInLine;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.NumericUpDown numberFlapjacks;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
    }
}

