namespace NQuery.Samples.CustomMethodProvider
{
	partial class Form1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.runMyReflectionProviderButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(313, 213);
			this.dataGridView1.TabIndex = 2;
			// 
			// runMyReflectionProviderButton
			// 
			this.runMyReflectionProviderButton.Location = new System.Drawing.Point(12, 12);
			this.runMyReflectionProviderButton.Name = "runMyReflectionProviderButton";
			this.runMyReflectionProviderButton.Size = new System.Drawing.Size(152, 23);
			this.runMyReflectionProviderButton.TabIndex = 0;
			this.runMyReflectionProviderButton.Text = "Run MyReflectionProvider";
			this.runMyReflectionProviderButton.UseVisualStyleBackColor = true;
			this.runMyReflectionProviderButton.Click += new System.EventHandler(this.runMyReflectionProviderButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 266);
			this.Controls.Add(this.runMyReflectionProviderButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Custom Method Providers Sample";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button runMyReflectionProviderButton;
	}
}