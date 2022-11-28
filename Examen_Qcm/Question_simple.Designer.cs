namespace Examen_Qcm
{
    partial class Question_simple
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
            this.proposition4_qcm = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.txtbox_question = new System.Windows.Forms.TextBox();
            this.txtbox_n = new System.Windows.Forms.Label();
            this.txt_question = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.Label();
            this.txtbox_numero = new System.Windows.Forms.TextBox();
            this.textBox_prp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // proposition4_qcm
            // 
            this.proposition4_qcm.AutoSize = true;
            this.proposition4_qcm.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proposition4_qcm.Location = new System.Drawing.Point(105, 229);
            this.proposition4_qcm.Name = "proposition4_qcm";
            this.proposition4_qcm.Size = new System.Drawing.Size(174, 19);
            this.proposition4_qcm.TabIndex = 47;
            this.proposition4_qcm.Text = "La Proposition:";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_annuler.Location = new System.Drawing.Point(387, 376);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(129, 33);
            this.btn_annuler.TabIndex = 45;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_confirmer.Location = new System.Drawing.Point(179, 376);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(126, 33);
            this.btn_confirmer.TabIndex = 44;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = false;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // txtbox_question
            // 
            this.txtbox_question.Location = new System.Drawing.Point(250, 164);
            this.txtbox_question.Name = "txtbox_question";
            this.txtbox_question.Size = new System.Drawing.Size(331, 20);
            this.txtbox_question.TabIndex = 43;
            // 
            // txtbox_n
            // 
            this.txtbox_n.AutoSize = true;
            this.txtbox_n.Location = new System.Drawing.Point(105, 130);
            this.txtbox_n.Name = "txtbox_n";
            this.txtbox_n.Size = new System.Drawing.Size(102, 13);
            this.txtbox_n.TabIndex = 42;
            this.txtbox_n.Text = "Numéro de question";
            // 
            // txt_question
            // 
            this.txt_question.AutoSize = true;
            this.txt_question.Location = new System.Drawing.Point(105, 171);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(49, 13);
            this.txt_question.TabIndex = 41;
            this.txt_question.Text = "Question";
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.ForeColor = System.Drawing.Color.Red;
            this.txt_titre.Location = new System.Drawing.Point(198, 42);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(352, 50);
            this.txt_titre.TabIndex = 40;
            this.txt_titre.Text = "Question Simple";
            // 
            // txtbox_numero
            // 
            this.txtbox_numero.Location = new System.Drawing.Point(250, 127);
            this.txtbox_numero.Name = "txtbox_numero";
            this.txtbox_numero.Size = new System.Drawing.Size(331, 20);
            this.txtbox_numero.TabIndex = 39;
            // 
            // textBox_prp
            // 
            this.textBox_prp.Location = new System.Drawing.Point(108, 277);
            this.textBox_prp.Name = "textBox_prp";
            this.textBox_prp.Size = new System.Drawing.Size(500, 20);
            this.textBox_prp.TabIndex = 48;
            // 
            // Question_simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_prp);
            this.Controls.Add(this.proposition4_qcm);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.txtbox_question);
            this.Controls.Add(this.txtbox_n);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txtbox_numero);
            this.Name = "Question_simple";
            this.Text = "Question_simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proposition4_qcm;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.TextBox txtbox_question;
        private System.Windows.Forms.Label txtbox_n;
        private System.Windows.Forms.Label txt_question;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.TextBox txtbox_numero;
        private System.Windows.Forms.TextBox textBox_prp;
    }
}