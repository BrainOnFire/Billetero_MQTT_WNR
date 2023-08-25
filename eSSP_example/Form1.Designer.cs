using System.Drawing;

namespace eSSP_example
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
            //this.Icon = new Icon("Resources/waitnrest.ico");
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoInsertarBilletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyNoteFloatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnHalt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StorageListBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackNextNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyStoredNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetTotalsText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalAcceptedNumText = new System.Windows.Forms.TextBox();
            this.noteToRecycleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashboxBtn = new System.Windows.Forms.Button();
            this.resetValidatorBtn = new System.Windows.Forms.Button();
            this.totalNumNotesDispensedText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.notesInStorageText = new System.Windows.Forms.TextBox();
            this.btnSmartEmpty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.StorageListBoxMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoInsertarBilletesToolStripMenuItem,
            this.emptyNoteFloatToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // modoInsertarBilletesToolStripMenuItem
            // 
            this.modoInsertarBilletesToolStripMenuItem.Name = "modoInsertarBilletesToolStripMenuItem";
            this.modoInsertarBilletesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.modoInsertarBilletesToolStripMenuItem.Text = "&Modo insertar billetes para vuelto";
            this.modoInsertarBilletesToolStripMenuItem.Click += new System.EventHandler(this.modoInsertarBilletesToolStripMenuItem_Click_1);
            // 
            // emptyNoteFloatToolStripMenuItem1
            // 
            this.emptyNoteFloatToolStripMenuItem1.Name = "emptyNoteFloatToolStripMenuItem1";
            this.emptyNoteFloatToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.emptyNoteFloatToolStripMenuItem1.Text = "&Vaciar almacenador de billetes";
            this.emptyNoteFloatToolStripMenuItem1.Click += new System.EventHandler(this.emptyNoteFloatToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.exitToolStripMenuItem.Text = "&Cerrar aplicacion";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 400);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(133, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "&Iniciar programa";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(151, 400);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(141, 23);
            this.btnHalt.TabIndex = 2;
            this.btnHalt.Text = "&Detener programa";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.ContextMenuStrip = this.StorageListBoxMenu;
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(280, 348);
            this.textBox1.TabIndex = 4;
            // 
            // StorageListBoxMenu
            // 
            this.StorageListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.stackNextNoteToolStripMenuItem,
            this.emptyStoredNotesToolStripMenuItem});
            this.StorageListBoxMenu.Name = "contextMenuStrip1";
            this.StorageListBoxMenu.Size = new System.Drawing.Size(226, 70);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.testToolStripMenuItem.Text = "Pagar billete";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // stackNextNoteToolStripMenuItem
            // 
            this.stackNextNoteToolStripMenuItem.Name = "stackNextNoteToolStripMenuItem";
            this.stackNextNoteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.stackNextNoteToolStripMenuItem.Text = "Guardar billete en caja fuerte";
            this.stackNextNoteToolStripMenuItem.Click += new System.EventHandler(this.stackNextNoteToolStripMenuItem_Click);
            // 
            // emptyStoredNotesToolStripMenuItem
            // 
            this.emptyStoredNotesToolStripMenuItem.Name = "emptyStoredNotesToolStripMenuItem";
            this.emptyStoredNotesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.emptyStoredNotesToolStripMenuItem.Text = "Vaciar notas almacenadas";
            this.emptyStoredNotesToolStripMenuItem.Click += new System.EventHandler(this.emptyStoredNotesToolStripMenuItem_Click);
            // 
            // ResetTotalsText
            // 
            this.ResetTotalsText.Location = new System.Drawing.Point(6, 108);
            this.ResetTotalsText.Name = "ResetTotalsText";
            this.ResetTotalsText.Size = new System.Drawing.Size(187, 23);
            this.ResetTotalsText.TabIndex = 5;
            this.ResetTotalsText.Text = "R&einiciar stats";
            this.ResetTotalsText.UseVisualStyleBackColor = true;
            this.ResetTotalsText.Click += new System.EventHandler(this.ResetTotalsText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "#  transacciones exitosas:";
            // 
            // totalAcceptedNumText
            // 
            this.totalAcceptedNumText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalAcceptedNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAcceptedNumText.Location = new System.Drawing.Point(6, 32);
            this.totalAcceptedNumText.Name = "totalAcceptedNumText";
            this.totalAcceptedNumText.ReadOnly = true;
            this.totalAcceptedNumText.Size = new System.Drawing.Size(188, 22);
            this.totalAcceptedNumText.TabIndex = 7;
            this.totalAcceptedNumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noteToRecycleComboBox
            // 
            this.noteToRecycleComboBox.FormattingEnabled = true;
            this.noteToRecycleComboBox.Location = new System.Drawing.Point(308, 315);
            this.noteToRecycleComboBox.Name = "noteToRecycleComboBox";
            this.noteToRecycleComboBox.Size = new System.Drawing.Size(200, 21);
            this.noteToRecycleComboBox.TabIndex = 9;
            this.noteToRecycleComboBox.SelectedIndexChanged += new System.EventHandler(this.noteToRecycleComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(298, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Billetes a reciclar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashboxBtn
            // 
            this.cashboxBtn.Location = new System.Drawing.Point(308, 342);
            this.cashboxBtn.Name = "cashboxBtn";
            this.cashboxBtn.Size = new System.Drawing.Size(199, 23);
            this.cashboxBtn.TabIndex = 14;
            this.cashboxBtn.Text = "&Siguiente billete a caja fuerte";
            this.cashboxBtn.UseVisualStyleBackColor = true;
            this.cashboxBtn.Click += new System.EventHandler(this.cashboxBtn_Click);
            // 
            // resetValidatorBtn
            // 
            this.resetValidatorBtn.Location = new System.Drawing.Point(309, 371);
            this.resetValidatorBtn.Name = "resetValidatorBtn";
            this.resetValidatorBtn.Size = new System.Drawing.Size(199, 23);
            this.resetValidatorBtn.TabIndex = 15;
            this.resetValidatorBtn.Text = "&Reiniciar billetero";
            this.resetValidatorBtn.UseVisualStyleBackColor = true;
            this.resetValidatorBtn.Click += new System.EventHandler(this.resetValidatorBtn_Click);
            // 
            // totalNumNotesDispensedText
            // 
            this.totalNumNotesDispensedText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalNumNotesDispensedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumNotesDispensedText.Location = new System.Drawing.Point(6, 74);
            this.totalNumNotesDispensedText.Name = "totalNumNotesDispensedText";
            this.totalNumNotesDispensedText.ReadOnly = true;
            this.totalNumNotesDispensedText.Size = new System.Drawing.Size(188, 22);
            this.totalNumNotesDispensedText.TabIndex = 20;
            this.totalNumNotesDispensedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "# de billetes devueltos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalNumNotesDispensedText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.totalAcceptedNumText);
            this.groupBox1.Controls.Add(this.ResetTotalsText);
            this.groupBox1.Location = new System.Drawing.Point(308, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 137);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Billetes guardados en almacenamiento:";
            // 
            // notesInStorageText
            // 
            this.notesInStorageText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesInStorageText.ContextMenuStrip = this.StorageListBoxMenu;
            this.notesInStorageText.Location = new System.Drawing.Point(308, 46);
            this.notesInStorageText.Multiline = true;
            this.notesInStorageText.Name = "notesInStorageText";
            this.notesInStorageText.ReadOnly = true;
            this.notesInStorageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesInStorageText.Size = new System.Drawing.Size(200, 93);
            this.notesInStorageText.TabIndex = 27;
            // 
            // btnSmartEmpty
            // 
            this.btnSmartEmpty.Location = new System.Drawing.Point(308, 400);
            this.btnSmartEmpty.Name = "btnSmartEmpty";
            this.btnSmartEmpty.Size = new System.Drawing.Size(199, 23);
            this.btnSmartEmpty.TabIndex = 29;
            this.btnSmartEmpty.Text = "&Vaciado smart";
            this.btnSmartEmpty.UseVisualStyleBackColor = true;
            this.btnSmartEmpty.Click += new System.EventHandler(this.btnSmartEmpty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mensajes de depuracion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 433);
            this.ContextMenuStrip = this.StorageListBoxMenu;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSmartEmpty);
            this.Controls.Add(this.resetValidatorBtn);
            this.Controls.Add(this.notesInStorageText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cashboxBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.noteToRecycleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wait N\' Rest Biller Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StorageListBoxMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResetTotalsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalAcceptedNumText;
        private System.Windows.Forms.ComboBox noteToRecycleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem emptyNoteFloatToolStripMenuItem1;
        private System.Windows.Forms.Button cashboxBtn;
        private System.Windows.Forms.Button resetValidatorBtn;
        private System.Windows.Forms.TextBox totalNumNotesDispensedText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox notesInStorageText;
        private System.Windows.Forms.ContextMenuStrip StorageListBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackNextNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyStoredNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnSmartEmpty;
        private System.Windows.Forms.ToolStripMenuItem modoInsertarBilletesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

