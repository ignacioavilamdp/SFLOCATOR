
namespace SFLOCATOR
{
    partial class FrmResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResults));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxFaultDistancePu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxFaultDistanceKm = new System.Windows.Forms.TextBox();
            this.comboBoxFaultedLoop = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxFaultResistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxFaultDistancePu);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtBoxFaultDistanceKm);
            this.groupBox3.Controls.Add(this.comboBoxFaultedLoop);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBoxFaultResistance);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 165);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fault location";
            // 
            // txtBoxFaultDistancePu
            // 
            this.txtBoxFaultDistancePu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFaultDistancePu.Location = new System.Drawing.Point(172, 63);
            this.txtBoxFaultDistancePu.Name = "txtBoxFaultDistancePu";
            this.txtBoxFaultDistancePu.ReadOnly = true;
            this.txtBoxFaultDistancePu.Size = new System.Drawing.Size(66, 22);
            this.txtBoxFaultDistancePu.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "Fault resistence [ohm]";
            // 
            // txtBoxFaultDistanceKm
            // 
            this.txtBoxFaultDistanceKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFaultDistanceKm.Location = new System.Drawing.Point(172, 95);
            this.txtBoxFaultDistanceKm.Name = "txtBoxFaultDistanceKm";
            this.txtBoxFaultDistanceKm.ReadOnly = true;
            this.txtBoxFaultDistanceKm.Size = new System.Drawing.Size(66, 22);
            this.txtBoxFaultDistanceKm.TabIndex = 9;
            // 
            // comboBoxFaultedLoop
            // 
            this.comboBoxFaultedLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaultedLoop.FormattingEnabled = true;
            this.comboBoxFaultedLoop.Items.AddRange(new object[] {
            "L1-G",
            "L2-G",
            "L3-G",
            "L1-L2",
            "L2-L3",
            "L3-L1"});
            this.comboBoxFaultedLoop.Location = new System.Drawing.Point(172, 28);
            this.comboBoxFaultedLoop.Name = "comboBoxFaultedLoop";
            this.comboBoxFaultedLoop.Size = new System.Drawing.Size(84, 24);
            this.comboBoxFaultedLoop.TabIndex = 5;
            this.comboBoxFaultedLoop.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaultedLoop_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Faulted Loop";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fault distance [km]";
            // 
            // txtBoxFaultResistance
            // 
            this.txtBoxFaultResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFaultResistance.Location = new System.Drawing.Point(172, 127);
            this.txtBoxFaultResistance.Name = "txtBoxFaultResistance";
            this.txtBoxFaultResistance.ReadOnly = true;
            this.txtBoxFaultResistance.Size = new System.Drawing.Size(66, 22);
            this.txtBoxFaultResistance.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fault distance [pu]";
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 198);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResults";
            this.Text = "Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmResults_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxFaultDistancePu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxFaultDistanceKm;
        private System.Windows.Forms.ComboBox comboBoxFaultedLoop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxFaultResistance;
        private System.Windows.Forms.Label label6;
    }
}