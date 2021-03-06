﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using SPK.Utilities;
using DB.Services.DataRepository;

namespace SPK.UserControls.SubForms
{
    public partial class TeachertoClass : UserControl
    {
        List<_class> classes = new List<_class>();
        List<school_subjects> Subjects = new List<school_subjects>();
        List<teacher> Teachers = new List<teacher>();
        List<teachers_classes> TnCs = new List<teachers_classes>();

        public TeachertoClass()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                cBoxClass.Cursor = Cursors.WaitCursor;
                cBoxSubject.Cursor = Cursors.WaitCursor;
                cBoxTeacher.Cursor = Cursors.WaitCursor;
                dGridTeachers_Class.Cursor = Cursors.WaitCursor;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var db = new Model1())
                {
                    classes = db.classes.ToList();
                    Subjects = db.school_subjects.ToList();
                    Teachers = db.teachers.ToList();
                    TnCs = db.teachers_classes.ToList();
                }
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
                MessageBox.Show("Error occured. Please contact support.");
            }
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cBoxClass.DataSource = classes;
            cBoxClass.DisplayMember = "classes";
            
            cBoxSubject.DataSource = Subjects;
            cBoxSubject.DisplayMember = "subjects";

            cBoxTeacher.DataSource = Teachers;
            cBoxTeacher.DisplayMember = "Fullname";

            dGridTeachers_Class.DataSource = TnCs;

            cBoxClass.Cursor = Cursors.Arrow;
            cBoxSubject.Cursor = Cursors.Arrow;
            cBoxTeacher.Cursor = Cursors.Arrow;
            dGridTeachers_Class.Cursor = Cursors.Arrow;

        }

        private teachers_classes CreateTeacherClass()
        {
            var TsCs = new teachers_classes()
            {
                name = cBoxTeacher.Text,
                subject = cBoxSubject.Text,
                term = cBoxTerm.Text,
                _class = cBoxClass.Text,
            };

            return TsCs;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if(ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                var tc = CreateTeacherClass();

                try
                {
                    var _unitOfWork = new UnitOfWork(new Model1());

                    _unitOfWork.Teachers_ClassesRepository.Add(tc);
                    _unitOfWork.Save();
                    _unitOfWork.Dispose();
                    MessageBox.Show("Added");

                    using (var db = new Model1())
                    {
                        TnCs = db.teachers_classes.ToList();
                        dGridTeachers_Class.DataSource = TnCs;
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
                
            }
        }

        private void dGridTeachers_Class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var btn = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (btn.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    if (senderGrid.CurrentRow != null)
                    {
                        var _id = (int)senderGrid.CurrentRow.Cells["id"].Value;
                        using (var db = new Model1())
                        {
                            var tc = new teachers_classes() { id = _id };
                            db.teachers_classes.Attach(tc);
                            db.teachers_classes.Remove(tc);
                            db.SaveChanges();

                            TnCs = db.teachers_classes.ToList();
                            dGridTeachers_Class.DataSource = TnCs;

                        }
                    }
                }
            }
        }
    }
}
