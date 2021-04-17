
namespace QuanLyDiemSV
{
    partial class frDiemExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDiemExcel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.dtgvDiemSV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANGDIEMCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemSVData = new QuanLyDiemSV.DiemSVData();
            this.btnLuu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bANGDIEMCTTableAdapter = new QuanLyDiemSV.DiemSVDataTableAdapters.BANGDIEMCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemSVData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDiemSV
            // 
            this.dtgvDiemSV.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvDiemSV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDiemSV.AutoGenerateColumns = false;
            this.dtgvDiemSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDiemSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDiemSV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDiemSV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiemSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDiemSV.ColumnHeadersHeight = 40;
            this.dtgvDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.mALOPHPDataGridViewTextBoxColumn,
            this.dIEMCCDataGridViewTextBoxColumn,
            this.dIEMTXDataGridViewTextBoxColumn,
            this.dIEMTHIDataGridViewTextBoxColumn,
            this.dIEMTBDataGridViewTextBoxColumn,
            this.tENSVDataGridViewTextBoxColumn});
            this.dtgvDiemSV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvDiemSV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvDiemSV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvDiemSV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvDiemSV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvDiemSV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvDiemSV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvDiemSV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvDiemSV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvDiemSV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDiemSV.CurrentTheme.Name = null;
            this.dtgvDiemSV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDiemSV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvDiemSV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvDiemSV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvDiemSV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvDiemSV.DataSource = this.bANGDIEMCTBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDiemSV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDiemSV.EnableHeadersVisualStyles = false;
            this.dtgvDiemSV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvDiemSV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvDiemSV.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvDiemSV.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvDiemSV.Location = new System.Drawing.Point(36, 26);
            this.dtgvDiemSV.Name = "dtgvDiemSV";
            this.dtgvDiemSV.RowHeadersVisible = false;
            this.dtgvDiemSV.RowHeadersWidth = 51;
            this.dtgvDiemSV.RowTemplate.Height = 40;
            this.dtgvDiemSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDiemSV.Size = new System.Drawing.Size(893, 449);
            this.dtgvDiemSV.TabIndex = 34;
            this.dtgvDiemSV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // mALOPHPDataGridViewTextBoxColumn
            // 
            this.mALOPHPDataGridViewTextBoxColumn.DataPropertyName = "MALOPHP";
            this.mALOPHPDataGridViewTextBoxColumn.HeaderText = "MALOPHP";
            this.mALOPHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOPHPDataGridViewTextBoxColumn.Name = "mALOPHPDataGridViewTextBoxColumn";
            // 
            // dIEMCCDataGridViewTextBoxColumn
            // 
            this.dIEMCCDataGridViewTextBoxColumn.DataPropertyName = "DIEMCC";
            this.dIEMCCDataGridViewTextBoxColumn.HeaderText = "DIEMCC";
            this.dIEMCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIEMCCDataGridViewTextBoxColumn.Name = "dIEMCCDataGridViewTextBoxColumn";
            // 
            // dIEMTXDataGridViewTextBoxColumn
            // 
            this.dIEMTXDataGridViewTextBoxColumn.DataPropertyName = "DIEMTX";
            this.dIEMTXDataGridViewTextBoxColumn.HeaderText = "DIEMTX";
            this.dIEMTXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIEMTXDataGridViewTextBoxColumn.Name = "dIEMTXDataGridViewTextBoxColumn";
            // 
            // dIEMTHIDataGridViewTextBoxColumn
            // 
            this.dIEMTHIDataGridViewTextBoxColumn.DataPropertyName = "DIEMTHI";
            this.dIEMTHIDataGridViewTextBoxColumn.HeaderText = "DIEMTHI";
            this.dIEMTHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIEMTHIDataGridViewTextBoxColumn.Name = "dIEMTHIDataGridViewTextBoxColumn";
            // 
            // dIEMTBDataGridViewTextBoxColumn
            // 
            this.dIEMTBDataGridViewTextBoxColumn.DataPropertyName = "DIEMTB";
            this.dIEMTBDataGridViewTextBoxColumn.HeaderText = "DIEMTB";
            this.dIEMTBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIEMTBDataGridViewTextBoxColumn.Name = "dIEMTBDataGridViewTextBoxColumn";
            // 
            // tENSVDataGridViewTextBoxColumn
            // 
            this.tENSVDataGridViewTextBoxColumn.DataPropertyName = "TENSV";
            this.tENSVDataGridViewTextBoxColumn.HeaderText = "TENSV";
            this.tENSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENSVDataGridViewTextBoxColumn.Name = "tENSVDataGridViewTextBoxColumn";
            // 
            // bANGDIEMCTBindingSource
            // 
            this.bANGDIEMCTBindingSource.DataMember = "BANGDIEMCT";
            this.bANGDIEMCTBindingSource.DataSource = this.diemSVData;
            // 
            // diemSVData
            // 
            this.diemSVData.DataSetName = "DiemSVData";
            this.diemSVData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.AllowToggling = false;
            this.btnLuu.AnimationSpeed = 200;
            this.btnLuu.AutoGenerateColors = true;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.ButtonText = "Xác nhận lưu";
            this.btnLuu.ButtonTextMarginLeft = 0;
            this.btnLuu.ColorContrastOnClick = 45;
            this.btnLuu.ColorContrastOnHover = 45;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLuu.CustomizableEdges = borderEdges1;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLuu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLuu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLuu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLuu.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.IconMarginLeft = 11;
            this.btnLuu.IconPadding = 10;
            this.btnLuu.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(175)))), ((int)(((byte)(85)))));
            this.btnLuu.IdleBorderRadius = 5;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLuu.IdleIconLeftImage = null;
            this.btnLuu.IdleIconRightImage = null;
            this.btnLuu.IndicateFocus = false;
            this.btnLuu.Location = new System.Drawing.Point(409, 489);
            this.btnLuu.Name = "btnLuu";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(211)))), ((int)(((byte)(161)))));
            stateProperties1.BorderRadius = 5;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLuu.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(96)))), ((int)(((byte)(46)))));
            stateProperties2.BorderRadius = 5;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(140)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLuu.OnPressedState = stateProperties2;
            this.btnLuu.Size = new System.Drawing.Size(151, 45);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.TextMarginLeft = 0;
            this.btnLuu.UseDefaultRadiusAndThickness = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bANGDIEMCTTableAdapter
            // 
            this.bANGDIEMCTTableAdapter.ClearBeforeFill = true;
            // 
            // frDiemExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 546);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtgvDiemSV);
            this.Name = "frDiemExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frDiemExcel";
            this.Load += new System.EventHandler(this.frDiemExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemSVData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtgvDiemSV;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLuu;
        private DiemSVData diemSVData;
        private System.Windows.Forms.BindingSource bANGDIEMCTBindingSource;
        private DiemSVDataTableAdapters.BANGDIEMCTTableAdapter bANGDIEMCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSVDataGridViewTextBoxColumn;
    }
}