partial class NewItem
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
        this.okButton = new System.Windows.Forms.Button();
        this.cancelButton = new System.Windows.Forms.Button();
        this.destination = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        this.label3 = new System.Windows.Forms.Label();
        this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        this.description = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
        this.SuspendLayout();
        // 
        // okButton
        // 
        this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.okButton.Location = new System.Drawing.Point(23, 161);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(74, 33);
        this.okButton.TabIndex = 5;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += new System.EventHandler(this.okButton_Click);
        // 
        // button1
        // 
        this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.cancelButton.Location = new System.Drawing.Point(165, 161);
        this.cancelButton.Name = "button1";
        this.cancelButton.Size = new System.Drawing.Size(74, 33);
        this.cancelButton.TabIndex = 6;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // destination
        // 
        this.destination.FormattingEnabled = true;
        this.destination.Items.AddRange(new object[] {
            "Kitchen",
            "Bar"});
        this.destination.Location = new System.Drawing.Point(95, 99);
        this.destination.Name = "destination";
        this.destination.Size = new System.Drawing.Size(144, 21);
        this.destination.TabIndex = 2;
        this.destination.SelectedIndexChanged += new System.EventHandler(this.destination_SelectedIndexChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(20, 107);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(60, 13);
        this.label1.TabIndex = 1;
        this.label1.Text = "Destination";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(20, 54);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(46, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "Quantity";
        // 
        // numericUpDown1
        // 
        this.numericUpDown1.Location = new System.Drawing.Point(95, 47);
        this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new System.Drawing.Size(144, 20);
        this.numericUpDown1.TabIndex = 4;
        this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(20, 80);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(34, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Table";
        // 
        // numericUpDown2
        // 
        this.numericUpDown2.Location = new System.Drawing.Point(95, 73);
        this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
        this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numericUpDown2.Name = "numericUpDown2";
        this.numericUpDown2.Size = new System.Drawing.Size(144, 20);
        this.numericUpDown2.TabIndex = 8;
        this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // description
        // 
        this.description.Location = new System.Drawing.Point(95, 21);
        this.description.Name = "description";
        this.description.Size = new System.Drawing.Size(144, 20);
        this.description.TabIndex = 9;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(20, 24);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(60, 13);
        this.label4.TabIndex = 10;
        this.label4.Text = "Description";
        // 
        // NewItem
        // 
        //this.AcceptButton = this.okButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.cancelButton;
        this.ClientSize = new System.Drawing.Size(276, 203);
        this.ControlBox = false;
        this.Controls.Add(this.label4);
        this.Controls.Add(this.description);
        this.Controls.Add(this.numericUpDown2);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.numericUpDown1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.destination);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.okButton);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "NewItem";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "CommentDlg";
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.ComboBox destination;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.TextBox description;
    private System.Windows.Forms.Label label4;

    public System.EventHandler comboBox1_SelectedIndexChanged { get; set; }
}