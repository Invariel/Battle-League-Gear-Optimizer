namespace Gear_Optimizer
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
            this.lbl_Primary = new System.Windows.Forms.Label();
            this.lbl_Secondary = new System.Windows.Forms.Label();
            this.lbl_Tertiary = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.lbl_Character = new System.Windows.Forms.Label();
            this.cmb_Character = new System.Windows.Forms.ComboBox();
            this.cmb_Primary = new System.Windows.Forms.ComboBox();
            this.cmb_Secondary = new System.Windows.Forms.ComboBox();
            this.cmb_Tertiary = new System.Windows.Forms.ComboBox();
            this.chk_IgnoreBushido = new System.Windows.Forms.CheckBox();
            this.lbl_Results = new System.Windows.Forms.Label();
            this.numud_Results = new System.Windows.Forms.NumericUpDown();
            this.dg_Result = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Primary
            // 
            this.lbl_Primary.AutoSize = true;
            this.lbl_Primary.Location = new System.Drawing.Point(39, 17);
            this.lbl_Primary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Primary.Name = "lbl_Primary";
            this.lbl_Primary.Size = new System.Drawing.Size(65, 21);
            this.lbl_Primary.TabIndex = 20;
            this.lbl_Primary.Text = "Primary";
            // 
            // lbl_Secondary
            // 
            this.lbl_Secondary.AutoSize = true;
            this.lbl_Secondary.Location = new System.Drawing.Point(301, 18);
            this.lbl_Secondary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Secondary.Name = "lbl_Secondary";
            this.lbl_Secondary.Size = new System.Drawing.Size(83, 21);
            this.lbl_Secondary.TabIndex = 40;
            this.lbl_Secondary.Text = "Secondary";
            // 
            // lbl_Tertiary
            // 
            this.lbl_Tertiary.AutoSize = true;
            this.lbl_Tertiary.Location = new System.Drawing.Point(603, 18);
            this.lbl_Tertiary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tertiary.Name = "lbl_Tertiary";
            this.lbl_Tertiary.Size = new System.Drawing.Size(61, 21);
            this.lbl_Tertiary.TabIndex = 60;
            this.lbl_Tertiary.Text = "Tertiary";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(1083, 51);
            this.btn_Go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(95, 29);
            this.btn_Go.TabIndex = 4;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            // 
            // lbl_Character
            // 
            this.lbl_Character.AutoSize = true;
            this.lbl_Character.Location = new System.Drawing.Point(27, 55);
            this.lbl_Character.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Character.Name = "lbl_Character";
            this.lbl_Character.Size = new System.Drawing.Size(77, 21);
            this.lbl_Character.TabIndex = 0;
            this.lbl_Character.Text = "Character";
            // 
            // cmb_Character
            // 
            this.cmb_Character.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Character.FormattingEnabled = true;
            this.cmb_Character.Location = new System.Drawing.Point(112, 51);
            this.cmb_Character.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Character.Name = "cmb_Character";
            this.cmb_Character.Size = new System.Drawing.Size(175, 29);
            this.cmb_Character.TabIndex = 10;
            // 
            // cmb_Primary
            // 
            this.cmb_Primary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Primary.FormattingEnabled = true;
            this.cmb_Primary.Items.AddRange(new object[] {
            "Strength",
            "Speed",
            "Shooting",
            "Passing",
            "Technique"});
            this.cmb_Primary.Location = new System.Drawing.Point(112, 14);
            this.cmb_Primary.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Primary.Name = "cmb_Primary";
            this.cmb_Primary.Size = new System.Drawing.Size(175, 29);
            this.cmb_Primary.TabIndex = 30;
            // 
            // cmb_Secondary
            // 
            this.cmb_Secondary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Secondary.FormattingEnabled = true;
            this.cmb_Secondary.Items.AddRange(new object[] {
            "None",
            "Strength",
            "Speed",
            "Shooting",
            "Passing",
            "Technique"});
            this.cmb_Secondary.Location = new System.Drawing.Point(392, 14);
            this.cmb_Secondary.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Secondary.Name = "cmb_Secondary";
            this.cmb_Secondary.Size = new System.Drawing.Size(175, 29);
            this.cmb_Secondary.TabIndex = 50;
            // 
            // cmb_Tertiary
            // 
            this.cmb_Tertiary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tertiary.FormattingEnabled = true;
            this.cmb_Tertiary.Items.AddRange(new object[] {
            "None",
            "Strength",
            "Speed",
            "Shooting",
            "Passing",
            "Technique"});
            this.cmb_Tertiary.Location = new System.Drawing.Point(672, 14);
            this.cmb_Tertiary.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Tertiary.Name = "cmb_Tertiary";
            this.cmb_Tertiary.Size = new System.Drawing.Size(175, 29);
            this.cmb_Tertiary.TabIndex = 70;
            // 
            // chk_IgnoreBushido
            // 
            this.chk_IgnoreBushido.AutoSize = true;
            this.chk_IgnoreBushido.Location = new System.Drawing.Point(412, 53);
            this.chk_IgnoreBushido.Name = "chk_IgnoreBushido";
            this.chk_IgnoreBushido.Size = new System.Drawing.Size(134, 25);
            this.chk_IgnoreBushido.TabIndex = 72;
            this.chk_IgnoreBushido.Text = "Ignore Bushido";
            this.chk_IgnoreBushido.UseVisualStyleBackColor = true;
            // 
            // lbl_Results
            // 
            this.lbl_Results.AutoSize = true;
            this.lbl_Results.Location = new System.Drawing.Point(672, 55);
            this.lbl_Results.Name = "lbl_Results";
            this.lbl_Results.Size = new System.Drawing.Size(60, 21);
            this.lbl_Results.TabIndex = 73;
            this.lbl_Results.Text = "Results";
            // 
            // numud_Results
            // 
            this.numud_Results.Location = new System.Drawing.Point(752, 51);
            this.numud_Results.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numud_Results.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numud_Results.Name = "numud_Results";
            this.numud_Results.Size = new System.Drawing.Size(95, 29);
            this.numud_Results.TabIndex = 74;
            this.numud_Results.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dg_Result
            // 
            this.dg_Result.AllowUserToAddRows = false;
            this.dg_Result.AllowUserToDeleteRows = false;
            this.dg_Result.AllowUserToResizeRows = false;
            this.dg_Result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Result.CausesValidation = false;
            this.dg_Result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dg_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Result.Location = new System.Drawing.Point(12, 87);
            this.dg_Result.Name = "dg_Result";
            this.dg_Result.RowTemplate.Height = 25;
            this.dg_Result.Size = new System.Drawing.Size(1166, 475);
            this.dg_Result.TabIndex = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 573);
            this.Controls.Add(this.dg_Result);
            this.Controls.Add(this.numud_Results);
            this.Controls.Add(this.lbl_Results);
            this.Controls.Add(this.chk_IgnoreBushido);
            this.Controls.Add(this.cmb_Tertiary);
            this.Controls.Add(this.cmb_Secondary);
            this.Controls.Add(this.cmb_Primary);
            this.Controls.Add(this.cmb_Character);
            this.Controls.Add(this.lbl_Character);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.lbl_Tertiary);
            this.Controls.Add(this.lbl_Secondary);
            this.Controls.Add(this.lbl_Primary);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Battle League Character Optimizer";
            ((System.ComponentModel.ISupportInitialize)(this.numud_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Primary;
        private Label lbl_Secondary;
        private Label lbl_Tertiary;
        private Button btn_Go;
        private Label lbl_Character;
        private ComboBox cmb_Character;
        private ComboBox cmb_Primary;
        private ComboBox cmb_Secondary;
        private ComboBox cmb_Tertiary;
        private CheckBox chk_IgnoreBushido;
        private Label lbl_Results;
        private NumericUpDown numud_Results;
        private DataGridView dg_Result;
    }
}