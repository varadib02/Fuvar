
namespace FuvarGUI
{
    partial class FuvarGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuvarGUI));
            this.btn_load = new System.Windows.Forms.Button();
            this.lB_fuvar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_azon = new System.Windows.Forms.TextBox();
            this.txtb_ind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_ido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_tav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_vdij = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_borravalo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_fmod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_close_confirm = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(11, 322);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(76, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lB_fuvar
            // 
            this.lB_fuvar.FormattingEnabled = true;
            this.lB_fuvar.ItemHeight = 15;
            this.lB_fuvar.Location = new System.Drawing.Point(12, 12);
            this.lB_fuvar.Name = "lB_fuvar";
            this.lB_fuvar.Size = new System.Drawing.Size(156, 304);
            this.lB_fuvar.TabIndex = 2;
            this.lB_fuvar.SelectedIndexChanged += new System.EventHandler(this.lB_fuvar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuvar Adatok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "azon";
            // 
            // txtb_azon
            // 
            this.txtb_azon.Location = new System.Drawing.Point(276, 53);
            this.txtb_azon.Name = "txtb_azon";
            this.txtb_azon.Size = new System.Drawing.Size(129, 23);
            this.txtb_azon.TabIndex = 5;
            // 
            // txtb_ind
            // 
            this.txtb_ind.Location = new System.Drawing.Point(276, 82);
            this.txtb_ind.Name = "txtb_ind";
            this.txtb_ind.Size = new System.Drawing.Size(129, 23);
            this.txtb_ind.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "indulás";
            // 
            // txtb_ido
            // 
            this.txtb_ido.Location = new System.Drawing.Point(276, 111);
            this.txtb_ido.Name = "txtb_ido";
            this.txtb_ido.Size = new System.Drawing.Size(129, 23);
            this.txtb_ido.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "időtart";
            // 
            // txtb_tav
            // 
            this.txtb_tav.Location = new System.Drawing.Point(276, 140);
            this.txtb_tav.Name = "txtb_tav";
            this.txtb_tav.Size = new System.Drawing.Size(129, 23);
            this.txtb_tav.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "táv";
            // 
            // txtb_vdij
            // 
            this.txtb_vdij.Location = new System.Drawing.Point(276, 169);
            this.txtb_vdij.Name = "txtb_vdij";
            this.txtb_vdij.Size = new System.Drawing.Size(129, 23);
            this.txtb_vdij.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "vdij";
            // 
            // txtb_borravalo
            // 
            this.txtb_borravalo.Location = new System.Drawing.Point(276, 198);
            this.txtb_borravalo.Name = "txtb_borravalo";
            this.txtb_borravalo.Size = new System.Drawing.Size(129, 23);
            this.txtb_borravalo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "borravalo";
            // 
            // txtb_fmod
            // 
            this.txtb_fmod.Location = new System.Drawing.Point(276, 227);
            this.txtb_fmod.Name = "txtb_fmod";
            this.txtb_fmod.Size = new System.Drawing.Size(129, 23);
            this.txtb_fmod.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "fizetesmodja";
            // 
            // btn_close_confirm
            // 
            this.btn_close_confirm.BackColor = System.Drawing.Color.Maroon;
            this.btn_close_confirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close_confirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close_confirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close_confirm.Location = new System.Drawing.Point(330, 293);
            this.btn_close_confirm.Name = "btn_close_confirm";
            this.btn_close_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_close_confirm.TabIndex = 18;
            this.btn_close_confirm.Text = "Close 100%";
            this.btn_close_confirm.UseVisualStyleBackColor = false;
            this.btn_close_confirm.Visible = false;
            this.btn_close_confirm.Click += new System.EventHandler(this.btn_close_confirm_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Location = new System.Drawing.Point(330, 322);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(93, 322);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 20;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // FuvarGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_close_confirm);
            this.Controls.Add(this.txtb_fmod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_borravalo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_vdij);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_tav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_ido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_ind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_azon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_fuvar);
            this.Controls.Add(this.btn_load);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuvarGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuvar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox lB_fuvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_azon;
        private System.Windows.Forms.TextBox txtb_ind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_ido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_tav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_vdij;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_borravalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_fmod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_close_confirm;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_order;
    }
}

