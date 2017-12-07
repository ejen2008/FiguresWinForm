namespace FiguresWinForm
{
    partial class FormMovingFigures
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovingFigures));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonRu = new System.Windows.Forms.RadioButton();
            this.radioButtonEn = new System.Windows.Forms.RadioButton();
            this.buttonStopStart = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxSave = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxSaveFormat = new System.Windows.Forms.ComboBox();
            this.listBoxFigures = new System.Windows.Forms.ListBox();
            this.pictureBoxMoving = new System.Windows.Forms.PictureBox();
            this.timerPictureBox = new System.Windows.Forms.Timer(this.components);
            this.buttonClean = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBoxSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoving)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Controls.Add(this.groupBoxLanguage);
            this.panelButtons.Controls.Add(this.buttonStopStart);
            this.panelButtons.Controls.Add(this.buttonSquare);
            this.panelButtons.Controls.Add(this.buttonCircle);
            this.panelButtons.Controls.Add(this.buttonTriangle);
            this.panelButtons.Name = "panelButtons";
            // 
            // groupBoxLanguage
            // 
            resources.ApplyResources(this.groupBoxLanguage, "groupBoxLanguage");
            this.groupBoxLanguage.Controls.Add(this.radioButtonRu);
            this.groupBoxLanguage.Controls.Add(this.radioButtonEn);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.TabStop = false;
            // 
            // radioButtonRu
            // 
            resources.ApplyResources(this.radioButtonRu, "radioButtonRu");
            this.radioButtonRu.Name = "radioButtonRu";
            this.radioButtonRu.TabStop = true;
            this.radioButtonRu.UseVisualStyleBackColor = true;
            this.radioButtonRu.CheckedChanged += new System.EventHandler(this.RadioButtonRuCheckedChanged);
            // 
            // radioButtonEn
            // 
            resources.ApplyResources(this.radioButtonEn, "radioButtonEn");
            this.radioButtonEn.Name = "radioButtonEn";
            this.radioButtonEn.TabStop = true;
            this.radioButtonEn.UseVisualStyleBackColor = true;
            this.radioButtonEn.CheckedChanged += new System.EventHandler(this.RadioButtonEnCheckedChanged);
            // 
            // buttonStopStart
            // 
            resources.ApplyResources(this.buttonStopStart, "buttonStopStart");
            this.buttonStopStart.Name = "buttonStopStart";
            this.buttonStopStart.UseVisualStyleBackColor = true;
            this.buttonStopStart.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // buttonSquare
            // 
            resources.ApplyResources(this.buttonSquare, "buttonSquare");
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquareClick);
            // 
            // buttonCircle
            // 
            resources.ApplyResources(this.buttonCircle, "buttonCircle");
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonCircleClick);
            // 
            // buttonTriangle
            // 
            resources.ApplyResources(this.buttonTriangle, "buttonTriangle");
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.ButtonTriangleClick);
            // 
            // buttonLoad
            // 
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
            // 
            // groupBoxSave
            // 
            resources.ApplyResources(this.groupBoxSave, "groupBoxSave");
            this.groupBoxSave.Controls.Add(this.buttonLoad);
            this.groupBoxSave.Controls.Add(this.buttonSave);
            this.groupBoxSave.Controls.Add(this.comboBoxSaveFormat);
            this.groupBoxSave.Name = "groupBoxSave";
            this.groupBoxSave.TabStop = false;
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // comboBoxSaveFormat
            // 
            resources.ApplyResources(this.comboBoxSaveFormat, "comboBoxSaveFormat");
            this.comboBoxSaveFormat.FormattingEnabled = true;
            this.comboBoxSaveFormat.Name = "comboBoxSaveFormat";
            
            // 
            // listBoxFigures
            // 
            resources.ApplyResources(this.listBoxFigures, "listBoxFigures");
            this.listBoxFigures.FormattingEnabled = true;
            this.listBoxFigures.Name = "listBoxFigures";
            this.listBoxFigures.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiguresSelectedIndexChanged);
            // 
            // pictureBoxMoving
            // 
            resources.ApplyResources(this.pictureBoxMoving, "pictureBoxMoving");
            this.pictureBoxMoving.Name = "pictureBoxMoving";
            this.pictureBoxMoving.TabStop = false;
            this.pictureBoxMoving.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxMovingPaint);
            this.pictureBoxMoving.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMovingMouseClick);
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Enabled = true;
            this.timerPictureBox.Interval = 50;
            this.timerPictureBox.Tick += new System.EventHandler(this.TimerPictureBoxTick);
            // 
            // buttonClean
            // 
            resources.ApplyResources(this.buttonClean, "buttonClean");
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.ButtonCleanClick);
            // 
            // FormMovingFigures
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.pictureBoxMoving);
            this.Controls.Add(this.groupBoxSave);
            this.Controls.Add(this.listBoxFigures);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormMovingFigures";
            this.Load += new System.EventHandler(this.FormMovingFiguresLoad);
            this.panelButtons.ResumeLayout(false);
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.groupBoxSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoving)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonStopStart;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.ListBox listBoxFigures;
        private System.Windows.Forms.PictureBox pictureBoxMoving;
        private System.Windows.Forms.Timer timerPictureBox;
        private System.Windows.Forms.GroupBox groupBoxSave;
        private System.Windows.Forms.ComboBox comboBoxSaveFormat;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioButtonRu;
        private System.Windows.Forms.RadioButton radioButtonEn;
        private System.Windows.Forms.Button buttonClean;
    }
}

