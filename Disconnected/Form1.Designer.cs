namespace Disconnected
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
            this.dGVAuthors = new System.Windows.Forms.DataGridView();
            this.bShowData = new System.Windows.Forms.Button();
            this.bPushProcessors = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripUpdatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDeleteLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDelete = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripInsertedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripInserted = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVAuthors
            // 
            this.dGVAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAuthors.Location = new System.Drawing.Point(0, 25);
            this.dGVAuthors.Name = "dGVAuthors";
            this.dGVAuthors.Size = new System.Drawing.Size(950, 460);
            this.dGVAuthors.TabIndex = 0;
            // 
            // bShowData
            // 
            this.bShowData.Dock = System.Windows.Forms.DockStyle.Top;
            this.bShowData.Location = new System.Drawing.Point(0, 0);
            this.bShowData.Name = "bShowData";
            this.bShowData.Size = new System.Drawing.Size(952, 23);
            this.bShowData.TabIndex = 1;
            this.bShowData.TabStop = false;
            this.bShowData.Text = "Show Data";
            this.bShowData.UseVisualStyleBackColor = true;
            this.bShowData.Click += new System.EventHandler(this.bShowData_Click);
            // 
            // bPushProcessors
            // 
            this.bPushProcessors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bPushProcessors.Location = new System.Drawing.Point(0, 491);
            this.bPushProcessors.Name = "bPushProcessors";
            this.bPushProcessors.Size = new System.Drawing.Size(952, 24);
            this.bPushProcessors.TabIndex = 2;
            this.bPushProcessors.TabStop = false;
            this.bPushProcessors.Text = "Push Data";
            this.bPushProcessors.UseVisualStyleBackColor = true;
            this.bPushProcessors.Click += new System.EventHandler(this.bPushProcessors_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUpdatedLabel,
            this.toolStripUpdate,
            this.toolStripDeleteLabel,
            this.toolStripDelete,
            this.toolStripInsertedLabel,
            this.toolStripInserted});
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(952, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripUpdatedLabel
            // 
            this.toolStripUpdatedLabel.Name = "toolStripUpdatedLabel";
            this.toolStripUpdatedLabel.Size = new System.Drawing.Size(58, 17);
            this.toolStripUpdatedLabel.Text = "Updated: ";
            // 
            // toolStripUpdate
            // 
            this.toolStripUpdate.Name = "toolStripUpdate";
            this.toolStripUpdate.Size = new System.Drawing.Size(13, 17);
            this.toolStripUpdate.Text = "0";
            // 
            // toolStripDeleteLabel
            // 
            this.toolStripDeleteLabel.Name = "toolStripDeleteLabel";
            this.toolStripDeleteLabel.Size = new System.Drawing.Size(56, 17);
            this.toolStripDeleteLabel.Text = " Deleted: ";
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(13, 17);
            this.toolStripDelete.Text = "0";
            // 
            // toolStripInsertedLabel
            // 
            this.toolStripInsertedLabel.Name = "toolStripInsertedLabel";
            this.toolStripInsertedLabel.Size = new System.Drawing.Size(58, 17);
            this.toolStripInsertedLabel.Text = " Inserted: ";
            // 
            // toolStripInserted
            // 
            this.toolStripInserted.Name = "toolStripInserted";
            this.toolStripInserted.Size = new System.Drawing.Size(13, 17);
            this.toolStripInserted.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 540);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.bPushProcessors);
            this.Controls.Add(this.bShowData);
            this.Controls.Add(this.dGVAuthors);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAuthors;
        private System.Windows.Forms.Button bShowData;
        private System.Windows.Forms.Button bPushProcessors;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUpdatedLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDeleteLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDelete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripInsertedLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripInserted;
    }
}

