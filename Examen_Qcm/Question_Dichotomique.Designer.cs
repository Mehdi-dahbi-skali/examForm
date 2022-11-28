namespace Examen_Qcm
{
    partial class Question_Dichotomique
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.txtbox_question_dicho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_question = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.Label();
            this.txtbox_numero_question = new System.Windows.Forms.TextBox();
            this.proposition4_qcm = new System.Windows.Forms.Label();
            this.radio_vrai = new System.Windows.Forms.RadioButton();
            this.radio_faux = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_annuler.Location = new System.Drawing.Point(376, 361);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(129, 44);
            this.btn_annuler.TabIndex = 33;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_confirmer.Location = new System.Drawing.Point(174, 361);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(126, 44);
            this.btn_confirmer.TabIndex = 32;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = false;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // txtbox_question_dicho
            // 
            this.txtbox_question_dicho.Location = new System.Drawing.Point(174, 159);
            this.txtbox_question_dicho.Name = "txtbox_question_dicho";
            this.txtbox_question_dicho.Size = new System.Drawing.Size(331, 20);
            this.txtbox_question_dicho.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numéro de question";
            // 
            // txtbox_question
            // 
            this.txtbox_question.AutoSize = true;
            this.txtbox_question.Location = new System.Drawing.Point(29, 166);
            this.txtbox_question.Name = "txtbox_question";
            this.txtbox_question.Size = new System.Drawing.Size(49, 13);
            this.txtbox_question.TabIndex = 23;
            this.txtbox_question.Text = "Question";
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.ForeColor = System.Drawing.Color.Red;
            this.txt_titre.Location = new System.Drawing.Point(122, 37);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(498, 50);
            this.txt_titre.TabIndex = 22;
            this.txt_titre.Text = "Question Dichotomique";
            // 
            // txtbox_numero_question
            // 
            this.txtbox_numero_question.Location = new System.Drawing.Point(174, 122);
            this.txtbox_numero_question.Name = "txtbox_numero_question";
            this.txtbox_numero_question.Size = new System.Drawing.Size(331, 20);
            this.txtbox_numero_question.TabIndex = 21;
            // 
            // proposition4_qcm
            // 
            this.proposition4_qcm.AutoSize = true;
            this.proposition4_qcm.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proposition4_qcm.Location = new System.Drawing.Point(29, 224);
            this.proposition4_qcm.Name = "proposition4_qcm";
            this.proposition4_qcm.Size = new System.Drawing.Size(119, 19);
            this.proposition4_qcm.TabIndex = 36;
            this.proposition4_qcm.Text = "Les choix:";
            // 
            // radio_vrai
            // 
            this.radio_vrai.AutoSize = true;
            this.radio_vrai.Location = new System.Drawing.Point(89, 263);
            this.radio_vrai.Name = "radio_vrai";
            this.radio_vrai.Size = new System.Drawing.Size(43, 17);
            this.radio_vrai.TabIndex = 37;
            this.radio_vrai.TabStop = true;
            this.radio_vrai.Text = "Vrai";
            this.radio_vrai.UseVisualStyleBackColor = true;
            // 
            // radio_faux
            // 
            this.radio_faux.AutoSize = true;
            this.radio_faux.Location = new System.Drawing.Point(89, 295);
            this.radio_faux.Name = "radio_faux";
            this.radio_faux.Size = new System.Drawing.Size(48, 17);
            this.radio_faux.TabIndex = 38;
            this.radio_faux.TabStop = true;
            this.radio_faux.Text = "Faux";
            this.radio_faux.UseVisualStyleBackColor = true;
            // 
            // Question_Dichotomique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radio_faux);
            this.Controls.Add(this.radio_vrai);
            this.Controls.Add(this.proposition4_qcm);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.txtbox_question_dicho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_question);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txtbox_numero_question);
            this.Name = "Question_Dichotomique";
            this.Text = "Question_Dichotomique";
            this.Load += new System.EventHandler(this.Question_Dichotomique_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.TextBox txtbox_question_dicho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtbox_question;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.TextBox txtbox_numero_question;
        private System.Windows.Forms.Label proposition4_qcm;
        private System.Windows.Forms.RadioButton radio_vrai;
        private System.Windows.Forms.RadioButton radio_faux;
    }
}