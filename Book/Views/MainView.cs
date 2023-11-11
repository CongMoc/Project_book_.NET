using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Views
{
    public partial class MainView : Form,IMainView
    {

        public bool check
        {
            get { return tsbbtnManager.Enabled; }
            set { tsbbtnManager.Enabled = value; }
        }

        public string idcus
        {
            get { return tsbbtnIDUser.Text; }
            set { tsbbtnIDUser.Text = value; }
        }

        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Show main
            tsbbtnMonbook.Click += delegate
            {
                ShowBook?.Invoke(this, EventArgs.Empty);
            };
            //Show cart
            tsbbtnCart.Click += delegate
            {
                ShowCart?.Invoke(this, EventArgs.Empty);
            };
            //Show History
            tsbbtnHistoryOrder.Click += delegate
            {
                ShowHistory?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnManager.Click += delegate
            {
                ShowManager?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnStoryMon.Click += delegate
            {
                ShowStory?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnMyProfile.Click += delegate
            {
                ShowProfile?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnStoryMon.Click += delegate
            {
                ShowStory?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnLogOut.Click += delegate
            {
                DialogResult dg = MessageBox.Show("Do you want to Logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    this.Close();
                    ShowPublisher?.Invoke(this, EventArgs.Empty);
                }            
            };
            tsbbtnPublisher.Click += delegate
            {
                MessageBox.Show("Events updating!!!", "Note", MessageBoxButtons.OK);
            };
        }

        public event EventHandler ShowBook;
        public event EventHandler ShowProfile;
        public event EventHandler ShowCart;
        public event EventHandler ShowHistory;
        public event EventHandler ShowManager;
        public event EventHandler ShowPublisher;
        public event EventHandler ShowStory;

        private void tsbbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        static int Count = 0;
        private void tsbbtnMaximize_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                WindowState = FormWindowState.Maximized;
                Count++;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Count--;
            }
        }

        private void tsbbtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tsbbtnMyProfile_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowBook?.Invoke(this, EventArgs.Empty);
        }

        private void tsbbtnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
