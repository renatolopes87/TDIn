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
        System.ComponentModel.ComponentResourceManager resources =
            new System.ComponentModel.ComponentResourceManager(typeof(InternalClientWindow));
        this.itemListView = new System.Windows.Forms.ListView();
        this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.changeCommentButton = new System.Windows.Forms.Button();
        this.closeButton = new System.Windows.Forms.Button();
        this.label_changeState = new System.Windows.Forms.Label();
        this.label_closeWindow = new System.Windows.Forms.Label();
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
        this.itemListView.Location = new System.Drawing.Point(12, 12);
        this.itemListView.MultiSelect = false;
        this.itemListView.Name = "itemListView";
        this.itemListView.Size = new System.Drawing.Size(579, 291);
        this.itemListView.TabIndex = 1;
        this.itemListView.UseCompatibleStateImageBehavior = false;
        this.itemListView.View = System.Windows.Forms.View.Details;
        // 
        // type
        // 
        this.type.Text = "ID";
        this.type.Width = 55;
        // 
        // name
        // 
        this.name.Text = "Description";
        this.name.Width = 156;
        // 
        // comment
        // 
        this.comment.Text = "State";
        this.comment.Width = 90;
        // 
        // table
        // 
        this.table.Text = "Table";
        this.table.Width = 81;
        // 
        // quantity
        // 
        this.quantity.Text = "Quantity";
        // 
        // destination
        // 
        this.destination.Text = "Destination";
        this.destination.Width = 128;
        // 
        // changeCommentButton
        // 
        this.changeCommentButton.BackgroundImage  =
           ((System.Drawing.Image)(InternalClient.Properties.Resources.edit)); 
        this.changeCommentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.changeCommentButton.Location = new System.Drawing.Point(182, 316);
        this.changeCommentButton.Name = "changeCommentButton";
        this.changeCommentButton.Size = new System.Drawing.Size(54, 60);
        this.changeCommentButton.TabIndex = 1;
        this.changeCommentButton.UseVisualStyleBackColor = true;
        this.changeCommentButton.Click += new System.EventHandler(this.changeStateButton_Click);
        // 
        // closeButton
        // 
        this.closeButton.BackgroundImage =
            ((System.Drawing.Image)(InternalClient.Properties.Resources.close)); 
        this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.closeButton.Location = new System.Drawing.Point(333, 316);
        this.closeButton.Name = "closeButton";
        this.closeButton.Size = new System.Drawing.Size(55, 60);
        this.closeButton.TabIndex = 2;
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
        // 
        // label_changeState
        // 
        this.label_changeState.AutoSize = true;
        this.label_changeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label_changeState.Location = new System.Drawing.Point(93, 340);
        this.label_changeState.Name = "label_changeState";
        this.label_changeState.Size = new System.Drawing.Size(84, 13);
        this.label_changeState.TabIndex = 3;
        this.label_changeState.Text = "Change State";
        // 
        // label_closeWindow
        // 
        this.label_closeWindow.AutoSize = true;
        this.label_closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label_closeWindow.Location = new System.Drawing.Point(406, 340);
        this.label_closeWindow.Name = "label_closeWindow";
        this.label_closeWindow.Size = new System.Drawing.Size(38, 13);
        this.label_closeWindow.TabIndex = 4;
        this.label_closeWindow.Text = "Close";
        // 
        // InternalClientWindow
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(631, 388);
        this.Controls.Add(this.label_closeWindow);
        this.Controls.Add(this.label_changeState);
        this.Controls.Add(this.closeButton);
        this.Controls.Add(this.changeCommentButton);
        this.Controls.Add(this.itemListView);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "InternalClientWindow";
        this.Text = "InternalClient " + id + "- " + type;
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView itemListView;
    private System.Windows.Forms.ColumnHeader type;
    private System.Windows.Forms.ColumnHeader name;
    private System.Windows.Forms.ColumnHeader comment;
    private System.Windows.Forms.ColumnHeader table;
    private System.Windows.Forms.ColumnHeader quantity;
    private System.Windows.Forms.ColumnHeader destination;
    private System.Windows.Forms.Button changeCommentButton;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Label label_changeState;
    private System.Windows.Forms.Label label_closeWindow;
}
