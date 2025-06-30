namespace OutlookObjectives
{
    using CommonObjectives;
    using Microsoft.Office.Interop.Outlook;
    using Microsoft.Web.WebView2.Core;
    using Microsoft.Win32;
    using Microsoft.Win32;
    using Serilog;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
    using Application = System.Windows.Forms.Application;

    /// <summary>
    /// A User Control to be used as the UI for the Objectives Pane.
    /// </summary>
    public partial class UCObjectives : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UCObjectives"/> class.
        /// </summary>
        public UCObjectives()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills the UI with Objectives.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void UCObjectives_Load(object sender, EventArgs e)
        {
            foreach (string path in Directory.EnumerateDirectories(InTouch.ObjectivesRootFolder, "*", SearchOption.TopDirectoryOnly))
            {
                Objective objective = InTouch.GetObjective(path);
                ListViewItem nextItem = new ListViewItem(objective.ObjectiveName)
                {
                    ImageIndex = 0,
                    Tag = objective.Path,
                };
                _ = ListObjectives.Items.Add(nextItem);
            }

            foreach (string path in Directory.EnumerateDirectories(InTouch.ObjectivesArchiveFolder, "*", SearchOption.TopDirectoryOnly))
            {
                Objective objective = InTouch.GetObjective(path);
                ListViewItem nextItem = new ListViewItem(objective.ObjectiveName)
                {
                    ImageIndex = 1,
                    Tag = objective.Path,
                };
                _ = ListObjectives.Items.Add(nextItem);
            }

            CultureInfo culture = CultureInfo.CurrentCulture;
            string formatted = DateTime.Now.ToString("MMM dd, yyyy", culture);

            groupBox1.Text = $"{formatted}";

            // Calculate how many days to subtract to get to Monday and Friday of this week.
            int daysToSubtract = (7 + (int)DateTime.Now.DayOfWeek - (int)DayOfWeek.Monday) % 7;
            DateTime monday = DateTime.Now.Date.AddDays(-daysToSubtract);
            int daysUntilFriday = ((int)DayOfWeek.Friday - (int)DateTime.Now.DayOfWeek + 7) % 7;
            DateTime thisFriday = DateTime.Now.Date.AddDays(daysUntilFriday);

            string monStr = monday.ToString("MMM dd, yyyy", culture);
            string friStr = thisFriday.ToString("MMM dd, yyyy", culture);
            grpSummary.Text = $"{monStr} ~ {friStr}";

            InitializeCoreWebView2Async();
            //Navigate to URI by setting Source property
            webView.Source = new Uri("http://localhost:2025/");
            //Navigate to URI by setting Source property
            webView21.Source = new Uri("http://localhost:2025/summary");
        }

        private void InitializeCoreWebView2Async()
        {
            string tempWebCacheDir = Path.GetTempPath();
            //Specify options regarding the coreView2 initialization process
            var webView2Environment = CoreWebView2Environment.CreateAsync(userDataFolder: tempWebCacheDir);
            //CoreWebView2 creation
            webView.EnsureCoreWebView2Async(webView2Environment.Result);
            webView21.EnsureCoreWebView2Async(webView2Environment.Result);
        }

        /// <summary>
        /// Manage the control being resized.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void UCObjectives_Resize(object sender, EventArgs e)
        {
            //panel1.Width = Width;
            //panel1.Height = Height;

            //ListObjectives.Width = Width + 100;
            //ListObjectives.Height = Height;
        }

        /// <summary>
        /// Mange the change of selection.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void ListObjectives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListObjectives.SelectedItems.Count > 0)
            {
                if (ListObjectives.SelectedItems[0] is object)
                {
                    if (ListObjectives.SelectedItems[0].ImageIndex == 0)
                    {
                        MenuObjective.Items["MenuArchive"].Visible = true;
                        MenuObjective.Items["MenuActivate"].Visible = false;
                    }
                    else
                    {
                        MenuObjective.Items["MenuArchive"].Visible = false;
                        MenuObjective.Items["MenuActivate"].Visible = true;
                    }
                }
            }
        }

        /// <summary>
        /// Archive the Objective.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void MenuArchive_Click(object sender, EventArgs e)
        {
            string pathto = InTouch.ObjectivesArchiveFolder + "\\" + ListObjectives.SelectedItems[0].Text;
            string pathfrom = InTouch.ObjectivesRootFolder + "\\" + ListObjectives.SelectedItems[0].Text;

            Log.Information("To  : " + pathto);
            Log.Information("From: " + pathfrom);
        }

        /// <summary>
        /// Re-activate the Objective from archive.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void MenuActivate_Click(object sender, EventArgs e)
        {
            string pathfrom = InTouch.ObjectivesArchiveFolder + "\\" + ListObjectives.SelectedItems[0].Text;
            string pathto = InTouch.ObjectivesRootFolder + "\\" + ListObjectives.SelectedItems[0].Text;

            Log.Information("To  : " + pathto);
            Log.Information("From: " + pathfrom);
        }

        /// <summary>
        /// Display the Rates and Costs for the Objective.
        /// </summary>
        /// <param name="sender">Unused.</param>
        /// <param name="e">Also unused.</param>
        private void MenuRates_Click(object sender, EventArgs e)
        {
            if (ListObjectives.SelectedItems[0] is object)
            {
                FormObjectiveRates ratesForm = new FormObjectiveRates
                {
                    Objective = InTouch.GetObjective(ListObjectives.SelectedItems[0].Tag.ToString()),
                };
                _ = ratesForm.ShowDialog();
                ratesForm.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Navigate to URI by setting Source property
            webView21.Refresh();

            InTouch.TaskManager.EnqueueTodayReportTask();
        }
    }
}