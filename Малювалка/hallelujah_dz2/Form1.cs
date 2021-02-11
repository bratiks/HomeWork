using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hallelujah_dz2
{
    public partial class Form1 : Form
    {
        string color = "Black";
        object last_sender = null;
        bool create_rectangle = false;
        bool rectangle = false;
        bool empty = true;
        Point start_point;

        public Form1()
        {
            InitializeComponent();
        }

        private void lb_redColor_Click(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(lb_pencil.Font, FontStyle.Underline);
            color = (sender as Label).Text;
            if(last_sender == null) { }
                else (last_sender as Label).Font = new Font(lb_pencil.Font, FontStyle.Regular);
            last_sender = sender;

            empty = false;
            lb_empty.Font = new Font(lb_pencil.Font, FontStyle.Regular);
        }

        private void lb_pencil_MouseClick(object sender, MouseEventArgs e)
        {
            lb_pencil.BorderStyle = BorderStyle.FixedSingle;
            lb_rectangle.BorderStyle = BorderStyle.None;
            tb_size.Enabled = true;
            rectangle = false;
            lb_empty.Enabled = false;

            lb_empty.Font = new Font(lb_empty.Font, FontStyle.Regular);
        }

        private void lb_rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            lb_pencil.BorderStyle = BorderStyle.None;
            lb_rectangle.BorderStyle = BorderStyle.FixedSingle;
            tb_size.Enabled = false;
            rectangle = true;
            lb_empty.Enabled = true;
        }

        private void lb_clear_MouseClick(object sender, MouseEventArgs e)
        {
            panel.Controls.Clear();

        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_size.Enabled) return;
            if (!rectangle) return;
            var label = new Label();

                if (!create_rectangle)
                {
                    start_point = new Point(e.X, e.Y);
                    label.BackColor = Color.FromName("Black");
                    label.Size = new Size(1, 1);
                    label.Location = start_point;
                    panel.Controls.Add(label);
            
                    create_rectangle = !create_rectangle;
            
                }
                else
                {
                    panel.Controls.RemoveAt(panel.Controls.Count - 1);

                    if (empty) { label.BorderStyle = BorderStyle.FixedSingle; }
                    else label.BackColor = Color.FromName(color);


                    if (e.X > start_point.X) { label.Size = new Size(e.X - start_point.X, start_point.Y); }
                     else { label.Size = new Size(start_point.X - e.X, start_point.Y);
                             start_point.X = e.X;
                     }
            
                    if(e.Y > start_point.Y) { label.Size = new Size(label.Width, e.Y - start_point.Y); }
                    else { label.Size = new Size(label.Width, start_point.Y - e.Y);
                             start_point.Y -= label.Height;
                    }

                    label.Location = start_point;
                     panel.Controls.Add(label);
                    label.BringToFront();

                    create_rectangle = !create_rectangle;
                }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectangle) return;
            if (!tb_size.Enabled) return;
            if (e.Button != MouseButtons.Left) return;
            
            var label = new Label();

                label.BackColor = Color.FromName(color);
                label.Size = new Size(int.Parse(tb_size.Text), int.Parse(tb_size.Text));
                label.Location = new Point(e.X, e.Y);
                panel.Controls.Add(label);
                label.BringToFront();

        }

        private void lb_help_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Щоб створити прямокутник, потрібно натиснути на відповідну кнопку у верхньому меню слідом поставити дві точки по діагоналі", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lb_empty_MouseClick(object sender, MouseEventArgs e)
        {
            empty = !empty;
            if (empty) { lb_empty.Font = new Font(lb_empty.Font, FontStyle.Underline); }
            else lb_empty.Font = new Font(lb_empty.Font, FontStyle.Regular);

            if (last_sender == null) { }
            else (last_sender as Label).Font = new Font(lb_pencil.Font, FontStyle.Regular);
            last_sender = null;
        }

        private void tb_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) { e.Handled = true; }
        }

        private void tb_size_MouseLeave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tb_size.Text) > 100) { tb_size.Text = "100"; }
        }
    }
}