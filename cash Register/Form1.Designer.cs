
namespace cash_Register
{
    partial class form1
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
            this.bread = new System.Windows.Forms.Label();
            this.milk = new System.Windows.Forms.Label();
            this.milkInput = new System.Windows.Forms.TextBox();
            this.breadInput = new System.Windows.Forms.TextBox();
            this.egg = new System.Windows.Forms.Label();
            this.eggInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.outputSub = new System.Windows.Forms.Label();
            this.Shop = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.payMethod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bread
            // 
            this.bread.AutoSize = true;
            this.bread.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bread.Location = new System.Drawing.Point(21, 62);
            this.bread.Name = "bread";
            this.bread.Size = new System.Drawing.Size(94, 36);
            this.bread.TabIndex = 0;
            this.bread.Text = "Bread";
            this.bread.Click += new System.EventHandler(this.bread_Click);
            // 
            // milk
            // 
            this.milk.AutoSize = true;
            this.milk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milk.Location = new System.Drawing.Point(46, 100);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(69, 36);
            this.milk.TabIndex = 1;
            this.milk.Text = "Milk";
            this.milk.Click += new System.EventHandler(this.label2_Click);
            // 
            // milkInput
            // 
            this.milkInput.Location = new System.Drawing.Point(121, 113);
            this.milkInput.Name = "milkInput";
            this.milkInput.Size = new System.Drawing.Size(50, 22);
            this.milkInput.TabIndex = 2;
            // 
            // breadInput
            // 
            this.breadInput.Location = new System.Drawing.Point(121, 75);
            this.breadInput.Name = "breadInput";
            this.breadInput.Size = new System.Drawing.Size(50, 22);
            this.breadInput.TabIndex = 3;
            this.breadInput.TextChanged += new System.EventHandler(this.boxB_TextChanged);
            // 
            // egg
            // 
            this.egg.AutoSize = true;
            this.egg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egg.Location = new System.Drawing.Point(31, 139);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(84, 36);
            this.egg.TabIndex = 4;
            this.egg.Text = "Eggs";
            // 
            // eggInput
            // 
            this.eggInput.Location = new System.Drawing.Point(121, 152);
            this.eggInput.Name = "eggInput";
            this.eggInput.Size = new System.Drawing.Size(50, 22);
            this.eggInput.TabIndex = 7;
            this.eggInput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 194);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(202, 36);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate total";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputSub
            // 
            this.outputSub.AutoSize = true;
            this.outputSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSub.Location = new System.Drawing.Point(47, 244);
            this.outputSub.Name = "outputSub";
            this.outputSub.Size = new System.Drawing.Size(0, 25);
            this.outputSub.TabIndex = 9;
            // 
            // Shop
            // 
            this.Shop.AutoSize = true;
            this.Shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shop.Location = new System.Drawing.Point(263, 9);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(106, 42);
            this.Shop.TabIndex = 10;
            this.Shop.Text = "Shop";
            this.Shop.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputTax
            // 
            this.outputTax.AutoSize = true;
            this.outputTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTax.Location = new System.Drawing.Point(47, 282);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(0, 25);
            this.outputTax.TabIndex = 11;
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTotal.Location = new System.Drawing.Point(47, 318);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(0, 25);
            this.outputTotal.TabIndex = 12;
            // 
            // payMethod
            // 
            this.payMethod.AutoSize = true;
            this.payMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMethod.Location = new System.Drawing.Point(12, 401);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(247, 25);
            this.payMethod.TabIndex = 13;
            this.payMethod.Text = "How would you like to pay?";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 550);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.outputSub);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.eggInput);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.breadInput);
            this.Controls.Add(this.milkInput);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.bread);
            this.Name = "form1";
            this.Text = "cash register";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bread;
        private System.Windows.Forms.Label milk;
        private System.Windows.Forms.TextBox milkInput;
        private System.Windows.Forms.TextBox breadInput;
        private System.Windows.Forms.Label egg;
        private System.Windows.Forms.TextBox eggInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label outputSub;
        private System.Windows.Forms.Label Shop;
        private System.Windows.Forms.Label outputTax;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Label payMethod;
    }
}

