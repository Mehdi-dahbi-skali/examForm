namespace Examen_Qcm
{
    partial class QCM
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
            this.txtbox_numero_question = new System.Windows.Forms.TextBox();
            this.txt_titre = new System.Windows.Forms.Label();
            this.txt_question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_question_qcm = new System.Windows.Forms.TextBox();
            this.proposition1_qcm = new System.Windows.Forms.Label();
            this.proposition2_qcm = new System.Windows.Forms.Label();
            this.proposition3_qcm = new System.Windows.Forms.Label();
            this.txtbox_p1 = new System.Windows.Forms.TextBox();
            this.txtbox_p2 = new System.Windows.Forms.TextBox();
            this.txtbox_p3 = new System.Windows.Forms.TextBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.txtbox_p4 = new System.Windows.Forms.TextBox();
            this.proposition4_qcm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_numero_question
            // 
            this.txtbox_numero_question.Location = new System.Drawing.Point(138, 96);
            this.txtbox_numero_question.Name = "txtbox_numero_question";
            this.txtbox_numero_question.Size = new System.Drawing.Size(292, 20);
            this.txtbox_numero_question.TabIndex = 5;
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.ForeColor = System.Drawing.Color.Red;
            this.txt_titre.Location = new System.Drawing.Point(295, 27);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(123, 50);
            this.txt_titre.TabIndex = 6;
            this.txt_titre.Text = "QCM";
            // 
            // txt_question
            // 
            this.txt_question.AutoSize = true;
            this.txt_question.Location = new System.Drawing.Point(12, 137);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(49, 13);
            this.txt_question.TabIndex = 7;
            this.txt_question.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numéro de question";
            // 
            // txtbox_question_qcm
            // 
            this.txtbox_question_qcm.Location = new System.Drawing.Point(138, 137);
            this.txtbox_question_qcm.Name = "txtbox_question_qcm";
            this.txtbox_question_qcm.Size = new System.Drawing.Size(292, 20);
            this.txtbox_question_qcm.TabIndex = 9;
            // 
            // proposition1_qcm
            // 
            this.proposition1_qcm.AutoSize = true;
            this.proposition1_qcm.Location = new System.Drawing.Point(12, 219);
            this.proposition1_qcm.Name = "proposition1_qcm";
            this.proposition1_qcm.Size = new System.Drawing.Size(68, 13);
            this.proposition1_qcm.TabIndex = 10;
            this.proposition1_qcm.Text = "Proposition 1";
            // 
            // proposition2_qcm
            // 
            this.proposition2_qcm.AutoSize = true;
            this.proposition2_qcm.Location = new System.Drawing.Point(12, 259);
            this.proposition2_qcm.Name = "proposition2_qcm";
            this.proposition2_qcm.Size = new System.Drawing.Size(68, 13);
            this.proposition2_qcm.TabIndex = 11;
            this.proposition2_qcm.Text = "Proposition 2";
            // 
            // proposition3_qcm
            // 
            this.proposition3_qcm.AutoSize = true;
            this.proposition3_qcm.Location = new System.Drawing.Point(12, 296);
            this.proposition3_qcm.Name = "proposition3_qcm";
            this.proposition3_qcm.Size = new System.Drawing.Size(68, 13);
            this.proposition3_qcm.TabIndex = 12;
            this.proposition3_qcm.Text = "Proposition 3";
            this.proposition3_qcm.Click += new System.EventHandler(this.proposition3_qcm_Click);
            // 
            // txtbox_p1
            // 
            this.txtbox_p1.Location = new System.Drawing.Point(138, 212);
            this.txtbox_p1.Name = "txtbox_p1";
            this.txtbox_p1.Size = new System.Drawing.Size(292, 20);
            this.txtbox_p1.TabIndex = 13;
            // 
            // txtbox_p2
            // 
            this.txtbox_p2.Location = new System.Drawing.Point(138, 252);
            this.txtbox_p2.Name = "txtbox_p2";
            this.txtbox_p2.Size = new System.Drawing.Size(292, 20);
            this.txtbox_p2.TabIndex = 14;
            // 
            // txtbox_p3
            // 
            this.txtbox_p3.Location = new System.Drawing.Point(138, 293);
            this.txtbox_p3.Name = "txtbox_p3";
            this.txtbox_p3.Size = new System.Drawing.Size(292, 20);
            this.txtbox_p3.TabIndex = 15;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_modifier.Location = new System.Drawing.Point(168, 369);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(119, 44);
            this.btn_modifier.TabIndex = 18;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_annuler.Location = new System.Drawing.Point(328, 369);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(119, 44);
            this.btn_annuler.TabIndex = 17;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_confirmer.Location = new System.Drawing.Point(15, 369);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(117, 44);
            this.btn_confirmer.TabIndex = 16;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = false;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // txtbox_p4
            // 
            this.txtbox_p4.Location = new System.Drawing.Point(138, 329);
            this.txtbox_p4.Name = "txtbox_p4";
            this.txtbox_p4.Size = new System.Drawing.Size(292, 20);
            this.txtbox_p4.TabIndex = 19;
            // 
            // proposition4_qcm
            // 
            this.proposition4_qcm.AutoSize = true;
            this.proposition4_qcm.Location = new System.Drawing.Point(12, 332);
            this.proposition4_qcm.Name = "proposition4_qcm";
            this.proposition4_qcm.Size = new System.Drawing.Size(68, 13);
            this.proposition4_qcm.TabIndex = 20;
            this.proposition4_qcm.Text = "Proposition 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Les Propositions:";
            // 
            // QCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proposition4_qcm);
            this.Controls.Add(this.txtbox_p4);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.txtbox_p3);
            this.Controls.Add(this.txtbox_p2);
            this.Controls.Add(this.txtbox_p1);
            this.Controls.Add(this.proposition3_qcm);
            this.Controls.Add(this.proposition2_qcm);
            this.Controls.Add(this.proposition1_qcm);
            this.Controls.Add(this.txtbox_question_qcm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txtbox_numero_question);
            this.Name = "QCM";
            this.Text = "QCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_numero_question;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.Label txt_question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_question_qcm;
        private System.Windows.Forms.Label proposition1_qcm;
        private System.Windows.Forms.Label proposition2_qcm;
        private System.Windows.Forms.Label proposition3_qcm;
        private System.Windows.Forms.TextBox txtbox_p1;
        private System.Windows.Forms.TextBox txtbox_p2;
        private System.Windows.Forms.TextBox txtbox_p3;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.TextBox txtbox_p4;
        private System.Windows.Forms.Label proposition4_qcm;
        private System.Windows.Forms.Label label3;
    }
}