using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using System.IO;
using Newtonsoft.Json;

namespace FileStorageApp
{
    public partial class UpdateStudent : MetroUserControl
    {
        private dynamic readObject;
        int rollno;
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void txtURollNo_TextChanged(object sender, EventArgs e)
        {
            stName.Text = "";
            if (!int.TryParse(txtURollNo.Text, out rollno))
            {
                stName.Visible = true;
                EnbleLayout(null, 2);
                stName.Text = "enter valid roll number";
            }
            else
            {
                if (File.Exists(MainWindow.FilePath))
                {

                    using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                    {
                        
                        string json = reader.ReadToEnd();
                         readObject= JsonConvert.DeserializeObject<List<StudentProp>>(json);
                        foreach (StudentProp pr in readObject)
                        {
                            if (pr.Rollno == rollno)
                            {
                                stName.Visible = true;
                                EnbleLayout(pr,1);
                                break;
                            }
                            else
                            {
                                stName.Visible = true;
                                stName.Text = "Record not found";
                                EnbleLayout(null,2);
                            }
                        }
                       
                    }
                    
                }
                else
                {
                    stName.Visible = true;
                    EnbleLayout(null,2);
                    stName.Text = "No data available for reading";
                }
               
            }
        }
        public void EnbleLayout(StudentProp std, int flag)
        {
            if (flag==1)
            {
              
                lblName.Visible = true;
                lblCls.Visible = true;
                lblSem.Visible = true;
                lblAdbms.Visible = true;
                lblAn.Visible = true;
                lblMc.Visible = true;
                lblSe.Visible = true;
                lblNs.Visible = true;

                mName.Visible = true;
                mName.Text = std.Name;

                mClass.Visible = true;
                mClass.Text= std.Cls;

                mSem.Visible = true;
                mSem.Text= std.Sem;

                mAdbms.Visible = true;
                mAdbms.Text= std.Subjects.Adbms.ToString();

                mAn.Visible = true;
                mAn.Text = std.Subjects.An.ToString();

                mMc.Visible = true;
                mMc.Text = std.Subjects.Mc.ToString();

                mSe.Visible = true;
                mSe.Text = std.Subjects.Se.ToString();

                mNs.Visible = true;
                mNs.Text = std.Subjects.Ns.ToString();

                mBtn.Visible = true;
                mBtn.Click += MBtn_Click;
                
            }
            else if (flag==2)
            {
                lblName.Visible = false;
                lblCls.Visible = false;
                lblSem.Visible = false;
                lblAdbms.Visible = false;
                lblAn.Visible = false;
                lblMc.Visible = false;
                lblSe.Visible = false;
                lblNs.Visible = false;

                mName.Visible = false;
                mClass.Visible = false;
                mSem.Visible = false;
                mAdbms.Visible = false;
                mAn.Visible = false;
                mMc.Visible = false;
                mSe.Visible = false;
                mNs.Visible = false;
                mBtn.Visible = false;
            }
        }

        private void MBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(MainWindow.FilePath))
            {
                List<StudentProp> newList = new List<StudentProp>();
                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {
                    string json = reader.ReadToEnd();
                    readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        if (pr.Rollno == rollno)
                        {
                            pr.Name = mName.Text;
                            pr.Cls = mClass.Text;
                            pr.Sem = mSem.Text;
                            pr.Subjects.Adbms = int.Parse(mAdbms.Text);
                            pr.Subjects.An =int.Parse(mAn.Text);
                            pr.Subjects.Mc= int.Parse(mMc.Text);
                            pr.Subjects.Se = int.Parse(mSe.Text);
                            pr.Subjects.Ns = int.Parse(mNs.Text);
                        }
                        newList.Add(pr);
                    }
                }
                File.WriteAllText(MainWindow.FilePath, JsonConvert.SerializeObject(newList));

            }
            else
            {
                stName.Visible = true;
                EnbleLayout(null, 2);
                stName.Text = "No data available for reading";
            }
        }
    }
}
