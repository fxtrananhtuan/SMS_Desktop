using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.ComponentModel;

namespace SMS_Desktop
{
   public class CGlobalFunction
    {
        /// <summary>
        /// OpenChildForm
        /// </summary>
        /// <param name="ff">Form main</param>
        /// <param name="f">Form child</param>
        public static void OpenChildForm(Form ff, Form f)
        {
            foreach (Form frm in ff.MdiChildren)
            {
                frm.Hide();
            }
            f.MdiParent = ff;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 0);
            f.BackColor = ff.BackColor;
            f.Opacity = 1;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ControlBox = true;
            if (ff.Contains(f))
            {
                f.Show();
                f.BringToFront();
                return;
            }
            f.MdiParent = ff;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 0);
            f.BackColor = ff.BackColor;
            f.Opacity = 1;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ControlBox = true;
            try
            {
                f.Show();
            }
            catch { f.Show(); }
        }
        /// <summary>
        /// Open from for login or connection
        /// </summary>
        /// <param name="ff">Form main</param>
        /// <param name="f">Form Child</param>
        public static void OpenForm(Form ff, Form f)
        {

            foreach (Form frm in ff.MdiChildren)
            {
                frm.Hide();
            }
            f.MdiParent = ff;
            f.ControlBox = true;
            f.StartPosition = FormStartPosition.Manual;
            // f.Location = new Point(ff.Width - f.Width - 350, ff.Height - f.Height - 200); 
            f.ControlBox = false;
            if (ff.Contains(f))
            {
                f.Show();
                f.BringToFront();
                return;
            }
            f.Show();
        }
        /// <summary>

        /// </summary> 
        /// <param name="f">Form</param>
        public static void OpenForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ControlBox = true;
            //f.ShowDialog();
            f.Show();
        }
        public static void openFormCenter(Form ff, Form f)
        {
            foreach (Form frm in ff.MdiChildren)
            {
                frm.Hide();
            }
            f.MdiParent = ff;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.BackColor = ff.BackColor;
            f.Opacity = 1;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ControlBox = true;
            if (ff.Contains(f))
            {
                f.Show();
                f.BringToFront();
                return;
            }
            f.MdiParent = ff;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.BackColor = ff.BackColor;
            f.Opacity = 1;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ControlBox = true;
            try
            {
                f.Show();
            }
            catch { f.Show(); }
        }
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }

}
