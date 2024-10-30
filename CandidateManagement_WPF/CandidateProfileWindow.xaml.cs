using CandidateManagement_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for CandidateProfile.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {
        private int? RoleID = 0;
        private ICandidateProfileService profileService;
        private IJobPostingService jobPostingService;
        public CandidateProfileWindow()
        {
            InitializeComponent();
            profileService = new CandidateProfileSevice();
            jobPostingService = new JobPostingService();
        }
        public CandidateProfileWindow(int? roleID)
        {
            InitializeComponent();
            profileService = new CandidateProfileSevice();
            jobPostingService = new JobPostingService();
            this.RoleID = roleID;
            switch (RoleID)
            {
                case 1:
                    break;
                case 2:
                    //2: Dont Add
                    this.btnAdd.IsEnabled = false;
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
MessageBox.Show("Are you sure to quit ?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInit();
        }
        private void loadDataInit()
        {
            this.dtgCandidateProfile.ItemsSource = profileService.GetCandidateProfiles();
            this.cmbPostID.ItemsSource = jobPostingService.GetJobPostings();
            this.cmbPostID.DisplayMemberPath = "JobPostingTitle";
            this.cmbPostID.SelectedValuePath = "PostingId";

            idCandidate.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            txtImg.Text = "";
            txtDescription.Text = "";
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            candidate.CandidateId = this.idCandidate.Text;
            candidate.Fullname = this.txtName.Text;
            candidate.Birthday = DateTime.Parse(this.txtBirthday.Text);
            candidate.ProfileShortDescription = this.txtDescription.Text;   
            candidate.ProfileUrl = this.txtImg.Text;
            candidate.PostingId = cmbPostID.SelectedValue.ToString();   

            if (profileService.AddCandidateProfile(candidate))
            {
                MessageBox.Show("Add successfully");
                loadDataInit();
            } else
            {
                MessageBox.Show("Add Failed");

            }
        }

        private void dtgCandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex) as DataGridRow;
            if (row != null) 
            {
                DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                string id = ((TextBlock)RowColumn.Content).Text;
                CandidateProfile profile = profileService.GetCandidateProfileById(id);
                if (profile != null)
                {
                    idCandidate.Text = profile.CandidateId;
                    txtName.Text = profile.Fullname;
                    txtBirthday.Text = profile.Birthday.ToString();
                    txtImg.Text = profile.ProfileUrl;
                    cmbPostID.SelectedValue = profile.PostingId;
                    txtDescription.Text = profile.ProfileShortDescription;
                }
            }


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
MessageBox.Show("Are you sure to delete ?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                if (idCandidate.Text.Length > 0 && profileService.DeleteCandidateProfile(idCandidate.Text))
                {
                    string name = txtName.Text;
                    MessageBox.Show($"Delete {name} successfull");
                    loadDataInit();
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            candidate.CandidateId = this.idCandidate.Text;
            candidate.Fullname = this.txtName.Text;
            candidate.Birthday = DateTime.Parse(this.txtBirthday.Text);
            candidate.ProfileShortDescription = this.txtDescription.Text;
            candidate.ProfileUrl = this.txtImg.Text;
            candidate.PostingId = cmbPostID.SelectedValue.ToString();

            if (profileService.UpdateCandidateProfile(candidate))
            {
                MessageBox.Show("Update successfull");
                loadDataInit();
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }


    }
}
