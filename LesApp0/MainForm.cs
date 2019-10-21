using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://metanit.com/sharp/entityframework/1.2.php
// https://metanit.com/sharp/entityframework/2.2.php

namespace LesApp0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При натисканні кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                // створюємо об'єкти
                Model[] models = new Model[]
                {
                    new Model() { Id = 0, Name = "Bogdan", Age = 27 },
                    new Model() { Id = 1, Name = "Vlad", Age = 26 },
                    new Model() { Id = 2, Name = "Vadim", Age = 28 },
                    new Model() { Id = 3, Name = "Dima", Age = 25 },
                    new Model() { Id = 4, Name = "Nastya", Age = 27 },
                    new Model() { Id = 5, Name = "Olexiy", Age = 18 },
                    new Model() { Id = 6, Name = "Valya", Age = 17 },
                };

                // додаємо в БД
                db.Models.AddRange(models);
                // зберігаємо
                db.SaveChanges();

                // завантаження даних
                db.Models.Load();
                // передача на форму
                dataGrid.DataSource = db.Models.Local;
                //dataGrid.Refresh();
                dataGrid.Update();
            }
        }
    }
}
