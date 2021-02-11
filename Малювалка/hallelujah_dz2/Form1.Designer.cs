
namespace hallelujah_dz2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.lb_redColor = new System.Windows.Forms.Label();
            this.lb_greenColor = new System.Windows.Forms.Label();
            this.lb_blueColor = new System.Windows.Forms.Label();
            this.lb_pencil = new System.Windows.Forms.Label();
            this.lb_rectangle = new System.Windows.Forms.Label();
            this.lb_size = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.lb_clear = new System.Windows.Forms.Label();
            this.lb_blackColor = new System.Windows.Forms.Label();
            this.lb_help = new System.Windows.Forms.Label();
            this.lb_empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 32);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 418);
            this.panel.TabIndex = 0;
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // lb_redColor
            // 
            this.lb_redColor.AutoSize = true;
            this.lb_redColor.Location = new System.Drawing.Point(12, 9);
            this.lb_redColor.Name = "lb_redColor";
            this.lb_redColor.Size = new System.Drawing.Size(27, 13);
            this.lb_redColor.TabIndex = 1;
            this.lb_redColor.Text = "Red";
            this.lb_redColor.Click += new System.EventHandler(this.lb_redColor_Click);
            // 
            // lb_greenColor
            // 
            this.lb_greenColor.AutoSize = true;
            this.lb_greenColor.Location = new System.Drawing.Point(45, 9);
            this.lb_greenColor.Name = "lb_greenColor";
            this.lb_greenColor.Size = new System.Drawing.Size(36, 13);
            this.lb_greenColor.TabIndex = 2;
            this.lb_greenColor.Text = "Green";
            this.lb_greenColor.Click += new System.EventHandler(this.lb_redColor_Click);
            // 
            // lb_blueColor
            // 
            this.lb_blueColor.AutoSize = true;
            this.lb_blueColor.Location = new System.Drawing.Point(88, 9);
            this.lb_blueColor.Name = "lb_blueColor";
            this.lb_blueColor.Size = new System.Drawing.Size(28, 13);
            this.lb_blueColor.TabIndex = 3;
            this.lb_blueColor.Text = "Blue";
            this.lb_blueColor.Click += new System.EventHandler(this.lb_redColor_Click);
            // 
            // lb_pencil
            // 
            this.lb_pencil.Image = ((System.Drawing.Image)(resources.GetObject("lb_pencil.Image")));
            this.lb_pencil.Location = new System.Drawing.Point(179, 6);
            this.lb_pencil.Name = "lb_pencil";
            this.lb_pencil.Size = new System.Drawing.Size(20, 20);
            this.lb_pencil.TabIndex = 5;
            this.lb_pencil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_pencil_MouseClick);
            // 
            // lb_rectangle
            // 
            this.lb_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("lb_rectangle.Image")));
            this.lb_rectangle.Location = new System.Drawing.Point(205, 6);
            this.lb_rectangle.Name = "lb_rectangle";
            this.lb_rectangle.Size = new System.Drawing.Size(20, 20);
            this.lb_rectangle.TabIndex = 6;
            this.lb_rectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_rectangle_MouseClick);
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Location = new System.Drawing.Point(290, 10);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(30, 13);
            this.lb_size.TabIndex = 7;
            this.lb_size.Text = "Size:";
            // 
            // tb_size
            // 
            this.tb_size.Enabled = false;
            this.tb_size.Location = new System.Drawing.Point(325, 7);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(35, 20);
            this.tb_size.TabIndex = 8;
            this.tb_size.Text = "1";
            this.tb_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_size_KeyPress);
            this.tb_size.MouseLeave += new System.EventHandler(this.tb_size_MouseLeave);
            // 
            // lb_clear
            // 
            this.lb_clear.AutoSize = true;
            this.lb_clear.Location = new System.Drawing.Point(396, 11);
            this.lb_clear.Name = "lb_clear";
            this.lb_clear.Size = new System.Drawing.Size(31, 13);
            this.lb_clear.TabIndex = 9;
            this.lb_clear.Text = "Clear";
            this.lb_clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_clear_MouseClick);
            // 
            // lb_blackColor
            // 
            this.lb_blackColor.AutoSize = true;
            this.lb_blackColor.Location = new System.Drawing.Point(122, 10);
            this.lb_blackColor.Name = "lb_blackColor";
            this.lb_blackColor.Size = new System.Drawing.Size(34, 13);
            this.lb_blackColor.TabIndex = 10;
            this.lb_blackColor.Text = "Black";
            this.lb_blackColor.Click += new System.EventHandler(this.lb_redColor_Click);
            // 
            // lb_help
            // 
            this.lb_help.Image = ((System.Drawing.Image)(resources.GetObject("lb_help.Image")));
            this.lb_help.Location = new System.Drawing.Point(464, 7);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(20, 20);
            this.lb_help.TabIndex = 11;
            this.lb_help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_help_MouseClick);
            // 
            // lb_empty
            // 
            this.lb_empty.AutoSize = true;
            this.lb_empty.Enabled = false;
            this.lb_empty.Location = new System.Drawing.Point(235, 10);
            this.lb_empty.Name = "lb_empty";
            this.lb_empty.Size = new System.Drawing.Size(36, 13);
            this.lb_empty.TabIndex = 12;
            this.lb_empty.Text = "Empty";
            this.lb_empty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_empty_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_empty);
            this.Controls.Add(this.lb_help);
            this.Controls.Add(this.lb_blackColor);
            this.Controls.Add(this.lb_clear);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.lb_rectangle);
            this.Controls.Add(this.lb_pencil);
            this.Controls.Add(this.lb_blueColor);
            this.Controls.Add(this.lb_greenColor);
            this.Controls.Add(this.lb_redColor);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lb_redColor;
        private System.Windows.Forms.Label lb_greenColor;
        private System.Windows.Forms.Label lb_blueColor;
        private System.Windows.Forms.Label lb_pencil;
        private System.Windows.Forms.Label lb_rectangle;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Label lb_clear;
        private System.Windows.Forms.Label lb_blackColor;
        private System.Windows.Forms.Label lb_help;
        private System.Windows.Forms.Label lb_empty;
    }
}

