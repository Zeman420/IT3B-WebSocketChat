﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IT3B_Chat.Client
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void msgBtn_Click(object sender, RoutedEventArgs e)
        {
            string newMessage = NewMessageTextBox.Text;
            MessagesListBox.Items.Add(newMessage);
            NewMessageTextBox.Text = "";
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}