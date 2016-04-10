partial class InternalClientWindow
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
    private void InitializeComponent(string type, int id)
    {
        this.itemListView = new System.Windows.Forms.ListView();
        this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.changeCommentButton = new System.Windows.Forms.Button();
        this.closeButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // itemListView
        // 
        this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.name,
            this.comment,
            this.table,
            this.quantity,
            this.destination});
        this.itemListView.FullRowSelect = true;
        this.itemListView.GridLines = true;
        this.itemListView.HideSelection = false;
        this.itemListView.Location = new System.Drawing.Point(29, 12);
        this.itemListView.MultiSelect = false;
        this.itemListView.Name = "itemListView";
        this.itemListView.Size = new System.Drawing.Size(610, 372);
        this.itemListView.TabIndex = 1;
        this.itemListView.UseCompatibleStateImageBehavior = false;
        this.itemListView.View = System.Windows.Forms.View.Details;
       
        // 
        // type
        // 
        this.type.Text = "ID";
        this.type.Width = 40;
        // 
        // name
        // 
        this.name.Text = "Description";
        this.name.Width = 186;
        // 
        // comment
        // 
        this.comment.Text = "State";
        this.comment.Width = 90;
        // 
        // table
        // 
        this.table.Text = "Table";
        this.table.Width = 43;
        // 
        // quantity
        // 
        this.quantity.Text = "Quantity";
        this.quantity.Width = 54;
        // 
        // destination
        // 
        this.destination.Text = "Destination";
        this.destination.Width = 75;
        // 
        // changeCommentButton
        // 
        this.changeCommentButton.Location = new System.Drawing.Point(379, 408);
        this.changeCommentButton.Name = "changeCommentButton";
        this.changeCommentButton.Size = new System.Drawing.Size(119, 32);
        this.changeCommentButton.TabIndex = 5;
        this.changeCommentButton.Text = "Change State";
        this.changeCommentButton.UseVisualStyleBackColor = true;
        this.changeCommentButton.Click += new System.EventHandler(this.changeStateButton_Click);
        // 
        // closeButton
        // 
        this.closeButton.Location = new System.Drawing.Point(520, 408);
        this.closeButton.Name = "closeButton";
        this.closeButton.Size = new System.Drawing.Size(119, 32);
        this.closeButton.TabIndex = 6;
        this.closeButton.Text = "Close";
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
        // 
        // InternalClientWindow
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(671, 464);
        this.Controls.Add(this.closeButton);
        this.Controls.Add(this.changeCommentButton);
        this.Controls.Add(this.itemListView);
        this.Name = "InternalClientWindow";
        this.Text = "InternalClient " + id + "- " + type;
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientWindow_FormClosed);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView itemListView;
    private System.Windows.Forms.ColumnHeader type;
    private System.Windows.Forms.ColumnHeader name;
    private System.Windows.Forms.ColumnHeader comment;
    private System.Windows.Forms.Button changeCommentButton;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.ColumnHeader table;
    private System.Windows.Forms.ColumnHeader quantity;
    private System.Windows.Forms.ColumnHeader destination;
}

