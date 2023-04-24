namespace OOXX
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
			this.label1 = new System.Windows.Forms.Label();
			this.startGame = new System.Windows.Forms.Button();
			this.button_00 = new System.Windows.Forms.Button();
			this.button_01 = new System.Windows.Forms.Button();
			this.button_02 = new System.Windows.Forms.Button();
			this.button_10 = new System.Windows.Forms.Button();
			this.button_11 = new System.Windows.Forms.Button();
			this.button_12 = new System.Windows.Forms.Button();
			this.button_20 = new System.Windows.Forms.Button();
			this.button_21 = new System.Windows.Forms.Button();
			this.button_22 = new System.Windows.Forms.Button();
			this.StopApp = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(254, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "井字遊戲";
			// 
			// startGame
			// 
			this.startGame.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.startGame.Location = new System.Drawing.Point(182, 75);
			this.startGame.Name = "startGame";
			this.startGame.Size = new System.Drawing.Size(210, 37);
			this.startGame.TabIndex = 1;
			this.startGame.Text = "開始遊戲";
			this.startGame.UseVisualStyleBackColor = true;
			this.startGame.Click += new System.EventHandler(this.startGame_Click);
			// 
			// button_00
			// 
			this.button_00.Location = new System.Drawing.Point(182, 126);
			this.button_00.Name = "button_00";
			this.button_00.Size = new System.Drawing.Size(100, 100);
			this.button_00.TabIndex = 2;
			this.button_00.UseVisualStyleBackColor = true;
			this.button_00.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_01
			// 
			this.button_01.Location = new System.Drawing.Point(288, 126);
			this.button_01.Name = "button_01";
			this.button_01.Size = new System.Drawing.Size(100, 100);
			this.button_01.TabIndex = 2;
			this.button_01.UseVisualStyleBackColor = true;
			this.button_01.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_02
			// 
			this.button_02.Location = new System.Drawing.Point(394, 126);
			this.button_02.Name = "button_02";
			this.button_02.Size = new System.Drawing.Size(100, 100);
			this.button_02.TabIndex = 2;
			this.button_02.UseVisualStyleBackColor = true;
			this.button_02.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_10
			// 
			this.button_10.Location = new System.Drawing.Point(182, 232);
			this.button_10.Name = "button_10";
			this.button_10.Size = new System.Drawing.Size(100, 100);
			this.button_10.TabIndex = 2;
			this.button_10.UseVisualStyleBackColor = true;
			this.button_10.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_11
			// 
			this.button_11.Location = new System.Drawing.Point(288, 232);
			this.button_11.Name = "button_11";
			this.button_11.Size = new System.Drawing.Size(100, 100);
			this.button_11.TabIndex = 2;
			this.button_11.UseVisualStyleBackColor = true;
			this.button_11.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_12
			// 
			this.button_12.Location = new System.Drawing.Point(394, 232);
			this.button_12.Name = "button_12";
			this.button_12.Size = new System.Drawing.Size(100, 100);
			this.button_12.TabIndex = 2;
			this.button_12.UseVisualStyleBackColor = true;
			this.button_12.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_20
			// 
			this.button_20.Location = new System.Drawing.Point(182, 338);
			this.button_20.Name = "button_20";
			this.button_20.Size = new System.Drawing.Size(100, 100);
			this.button_20.TabIndex = 2;
			this.button_20.UseVisualStyleBackColor = true;
			this.button_20.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_21
			// 
			this.button_21.Location = new System.Drawing.Point(288, 338);
			this.button_21.Name = "button_21";
			this.button_21.Size = new System.Drawing.Size(100, 100);
			this.button_21.TabIndex = 2;
			this.button_21.UseVisualStyleBackColor = true;
			this.button_21.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// button_22
			// 
			this.button_22.Location = new System.Drawing.Point(394, 338);
			this.button_22.Name = "button_22";
			this.button_22.Size = new System.Drawing.Size(100, 100);
			this.button_22.TabIndex = 2;
			this.button_22.UseVisualStyleBackColor = true;
			this.button_22.Click += new System.EventHandler(this.GameButton_Click);
			// 
			// StopApp
			// 
			this.StopApp.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.StopApp.Location = new System.Drawing.Point(229, 453);
			this.StopApp.Name = "StopApp";
			this.StopApp.Size = new System.Drawing.Size(210, 37);
			this.StopApp.TabIndex = 1;
			this.StopApp.Text = "關閉";
			this.StopApp.UseVisualStyleBackColor = true;
			this.StopApp.Click += new System.EventHandler(this.StopApp_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.radioButton1.Location = new System.Drawing.Point(409, 75);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(71, 16);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "玩家先手";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(409, 96);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(71, 16);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "電腦先手";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 518);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button_22);
			this.Controls.Add(this.button_21);
			this.Controls.Add(this.button_12);
			this.Controls.Add(this.button_11);
			this.Controls.Add(this.button_20);
			this.Controls.Add(this.button_02);
			this.Controls.Add(this.button_10);
			this.Controls.Add(this.button_01);
			this.Controls.Add(this.button_00);
			this.Controls.Add(this.StopApp);
			this.Controls.Add(this.startGame);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button startGame;
		private System.Windows.Forms.Button button_00;
		private System.Windows.Forms.Button button_01;
		private System.Windows.Forms.Button button_02;
		private System.Windows.Forms.Button button_10;
		private System.Windows.Forms.Button button_11;
		private System.Windows.Forms.Button button_12;
		private System.Windows.Forms.Button button_20;
		private System.Windows.Forms.Button button_21;
		private System.Windows.Forms.Button button_22;
		private System.Windows.Forms.Button StopApp;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
	}
}

