
using System;
using System.Windows;

namespace codeGuard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void ShowLogin()
        {
            LoginPanel.Visibility = Visibility.Visible;
            SignupPanel.Visibility = Visibility.Collapsed;
            ForgotPanel.Visibility = Visibility.Collapsed;
        }

        private void ShowSignup()
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            SignupPanel.Visibility = Visibility.Visible;
            ForgotPanel.Visibility = Visibility.Collapsed;
        }

        private void ShowForgot()
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            SignupPanel.Visibility = Visibility.Collapsed;
            ForgotPanel.Visibility = Visibility.Visible;
        }

        private void ShowLogin_Click(object sender, RoutedEventArgs e)
        {
            ShowLogin();
        }

        private void ShowSignup_Click(object sender, RoutedEventArgs e)
        {
            ShowSignup();
        }

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotEmail.Text = LoginEmail.Text;
            ShowForgot();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginEmail.Text) ||
                string.IsNullOrWhiteSpace(LoginPassword.Password))
            {
                MessageBox.Show("Please enter your email and password.",
                    "Missing Details", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show(
                "Login interface is ready. Backend authentication will be connected later.",
                "codeGuard",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignupName.Text) ||
                string.IsNullOrWhiteSpace(SignupEmail.Text) ||
                string.IsNullOrWhiteSpace(SignupPassword.Password))
            {
                MessageBox.Show("Please complete all the fields.",
                    "Missing Details", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show(
                "Signup interface is ready. Account creation will be connected later.",
                "codeGuard",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void ResetPassword_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ForgotEmail.Text))
            {
                MessageBox.Show("Please enter your registered email address.",
                    "Missing Details", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show(
                "Password reset functionality will be connected later.",
                "codeGuard",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Google_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Google sign-in will be configured later.",
                "codeGuard", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Github_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GitHub sign-in will be configured later.",
                "codeGuard", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
