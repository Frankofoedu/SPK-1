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
using DB.Services.Interfaces;
using DB.Services.DataRepository;
using SPK.Utilities;

namespace SPK.UserControls.SubForms
{
    public partial class SpecifyJssSubject : UserControl
    {
        private List<jss> _listClass;
        private List<school_subjects> _listSubjects;
        private IUnitOfWork _unitOfWork;
        public SpecifyJssSubject()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(new Model1());

            dGridSubjecs.Cursor = Cursors.WaitCursor;
            cBoxSubject.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _listSubjects = _unitOfWork.School_SubjectsRepository.FindAll().ToList();
                using (var db = new Model1())
                {
                    _listClass = db.jsses.ToList();
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
            cBoxSubject.DataSource = _listSubjects;
            cBoxSubject.Cursor = Cursors.Arrow;

            dGridSubjecs.DataSource = _listClass;
            dGridSubjecs.Cursor = Cursors.Arrow;
        }

        private void btnSave_ClickEvent(object sender, EventArgs e)
        {
            if (ValidateFomControls.CheckComboBoxes(this, errorProvider1))
            {
                var subj = new jss()
                {
                    jss_subjects = cBoxSubject.Text,
                    upload_date = DateTime.Now.ToString("d"),
                    upload_time = DateTime.Now
                };
                try
                {
                    using (var db = new Model1())
                    {
                        var isExist = db.jsses.Any(x => x.jss_subjects == subj.jss_subjects);
                        if (!isExist)
                        {
                            db.jsses.Add(subj);
                            db.SaveChanges();

                            dGridSubjecs.DataSource = db.jsses.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Subject already exists");
                        }

                    }

                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                    MessageBox.Show("Error occured. Please contact support.");
                }
            }
        }
    }
}
