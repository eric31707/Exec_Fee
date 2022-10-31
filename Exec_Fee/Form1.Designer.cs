namespace Exec_Fee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.calcubtn = new System.Windows.Forms.Button();
			this.agelbl = new System.Windows.Forms.Label();
			this.boybtn = new System.Windows.Forms.RadioButton();
			this.girlbtn = new System.Windows.Forms.RadioButton();
			this.agetxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.moneylbl = new System.Windows.Forms.Label();
			this.reasonlbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.agetxt);
			this.groupBox1.Controls.Add(this.girlbtn);
			this.groupBox1.Controls.Add(this.boybtn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.agelbl);
			this.groupBox1.Controls.Add(this.calcubtn);
			this.groupBox1.Location = new System.Drawing.Point(39, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(749, 222);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(39, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(749, 198);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox1";
			// 
			// calcubtn
			// 
			this.calcubtn.Location = new System.Drawing.Point(154, 120);
			this.calcubtn.Name = "calcubtn";
			this.calcubtn.Size = new System.Drawing.Size(75, 23);
			this.calcubtn.TabIndex = 0;
			this.calcubtn.Text = "計算";
			this.calcubtn.UseVisualStyleBackColor = true;
			this.calcubtn.Click += new System.EventHandler(this.calcubtn_Click);
			// 
			// agelbl
			// 
			this.agelbl.AutoSize = true;
			this.agelbl.Location = new System.Drawing.Point(25, 52);
			this.agelbl.Name = "agelbl";
			this.agelbl.Size = new System.Drawing.Size(32, 12);
			this.agelbl.TabIndex = 1;
			this.agelbl.Text = "年齡:";
			// 
			// boybtn
			// 
			this.boybtn.AutoSize = true;
			this.boybtn.Location = new System.Drawing.Point(529, 48);
			this.boybtn.Name = "boybtn";
			this.boybtn.Size = new System.Drawing.Size(47, 16);
			this.boybtn.TabIndex = 2;
			this.boybtn.TabStop = true;
			this.boybtn.Text = "男性";
			this.boybtn.UseVisualStyleBackColor = true;
			// 
			// girlbtn
			// 
			this.girlbtn.AutoSize = true;
			this.girlbtn.Location = new System.Drawing.Point(632, 48);
			this.girlbtn.Name = "girlbtn";
			this.girlbtn.Size = new System.Drawing.Size(47, 16);
			this.girlbtn.TabIndex = 2;
			this.girlbtn.TabStop = true;
			this.girlbtn.Text = "女性";
			this.girlbtn.UseVisualStyleBackColor = true;
			// 
			// agetxt
			// 
			this.agetxt.Location = new System.Drawing.Point(194, 47);
			this.agetxt.Name = "agetxt";
			this.agetxt.Size = new System.Drawing.Size(100, 22);
			this.agetxt.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "label1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.reasonlbl);
			this.groupBox3.Controls.Add(this.moneylbl);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(39, 240);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(749, 198);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "計算結果";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "原因:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "車資:";
			// 
			// moneylbl
			// 
			this.moneylbl.AutoSize = true;
			this.moneylbl.Location = new System.Drawing.Point(91, 56);
			this.moneylbl.Name = "moneylbl";
			this.moneylbl.Size = new System.Drawing.Size(49, 12);
			this.moneylbl.TabIndex = 1;
			this.moneylbl.Text = "moneylbl";
			// 
			// reasonlbl
			// 
			this.reasonlbl.AutoSize = true;
			this.reasonlbl.Location = new System.Drawing.Point(91, 97);
			this.reasonlbl.Name = "reasonlbl";
			this.reasonlbl.Size = new System.Drawing.Size(47, 12);
			this.reasonlbl.TabIndex = 1;
			this.reasonlbl.Text = "reasonlbl";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(441, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "性別:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox agetxt;
		private System.Windows.Forms.RadioButton girlbtn;
		private System.Windows.Forms.RadioButton boybtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label agelbl;
		private System.Windows.Forms.Button calcubtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label reasonlbl;
		private System.Windows.Forms.Label moneylbl;
		private System.Windows.Forms.Label label5;
	}
}

