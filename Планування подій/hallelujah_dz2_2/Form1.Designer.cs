
namespace hallelujah_dz2_2
{
    partial class Form
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
            this.tb_eventName = new System.Windows.Forms.TextBox();
            this.lb_eventName = new System.Windows.Forms.Label();
            this.lb_eventPlace = new System.Windows.Forms.Label();
            this.tb_eventPlace = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_eventPriority = new System.Windows.Forms.Label();
            this.listbox_events = new System.Windows.Forms.ListBox();
            this.btn_deleteAllEvents = new System.Windows.Forms.Button();
            this.btn_deleteEvent = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.listbox_priority = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_eventName
            // 
            this.tb_eventName.Location = new System.Drawing.Point(81, 15);
            this.tb_eventName.Name = "tb_eventName";
            this.tb_eventName.Size = new System.Drawing.Size(140, 20);
            this.tb_eventName.TabIndex = 0;
            // 
            // lb_eventName
            // 
            this.lb_eventName.AutoSize = true;
            this.lb_eventName.Location = new System.Drawing.Point(12, 15);
            this.lb_eventName.Name = "lb_eventName";
            this.lb_eventName.Size = new System.Drawing.Size(68, 13);
            this.lb_eventName.TabIndex = 9;
            this.lb_eventName.Text = "Назва події:";
            // 
            // lb_eventPlace
            // 
            this.lb_eventPlace.AutoSize = true;
            this.lb_eventPlace.Location = new System.Drawing.Point(12, 63);
            this.lb_eventPlace.Name = "lb_eventPlace";
            this.lb_eventPlace.Size = new System.Drawing.Size(65, 13);
            this.lb_eventPlace.TabIndex = 10;
            this.lb_eventPlace.Text = "Місце події:";
            // 
            // tb_eventPlace
            // 
            this.tb_eventPlace.Location = new System.Drawing.Point(81, 63);
            this.tb_eventPlace.Name = "tb_eventPlace";
            this.tb_eventPlace.Size = new System.Drawing.Size(140, 20);
            this.tb_eventPlace.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.Location = new System.Drawing.Point(264, 15);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 2, 15, 0, 0, 0, 0), new System.DateTime(2021, 2, 21, 0, 0, 0, 0));
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // lb_eventPriority
            // 
            this.lb_eventPriority.AutoSize = true;
            this.lb_eventPriority.Location = new System.Drawing.Point(11, 114);
            this.lb_eventPriority.Name = "lb_eventPriority";
            this.lb_eventPriority.Size = new System.Drawing.Size(86, 13);
            this.lb_eventPriority.TabIndex = 11;
            this.lb_eventPriority.Text = "Приорітет події:";
            // 
            // listbox_events
            // 
            this.listbox_events.FormattingEnabled = true;
            this.listbox_events.Location = new System.Drawing.Point(15, 189);
            this.listbox_events.Name = "listbox_events";
            this.listbox_events.Size = new System.Drawing.Size(441, 147);
            this.listbox_events.TabIndex = 6;
            // 
            // btn_deleteAllEvents
            // 
            this.btn_deleteAllEvents.Location = new System.Drawing.Point(31, 410);
            this.btn_deleteAllEvents.Name = "btn_deleteAllEvents";
            this.btn_deleteAllEvents.Size = new System.Drawing.Size(172, 23);
            this.btn_deleteAllEvents.TabIndex = 8;
            this.btn_deleteAllEvents.Text = "Очистити список подій";
            this.btn_deleteAllEvents.UseVisualStyleBackColor = true;
            this.btn_deleteAllEvents.Click += new System.EventHandler(this.btn_deleteAllEvents_Click);
            // 
            // btn_deleteEvent
            // 
            this.btn_deleteEvent.Location = new System.Drawing.Point(63, 369);
            this.btn_deleteEvent.Name = "btn_deleteEvent";
            this.btn_deleteEvent.Size = new System.Drawing.Size(109, 23);
            this.btn_deleteEvent.TabIndex = 7;
            this.btn_deleteEvent.Text = "Видалити подію";
            this.btn_deleteEvent.UseVisualStyleBackColor = true;
            this.btn_deleteEvent.Click += new System.EventHandler(this.btn_deleteEvent_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(264, 410);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Зберегти список подій";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Location = new System.Drawing.Point(296, 369);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(104, 23);
            this.btn_addEvent.TabIndex = 4;
            this.btn_addEvent.Text = "Додати подію";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // listbox_priority
            // 
            this.listbox_priority.FormattingEnabled = true;
            this.listbox_priority.Items.AddRange(new object[] {
            "Низький",
            "Середній",
            "Високий"});
            this.listbox_priority.Location = new System.Drawing.Point(103, 114);
            this.listbox_priority.Name = "listbox_priority";
            this.listbox_priority.Size = new System.Drawing.Size(120, 30);
            this.listbox_priority.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(468, 456);
            this.Controls.Add(this.listbox_priority);
            this.Controls.Add(this.btn_addEvent);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_deleteEvent);
            this.Controls.Add(this.btn_deleteAllEvents);
            this.Controls.Add(this.listbox_events);
            this.Controls.Add(this.lb_eventPriority);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lb_eventPlace);
            this.Controls.Add(this.tb_eventPlace);
            this.Controls.Add(this.lb_eventName);
            this.Controls.Add(this.tb_eventName);
            this.Name = "Form";
            this.Text = "Планування подій (Version 1.0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_eventName;
        private System.Windows.Forms.Label lb_eventName;
        private System.Windows.Forms.Label lb_eventPlace;
        private System.Windows.Forms.TextBox tb_eventPlace;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lb_eventPriority;
        private System.Windows.Forms.ListBox listbox_events;
        private System.Windows.Forms.Button btn_deleteAllEvents;
        private System.Windows.Forms.Button btn_deleteEvent;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.ListBox listbox_priority;
    }
}

