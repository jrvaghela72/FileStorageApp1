using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Newtonsoft.Json;

namespace FileStorageApp
{
    public partial class ShowStudent : MetroUserControl
    {
        private dynamic readObject;
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            stdData.Rows.Clear();
            LoadStudentRecord();
        }
        private void updtStudentRecord_Click(object sender, EventArgs e)
        {
            stdData.Rows.Clear();
            LoadStudentRecord();
        }

        private void LoadStudentRecord()
        {
            if (File.Exists(MainWindow.FilePath))
            {

                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {

                    string json = reader.ReadToEnd();
                    readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        if (pr != null)
                        {
                            stdData.Rows.Add(pr.Rollno, pr.Name, pr.Cls, pr.Sem, pr.Subjects.Adbms, pr.Subjects.Ns,
                                pr.Subjects.Mc, pr.Subjects.An, pr.Subjects.Se, pr.Subjects.Total, pr.Subjects.Percentage);
                        }
                        else
                        {
                            MessageBox.Show("Currently no student in the list");
                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("No data available for reading");
            }
        }
    }
}
