using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POEcmcs
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ClaimDetail : UserControl
    {

        private void PreviewDoc_Click(object s, RoutedEventArgs e) => MessageBox.Show("Open document preview (visual only).");

        private void Approve_Click(object s, RoutedEventArgs e)
        {
            MessageBox.Show("Approve (visual only).");
            // In a real app we'd add Approval record and update Claim.Status
        }

        private void Reject_Click(object s, RoutedEventArgs e)
        {
            MessageBox.Show("Reject (visual only).");
        }
    }
}
