partial class ClientWindow
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

    public void ClearItemListView()
    {
        itemListView.Items.Clear();
    }


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.itemListView = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addItemButton = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Button();
            this.closeTable = new System.Windows.Forms.Button();
            this.tableSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.name,
            this.comment,
            this.quant,
            this.table});
            this.itemListView.FullRowSelect = true;
            this.itemListView.GridLines = true;
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(13, 13);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(502, 372);
            this.itemListView.TabIndex = 1;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Description";
            this.name.Width = 218;
            // 
            // comment
            // 
            this.comment.Text = "State";
            this.comment.Width = 100;
            // 
            // quant
            // 
            this.quant.Text = "Quantity";
            // 
            // table
            // 
            this.table.Text = "Table";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(13, 425);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(125, 32);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "Add Request";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(390, 402);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(125, 32);
            this.price.TabIndex = 5;
            this.price.Text = "Total Price";
            this.price.UseVisualStyleBackColor = true;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // closeTable
            // 
            this.closeTable.Location = new System.Drawing.Point(390, 457);
            this.closeTable.Name = "closeTable";
            this.closeTable.Size = new System.Drawing.Size(125, 32);
            this.closeTable.TabIndex = 6;
            this.closeTable.Text = "Close Table";
            this.closeTable.UseVisualStyleBackColor = true;
            this.closeTable.Click += new System.EventHandler(this.closeTable_Click);
            // 
            // tableSelector
            // 
            this.tableSelector.FormattingEnabled = true;
            this.tableSelector.Location = new System.Drawing.Point(321, 409);
            this.tableSelector.Name = "tableSelector";
            this.tableSelector.Size = new System.Drawing.Size(53, 21);
            this.tableSelector.TabIndex = 7;
            this.tableSelector.SelectedIndexChanged += new System.EventHandler(this.tableSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Table";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(244, 440);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Only This Table";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 501);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableSelector);
            this.Controls.Add(this.closeTable);
            this.Controls.Add(this.price);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemListView);
            this.Name = "ClientWindow";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView itemListView;
    private System.Windows.Forms.ColumnHeader type;
    private System.Windows.Forms.ColumnHeader name;
    private System.Windows.Forms.ColumnHeader comment;
    private System.Windows.Forms.Button addItemButton;
    private System.Windows.Forms.ColumnHeader quant;
    private System.Windows.Forms.ColumnHeader table;
    private System.Windows.Forms.Button price;
    private System.Windows.Forms.Button closeTable;
    private System.Windows.Forms.ComboBox tableSelector;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox checkBox1;
}

