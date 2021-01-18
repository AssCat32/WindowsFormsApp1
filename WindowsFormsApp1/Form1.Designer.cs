
namespace WindowsFormsApp1
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
            this.Createbutton = new System.Windows.Forms.Button();
            this.ReadtextBox = new System.Windows.Forms.TextBox();
            this.ChetSumButton = new System.Windows.Forms.Button();
            this.OutputtextBox = new System.Windows.Forms.TextBox();
            this.NeChetbutton = new System.Windows.Forms.Button();
            this.ArraytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreatebuttonList = new System.Windows.Forms.Button();
            this.ChetbuttonList = new System.Windows.Forms.Button();
            this.NeChetbuttonList = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.InsertFirstM = new System.Windows.Forms.Button();
            this.DeleteFirstM = new System.Windows.Forms.Button();
            this.InsertSecondM = new System.Windows.Forms.Button();
            this.DeleteSecondM = new System.Windows.Forms.Button();
            this.EventFirst = new System.Windows.Forms.Button();
            this.EventSecond = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(0, 121);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(125, 52);
            this.Createbutton.TabIndex = 0;
            this.Createbutton.Text = "CreateArray";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // ReadtextBox
            // 
            this.ReadtextBox.Location = new System.Drawing.Point(68, 11);
            this.ReadtextBox.Name = "ReadtextBox";
            this.ReadtextBox.Size = new System.Drawing.Size(160, 20);
            this.ReadtextBox.TabIndex = 1;
            // 
            // ChetSumButton
            // 
            this.ChetSumButton.Location = new System.Drawing.Point(131, 121);
            this.ChetSumButton.Name = "ChetSumButton";
            this.ChetSumButton.Size = new System.Drawing.Size(75, 23);
            this.ChetSumButton.TabIndex = 2;
            this.ChetSumButton.Text = "ChetSum";
            this.ChetSumButton.UseCompatibleTextRendering = true;
            this.ChetSumButton.UseVisualStyleBackColor = true;
            this.ChetSumButton.Click += new System.EventHandler(this.ChetSumButton_Click);
            // 
            // OutputtextBox
            // 
            this.OutputtextBox.Location = new System.Drawing.Point(68, 65);
            this.OutputtextBox.Name = "OutputtextBox";
            this.OutputtextBox.Size = new System.Drawing.Size(160, 20);
            this.OutputtextBox.TabIndex = 3;
            // 
            // NeChetbutton
            // 
            this.NeChetbutton.Location = new System.Drawing.Point(131, 150);
            this.NeChetbutton.Name = "NeChetbutton";
            this.NeChetbutton.Size = new System.Drawing.Size(75, 23);
            this.NeChetbutton.TabIndex = 4;
            this.NeChetbutton.Text = "NeChetSum";
            this.NeChetbutton.UseCompatibleTextRendering = true;
            this.NeChetbutton.UseVisualStyleBackColor = true;
            this.NeChetbutton.Click += new System.EventHandler(this.NeChetbutton_Click);
            // 
            // ArraytextBox
            // 
            this.ArraytextBox.Location = new System.Drawing.Point(68, 37);
            this.ArraytextBox.Name = "ArraytextBox";
            this.ArraytextBox.Size = new System.Drawing.Size(160, 20);
            this.ArraytextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Array:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sum:";
            // 
            // CreatebuttonList
            // 
            this.CreatebuttonList.Location = new System.Drawing.Point(0, 203);
            this.CreatebuttonList.Name = "CreatebuttonList";
            this.CreatebuttonList.Size = new System.Drawing.Size(125, 52);
            this.CreatebuttonList.TabIndex = 6;
            this.CreatebuttonList.Text = "CreateList";
            this.CreatebuttonList.UseVisualStyleBackColor = true;
            this.CreatebuttonList.Click += new System.EventHandler(this.CreatebuttonList_Click);
            // 
            // ChetbuttonList
            // 
            this.ChetbuttonList.Location = new System.Drawing.Point(131, 203);
            this.ChetbuttonList.Name = "ChetbuttonList";
            this.ChetbuttonList.Size = new System.Drawing.Size(104, 23);
            this.ChetbuttonList.TabIndex = 7;
            this.ChetbuttonList.Text = "ChetSumList";
            this.ChetbuttonList.UseCompatibleTextRendering = true;
            this.ChetbuttonList.UseVisualStyleBackColor = true;
            this.ChetbuttonList.Click += new System.EventHandler(this.ChetbuttonList_Click);
            // 
            // NeChetbuttonList
            // 
            this.NeChetbuttonList.Location = new System.Drawing.Point(131, 232);
            this.NeChetbuttonList.Name = "NeChetbuttonList";
            this.NeChetbuttonList.Size = new System.Drawing.Size(104, 23);
            this.NeChetbuttonList.TabIndex = 8;
            this.NeChetbuttonList.Text = "NeChetSumList";
            this.NeChetbuttonList.UseCompatibleTextRendering = true;
            this.NeChetbuttonList.UseVisualStyleBackColor = true;
            this.NeChetbuttonList.Click += new System.EventHandler(this.NeChetbuttonList_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(378, 11);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(313, 305);
            this.richTextBox.TabIndex = 10;
            this.richTextBox.Text = "";
            // 
            // InsertFirstM
            // 
            this.InsertFirstM.Location = new System.Drawing.Point(391, 319);
            this.InsertFirstM.Name = "InsertFirstM";
            this.InsertFirstM.Size = new System.Drawing.Size(75, 23);
            this.InsertFirstM.TabIndex = 17;
            this.InsertFirstM.Text = "InsertFirstM";
            this.InsertFirstM.UseVisualStyleBackColor = true;
            this.InsertFirstM.Click += new System.EventHandler(this.InsertFirstM_Click);
            // 
            // DeleteFirstM
            // 
            this.DeleteFirstM.Location = new System.Drawing.Point(391, 348);
            this.DeleteFirstM.Name = "DeleteFirstM";
            this.DeleteFirstM.Size = new System.Drawing.Size(75, 23);
            this.DeleteFirstM.TabIndex = 18;
            this.DeleteFirstM.Text = "DeleteFirstM";
            this.DeleteFirstM.UseVisualStyleBackColor = true;
            this.DeleteFirstM.Click += new System.EventHandler(this.DeleteFirstM_Click);
            // 
            // InsertSecondM
            // 
            this.InsertSecondM.Location = new System.Drawing.Point(483, 319);
            this.InsertSecondM.Name = "InsertSecondM";
            this.InsertSecondM.Size = new System.Drawing.Size(91, 23);
            this.InsertSecondM.TabIndex = 19;
            this.InsertSecondM.Text = "InsertSecondM";
            this.InsertSecondM.UseVisualStyleBackColor = true;
            this.InsertSecondM.Click += new System.EventHandler(this.InsertSecondM_Click);
            // 
            // DeleteSecondM
            // 
            this.DeleteSecondM.Location = new System.Drawing.Point(483, 348);
            this.DeleteSecondM.Name = "DeleteSecondM";
            this.DeleteSecondM.Size = new System.Drawing.Size(91, 23);
            this.DeleteSecondM.TabIndex = 20;
            this.DeleteSecondM.Text = "DeleteSecondM";
            this.DeleteSecondM.UseVisualStyleBackColor = true;
            this.DeleteSecondM.Click += new System.EventHandler(this.DeleteSecondM_Click);
            // 
            // EventFirst
            // 
            this.EventFirst.Location = new System.Drawing.Point(594, 319);
            this.EventFirst.Name = "EventFirst";
            this.EventFirst.Size = new System.Drawing.Size(91, 23);
            this.EventFirst.TabIndex = 21;
            this.EventFirst.Text = "EventFirst";
            this.EventFirst.UseVisualStyleBackColor = true;
            this.EventFirst.Click += new System.EventHandler(this.EventFirst_Click);
            // 
            // EventSecond
            // 
            this.EventSecond.Location = new System.Drawing.Point(594, 348);
            this.EventSecond.Name = "EventSecond";
            this.EventSecond.Size = new System.Drawing.Size(91, 23);
            this.EventSecond.TabIndex = 22;
            this.EventSecond.Text = "EventSecond";
            this.EventSecond.UseVisualStyleBackColor = true;
            this.EventSecond.Click += new System.EventHandler(this.EventSecond_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Task:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SecondTask:";
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.Location = new System.Drawing.Point(241, 9);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(131, 264);
            this.listBoxClasses.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArraytextBox);
            this.Controls.Add(this.NeChetbutton);
            this.Controls.Add(this.OutputtextBox);
            this.Controls.Add(this.listBoxClasses);
            this.Controls.Add(this.EventSecond);
            this.Controls.Add(this.EventFirst);
            this.Controls.Add(this.DeleteSecondM);
            this.Controls.Add(this.InsertSecondM);
            this.Controls.Add(this.DeleteFirstM);
            this.Controls.Add(this.InsertFirstM);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.NeChetbuttonList);
            this.Controls.Add(this.ChetbuttonList);
            this.Controls.Add(this.CreatebuttonList);
            this.Controls.Add(this.ChetSumButton);
            this.Controls.Add(this.ReadtextBox);
            this.Controls.Add(this.Createbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.TextBox ReadtextBox;
        private System.Windows.Forms.Button ChetSumButton;
        private System.Windows.Forms.TextBox OutputtextBox;
        private System.Windows.Forms.Button NeChetbutton;
        private System.Windows.Forms.TextBox ArraytextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreatebuttonList;
        private System.Windows.Forms.Button ChetbuttonList;
        private System.Windows.Forms.Button NeChetbuttonList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button InsertFirstM;
        private System.Windows.Forms.Button DeleteFirstM;
        private System.Windows.Forms.Button InsertSecondM;
        private System.Windows.Forms.Button DeleteSecondM;
        private System.Windows.Forms.Button EventFirst;
        private System.Windows.Forms.Button EventSecond;
    }
}

