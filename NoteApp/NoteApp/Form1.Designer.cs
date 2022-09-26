namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnNew = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.textTitle1 = new System.Windows.Forms.TextBox();
            this.textMessage1 = new System.Windows.Forms.TextBox();
            this.bttnOpen1 = new System.Windows.Forms.Button();
            this.button_Export1 = new System.Windows.Forms.Button();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(239, 265);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttnNew
            // 
            this.bttnNew.BackColor = System.Drawing.Color.White;
            this.bttnNew.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnNew.Location = new System.Drawing.Point(738, 62);
            this.bttnNew.Margin = new System.Windows.Forms.Padding(4);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(96, 29);
            this.bttnNew.TabIndex = 1;
            this.bttnNew.Text = "NEW";
            this.bttnNew.UseVisualStyleBackColor = false;
            this.bttnNew.Click += new System.EventHandler(this.button_New1);
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.White;
            this.bttnSave.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnSave.Location = new System.Drawing.Point(738, 105);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(96, 29);
            this.bttnSave.TabIndex = 2;
            this.bttnSave.Text = "SAVE";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.button_Save1);
            // 
            // textTitle1
            // 
            this.textTitle1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTitle1.Location = new System.Drawing.Point(126, 62);
            this.textTitle1.Name = "textTitle1";
            this.textTitle1.Size = new System.Drawing.Size(307, 26);
            this.textTitle1.TabIndex = 0;
            // 
            // textMessage1
            // 
            this.textMessage1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage1.Location = new System.Drawing.Point(126, 134);
            this.textMessage1.Multiline = true;
            this.textMessage1.Name = "textMessage1";
            this.textMessage1.Size = new System.Drawing.Size(307, 191);
            this.textMessage1.TabIndex = 3;
            // 
            // bttnOpen1
            // 
            this.bttnOpen1.BackColor = System.Drawing.Color.White;
            this.bttnOpen1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnOpen1.Location = new System.Drawing.Point(738, 148);
            this.bttnOpen1.Margin = new System.Windows.Forms.Padding(4);
            this.bttnOpen1.Name = "bttnOpen1";
            this.bttnOpen1.Size = new System.Drawing.Size(96, 29);
            this.bttnOpen1.TabIndex = 5;
            this.bttnOpen1.Text = "Read";
            this.bttnOpen1.UseVisualStyleBackColor = false;
            this.bttnOpen1.Click += new System.EventHandler(this.button_Open);
            // 
            // button_Export1
            // 
            this.button_Export1.BackColor = System.Drawing.Color.White;
            this.button_Export1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Export1.Location = new System.Drawing.Point(738, 191);
            this.button_Export1.Margin = new System.Windows.Forms.Padding(4);
            this.button_Export1.Name = "button_Export1";
            this.button_Export1.Size = new System.Drawing.Size(96, 29);
            this.button_Export1.TabIndex = 6;
            this.button_Export1.Text = "Export";
            this.button_Export1.UseVisualStyleBackColor = false;
            this.button_Export1.Click += new System.EventHandler(this.openFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(879, 421);
            this.Controls.Add(this.button_Export1);
            this.Controls.Add(this.bttnOpen1);
            this.Controls.Add(this.textMessage1);
            this.Controls.Add(this.textTitle1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnNew);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bttnOpen1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bttnNew;
        private Button bttnSave;
        private TextBox textTitle1;
        private TextBox textMessage1;
        private Button bttnOpen1;
        private Button button_Export1;
        private OpenFileDialog openFile1;
        private FolderBrowserDialog folderBrowserDialog1;

        private bool fileOpened = false;
        private string fileName;
        private string content;
    }
}