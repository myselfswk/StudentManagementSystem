
namespace StudentManagementSystem
{
    partial class AddCourses
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
            this.lbladdCourse = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.lblOfferedDate = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescriptions = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.NumericUpDown();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCR)).BeginInit();
            this.SuspendLayout();
            // 
            // lbladdCourse
            // 
            this.lbladdCourse.AutoSize = true;
            this.lbladdCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdCourse.Location = new System.Drawing.Point(247, 9);
            this.lbladdCourse.Name = "lbladdCourse";
            this.lbladdCourse.Size = new System.Drawing.Size(182, 31);
            this.lbladdCourse.TabIndex = 0;
            this.lbladdCourse.Text = "Add Courses";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(151, 92);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(38, 20);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(151, 143);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(89, 20);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "Description";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCR.Location = new System.Drawing.Point(151, 239);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(98, 20);
            this.lblCR.TabIndex = 1;
            this.lblCR.Text = "Credit Hours";
            // 
            // lblOfferedDate
            // 
            this.lblOfferedDate.AutoSize = true;
            this.lblOfferedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedDate.Location = new System.Drawing.Point(151, 290);
            this.lblOfferedDate.Name = "lblOfferedDate";
            this.lblOfferedDate.Size = new System.Drawing.Size(102, 20);
            this.lblOfferedDate.TabIndex = 1;
            this.lblOfferedDate.Text = "Offered Date";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(309, 91);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptions.Location = new System.Drawing.Point(309, 137);
            this.txtDescriptions.Multiline = true;
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(201, 76);
            this.txtDescriptions.TabIndex = 2;
            // 
            // txtCR
            // 
            this.txtCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCR.Location = new System.Drawing.Point(309, 238);
            this.txtCR.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtCR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(201, 26);
            this.txtCR.TabIndex = 3;
            this.txtCR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DTPicker
            // 
            this.DTPicker.Location = new System.Drawing.Point(309, 289);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(200, 20);
            this.DTPicker.TabIndex = 4;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(309, 345);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(200, 44);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtDescriptions);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblOfferedDate);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lbladdCourse);
            this.Name = "AddCourses";
            this.Text = "Add Courses";
            ((System.ComponentModel.ISupportInitialize)(this.txtCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdCourse;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Label lblOfferedDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescriptions;
        private System.Windows.Forms.NumericUpDown txtCR;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.Button btnAddCourse;
    }
}