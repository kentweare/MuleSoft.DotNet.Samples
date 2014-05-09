namespace MuleSoft.DotNet.MaintenanceSystem
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
            this.btnGetWorkOrder = new System.Windows.Forms.Button();
            this.txtWorkOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlant = new System.Windows.Forms.TextBox();
            this.txtFunctionalLocation = new System.Windows.Forms.TextBox();
            this.txtMaintenanceType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.txtRequestedDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCompleteWorkOrder = new System.Windows.Forms.Button();
            this.panelCompleteWorkOrder = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompleteWorkOrderID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompleteHours = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkYes = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmitCompletedWorkOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCompleteWorkOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetWorkOrder
            // 
            this.btnGetWorkOrder.Location = new System.Drawing.Point(12, 299);
            this.btnGetWorkOrder.Name = "btnGetWorkOrder";
            this.btnGetWorkOrder.Size = new System.Drawing.Size(98, 23);
            this.btnGetWorkOrder.TabIndex = 0;
            this.btnGetWorkOrder.Text = "Get Work Order";
            this.btnGetWorkOrder.UseVisualStyleBackColor = true;
            this.btnGetWorkOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWorkOrderID
            // 
            this.txtWorkOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrderID.Location = new System.Drawing.Point(154, 31);
            this.txtWorkOrderID.Name = "txtWorkOrderID";
            this.txtWorkOrderID.Size = new System.Drawing.Size(110, 23);
            this.txtWorkOrderID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Work Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plant: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maintenance Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Requested Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Functional Location:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPlant
            // 
            this.txtPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlant.Location = new System.Drawing.Point(154, 65);
            this.txtPlant.Name = "txtPlant";
            this.txtPlant.Size = new System.Drawing.Size(110, 23);
            this.txtPlant.TabIndex = 14;
            // 
            // txtFunctionalLocation
            // 
            this.txtFunctionalLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunctionalLocation.Location = new System.Drawing.Point(154, 102);
            this.txtFunctionalLocation.Name = "txtFunctionalLocation";
            this.txtFunctionalLocation.Size = new System.Drawing.Size(110, 23);
            this.txtFunctionalLocation.TabIndex = 15;
            // 
            // txtMaintenanceType
            // 
            this.txtMaintenanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceType.Location = new System.Drawing.Point(154, 172);
            this.txtMaintenanceType.Name = "txtMaintenanceType";
            this.txtMaintenanceType.Size = new System.Drawing.Size(110, 23);
            this.txtMaintenanceType.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Machine ID:";
            // 
            // txtMachineID
            // 
            this.txtMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineID.Location = new System.Drawing.Point(154, 138);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(110, 23);
            this.txtMachineID.TabIndex = 18;
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestedDate.Location = new System.Drawing.Point(154, 216);
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.Size = new System.Drawing.Size(110, 23);
            this.txtRequestedDate.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRequestedDate);
            this.panel1.Controls.Add(this.txtMachineID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMaintenanceType);
            this.panel1.Controls.Add(this.txtFunctionalLocation);
            this.panel1.Controls.Add(this.txtPlant);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWorkOrderID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 268);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Work Orders";
            // 
            // btnCompleteWorkOrder
            // 
            this.btnCompleteWorkOrder.Location = new System.Drawing.Point(125, 299);
            this.btnCompleteWorkOrder.Name = "btnCompleteWorkOrder";
            this.btnCompleteWorkOrder.Size = new System.Drawing.Size(117, 23);
            this.btnCompleteWorkOrder.TabIndex = 8;
            this.btnCompleteWorkOrder.Text = "Complete Work Order";
            this.btnCompleteWorkOrder.UseVisualStyleBackColor = true;
            this.btnCompleteWorkOrder.Visible = false;
            this.btnCompleteWorkOrder.Click += new System.EventHandler(this.btnCompleteWorkOrder_Click);
            // 
            // panelCompleteWorkOrder
            // 
            this.panelCompleteWorkOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCompleteWorkOrder.Controls.Add(this.label12);
            this.panelCompleteWorkOrder.Controls.Add(this.txtComments);
            this.panelCompleteWorkOrder.Controls.Add(this.checkYes);
            this.panelCompleteWorkOrder.Controls.Add(this.label11);
            this.panelCompleteWorkOrder.Controls.Add(this.txtCompleteHours);
            this.panelCompleteWorkOrder.Controls.Add(this.label10);
            this.panelCompleteWorkOrder.Controls.Add(this.txtCompleteWorkOrderID);
            this.panelCompleteWorkOrder.Controls.Add(this.label9);
            this.panelCompleteWorkOrder.Controls.Add(this.label7);
            this.panelCompleteWorkOrder.Location = new System.Drawing.Point(449, 12);
            this.panelCompleteWorkOrder.Name = "panelCompleteWorkOrder";
            this.panelCompleteWorkOrder.Size = new System.Drawing.Size(460, 268);
            this.panelCompleteWorkOrder.TabIndex = 9;
            this.panelCompleteWorkOrder.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Complete Work Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Work Order ID:";
            // 
            // txtCompleteWorkOrderID
            // 
            this.txtCompleteWorkOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleteWorkOrderID.Location = new System.Drawing.Point(190, 31);
            this.txtCompleteWorkOrderID.Name = "txtCompleteWorkOrderID";
            this.txtCompleteWorkOrderID.Size = new System.Drawing.Size(110, 23);
            this.txtCompleteWorkOrderID.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Hours:";
            // 
            // txtCompleteHours
            // 
            this.txtCompleteHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleteHours.Location = new System.Drawing.Point(190, 68);
            this.txtCompleteHours.Name = "txtCompleteHours";
            this.txtCompleteHours.Size = new System.Drawing.Size(110, 23);
            this.txtCompleteHours.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Completed Successfully:";
            // 
            // checkYes
            // 
            this.checkYes.AutoSize = true;
            this.checkYes.Location = new System.Drawing.Point(190, 107);
            this.checkYes.Name = "checkYes";
            this.checkYes.Size = new System.Drawing.Size(44, 17);
            this.checkYes.TabIndex = 15;
            this.checkYes.Text = "Yes";
            this.checkYes.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(190, 138);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(236, 101);
            this.txtComments.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Comments";
            
            // 
            // btnSubmitCompletedWorkOrder
            // 
            this.btnSubmitCompletedWorkOrder.Location = new System.Drawing.Point(449, 298);
            this.btnSubmitCompletedWorkOrder.Name = "btnSubmitCompletedWorkOrder";
            this.btnSubmitCompletedWorkOrder.Size = new System.Drawing.Size(162, 23);
            this.btnSubmitCompletedWorkOrder.TabIndex = 10;
            this.btnSubmitCompletedWorkOrder.Text = "Submit Completed Work Order";
            this.btnSubmitCompletedWorkOrder.UseVisualStyleBackColor = true;
            this.btnSubmitCompletedWorkOrder.Visible = false;
            this.btnSubmitCompletedWorkOrder.Click += new System.EventHandler(this.btnSubmitCompletedWorkOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 345);
            this.Controls.Add(this.btnSubmitCompletedWorkOrder);
            this.Controls.Add(this.panelCompleteWorkOrder);
            this.Controls.Add(this.btnCompleteWorkOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetWorkOrder);
            this.Name = "Form1";
            this.Text = "Maintenance Module";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCompleteWorkOrder.ResumeLayout(false);
            this.panelCompleteWorkOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetWorkOrder;
        private System.Windows.Forms.TextBox txtWorkOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlant;
        private System.Windows.Forms.TextBox txtFunctionalLocation;
        private System.Windows.Forms.TextBox txtMaintenanceType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.TextBox txtRequestedDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCompleteWorkOrder;
        private System.Windows.Forms.Panel panelCompleteWorkOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox checkYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCompleteHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompleteWorkOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmitCompletedWorkOrder;
    }
}

