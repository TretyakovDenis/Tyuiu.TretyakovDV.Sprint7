using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TretyakovDV.Sprint7.Project.V7
{
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAdd_TDV_Click(object sender, EventArgs e)
        {
            if ((comboBoxKids_TDV.Text == "") || (comboBoxDebt_TDV.Text == ""))
            {
                MessageBox.Show("Введите обязательные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fmain.dataGridViewBase_TDV.Rows.Add(textBoxPadik_TDV.Text, textBoxAppartament_TDV.Text, textBoxRooms_TDV.Text, textBoxTotalArea_TDV.Text, comboBoxKids_TDV.Text, comboBoxDebt_TDV.Text);
                this.Close();
            }
        }
       
        private void textBoxPadik_TDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAppartament_TDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRooms_TDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxTotalArea_TDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
