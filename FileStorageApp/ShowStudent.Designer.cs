namespace FileStorageApp
{
    partial class ShowStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updtStudentRecord = new MetroFramework.Controls.MetroButton();
            this.stdData = new MetroFramework.Controls.MetroGrid();
            this.cellRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellCls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAdbms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellMc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellSe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTtl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stdData)).BeginInit();
            this.SuspendLayout();
            // 
            // updtStudentRecord
            // 
            this.updtStudentRecord.Location = new System.Drawing.Point(547, 14);
            this.updtStudentRecord.Name = "updtStudentRecord";
            this.updtStudentRecord.Size = new System.Drawing.Size(127, 23);
            this.updtStudentRecord.TabIndex = 1;
            this.updtStudentRecord.Text = "Update Record";
            this.updtStudentRecord.UseSelectable = true;
            this.updtStudentRecord.Click += new System.EventHandler(this.updtStudentRecord_Click);
            // 
            // stdData
            // 
            this.stdData.AllowUserToResizeRows = false;
            this.stdData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellRoll,
            this.cellName,
            this.cellCls,
            this.cellSem,
            this.cellAdbms,
            this.cellNs,
            this.cellMc,
            this.cellAn,
            this.cellSe,
            this.cellTtl,
            this.cellPr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stdData.DefaultCellStyle = dataGridViewCellStyle2;
            this.stdData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stdData.EnableHeadersVisualStyles = false;
            this.stdData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stdData.Location = new System.Drawing.Point(0, 54);
            this.stdData.Name = "stdData";
            this.stdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stdData.Size = new System.Drawing.Size(728, 409);
            this.stdData.TabIndex = 2;
            // 
            // cellRoll
            // 
            this.cellRoll.HeaderText = "Roll No";
            this.cellRoll.Name = "cellRoll";
            // 
            // cellName
            // 
            this.cellName.HeaderText = "Name";
            this.cellName.Name = "cellName";
            // 
            // cellCls
            // 
            this.cellCls.HeaderText = "Class";
            this.cellCls.Name = "cellCls";
            // 
            // cellSem
            // 
            this.cellSem.HeaderText = "Semester";
            this.cellSem.Name = "cellSem";
            // 
            // cellAdbms
            // 
            this.cellAdbms.HeaderText = "ADBMS";
            this.cellAdbms.Name = "cellAdbms";
            // 
            // cellNs
            // 
            this.cellNs.HeaderText = "NS";
            this.cellNs.Name = "cellNs";
            // 
            // cellMc
            // 
            this.cellMc.HeaderText = "MC";
            this.cellMc.Name = "cellMc";
            // 
            // cellAn
            // 
            this.cellAn.HeaderText = "AN";
            this.cellAn.Name = "cellAn";
            // 
            // cellSe
            // 
            this.cellSe.HeaderText = "SE";
            this.cellSe.Name = "cellSe";
            // 
            // cellTtl
            // 
            this.cellTtl.HeaderText = "Total";
            this.cellTtl.Name = "cellTtl";
            // 
            // cellPr
            // 
            this.cellPr.HeaderText = "Percentage";
            this.cellPr.Name = "cellPr";
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stdData);
            this.Controls.Add(this.updtStudentRecord);
            this.Name = "ShowStudent";
            this.Size = new System.Drawing.Size(728, 463);
            this.Load += new System.EventHandler(this.ShowStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton updtStudentRecord;
        private MetroFramework.Controls.MetroGrid stdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellCls;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellAdbms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellMc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellSe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPr;
    }
}
