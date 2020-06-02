namespace Assym
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Params = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.ListBox();
            this.p = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.Fe = new System.Windows.Forms.Label();
            this.en = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Params
            // 
            this.Params.Location = new System.Drawing.Point(13, 13);
            this.Params.Name = "Params";
            this.Params.Size = new System.Drawing.Size(195, 23);
            this.Params.TabIndex = 0;
            this.Params.Text = "Рассчитать параметры";
            this.Params.UseVisualStyleBackColor = true;
            this.Params.Click += new System.EventHandler(this.Params_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "e:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "d:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Кодируемое сообщение:";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(13, 201);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(208, 71);
            this.Input.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Закодированное сообщение:";
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(12, 300);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(208, 82);
            this.Output.TabIndex = 10;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(26, 39);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(0, 13);
            this.p.TabIndex = 11;
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(26, 64);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(0, 13);
            this.q.TabIndex = 12;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(26, 87);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(0, 13);
            this.n.TabIndex = 13;
            // 
            // Fe
            // 
            this.Fe.AutoSize = true;
            this.Fe.Location = new System.Drawing.Point(29, 109);
            this.Fe.Name = "Fe";
            this.Fe.Size = new System.Drawing.Size(0, 13);
            this.Fe.TabIndex = 14;
            // 
            // en
            // 
            this.en.AutoSize = true;
            this.en.Location = new System.Drawing.Point(26, 132);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(0, 13);
            this.en.TabIndex = 15;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(26, 155);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(0, 13);
            this.d.TabIndex = 16;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(12, 389);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(101, 23);
            this.Code.TabIndex = 17;
            this.Code.Text = "Кодировать";
            this.Code.UseVisualStyleBackColor = true;
            this.Code.Click += new System.EventHandler(this.Code_Click);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(120, 389);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(100, 23);
            this.Decode.TabIndex = 18;
            this.Decode.Text = "Декодировать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 450);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.d);
            this.Controls.Add(this.en);
            this.Controls.Add(this.Fe);
            this.Controls.Add(this.n);
            this.Controls.Add(this.q);
            this.Controls.Add(this.p);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Params);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Params;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label Fe;
        private System.Windows.Forms.Label en;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button Code;
        private System.Windows.Forms.Button Decode;
    }
}

