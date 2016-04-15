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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWindow));
            this.itemListView = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addItemButton = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Button();
            this.closeTable = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.label_addReq = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_payment = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
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
            this.itemListView.Location = new System.Drawing.Point(30, 12);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(546, 372);
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
            this.quant.Width = 75;
            // 
            // table
            // 
            this.table.Text = "Table";
            this.table.Width = 77;
            // 
            // addItemButton
            // 
            this.addItemButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addItemButton.BackgroundImage")));
            this.addItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(30, 408);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(51, 49);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // price
            // 
            this.price.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("price.BackgroundImage")));
            this.price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(456, 410);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 41);
            this.price.TabIndex = 5;
            this.price.UseVisualStyleBackColor = true;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // closeTable
            // 
            this.closeTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeTable.BackgroundImage")));
            this.closeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTable.Location = new System.Drawing.Point(456, 457);
            this.closeTable.Name = "closeTable";
            this.closeTable.Size = new System.Drawing.Size(59, 48);
            this.closeTable.TabIndex = 6;
            this.closeTable.UseVisualStyleBackColor = true;
            this.closeTable.Click += new System.EventHandler(this.closeTable_Click);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.Location = new System.Drawing.Point(33, 465);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(48, 40);
            this.button_search.TabIndex = 10;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.Location = new System.Drawing.Point(87, 492);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(83, 13);
            this.label_search.TabIndex = 11;
            this.label_search.Text = "Search Table";
            // 
            // label_addReq
            // 
            this.label_addReq.AutoSize = true;
            this.label_addReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addReq.Location = new System.Drawing.Point(87, 424);
            this.label_addReq.Name = "label_addReq";
            this.label_addReq.Size = new System.Drawing.Size(98, 16);
            this.label_addReq.TabIndex = 12;
            this.label_addReq.Text = "Add Request";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(90, 465);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(61, 20);
            this.textBox_search.TabIndex = 13;
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment.Location = new System.Drawing.Point(521, 424);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(55, 13);
            this.label_payment.TabIndex = 14;
            this.label_payment.Text = "Payment";
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.Location = new System.Drawing.Point(521, 479);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(74, 13);
            this.label_close.TabIndex = 15;
            this.label_close.Text = "Close Table";
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 517);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_addReq);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_search);
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
    private System.Windows.Forms.Button button_search;
    private System.Windows.Forms.Label label_search;
    private System.Windows.Forms.Label label_addReq;
    private System.Windows.Forms.TextBox textBox_search;
    private System.Windows.Forms.Label label_payment;
    private System.Windows.Forms.Label label_close;
}

