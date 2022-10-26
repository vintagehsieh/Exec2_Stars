namespace Exec_Stars
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
			this.rowsLabel = new System.Windows.Forms.Label();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.leftButton = new System.Windows.Forms.Button();
			this.rightButton = new System.Windows.Forms.Button();
			this.isoTriangle = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// rowsLabel
			// 
			this.rowsLabel.AutoSize = true;
			this.rowsLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rowsLabel.Location = new System.Drawing.Point(245, 56);
			this.rowsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.rowsLabel.Name = "rowsLabel";
			this.rowsLabel.Size = new System.Drawing.Size(52, 25);
			this.rowsLabel.TabIndex = 0;
			this.rowsLabel.Text = "列數";
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(300, 52);
			this.rowsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rowsTextBox.MaxLength = 3;
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(141, 25);
			this.rowsTextBox.TabIndex = 1;
			// 
			// leftButton
			// 
			this.leftButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.leftButton.Location = new System.Drawing.Point(176, 100);
			this.leftButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.leftButton.Name = "leftButton";
			this.leftButton.Size = new System.Drawing.Size(115, 82);
			this.leftButton.TabIndex = 2;
			this.leftButton.Text = "產生\r\n靠左三角形";
			this.leftButton.UseVisualStyleBackColor = true;
			this.leftButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// rightButton
			// 
			this.rightButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rightButton.Location = new System.Drawing.Point(300, 100);
			this.rightButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rightButton.Name = "rightButton";
			this.rightButton.Size = new System.Drawing.Size(115, 82);
			this.rightButton.TabIndex = 3;
			this.rightButton.Text = "產生\r\n靠右三角形";
			this.rightButton.UseVisualStyleBackColor = true;
			this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
			// 
			// isoTriangle
			// 
			this.isoTriangle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.isoTriangle.Location = new System.Drawing.Point(431, 100);
			this.isoTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.isoTriangle.Name = "isoTriangle";
			this.isoTriangle.Size = new System.Drawing.Size(115, 82);
			this.isoTriangle.TabIndex = 4;
			this.isoTriangle.Text = "產生\r\n等腰三角形";
			this.isoTriangle.UseVisualStyleBackColor = true;
			this.isoTriangle.Click += new System.EventHandler(this.isoTriangle_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextBox.Location = new System.Drawing.Point(176, 202);
			this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultTextBox.Size = new System.Drawing.Size(369, 413);
			this.resultTextBox.TabIndex = 5;
			this.resultTextBox.WordWrap = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 665);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.isoTriangle);
			this.Controls.Add(this.rightButton);
			this.Controls.Add(this.leftButton);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.rowsLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimumSize = new System.Drawing.Size(759, 700);
			this.Name = "Form1";
			this.Text = "三角形產生器";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label rowsLabel;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.Button leftButton;
		private System.Windows.Forms.Button rightButton;
		private System.Windows.Forms.Button isoTriangle;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}

