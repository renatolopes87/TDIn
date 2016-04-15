partial class Bill
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
        itemListView2.Items.Clear();
    }


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.itemListView2 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeTable = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemListView2
            // 
            this.itemListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.quantity,
            this.unit,
            this.Price});
            this.itemListView2.HideSelection = false;
            this.itemListView2.Location = new System.Drawing.Point(13, 13);
            this.itemListView2.MultiSelect = false;
            this.itemListView2.Name = "itemListView2";
            this.itemListView2.Size = new System.Drawing.Size(442, 372);
            this.itemListView2.TabIndex = 1;
            this.itemListView2.UseCompatibleStateImageBehavior = false;
            this.itemListView2.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Description";
            this.name.Width = 218;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 100;
            // 
            // unit
            // 
            this.unit.Text = "Unit Price";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // closeTable
            // 
            this.closeTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeTable.BackgroundImage")));
            this.closeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeTable.Location = new System.Drawing.Point(190, 400);
            this.closeTable.Name = "closeTable";
            this.closeTable.Size = new System.Drawing.Size(51, 45);
            this.closeTable.TabIndex = 6;
            this.closeTable.UseVisualStyleBackColor = true;
            this.closeTable.Click += new System.EventHandler(this.closeTable_Click);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.Location = new System.Drawing.Point(247, 416);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(38, 13);
            this.label_close.TabIndex = 7;
            this.label_close.Text = "Close";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 470);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.closeTable);
            this.Controls.Add(this.itemListView2);
            this.Name = "Bill";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView itemListView2;
    private System.Windows.Forms.ColumnHeader name;
    private System.Windows.Forms.ColumnHeader quantity;
    private System.Windows.Forms.ColumnHeader unit;
    private System.Windows.Forms.ColumnHeader Price;
    private System.Windows.Forms.Button closeTable;
    private System.Windows.Forms.Label label_close;
}

