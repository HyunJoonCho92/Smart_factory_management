namespace _미니_프로젝트_Ver_3_스마트팩토리_전용_설비_관리SW
{
    partial class Form_manageMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_manageMode_updateID = new System.Windows.Forms.TextBox();
            this.tb_manageMode_deleteID = new System.Windows.Forms.TextBox();
            this.bt_manageMode_update = new System.Windows.Forms.Button();
            this.bt_manageMode_delete = new System.Windows.Forms.Button();
            this.bt_manageMode_select = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 모드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. 사원 수정   ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. 사원 삭제   ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. 사원 조회";
            // 
            // tb_manageMode_updateID
            // 
            this.tb_manageMode_updateID.Location = new System.Drawing.Point(266, 78);
            this.tb_manageMode_updateID.Name = "tb_manageMode_updateID";
            this.tb_manageMode_updateID.Size = new System.Drawing.Size(100, 25);
            this.tb_manageMode_updateID.TabIndex = 4;
            // 
            // tb_manageMode_deleteID
            // 
            this.tb_manageMode_deleteID.Location = new System.Drawing.Point(266, 114);
            this.tb_manageMode_deleteID.Name = "tb_manageMode_deleteID";
            this.tb_manageMode_deleteID.Size = new System.Drawing.Size(100, 25);
            this.tb_manageMode_deleteID.TabIndex = 5;
            // 
            // bt_manageMode_update
            // 
            this.bt_manageMode_update.Location = new System.Drawing.Point(372, 77);
            this.bt_manageMode_update.Name = "bt_manageMode_update";
            this.bt_manageMode_update.Size = new System.Drawing.Size(75, 23);
            this.bt_manageMode_update.TabIndex = 6;
            this.bt_manageMode_update.Text = "검색";
            this.bt_manageMode_update.UseVisualStyleBackColor = true;
            this.bt_manageMode_update.Click += new System.EventHandler(this.bt_manageMode_update_Click);
            // 
            // bt_manageMode_delete
            // 
            this.bt_manageMode_delete.Location = new System.Drawing.Point(372, 117);
            this.bt_manageMode_delete.Name = "bt_manageMode_delete";
            this.bt_manageMode_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_manageMode_delete.TabIndex = 7;
            this.bt_manageMode_delete.Text = "검색";
            this.bt_manageMode_delete.UseVisualStyleBackColor = true;
            this.bt_manageMode_delete.Click += new System.EventHandler(this.bt_manageMode_delete_Click);
            // 
            // bt_manageMode_select
            // 
            this.bt_manageMode_select.Location = new System.Drawing.Point(277, 155);
            this.bt_manageMode_select.Name = "bt_manageMode_select";
            this.bt_manageMode_select.Size = new System.Drawing.Size(75, 23);
            this.bt_manageMode_select.TabIndex = 8;
            this.bt_manageMode_select.Text = "조회";
            this.bt_manageMode_select.UseVisualStyleBackColor = true;
            this.bt_manageMode_select.Click += new System.EventHandler(this.bt_manageMode_select_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(483, 208);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form_manageMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 460);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_manageMode_select);
            this.Controls.Add(this.bt_manageMode_delete);
            this.Controls.Add(this.bt_manageMode_update);
            this.Controls.Add(this.tb_manageMode_deleteID);
            this.Controls.Add(this.tb_manageMode_updateID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_manageMode";
            this.Text = "Form_manageMode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_manageMode_FormClosed);
            this.Load += new System.EventHandler(this.Form_manageMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_manageMode_updateID;
        private System.Windows.Forms.TextBox tb_manageMode_deleteID;
        private System.Windows.Forms.Button bt_manageMode_update;
        private System.Windows.Forms.Button bt_manageMode_delete;
        private System.Windows.Forms.Button bt_manageMode_select;
        private System.Windows.Forms.ListView listView1;
    }
}