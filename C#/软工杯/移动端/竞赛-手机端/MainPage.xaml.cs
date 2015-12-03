﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=391641 上有介绍

namespace 竞赛_手机端
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static StreamSocket clientSocket;
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。
        /// 此参数通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: 准备此处显示的页面。

            // TODO: 如果您的应用程序包含多个页面，请确保
            // 通过注册以下事件来处理硬件“后退”按钮:
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed 事件。
            // 如果使用由某些模板提供的 NavigationHelper，
            // 则系统会为您处理该事件。
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Connect();
        }
        async void Connect()
        {
            string Ip, Port;
            Ip = IP.Text;
            Port = port.Text;
            clientSocket = new StreamSocket();
            try
            {
                HostName PcHost = new HostName(Ip);
                await clientSocket.ConnectAsync(PcHost, Port);
                await new MessageDialog("成功连接至PC").ShowAsync();
                Frame.Navigate(typeof(DoSomeThing));
                IP.Text="";
                port.Text = "";
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                clientSocket.Dispose();
                clientSocket = null;
                IP.Text = "";
                port.Text = "";
            }
       }
    }
}
