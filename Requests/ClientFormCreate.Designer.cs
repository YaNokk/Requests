
namespace Requests
{
    partial class ClientFormCreate
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
            this.clientFormCreateType = new System.Windows.Forms.TextBox();
            this.clientFormCreateModel = new System.Windows.Forms.TextBox();
            this.clientFormCreateDescription = new System.Windows.Forms.RichTextBox();
            this.clientFormCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientFormCreateType
            // 
            this.clientFormCreateType.Location = new System.Drawing.Point(311, 81);
            this.clientFormCreateType.Name = "clientFormCreateType";
            this.clientFormCreateType.Size = new System.Drawing.Size(176, 22);
            this.clientFormCreateType.TabIndex = 0;
            // 
            // clientFormCreateModel
            // 
            this.clientFormCreateModel.Location = new System.Drawing.Point(311, 121);
            this.clientFormCreateModel.Name = "clientFormCreateModel";
            this.clientFormCreateModel.Size = new System.Drawing.Size(176, 22);
            this.clientFormCreateModel.TabIndex = 1;
            // 
            // clientFormCreateDescription
            // 
            this.clientFormCreateDescription.Location = new System.Drawing.Point(311, 159);
            this.clientFormCreateDescription.Name = "clientFormCreateDescription";
            this.clientFormCreateDescription.Size = new System.Drawing.Size(176, 96);
            this.clientFormCreateDescription.TabIndex = 2;
            this.clientFormCreateDescription.Text = "";
            // 
            // clientFormCreateButton
            // 
            this.clientFormCreateButton.Location = new System.Drawing.Point(311, 278);
            this.clientFormCreateButton.Name = "clientFormCreateButton";
            this.clientFormCreateButton.Size = new System.Drawing.Size(176, 23);
            this.clientFormCreateButton.TabIndex = 5;
            this.clientFormCreateButton.Text = "Создать заявку";
            this.clientFormCreateButton.UseVisualStyleBackColor = true;
            this.clientFormCreateButton.Click += new System.EventHandler(this.clientFormCreateButton_Click);
            // 
            // ClientFormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientFormCreateButton);
            this.Controls.Add(this.clientFormCreateDescription);
            this.Controls.Add(this.clientFormCreateModel);
            this.Controls.Add(this.clientFormCreateType);
            this.Name = "ClientFormCreate";
            this.Text = "ClientFormCreate";
            this.Load += new System.EventHandler(this.ClientFormCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientFormCreateType;
        private System.Windows.Forms.TextBox clientFormCreateModel;
        private System.Windows.Forms.RichTextBox clientFormCreateDescription;
        private System.Windows.Forms.Button clientFormCreateButton;
    }
}